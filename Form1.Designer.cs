namespace N11Category
{
    partial class Form1
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
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblExcelFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentRow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLeftRow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAttributeValue = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImportConfig = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.txtTableCategory = new System.Windows.Forms.TextBox();
            this.txtTableAttribute = new System.Windows.Forms.TextBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.lblReadDataStatus = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblParseCategoryStatus = new System.Windows.Forms.Label();
            this.lblParseAttributeStatus = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblParseCurrentValue = new System.Windows.Forms.Label();
            this.lblParseCurrentCategory = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnParseData = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblInsertAttributesStatus = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnInsertAttributeValues = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lblInsertCategoriesStatus = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnInsertCategories = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnChangeLog = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(41, 41);
            this.btnShowDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(172, 37);
            this.btnShowDialog.TabIndex = 0;
            this.btnShowDialog.Text = "Select Excel File";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(40, 69);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(0, 20);
            this.lblStep1.TabIndex = 2;
            // 
            // lblExcelFileName
            // 
            this.lblExcelFileName.AutoSize = true;
            this.lblExcelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcelFileName.Location = new System.Drawing.Point(124, 100);
            this.lblExcelFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExcelFileName.Name = "lblExcelFileName";
            this.lblExcelFileName.Size = new System.Drawing.Size(0, 16);
            this.lblExcelFileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filename:";
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(41, 41);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(172, 37);
            this.btnReadData.TabIndex = 3;
            this.btnReadData.Text = "Read Data";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Row count:";
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(134, 145);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(18, 20);
            this.lblRowCount.TabIndex = 2;
            this.lblRowCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current row:";
            // 
            // lblCurrentRow
            // 
            this.lblCurrentRow.AutoSize = true;
            this.lblCurrentRow.Location = new System.Drawing.Point(140, 212);
            this.lblCurrentRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentRow.Name = "lblCurrentRow";
            this.lblCurrentRow.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentRow.TabIndex = 2;
            this.lblCurrentRow.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Remaining rows:";
            // 
            // lblLeftRow
            // 
            this.lblLeftRow.AutoSize = true;
            this.lblLeftRow.Location = new System.Drawing.Point(171, 245);
            this.lblLeftRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeftRow.Name = "lblLeftRow";
            this.lblLeftRow.Size = new System.Drawing.Size(18, 20);
            this.lblLeftRow.TabIndex = 2;
            this.lblLeftRow.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Processing value:";
            // 
            // lblAttributeValue
            // 
            this.lblAttributeValue.AutoSize = true;
            this.lblAttributeValue.Location = new System.Drawing.Point(180, 179);
            this.lblAttributeValue.Name = "lblAttributeValue";
            this.lblAttributeValue.Size = new System.Drawing.Size(14, 20);
            this.lblAttributeValue.TabIndex = 5;
            this.lblAttributeValue.Text = "-";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 464);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImportConfig);
            this.tabPage1.Controls.Add(this.btnTestConnection);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.txtDbName);
            this.tabPage1.Controls.Add(this.txtTableCategory);
            this.tabPage1.Controls.Add(this.txtTableAttribute);
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
            this.btnImportConfig.Click += new System.EventHandler(this.btnImportConfig_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(247, 299);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(339, 32);
            this.btnTestConnection.TabIndex = 2;
            this.btnTestConnection.Text = "Connect";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(247, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
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
            // txtTableCategory
            // 
            this.txtTableCategory.Location = new System.Drawing.Point(247, 203);
            this.txtTableCategory.Name = "txtTableCategory";
            this.txtTableCategory.Size = new System.Drawing.Size(339, 26);
            this.txtTableCategory.TabIndex = 1;
            // 
            // txtTableAttribute
            // 
            this.txtTableAttribute.Location = new System.Drawing.Point(247, 171);
            this.txtTableAttribute.Name = "txtTableAttribute";
            this.txtTableAttribute.Size = new System.Drawing.Size(339, 26);
            this.txtTableAttribute.TabIndex = 1;
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
            this.label15.Location = new System.Drawing.Point(24, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "5. Table name for categories:";
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
            this.label10.Location = new System.Drawing.Point(32, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "4. Table name for attributes:";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowDialog);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblExcelFileName);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. Excel File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblAttributeValue);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.lblReadDataStatus);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnReadData);
            this.tabPage3.Controls.Add(this.lblRowCount);
            this.tabPage3.Controls.Add(this.lblLeftRow);
            this.tabPage3.Controls.Add(this.lblCurrentRow);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(704, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. Read Data";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.lblReadDataStatus.Location = new System.Drawing.Point(105, 305);
            this.lblReadDataStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReadDataStatus.Name = "lblReadDataStatus";
            this.lblReadDataStatus.Size = new System.Drawing.Size(14, 20);
            this.lblReadDataStatus.TabIndex = 2;
            this.lblReadDataStatus.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(41, 305);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 20);
            this.label21.TabIndex = 2;
            this.label21.Text = "Status:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblParseCategoryStatus);
            this.tabPage4.Controls.Add(this.lblParseAttributeStatus);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.lblParseCurrentValue);
            this.tabPage4.Controls.Add(this.lblParseCurrentCategory);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.btnParseData);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(704, 431);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4. Parse Data";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblParseCategoryStatus
            // 
            this.lblParseCategoryStatus.AutoSize = true;
            this.lblParseCategoryStatus.Location = new System.Drawing.Point(105, 325);
            this.lblParseCategoryStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParseCategoryStatus.Name = "lblParseCategoryStatus";
            this.lblParseCategoryStatus.Size = new System.Drawing.Size(14, 20);
            this.lblParseCategoryStatus.TabIndex = 8;
            this.lblParseCategoryStatus.Text = "-";
            // 
            // lblParseAttributeStatus
            // 
            this.lblParseAttributeStatus.AutoSize = true;
            this.lblParseAttributeStatus.Location = new System.Drawing.Point(105, 183);
            this.lblParseAttributeStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParseAttributeStatus.Name = "lblParseAttributeStatus";
            this.lblParseAttributeStatus.Size = new System.Drawing.Size(14, 20);
            this.lblParseAttributeStatus.TabIndex = 8;
            this.lblParseAttributeStatus.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(41, 325);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "Status:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(41, 183);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 20);
            this.label23.TabIndex = 9;
            this.label23.Text = "Status:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(41, 260);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 20);
            this.label19.TabIndex = 7;
            this.label19.Text = "Category Summary";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(41, 112);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(218, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "Attribute Values Summary";
            // 
            // lblParseCurrentValue
            // 
            this.lblParseCurrentValue.AutoSize = true;
            this.lblParseCurrentValue.Location = new System.Drawing.Point(223, 146);
            this.lblParseCurrentValue.Name = "lblParseCurrentValue";
            this.lblParseCurrentValue.Size = new System.Drawing.Size(14, 20);
            this.lblParseCurrentValue.TabIndex = 5;
            this.lblParseCurrentValue.Text = "-";
            // 
            // lblParseCurrentCategory
            // 
            this.lblParseCurrentCategory.AutoSize = true;
            this.lblParseCurrentCategory.Location = new System.Drawing.Point(181, 290);
            this.lblParseCurrentCategory.Name = "lblParseCurrentCategory";
            this.lblParseCurrentCategory.Size = new System.Drawing.Size(14, 20);
            this.lblParseCurrentCategory.TabIndex = 5;
            this.lblParseCurrentCategory.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 290);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Current Category:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(176, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Current Attribute Value:";
            // 
            // btnParseData
            // 
            this.btnParseData.Location = new System.Drawing.Point(41, 41);
            this.btnParseData.Name = "btnParseData";
            this.btnParseData.Size = new System.Drawing.Size(175, 37);
            this.btnParseData.TabIndex = 4;
            this.btnParseData.Text = "Parse Data";
            this.btnParseData.UseVisualStyleBackColor = true;
            this.btnParseData.Click += new System.EventHandler(this.btnParseData_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblInsertAttributesStatus);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.btnInsertAttributeValues);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(704, 431);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "5. Insert Attributes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblInsertAttributesStatus
            // 
            this.lblInsertAttributesStatus.AutoSize = true;
            this.lblInsertAttributesStatus.Location = new System.Drawing.Point(101, 98);
            this.lblInsertAttributesStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsertAttributesStatus.Name = "lblInsertAttributesStatus";
            this.lblInsertAttributesStatus.Size = new System.Drawing.Size(14, 20);
            this.lblInsertAttributesStatus.TabIndex = 10;
            this.lblInsertAttributesStatus.Text = "-";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(37, 98);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 20);
            this.label25.TabIndex = 11;
            this.label25.Text = "Status:";
            // 
            // btnInsertAttributeValues
            // 
            this.btnInsertAttributeValues.Location = new System.Drawing.Point(41, 41);
            this.btnInsertAttributeValues.Name = "btnInsertAttributeValues";
            this.btnInsertAttributeValues.Size = new System.Drawing.Size(217, 37);
            this.btnInsertAttributeValues.TabIndex = 0;
            this.btnInsertAttributeValues.Text = "Insert Attribute Values";
            this.btnInsertAttributeValues.UseVisualStyleBackColor = true;
            this.btnInsertAttributeValues.Click += new System.EventHandler(this.btnInsertAttributeValues_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lblInsertCategoriesStatus);
            this.tabPage6.Controls.Add(this.label27);
            this.tabPage6.Controls.Add(this.btnInsertCategories);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(704, 431);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "6. Insert Categories";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblInsertCategoriesStatus
            // 
            this.lblInsertCategoriesStatus.AutoSize = true;
            this.lblInsertCategoriesStatus.Location = new System.Drawing.Point(101, 98);
            this.lblInsertCategoriesStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsertCategoriesStatus.Name = "lblInsertCategoriesStatus";
            this.lblInsertCategoriesStatus.Size = new System.Drawing.Size(14, 20);
            this.lblInsertCategoriesStatus.TabIndex = 10;
            this.lblInsertCategoriesStatus.Text = "-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(37, 98);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 20);
            this.label27.TabIndex = 11;
            this.label27.Text = "Status:";
            // 
            // btnInsertCategories
            // 
            this.btnInsertCategories.Location = new System.Drawing.Point(41, 41);
            this.btnInsertCategories.Name = "btnInsertCategories";
            this.btnInsertCategories.Size = new System.Drawing.Size(175, 37);
            this.btnInsertCategories.TabIndex = 1;
            this.btnInsertCategories.Text = "Insert Categories";
            this.btnInsertCategories.UseVisualStyleBackColor = true;
            this.btnInsertCategories.Click += new System.EventHandler(this.btnInsertCategories_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(492, 488);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(201, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright © 2020 doxalabs.co.uk";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnChangeLog
            // 
            this.btnChangeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLog.Location = new System.Drawing.Point(12, 480);
            this.btnChangeLog.Name = "btnChangeLog";
            this.btnChangeLog.Size = new System.Drawing.Size(104, 32);
            this.btnChangeLog.TabIndex = 12;
            this.btnChangeLog.Text = "v2.0 changelogs";
            this.btnChangeLog.UseVisualStyleBackColor = true;
            this.btnChangeLog.Click += new System.EventHandler(this.BtnChangeLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 518);
            this.Controls.Add(this.btnChangeLog);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStep1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N11 Excel Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblExcelFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLeftRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAttributeValue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.TextBox txtTableAttribute;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TextBox txtTableCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnImportConfig;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnInsertAttributeValues;
        private System.Windows.Forms.Button btnInsertCategories;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblParseCurrentValue;
        private System.Windows.Forms.Label lblParseCurrentCategory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnParseData;
        private System.Windows.Forms.Label lblReadDataStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblParseCategoryStatus;
        private System.Windows.Forms.Label lblParseAttributeStatus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblInsertAttributesStatus;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblInsertCategoriesStatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnChangeLog;
    }
}

