﻿namespace PHARMACY
{
    partial class drugDetails
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drugDetails));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cashSaleRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pricePerUnit = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cashSaleQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cashSaleDrugSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cashSaleBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashSaleAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cashSaleDiscount = new System.Windows.Forms.TextBox();
            this.cashSaleTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pfsession = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cashSaleCancel = new System.Windows.Forms.Button();
            this.setSerial = new System.Windows.Forms.TextBox();
            this.saleDashboardDataGridView = new System.Windows.Forms.DataGridView();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.vatTextBox = new System.Windows.Forms.TextBox();
            this.displayResults = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.drugDetailsLabel = new System.Windows.Forms.Label();
            this.stockIDTextBox = new System.Windows.Forms.TextBox();
            this.drugStockQuantityTextBox = new System.Windows.Forms.TextBox();
            this.cartQuantityTextBox = new System.Windows.Forms.TextBox();
            this.remainedDrugQuantitylabel = new System.Windows.Forms.Label();
            this.cartStockIDtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDashboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cashSaleRemove);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pricePerUnit);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cashSaleQuantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cashSaleDrugSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(16, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1304, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantity sale";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cashSaleRemove
            // 
            this.cashSaleRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cashSaleRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashSaleRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashSaleRemove.ForeColor = System.Drawing.Color.Black;
            this.cashSaleRemove.Location = new System.Drawing.Point(1176, 16);
            this.cashSaleRemove.Name = "cashSaleRemove";
            this.cashSaleRemove.Size = new System.Drawing.Size(87, 30);
            this.cashSaleRemove.TabIndex = 7;
            this.cashSaleRemove.Text = "Remove";
            this.cashSaleRemove.UseVisualStyleBackColor = false;
            this.cashSaleRemove.Click += new System.EventHandler(this.cashSaleRemove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(766, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price";
            // 
            // pricePerUnit
            // 
            this.pricePerUnit.Location = new System.Drawing.Point(837, 16);
            this.pricePerUnit.MaxLength = 10;
            this.pricePerUnit.Name = "pricePerUnit";
            this.pricePerUnit.Size = new System.Drawing.Size(153, 26);
            this.pricePerUnit.TabIndex = 5;
            this.pricePerUnit.TextChanged += new System.EventHandler(this.pricePerUnit_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1012, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Enter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cashSaleQuantity
            // 
            this.cashSaleQuantity.Location = new System.Drawing.Point(589, 20);
            this.cashSaleQuantity.Name = "cashSaleQuantity";
            this.cashSaleQuantity.Size = new System.Drawing.Size(155, 26);
            this.cashSaleQuantity.TabIndex = 3;
            this.cashSaleQuantity.TextChanged += new System.EventHandler(this.cashSaleQuantity_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(497, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantity";
            // 
            // cashSaleDrugSearch
            // 
            this.cashSaleDrugSearch.Location = new System.Drawing.Point(67, 18);
            this.cashSaleDrugSearch.Name = "cashSaleDrugSearch";
            this.cashSaleDrugSearch.Size = new System.Drawing.Size(424, 26);
            this.cashSaleDrugSearch.TabIndex = 1;
            this.cashSaleDrugSearch.TextChanged += new System.EventHandler(this.cashSaleDrugSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // cashSaleBalance
            // 
            this.cashSaleBalance.AutoSize = true;
            this.cashSaleBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashSaleBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cashSaleBalance.Location = new System.Drawing.Point(756, 27);
            this.cashSaleBalance.Name = "cashSaleBalance";
            this.cashSaleBalance.Size = new System.Drawing.Size(16, 24);
            this.cashSaleBalance.TabIndex = 3;
            this.cashSaleBalance.Text = ".";
            this.cashSaleBalance.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cashSaleAmountTextBox
            // 
            this.cashSaleAmountTextBox.Location = new System.Drawing.Point(94, 41);
            this.cashSaleAmountTextBox.MaxLength = 30;
            this.cashSaleAmountTextBox.Name = "cashSaleAmountTextBox";
            this.cashSaleAmountTextBox.Size = new System.Drawing.Size(176, 20);
            this.cashSaleAmountTextBox.TabIndex = 6;
            this.cashSaleAmountTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(322, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Discount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cashSaleDiscount
            // 
            this.cashSaleDiscount.Location = new System.Drawing.Point(448, 37);
            this.cashSaleDiscount.MaxLength = 20;
            this.cashSaleDiscount.Name = "cashSaleDiscount";
            this.cashSaleDiscount.Size = new System.Drawing.Size(123, 20);
            this.cashSaleDiscount.TabIndex = 8;
            this.cashSaleDiscount.Text = "0.00";
            this.cashSaleDiscount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cashSaleTotal
            // 
            this.cashSaleTotal.Enabled = false;
            this.cashSaleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashSaleTotal.ForeColor = System.Drawing.Color.Blue;
            this.cashSaleTotal.Location = new System.Drawing.Point(83, 5);
            this.cashSaleTotal.Name = "cashSaleTotal";
            this.cashSaleTotal.Size = new System.Drawing.Size(217, 29);
            this.cashSaleTotal.TabIndex = 4;
            this.cashSaleTotal.TextChanged += new System.EventHandler(this.cashSaleTotal_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(432, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "welcome  ";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(503, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(68, 16);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "welcome  ";
            // 
            // pfsession
            // 
            this.pfsession.Location = new System.Drawing.Point(661, 68);
            this.pfsession.Name = "pfsession";
            this.pfsession.Size = new System.Drawing.Size(99, 20);
            this.pfsession.TabIndex = 2;
            this.pfsession.Visible = false;
            this.pfsession.TextChanged += new System.EventHandler(this.pfsession_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1028, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "sale";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashSaleCancel
            // 
            this.cashSaleCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cashSaleCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashSaleCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashSaleCancel.Location = new System.Drawing.Point(1192, 26);
            this.cashSaleCancel.Name = "cashSaleCancel";
            this.cashSaleCancel.Size = new System.Drawing.Size(102, 36);
            this.cashSaleCancel.TabIndex = 12;
            this.cashSaleCancel.Text = "cancel";
            this.cashSaleCancel.UseVisualStyleBackColor = false;
            this.cashSaleCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // setSerial
            // 
            this.setSerial.Location = new System.Drawing.Point(1132, 88);
            this.setSerial.Name = "setSerial";
            this.setSerial.Size = new System.Drawing.Size(161, 20);
            this.setSerial.TabIndex = 20;
            this.setSerial.Visible = false;
            this.setSerial.TextChanged += new System.EventHandler(this.setSerial_TextChanged);
            // 
            // saleDashboardDataGridView
            // 
            this.saleDashboardDataGridView.AllowUserToOrderColumns = true;
            this.saleDashboardDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.saleDashboardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleDashboardDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDashboardDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.saleDashboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleDashboardDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.saleDashboardDataGridView.Location = new System.Drawing.Point(16, 183);
            this.saleDashboardDataGridView.Name = "saleDashboardDataGridView";
            this.saleDashboardDataGridView.Size = new System.Drawing.Size(1342, 536);
            this.saleDashboardDataGridView.TabIndex = 21;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(245, 68);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.lastNameTextBox.TabIndex = 41;
            this.lastNameTextBox.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(16, 68);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.firstNameTextBox.TabIndex = 40;
            this.firstNameTextBox.Visible = false;
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Location = new System.Drawing.Point(689, 98);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(0, 13);
            this.rowCountLabel.TabIndex = 42;
            // 
            // vatTextBox
            // 
            this.vatTextBox.Location = new System.Drawing.Point(506, 68);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(89, 20);
            this.vatTextBox.TabIndex = 43;
            this.vatTextBox.Visible = false;
            // 
            // displayResults
            // 
            this.displayResults.AutoSize = true;
            this.displayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayResults.Location = new System.Drawing.Point(1164, 306);
            this.displayResults.Name = "displayResults";
            this.displayResults.Size = new System.Drawing.Size(0, 31);
            this.displayResults.TabIndex = 63;
            this.displayResults.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(302, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 30);
            this.button2.TabIndex = 85;
            this.button2.Text = "calculator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // drugDetailsLabel
            // 
            this.drugDetailsLabel.AutoSize = true;
            this.drugDetailsLabel.Location = new System.Drawing.Point(13, 95);
            this.drugDetailsLabel.Name = "drugDetailsLabel";
            this.drugDetailsLabel.Size = new System.Drawing.Size(10, 13);
            this.drugDetailsLabel.TabIndex = 87;
            this.drugDetailsLabel.Text = ".";
            this.drugDetailsLabel.Click += new System.EventHandler(this.drugDetailsLabel_Click);
            // 
            // stockIDTextBox
            // 
            this.stockIDTextBox.Location = new System.Drawing.Point(802, 62);
            this.stockIDTextBox.Name = "stockIDTextBox";
            this.stockIDTextBox.Size = new System.Drawing.Size(204, 20);
            this.stockIDTextBox.TabIndex = 89;
            this.stockIDTextBox.Visible = false;
            this.stockIDTextBox.TextChanged += new System.EventHandler(this.stockIDTextBox_TextChanged);
            // 
            // drugStockQuantityTextBox
            // 
            this.drugStockQuantityTextBox.Location = new System.Drawing.Point(834, 0);
            this.drugStockQuantityTextBox.Name = "drugStockQuantityTextBox";
            this.drugStockQuantityTextBox.Size = new System.Drawing.Size(204, 20);
            this.drugStockQuantityTextBox.TabIndex = 90;
            this.drugStockQuantityTextBox.Visible = false;
            // 
            // cartQuantityTextBox
            // 
            this.cartQuantityTextBox.Location = new System.Drawing.Point(1132, 62);
            this.cartQuantityTextBox.Name = "cartQuantityTextBox";
            this.cartQuantityTextBox.Size = new System.Drawing.Size(142, 20);
            this.cartQuantityTextBox.TabIndex = 91;
            this.cartQuantityTextBox.Visible = false;
            // 
            // remainedDrugQuantitylabel
            // 
            this.remainedDrugQuantitylabel.AutoSize = true;
            this.remainedDrugQuantitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainedDrugQuantitylabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.remainedDrugQuantitylabel.Location = new System.Drawing.Point(526, 95);
            this.remainedDrugQuantitylabel.Name = "remainedDrugQuantitylabel";
            this.remainedDrugQuantitylabel.Size = new System.Drawing.Size(16, 24);
            this.remainedDrugQuantitylabel.TabIndex = 92;
            this.remainedDrugQuantitylabel.Text = ".";
            // 
            // cartStockIDtextBox
            // 
            this.cartStockIDtextBox.Location = new System.Drawing.Point(1056, 0);
            this.cartStockIDtextBox.Name = "cartStockIDtextBox";
            this.cartStockIDtextBox.Size = new System.Drawing.Size(204, 20);
            this.cartStockIDtextBox.TabIndex = 93;
            this.cartStockIDtextBox.Visible = false;
            // 
            // drugDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.cartStockIDtextBox);
            this.Controls.Add(this.remainedDrugQuantitylabel);
            this.Controls.Add(this.cartQuantityTextBox);
            this.Controls.Add(this.drugStockQuantityTextBox);
            this.Controls.Add(this.stockIDTextBox);
            this.Controls.Add(this.drugDetailsLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.displayResults);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.vatTextBox);
            this.Controls.Add(this.rowCountLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.saleDashboardDataGridView);
            this.Controls.Add(this.setSerial);
            this.Controls.Add(this.pfsession);
            this.Controls.Add(this.cashSaleCancel);
            this.Controls.Add(this.cashSaleTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cashSaleBalance);
            this.Controls.Add(this.cashSaleDiscount);
            this.Controls.Add(this.cashSaleAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "drugDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUANTITY SALE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dashboard_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dashboard_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDashboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cashSaleBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cashSaleDrugSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cashSaleTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cashSaleAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cashSaleDiscount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cashSaleCancel;
        private System.Windows.Forms.TextBox pfsession;
        private System.Windows.Forms.TextBox cashSaleQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pricePerUnit;
        private System.Windows.Forms.Button cashSaleRemove;
        private System.Windows.Forms.TextBox setSerial;
        private System.Windows.Forms.DataGridView saleDashboardDataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label rowCountLabel;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.Label displayResults;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label drugDetailsLabel;
        private System.Windows.Forms.TextBox stockIDTextBox;
        private System.Windows.Forms.TextBox drugStockQuantityTextBox;
        private System.Windows.Forms.TextBox cartQuantityTextBox;
        private System.Windows.Forms.Label remainedDrugQuantitylabel;
        private System.Windows.Forms.TextBox cartStockIDtextBox;
    }
}