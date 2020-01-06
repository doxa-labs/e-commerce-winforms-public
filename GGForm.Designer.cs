namespace N11Category
{
    partial class GGForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImportConfig = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.txtTableGGProduct = new System.Windows.Forms.TextBox();
            this.txtTableProduct = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblReadDataStatus = new System.Windows.Forms.Label();
            this.lblCurrentGgProduct = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblGgProductCount = new System.Windows.Forms.Label();
            this.btnReadData = new System.Windows.Forms.Button();
            this.lblDbProductCount = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listFailedProducts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinishedEarly = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblStockCount = new System.Windows.Forms.Label();
            this.lblRemainingStock = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblUpdateStockStatus = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listFailedPrice = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPriceCount = new System.Windows.Forms.Label();
            this.lblPriceRemaining = new System.Windows.Forms.Label();
            this.lblPriceCurrent = new System.Windows.Forms.Label();
            this.lblUpdatePriceStatus = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.btnChangeLog = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(492, 489);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(201, 16);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright © 2020 doxalabs.co.uk";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 464);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImportConfig);
            this.tabPage1.Controls.Add(this.btnTestConnection);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.txtDbName);
            this.tabPage1.Controls.Add(this.txtTableGGProduct);
            this.tabPage1.Controls.Add(this.txtTableProduct);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.txtServer);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. DB Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImportConfig
            // 
            this.btnImportConfig.Location = new System.Drawing.Point(13, 13);
            this.btnImportConfig.Name = "btnImportConfig";
            this.btnImportConfig.Size = new System.Drawing.Size(114, 37);
            this.btnImportConfig.TabIndex = 3;
            this.btnImportConfig.Text = "Import Config";
            this.btnImportConfig.UseVisualStyleBackColor = true;
            this.btnImportConfig.Click += new System.EventHandler(this.BtnImportConfig_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(247, 299);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(339, 32);
            this.btnTestConnection.TabIndex = 2;
            this.btnTestConnection.Text = "Connect";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.BtnTestConnection_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(247, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(339, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(247, 235);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(339, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(247, 139);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(339, 26);
            this.txtDbName.TabIndex = 1;
            // 
            // txtTableGGProduct
            // 
            this.txtTableGGProduct.Location = new System.Drawing.Point(247, 203);
            this.txtTableGGProduct.Name = "txtTableGGProduct";
            this.txtTableGGProduct.Size = new System.Drawing.Size(339, 26);
            this.txtTableGGProduct.TabIndex = 1;
            // 
            // txtTableProduct
            // 
            this.txtTableProduct.Location = new System.Drawing.Point(247, 171);
            this.txtTableProduct.Name = "txtTableProduct";
            this.txtTableProduct.Size = new System.Drawing.Size(339, 26);
            this.txtTableProduct.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(247, 107);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(339, 26);
            this.txtPort.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(247, 75);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(339, 26);
            this.txtServer.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(143, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "7. Password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(10, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(232, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "5. Table name for GG products:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(139, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "6. Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(36, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "4. Table name for products:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(99, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "3. Database name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(184, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "2. Port:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(296, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Enter database connection info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(167, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "1. Server:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(135, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.lblReadDataStatus);
            this.tabPage3.Controls.Add(this.lblCurrentGgProduct);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.lblGgProductCount);
            this.tabPage3.Controls.Add(this.btnReadData);
            this.tabPage3.Controls.Add(this.lblDbProductCount);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(704, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2. Read Data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(41, 211);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(146, 20);
            this.label32.TabIndex = 2;
            this.label32.Text = "Current gg product:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(41, 178);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(175, 20);
            this.label30.TabIndex = 2;
            this.label30.Text = "Number of gg products:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of db products:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(41, 112);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Summary";
            // 
            // lblReadDataStatus
            // 
            this.lblReadDataStatus.AutoSize = true;
            this.lblReadDataStatus.Location = new System.Drawing.Point(105, 272);
            this.lblReadDataStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReadDataStatus.Name = "lblReadDataStatus";
            this.lblReadDataStatus.Size = new System.Drawing.Size(14, 20);
            this.lblReadDataStatus.TabIndex = 2;
            this.lblReadDataStatus.Text = "-";
            // 
            // lblCurrentGgProduct
            // 
            this.lblCurrentGgProduct.AutoSize = true;
            this.lblCurrentGgProduct.Location = new System.Drawing.Point(191, 211);
            this.lblCurrentGgProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentGgProduct.Name = "lblCurrentGgProduct";
            this.lblCurrentGgProduct.Size = new System.Drawing.Size(14, 20);
            this.lblCurrentGgProduct.TabIndex = 2;
            this.lblCurrentGgProduct.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(41, 272);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 20);
            this.label21.TabIndex = 2;
            this.label21.Text = "Status:";
            // 
            // lblGgProductCount
            // 
            this.lblGgProductCount.AutoSize = true;
            this.lblGgProductCount.Location = new System.Drawing.Point(225, 178);
            this.lblGgProductCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGgProductCount.Name = "lblGgProductCount";
            this.lblGgProductCount.Size = new System.Drawing.Size(18, 20);
            this.lblGgProductCount.TabIndex = 2;
            this.lblGgProductCount.Text = "0";
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(41, 41);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(175, 37);
            this.btnReadData.TabIndex = 3;
            this.btnReadData.Text = "Fetch Products";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.BtnReadData_Click);
            // 
            // lblDbProductCount
            // 
            this.lblDbProductCount.AutoSize = true;
            this.lblDbProductCount.Location = new System.Drawing.Point(225, 145);
            this.lblDbProductCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDbProductCount.Name = "lblDbProductCount";
            this.lblDbProductCount.Size = new System.Drawing.Size(18, 20);
            this.lblDbProductCount.TabIndex = 2;
            this.lblDbProductCount.Text = "0";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listFailedProducts);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.lblStockValue);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.lblFinishedEarly);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.lblStockCount);
            this.tabPage5.Controls.Add(this.lblRemainingStock);
            this.tabPage5.Controls.Add(this.lblCurrentStock);
            this.tabPage5.Controls.Add(this.lblUpdateStockStatus);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.btnUpdateStock);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(704, 431);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "3. Update Stock";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listFailedProducts
            // 
            this.listFailedProducts.FormattingEnabled = true;
            this.listFailedProducts.HorizontalScrollbar = true;
            this.listFailedProducts.ItemHeight = 20;
            this.listFailedProducts.Location = new System.Drawing.Point(446, 102);
            this.listFailedProducts.Name = "listFailedProducts";
            this.listFailedProducts.ScrollAlwaysVisible = true;
            this.listFailedProducts.Size = new System.Drawing.Size(246, 304);
            this.listFailedProducts.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Processing product id:";
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Location = new System.Drawing.Point(210, 136);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(14, 20);
            this.lblStockValue.TabIndex = 19;
            this.lblStockValue.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total product count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current product:";
            // 
            // lblFinishedEarly
            // 
            this.lblFinishedEarly.AutoSize = true;
            this.lblFinishedEarly.Location = new System.Drawing.Point(37, 238);
            this.lblFinishedEarly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinishedEarly.Name = "lblFinishedEarly";
            this.lblFinishedEarly.Size = new System.Drawing.Size(247, 20);
            this.lblFinishedEarly.TabIndex = 14;
            this.lblFinishedEarly.Text = "Pieces of product is finished early.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Remaining product:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(37, 242);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 20);
            this.label29.TabIndex = 16;
            // 
            // lblStockCount
            // 
            this.lblStockCount.AutoSize = true;
            this.lblStockCount.Location = new System.Drawing.Point(195, 102);
            this.lblStockCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockCount.Name = "lblStockCount";
            this.lblStockCount.Size = new System.Drawing.Size(18, 20);
            this.lblStockCount.TabIndex = 15;
            this.lblStockCount.Text = "0";
            // 
            // lblRemainingStock
            // 
            this.lblRemainingStock.AutoSize = true;
            this.lblRemainingStock.Location = new System.Drawing.Point(192, 202);
            this.lblRemainingStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemainingStock.Name = "lblRemainingStock";
            this.lblRemainingStock.Size = new System.Drawing.Size(18, 20);
            this.lblRemainingStock.TabIndex = 16;
            this.lblRemainingStock.Text = "0";
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Location = new System.Drawing.Point(169, 169);
            this.lblCurrentStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentStock.TabIndex = 17;
            this.lblCurrentStock.Text = "0";
            // 
            // lblUpdateStockStatus
            // 
            this.lblUpdateStockStatus.AutoSize = true;
            this.lblUpdateStockStatus.Location = new System.Drawing.Point(101, 386);
            this.lblUpdateStockStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateStockStatus.Name = "lblUpdateStockStatus";
            this.lblUpdateStockStatus.Size = new System.Drawing.Size(14, 20);
            this.lblUpdateStockStatus.TabIndex = 10;
            this.lblUpdateStockStatus.Text = "-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(442, 58);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(137, 20);
            this.label28.TabIndex = 11;
            this.label28.Text = "Failed product list:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(37, 386);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 20);
            this.label25.TabIndex = 11;
            this.label25.Text = "Status:";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(41, 41);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(175, 37);
            this.btnUpdateStock.TabIndex = 0;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.BtnUpdateStock_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listFailedPrice);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.lblPriceValue);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.lblPriceCount);
            this.tabPage6.Controls.Add(this.lblPriceRemaining);
            this.tabPage6.Controls.Add(this.lblPriceCurrent);
            this.tabPage6.Controls.Add(this.lblUpdatePriceStatus);
            this.tabPage6.Controls.Add(this.label27);
            this.tabPage6.Controls.Add(this.btnUpdatePrice);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(704, 431);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "4. Update Price";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listFailedPrice
            // 
            this.listFailedPrice.FormattingEnabled = true;
            this.listFailedPrice.HorizontalScrollbar = true;
            this.listFailedPrice.ItemHeight = 20;
            this.listFailedPrice.Location = new System.Drawing.Point(446, 102);
            this.listFailedPrice.Name = "listFailedPrice";
            this.listFailedPrice.ScrollAlwaysVisible = true;
            this.listFailedPrice.Size = new System.Drawing.Size(246, 304);
            this.listFailedPrice.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(442, 58);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Failed product list:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Processing product id:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(210, 136);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(14, 20);
            this.lblPriceValue.TabIndex = 27;
            this.lblPriceValue.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 102);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Total product count:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 169);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Current product:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 202);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 20);
            this.label20.TabIndex = 22;
            this.label20.Text = "Remaining product:";
            // 
            // lblPriceCount
            // 
            this.lblPriceCount.AutoSize = true;
            this.lblPriceCount.Location = new System.Drawing.Point(195, 102);
            this.lblPriceCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceCount.Name = "lblPriceCount";
            this.lblPriceCount.Size = new System.Drawing.Size(18, 20);
            this.lblPriceCount.TabIndex = 23;
            this.lblPriceCount.Text = "0";
            // 
            // lblPriceRemaining
            // 
            this.lblPriceRemaining.AutoSize = true;
            this.lblPriceRemaining.Location = new System.Drawing.Point(192, 202);
            this.lblPriceRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceRemaining.Name = "lblPriceRemaining";
            this.lblPriceRemaining.Size = new System.Drawing.Size(18, 20);
            this.lblPriceRemaining.TabIndex = 24;
            this.lblPriceRemaining.Text = "0";
            // 
            // lblPriceCurrent
            // 
            this.lblPriceCurrent.AutoSize = true;
            this.lblPriceCurrent.Location = new System.Drawing.Point(169, 169);
            this.lblPriceCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceCurrent.Name = "lblPriceCurrent";
            this.lblPriceCurrent.Size = new System.Drawing.Size(18, 20);
            this.lblPriceCurrent.TabIndex = 25;
            this.lblPriceCurrent.Text = "0";
            // 
            // lblUpdatePriceStatus
            // 
            this.lblUpdatePriceStatus.AutoSize = true;
            this.lblUpdatePriceStatus.Location = new System.Drawing.Point(101, 273);
            this.lblUpdatePriceStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePriceStatus.Name = "lblUpdatePriceStatus";
            this.lblUpdatePriceStatus.Size = new System.Drawing.Size(14, 20);
            this.lblUpdatePriceStatus.TabIndex = 10;
            this.lblUpdatePriceStatus.Text = "-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(37, 273);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 20);
            this.label27.TabIndex = 11;
            this.label27.Text = "Status:";
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Location = new System.Drawing.Point(41, 41);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(175, 37);
            this.btnUpdatePrice.TabIndex = 1;
            this.btnUpdatePrice.Text = "Update Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.BtnUpdatePrice_Click);
            // 
            // btnChangeLog
            // 
            this.btnChangeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLog.Location = new System.Drawing.Point(13, 480);
            this.btnChangeLog.Name = "btnChangeLog";
            this.btnChangeLog.Size = new System.Drawing.Size(104, 32);
            this.btnChangeLog.TabIndex = 11;
            this.btnChangeLog.Text = "v2.0 changelogs";
            this.btnChangeLog.UseVisualStyleBackColor = true;
            this.btnChangeLog.Click += new System.EventHandler(this.BtnChangeLog_Click);
            // 
            // GGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 518);
            this.Controls.Add(this.btnChangeLog);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GGForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GittiGidiyor Tool";
            this.Load += new System.EventHandler(this.GGForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnImportConfig;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.TextBox txtTableGGProduct;
        private System.Windows.Forms.TextBox txtTableProduct;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblReadDataStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Label lblDbProductCount;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblUpdateStockStatus;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lblUpdatePriceStatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStockCount;
        private System.Windows.Forms.Label lblRemainingStock;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.ListBox listFailedProducts;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblGgProductCount;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblCurrentGgProduct;
        private System.Windows.Forms.Label lblFinishedEarly;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnChangeLog;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblPriceCount;
        private System.Windows.Forms.Label lblPriceRemaining;
        private System.Windows.Forms.Label lblPriceCurrent;
        private System.Windows.Forms.ListBox listFailedPrice;
        private System.Windows.Forms.Label label17;
    }
}