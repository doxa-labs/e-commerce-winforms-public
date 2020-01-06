using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
// Service
using GittiGidiyor;
using GittiGidiyor.Product;
// Self
using N11Category.Models;

namespace N11Category
{
    public partial class GGForm : Form
    {
        ConnectionModelGG conModel = null; // connection info
        public GGForm(bool hasToken)
        {
            if (!hasToken)
            {
                MessageBox.Show("Please login!");
                this.Visible = false;
            }
            else
            {
                InitializeComponent();
                CheckForIllegalCrossThreadCalls = false; // to avoid cross thread
            }
        }

        private void LinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://doxalabs.co.uk";
            Process.Start(url);
        }

        private void BtnImportConfig_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Db Config File (*.json)|*.json";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string tmp = File.ReadAllText(file);
                conModel = JsonConvert.DeserializeObject<ConnectionModelGG>(tmp);
            }
        }

        private void BtnTestConnection_Click(object sender, System.EventArgs e)
        {
            if (conModel == null && txtDbName.Text.Trim() == "")
            {
                MessageBox.Show("Error no: 2 - Please enter connection info OR Import database config!");
            }
            else
            {
                if (conModel == null)
                {
                    conModel = new ConnectionModelGG();
                    conModel.port = txtPort.Text.Trim();
                    conModel.server = txtServer.Text.Trim();
                    conModel.username = txtUsername.Text.Trim();
                    conModel.password = txtPassword.Text.Trim();
                    conModel.databaseName = txtDbName.Text.Trim();
                    conModel.ggProductTable = txtTableGGProduct.Text.Trim();
                    conModel.productTable = txtTableProduct.Text.Trim();
                }

                var con = DBConnection.Instance();
                con.DatabaseName = conModel.databaseName;
                if (con.IsConnect(conModel))
                {
                    txtPort.Text = conModel.port;
                    txtServer.Text = conModel.server;
                    txtUsername.Text = conModel.username;
                    txtDbName.Text = conModel.databaseName;
                    txtTableProduct.Text = conModel.productTable;
                    txtTableGGProduct.Text = conModel.ggProductTable;

                    MessageBox.Show("Test is successful.");
                }

                con.Close();
            }
        }

        private int stockCounter = 0;
        private int priceCounter = 0;
        private Thread threadUpdateStocks = null;
        private Thread threadUpdatePrices = null;
        private Thread threadFetchProducts = null;
        List<ProductGG> productsFromDB = new List<ProductGG>();
        List<ProductGG> productsFromGG = new List<ProductGG>();
        List<ProductGG> productsWillStockUpdate = new List<ProductGG>();
        List<ProductGG> productsWillPriceUpdate = new List<ProductGG>();
        private void BtnReadData_Click(object sender, System.EventArgs e)
        {
            if (conModel == null)
            {
                MessageBox.Show("Error no: 2 - Please import database config!");
            }
            else
            {
                btnReadData.Enabled = false;
                threadFetchProducts = new Thread(new ThreadStart(GetGGProducts));
                threadFetchProducts.Start();
            }
        }

        private void GetGGProducts()
        {
            try
            {
                List<string> listOfCategories = new List<string>();

                int pageSize = 100;
                int currentPageCount = 0;

                var productService = ServiceProvider.getProductService();
                while (true)
                {
                    /*
                    A - Aktif Şatışlar
                    L - Yeni Listelenenler
                    S - Satılan Ürünler
                    U - Satılmayan Ürünler
                    R - Yeniden Listelenenler
                    */
                    List<productDetailType> pDetailsResult = productService.getProducts(currentPageCount * pageSize, pageSize, "A", true, "tr").products.ToList();

                    foreach (productDetailType item in pDetailsResult)
                    {
                        ProductGG p = new ProductGG();
                        p.GgId = item.productId.ToString();
                        p.Quantity = item.product.productCount;
                        p.Price = item.product.buyNowPrice;

                        // Update UI
                        UpdateCurrentGGProduct(item.product.title);

                        productsFromGG.Add(p);
                    }

                    if (pDetailsResult.Count < 100)
                    {
                        break;
                    }
                    else
                    {
                        currentPageCount++;
                    }

                    // Update UI
                    UpdateGgProductCount(productsFromGG.Count.ToString());
                }

                // Update UI for last time
                UpdateGgProductCount(productsFromGG.Count.ToString());

                // Fetch products from db
                GetDBProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no: 10 - Get products from gg. Message: " + ex.Message);
            }
        }

        private void GetDBProducts()
        {
            try
            {
                var con = DBConnection.Instance();
                con.DatabaseName = con.DatabaseName;
                if (con.IsConnect(conModel))
                {
                    string query = "SELECT p.product_id, gg_id, quantity, price FROM " + conModel.productTable + " p LEFT JOIN " + conModel.ggProductTable + " ggp ON (p.product_id = ggp.product_id)";
                    var cmd = new MySqlCommand(query, con.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ProductGG p = new ProductGG();
                        p.ProductId = reader["product_id"].ToString();
                        p.GgId = reader["gg_id"].ToString();
                        p.Price = double.Parse(reader["price"].ToString());
                        p.Quantity = int.Parse(reader["quantity"].ToString());

                        productsFromDB.Add(p);
                    }
                }

                lblDbProductCount.Text = productsFromDB.Count.ToString();
                lblReadDataStatus.Text = "Completed";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no: 11 - Get products from db. Message: " + ex.Message);
            }
        }

        private void BtnUpdateStock_Click(object sender, System.EventArgs e)
        {
            if (productsFromDB.Count == 0 || productsFromGG.Count == 0)
            {
                MessageBox.Show("Error no: 12 - Please go to 2.Read Data first!");
            }
            else
            {
                btnUpdateStock.Enabled = false;
                foreach (ProductGG item in productsFromGG)
                {
                    ProductGG pon = productsFromDB.Find(p => p.GgId == item.GgId);
                    if (pon != null)
                    {
                        if (pon.Quantity != item.Quantity) // stok değişmisse güncellenecekler listesine ekle
                        {
                            productsWillStockUpdate.Add(pon);
                        }
                    }
                }

                if (productsWillStockUpdate.Count > 0)
                {
                    // show total count
                    lblStockCount.Text = productsWillStockUpdate.Count.ToString();

                    threadUpdateStocks = new Thread(new ThreadStart(UpdateStocks));
                    threadUpdateStocks.Start();
                }
                else
                {
                    lblUpdateStockStatus.Text = "All products are up-to-date : )";
                    MessageBox.Show("All products are up-to-date : )");
                }
            }
        }

        private void BtnUpdatePrice_Click(object sender, System.EventArgs e)
        {
            if (productsFromDB.Count == 0 || productsFromGG.Count == 0)
            {
                MessageBox.Show("Error no: 14 - Please go to 2.Read Data first!");
            }
            else
            {
                btnUpdatePrice.Enabled = false;
                foreach (ProductGG item in productsFromGG)
                {
                    ProductGG pon = productsFromDB.Find(p => p.GgId == item.GgId);
                    if (pon != null)
                    {
                        if (pon.Price != item.Price) // fiyat değişmisse güncellenecekler listesine ekle
                        {
                            productsWillPriceUpdate.Add(pon);
                        }
                    }
                }

                if (productsWillPriceUpdate.Count > 0)
                {
                    // show total count
                    lblPriceCount.Text = productsWillPriceUpdate.Count.ToString();

                    threadUpdatePrices = new Thread(new ThreadStart(UpdatePrices));
                    threadUpdatePrices.Start();
                }
                else
                {
                    lblUpdatePriceStatus.Text = "All products are up-to-date : )";
                    MessageBox.Show("All products are up-to-date : )");
                }
            }
        }

        List<int> productIdsWillFinishEarly = new List<int>();
        List<string> itemIdsWillFinishEarly = new List<string>();
        private void UpdateStocks()
        {
            try
            {
                var productService = ServiceProvider.getProductService();
                foreach (ProductGG item in productsWillStockUpdate)
                {
                    if (item.Quantity > 0)
                    {
                        var stock = productService.updateStock(item.GgId, "", item.Quantity, true, "tr");
                        if (stock.error != null)
                        {
                            listFailedProducts.Items.Add(stock.error.message);
                        }

                        stockCounter++;
                        // Update UI
                        UpdateStockValueText(item.ProductId);
                        UpdateCurrentStockText(stockCounter.ToString());
                        UpdateRemainingText((productsWillStockUpdate.Count - stockCounter).ToString());
                    }
                    else // satıştan kaldırılacak ürünler listesine ekle
                    {
                        productIdsWillFinishEarly.Add(int.Parse(item.GgId));
                    }
                }

                // stoğu 0 olan ürünleri satıştan kaldır
                var ferly = productService.finishEarly(productIdsWillFinishEarly, itemIdsWillFinishEarly, "tr");
                lblFinishedEarly.Text = ferly.result; //productIdsWillFinishEarly.Count + " pieces of product is finished early.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no: 13 - Stock update failed! Message: " + ex.Message);
            }
        }

        private void UpdatePrices()
        {
            try
            {
                var productService = ServiceProvider.getProductService();
                foreach (ProductGG item in productsWillPriceUpdate)
                {
                    var stock = productService.updatePrice(item.GgId, "", item.Price, true, "tr");
                    if (stock.error != null)
                    {
                        listFailedPrice.Items.Add(stock.error.message);
                    }

                    priceCounter++;
                    // Update UI
                    UpdatePriceValueText(item.ProductId);
                    UpdateCurrentPriceText(priceCounter.ToString());
                    UpdatePriceRemainingText((productsWillPriceUpdate.Count - priceCounter).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no: 15 - Price update failed! Message: " + ex.Message);
            }
        }

        // Begin UI Update
        private void UpdateStockValueText(string value)
        {
            lblStockValue.Invoke((MethodInvoker)delegate
            {
                lblStockValue.Text = value;
            });
        }

        private void UpdatePriceValueText(string value)
        {
            lblPriceValue.Invoke((MethodInvoker)delegate
            {
                lblPriceValue.Text = value;
            });
        }

        private void UpdateCurrentStockText(string value)
        {
            lblCurrentStock.Invoke((MethodInvoker)delegate
            {
                lblCurrentStock.Text = value;
            });
        }

        private void UpdateCurrentPriceText(string value)
        {
            lblPriceCurrent.Invoke((MethodInvoker)delegate
            {
                lblPriceCurrent.Text = value;
            });
        }

        private void UpdateRemainingText(string value)
        {
            lblRemainingStock.Invoke((MethodInvoker)delegate
            {
                lblRemainingStock.Text = value;
            });
        }

        private void UpdatePriceRemainingText(string value)
        {
            lblPriceRemaining.Invoke((MethodInvoker)delegate
            {
                lblPriceRemaining.Text = value;
            });
        }

        private void UpdateCurrentGGProduct(string value)
        {
            lblCurrentGgProduct.Invoke((MethodInvoker)delegate
            {
                lblCurrentGgProduct.Text = value;
            });
        }

        private void UpdateGgProductCount(string value)
        {
            lblGgProductCount.Invoke((MethodInvoker)delegate
            {
                lblGgProductCount.Text = value;
            });
        }
        // End UI Update

        private void GGForm_Load(object sender, EventArgs e)
        {
            // Load GG Config
            ConfigurationManager.getAuthParameters();
        }

        private void BtnChangeLog_Click(object sender, EventArgs e)
        {
            var changeLogForm = new ChangeLogForm();
            changeLogForm.Show();
        }
    }
}
