using System;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
// Self
using N11Category.Models;

namespace N11Category
{
    public partial class Form1 : Form
    {
        public Form1(bool hasToken)
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

        // category
        public static List<Category> categoryList = new List<Category>();

        // attributes
        public static List<Attribute> attributeList = new List<Attribute>();
        public static List<AttributeValue> attributesWithValueList = new List<AttributeValue>();

        // together
        public static List<AttributeAndCategory> atrAndCatList = new List<AttributeAndCategory>();

        public static int counter = 1; // file counter
        public static string excelPath = ""; // excel path
        ConnectionModelN11 conModel = null; // connection info

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            //openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Filter = "Excel Worksheets (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                lblExcelFileName.Text = file;
                excelPath = file;
            }
        }

        private Thread threadReadData = null;
        private void btnReadData_Click(object sender, EventArgs e)
        {
            if (excelPath == "")
            {
                MessageBox.Show("Error no: 5 - Please Select Excel File!");
            }
            else
            {
                threadReadData = new Thread(new ThreadStart(GetDataFromExcel));
                threadReadData.Start();
            }
        }

        private Thread threadParseData = null;
        private Thread threadGetAttributeCategory = null;
        private void btnParseData_Click(object sender, EventArgs e)
        {
            if (categoryList.Count <= 0 || attributeList.Count <= 0)
            {
                MessageBox.Show("Error no: 6 - Please Read Data!");
            }
            else
            {
                threadParseData = new Thread(new ThreadStart(SetValues));
                threadParseData.Start();

                threadGetAttributeCategory = new Thread(new ThreadStart(GetAttributeAndCategoryId));
                threadGetAttributeCategory.Start();
            }
        }

        private void GetDataFromExcel()
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelPath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[2];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            lblRowCount.Text = xlRange.Rows.Count.ToString(); // set label

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 2; i <= rowCount; i++)
            {
                Category c = new Category();
                c.name = xlRange.Cells[i, 1].Value2.ToString();
                string catId = xlRange.Cells[i, 2].Value2.ToString();
                c.category_id = int.Parse(catId);
                c.attributeNames = new List<string>();

                // kategorileri topla
                if (!categoryList.Exists(cat => cat.category_id == c.category_id))
                {
                    categoryList.Add(c);
                }

                Attribute at = new Attribute();
                at.category_id = c.category_id;
                string attrId = xlRange.Cells[i, 3].Value2.ToString();
                at.attribute_id = int.Parse(attrId);
                at.attribute_name = xlRange.Cells[i, 4].Value2.ToString();
                at.attribute_value = xlRange.Cells[i, 5].Value2.ToString();

                if (!categoryList.Find(cc => cc.category_id == c.category_id).attributeNames.Contains(at.attribute_name))
                {
                    categoryList.Find(cc => cc.category_id == c.category_id).attributeNames.Add(at.attribute_name);
                }

                at.multipleselect = 0;
                string mand = xlRange.Cells[i, 6].Value2.ToString();
                if (mand == "Evet")
                {
                    at.mandatory = 1;
                }
                else
                {
                    at.mandatory = 0;
                }

                // özellikleri topla
                if (!attributeList.Exists(atrk => atrk.attribute_id == at.attribute_id && atrk.attribute_value == at.attribute_value && atrk.category_id == at.category_id))
                {
                    attributeList.Add(at);
                }

                UpdateCurrentRowText(i);
                UpdateLeftRowText(rowCount, i);
                UpdateAttrivuteValueText(at.attribute_value);
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            lblReadDataStatus.Text = "Completed";
        }

        // get for oc_n11category_to_attr
        private void GetAttributeAndCategoryId()
        {
            int counter2 = 1;
            foreach (Category item in categoryList)
            {
                foreach (string item2 in item.attributeNames)
                {
                    Attribute atari = attributeList.Find(iii => iii.attribute_name == item2);

                    AttributeAndCategory atr = new AttributeAndCategory();
                    atr.id = counter2;
                    atr.category_id = item.category_id.ToString();
                    atr.attribute_id = atari.attribute_id.ToString();

                    atrAndCatList.Add(atr);
                    counter2++;

                    // Update UI
                    UpdateCurrentParseCategoryText(item.name + " " + atari.attribute_name);
                }
            }

            // Update Status
            lblParseCategoryStatus.Text = "Completed";
        }

        // do it for n11category_attributes
        private void SetValues()
        {
            foreach (Category item in categoryList)
            {
                List<Attribute> atrs = attributeList.FindAll(i => i.category_id == item.category_id);
                foreach (string item2 in item.attributeNames)
                {
                    AttributeValue atrValue = new AttributeValue();
                    List<Attribute> subAtr = atrs.FindAll(str => str.attribute_name == item2);
                    if (subAtr.Count > 0)
                    {
                        atrValue.mandatory = subAtr[0].mandatory;
                        atrValue.attribute_id = subAtr[0].attribute_id.ToString();
                        atrValue.multipleselect = subAtr[0].multipleselect;
                        atrValue.attribute_name = subAtr[0].attribute_name;
                    }

                    // begin to array
                    string begin = "[";
                    string value = "";
                    string end = "]";

                    foreach (Attribute item3 in subAtr)
                    {
                        value += '"' + item3.attribute_value + '"' + ',';

                        // Update UI
                        UpdateCurrentParseAttributeValueText(item2 + " " + item3.attribute_value);
                    }

                    value = value.Remove(value.LastIndexOf(','));

                    atrValue.valuelist = begin + value + end;
                    atrValue.id = counter;

                    if (!attributesWithValueList.Exists(akar => akar.attribute_id == atrValue.attribute_id && akar.attribute_name == atrValue.attribute_name))
                    {
                        attributesWithValueList.Add(atrValue);
                    }

                    counter++;
                }
            }

            // Update Status
            lblParseAttributeStatus.Text = "Completed";
        }

        // do it for n11category_attributes
        private void InsertToc_n11category_attributes(DBConnection con)
        {
            try
            {
                foreach (AttributeValue item in attributesWithValueList)
                {
                    string query = "INSERT INTO " + conModel.tableAttributes + "(attribute_id,attribute_name,mandatory,multipleselect,valuelist) VALUES(@attribute_id, @attribute_name, @mandatory, @multipleselect, @valuelist)";
                    var cmd = new MySqlCommand(query, con.Connection);
                    cmd.Parameters.AddWithValue("@attribute_id", item.attribute_id);
                    cmd.Parameters.AddWithValue("@attribute_name", item.attribute_name);
                    cmd.Parameters.AddWithValue("@mandatory", item.mandatory);
                    cmd.Parameters.AddWithValue("@multipleselect", item.multipleselect);
                    cmd.Parameters.AddWithValue("@valuelist", item.valuelist);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("executed item: " + item.id);
                }

                // Update status
                lblInsertAttributesStatus.Text = "Completed";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no: 3 - Insert into " + conModel.tableAttributes + " failed!");
            }
        }

        // do it for oc_n11category_to_attr
        private void InsertToc_n11category_to_attr(DBConnection con)
        {
            try
            {
                foreach (AttributeAndCategory item in atrAndCatList)
                {
                    string query = "INSERT INTO " + conModel.tableCategories + "(category_id,attribute_id) VALUES(@category_id, @attribute_id)";
                    var cmd = new MySqlCommand(query, con.Connection);
                    cmd.Parameters.AddWithValue("@category_id", item.category_id);
                    cmd.Parameters.AddWithValue("@attribute_id", item.attribute_id);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("executed item: " + item.id);
                }

                // Update status
                lblInsertCategoriesStatus.Text = "Completed";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no: 4 - Insert into " + conModel.tableCategories + " failed!");
            }
        }

        // Begin Update UI
        private void UpdateCurrentRowText(int row)
        {
            lblCurrentRow.Invoke((MethodInvoker)delegate
            {
                lblCurrentRow.Text = row.ToString();
            });
        }

        private void UpdateLeftRowText(int totalRow, int currentRow)
        {
            int leftRow = totalRow - currentRow;
            lblLeftRow.Invoke((MethodInvoker)delegate
            {
                lblLeftRow.Text = leftRow.ToString();
            });
        }

        private void UpdateAttrivuteValueText(string value)
        {
            lblAttributeValue.Invoke((MethodInvoker)delegate
            {
                lblAttributeValue.Text = value;
            });
        }

        private void UpdateCurrentParseAttributeValueText(string value)
        {
            lblParseCurrentValue.Invoke((MethodInvoker)delegate
            {
                lblParseCurrentValue.Text = value;
            });
        }

        private void UpdateCurrentParseCategoryText(string value)
        {
            lblParseCurrentCategory.Invoke((MethodInvoker)delegate
            {
                lblParseCurrentCategory.Text = value;
            });
        }
        // End Update UI

        // open copyright url
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://doxasoftware.co.uk";
            Process.Start(url);
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (conModel == null && txtDbName.Text.Trim() == "")
            {
                MessageBox.Show("Error no: 2 - Please enter connection info OR Import database config!");
            }
            else
            {
                if (conModel == null)
                {
                    conModel = new ConnectionModelN11();
                    conModel.port = txtPort.Text.Trim();
                    conModel.server = txtServer.Text.Trim();
                    conModel.username = txtUsername.Text.Trim();
                    conModel.password = txtPassword.Text.Trim();
                    conModel.databaseName = txtDbName.Text.Trim();
                    conModel.tableCategories = txtTableCategory.Text.Trim();
                    conModel.tableAttributes = txtTableAttribute.Text.Trim();
                }

                var con = DBConnection.Instance();
                con.DatabaseName = conModel.databaseName;
                if (con.IsConnect(conModel))
                {
                    txtPort.Text = conModel.port;
                    txtServer.Text = conModel.server;
                    txtUsername.Text = conModel.username;
                    txtDbName.Text = conModel.databaseName;
                    txtTableAttribute.Text = conModel.tableAttributes;
                    txtTableCategory.Text = conModel.tableCategories;

                    MessageBox.Show("Test is successful.");
                }

                con.Close();
            }
        }

        private void btnImportConfig_Click(object sender, EventArgs e)
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
                conModel = JsonConvert.DeserializeObject<ConnectionModelN11>(tmp);
            }
        }

        private void btnInsertAttributeValues_Click(object sender, EventArgs e)
        {
            if (conModel == null)
            {
                MessageBox.Show("Error no: 2 - Please import database config!");
            }
            else
            {
                var con = DBConnection.Instance();
                con.DatabaseName = con.DatabaseName;
                if (con.IsConnect(conModel))
                {
                    InsertToc_n11category_attributes(con); // insert to n11category_attributes
                }

                con.Close();
            }
        }

        private void btnInsertCategories_Click(object sender, EventArgs e)
        {
            if (conModel == null)
            {
                MessageBox.Show("Error no: 2 - Please import database config!");
            }
            else
            {
                var con = DBConnection.Instance();
                con.DatabaseName = "n11";
                if (con.IsConnect(conModel))
                {
                    InsertToc_n11category_to_attr(con); // insert to oc_n11category_to_attr
                }

                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnChangeLog_Click(object sender, EventArgs e)
        {
            var changeLogForm = new ChangeLogForm();
            changeLogForm.Show();
        }
    }
}

public class Category
{
    public string name { get; set; }
    public int category_id { get; set; }
    public List<string> attributeNames { get; set; }
}

public class Attribute
{
    public int category_id { get; set; }
    public int attribute_id { get; set; }
    public string attribute_name { get; set; }
    public string attribute_value { get; set; }
    public int mandatory { get; set; }
    public int multipleselect { get; set; }
}

public class AttributeValue
{
    public int id { get; set; }
    public string attribute_id { get; set; }
    public string attribute_name { get; set; }
    public int mandatory { get; set; }
    public int multipleselect { get; set; }
    public string valuelist { get; set; }
}

public class AttributeAndCategory
{
    public int id { get; set; }
    public string category_id { get; set; }
    public string attribute_id { get; set; }
}