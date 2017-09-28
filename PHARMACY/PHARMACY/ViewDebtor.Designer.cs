﻿namespace PHARMACY
{
    partial class ViewDebtor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDebtor));
            this.viewDebtorDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.debtorPdfReport = new System.Windows.Forms.Button();
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewDebtorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDebtorDataGridView
            // 
            this.viewDebtorDataGridView.AllowUserToOrderColumns = true;
            this.viewDebtorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.viewDebtorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDebtorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDebtorDataGridView.Location = new System.Drawing.Point(12, 61);
            this.viewDebtorDataGridView.Name = "viewDebtorDataGridView";
            this.viewDebtorDataGridView.Size = new System.Drawing.Size(1032, 375);
            this.viewDebtorDataGridView.TabIndex = 0;
            this.viewDebtorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDebtorDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(373, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Debtors";
            // 
            // debtorPdfReport
            // 
            this.debtorPdfReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.debtorPdfReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtorPdfReport.Location = new System.Drawing.Point(573, 9);
            this.debtorPdfReport.Name = "debtorPdfReport";
            this.debtorPdfReport.Size = new System.Drawing.Size(108, 32);
            this.debtorPdfReport.TabIndex = 2;
            this.debtorPdfReport.Text = "Print";
            this.debtorPdfReport.UseVisualStyleBackColor = false;
            this.debtorPdfReport.Click += new System.EventHandler(this.debtorPdfReport_Click);
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Location = new System.Drawing.Point(913, 28);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(0, 13);
            this.rowCountLabel.TabIndex = 5;
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exportToExcelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToExcelButton.Location = new System.Drawing.Point(687, 12);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(138, 30);
            this.exportToExcelButton.TabIndex = 6;
            this.exportToExcelButton.Text = "Excel";
            this.exportToExcelButton.UseVisualStyleBackColor = false;
            this.exportToExcelButton.Click += new System.EventHandler(this.exportToExcelButton_Click);
            // 
            // ViewDebtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 448);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.rowCountLabel);
            this.Controls.Add(this.debtorPdfReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewDebtorDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewDebtor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDebtor";
            this.Load += new System.EventHandler(this.ViewDebtor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDebtorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewDebtorDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button debtorPdfReport;
        private System.Windows.Forms.Label rowCountLabel;
        private System.Windows.Forms.Button exportToExcelButton;
    }
}