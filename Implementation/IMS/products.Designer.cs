﻿namespace IMS
{
	partial class products
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label2 = new System.Windows.Forms.Label();
			this.proTxt = new System.Windows.Forms.TextBox();
			this.proErrorLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.barcodeTxt = new System.Windows.Forms.TextBox();
			this.barcodeErrorLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.expiryPicker = new System.Windows.Forms.DateTimePicker();
			this.expiryErrorLabel = new System.Windows.Forms.Label();
			this.priceTxt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.priceErrorLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.catErrorLabel = new System.Windows.Forms.Label();
			this.categoryDD = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leftPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Size = new System.Drawing.Size(849, 55);
			// 
			// searchTxt
			// 
			this.searchTxt.Size = new System.Drawing.Size(132, 22);
			// 
			// backBtn
			// 
			this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.backBtn.FlatAppearance.BorderSize = 3;
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.categoryDD);
			this.leftPanel.Controls.Add(this.label5);
			this.leftPanel.Controls.Add(this.priceTxt);
			this.leftPanel.Controls.Add(this.label8);
			this.leftPanel.Controls.Add(this.expiryPicker);
			this.leftPanel.Controls.Add(this.label6);
			this.leftPanel.Controls.Add(this.barcodeTxt);
			this.leftPanel.Controls.Add(this.label4);
			this.leftPanel.Controls.Add(this.proTxt);
			this.leftPanel.Controls.Add(this.label2);
			this.leftPanel.Controls.Add(this.proErrorLabel);
			this.leftPanel.Controls.Add(this.barcodeErrorLabel);
			this.leftPanel.Controls.Add(this.expiryErrorLabel);
			this.leftPanel.Controls.Add(this.priceErrorLabel);
			this.leftPanel.Controls.Add(this.catErrorLabel);
			this.leftPanel.Size = new System.Drawing.Size(250, 567);
			this.leftPanel.Controls.SetChildIndex(this.catErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.priceErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.expiryErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.proErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
			this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
			this.leftPanel.Controls.SetChildIndex(this.label2, 0);
			this.leftPanel.Controls.SetChildIndex(this.proTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.label4, 0);
			this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.label6, 0);
			this.leftPanel.Controls.SetChildIndex(this.expiryPicker, 0);
			this.leftPanel.Controls.SetChildIndex(this.label8, 0);
			this.leftPanel.Controls.SetChildIndex(this.priceTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.label5, 0);
			this.leftPanel.Controls.SetChildIndex(this.categoryDD, 0);
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.dataGridView1);
			this.rightPanel.Size = new System.Drawing.Size(849, 567);
			this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
			this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
			this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(849, 49);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Product Name";
			// 
			// proTxt
			// 
			this.proTxt.Location = new System.Drawing.Point(10, 134);
			this.proTxt.Name = "proTxt";
			this.proTxt.Size = new System.Drawing.Size(234, 22);
			this.proTxt.TabIndex = 3;
			// 
			// proErrorLabel
			// 
			this.proErrorLabel.AutoSize = true;
			this.proErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.proErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.proErrorLabel.Location = new System.Drawing.Point(111, 106);
			this.proErrorLabel.Name = "proErrorLabel";
			this.proErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.proErrorLabel.TabIndex = 13;
			this.proErrorLabel.Text = "*";
			this.proErrorLabel.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "Barcode";
			// 
			// barcodeTxt
			// 
			this.barcodeTxt.Location = new System.Drawing.Point(10, 182);
			this.barcodeTxt.Name = "barcodeTxt";
			this.barcodeTxt.Size = new System.Drawing.Size(234, 22);
			this.barcodeTxt.TabIndex = 15;
			// 
			// barcodeErrorLabel
			// 
			this.barcodeErrorLabel.AutoSize = true;
			this.barcodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.barcodeErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.barcodeErrorLabel.Location = new System.Drawing.Point(109, 154);
			this.barcodeErrorLabel.Name = "barcodeErrorLabel";
			this.barcodeErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.barcodeErrorLabel.TabIndex = 16;
			this.barcodeErrorLabel.Text = "*";
			this.barcodeErrorLabel.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 17);
			this.label6.TabIndex = 17;
			this.label6.Text = "Expiry Date";
			// 
			// expiryPicker
			// 
			this.expiryPicker.CustomFormat = "dd-MMM-yyyy";
			this.expiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.expiryPicker.Location = new System.Drawing.Point(10, 232);
			this.expiryPicker.Name = "expiryPicker";
			this.expiryPicker.Size = new System.Drawing.Size(234, 22);
			this.expiryPicker.TabIndex = 18;
			// 
			// expiryErrorLabel
			// 
			this.expiryErrorLabel.AutoSize = true;
			this.expiryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.expiryErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.expiryErrorLabel.Location = new System.Drawing.Point(110, 203);
			this.expiryErrorLabel.Name = "expiryErrorLabel";
			this.expiryErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.expiryErrorLabel.TabIndex = 19;
			this.expiryErrorLabel.Text = "*";
			this.expiryErrorLabel.Visible = false;
			// 
			// priceTxt
			// 
			this.priceTxt.Location = new System.Drawing.Point(10, 282);
			this.priceTxt.Name = "priceTxt";
			this.priceTxt.Size = new System.Drawing.Size(234, 22);
			this.priceTxt.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 261);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 17);
			this.label8.TabIndex = 20;
			this.label8.Text = "Price";
			// 
			// priceErrorLabel
			// 
			this.priceErrorLabel.AutoSize = true;
			this.priceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.priceErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.priceErrorLabel.Location = new System.Drawing.Point(109, 254);
			this.priceErrorLabel.Name = "priceErrorLabel";
			this.priceErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.priceErrorLabel.TabIndex = 22;
			this.priceErrorLabel.Text = "*";
			this.priceErrorLabel.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 310);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 17);
			this.label5.TabIndex = 23;
			this.label5.Text = "Category";
			// 
			// catErrorLabel
			// 
			this.catErrorLabel.AutoSize = true;
			this.catErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.catErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.catErrorLabel.Location = new System.Drawing.Point(109, 303);
			this.catErrorLabel.Name = "catErrorLabel";
			this.catErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.catErrorLabel.TabIndex = 24;
			this.catErrorLabel.Text = "*";
			this.catErrorLabel.Visible = false;
			// 
			// categoryDD
			// 
			this.categoryDD.FormattingEnabled = true;
			this.categoryDD.Location = new System.Drawing.Point(10, 331);
			this.categoryDD.Name = "categoryDD";
			this.categoryDD.Size = new System.Drawing.Size(234, 24);
			this.categoryDD.TabIndex = 25;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.proGV,
            this.barcodeGV,
            this.expiryGV,
            this.priceGV,
            this.catIDGV,
            this.catGV});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 104);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(849, 463);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// proIDGV
			// 
			this.proIDGV.HeaderText = "proID";
			this.proIDGV.Name = "proIDGV";
			this.proIDGV.ReadOnly = true;
			this.proIDGV.Visible = false;
			// 
			// proGV
			// 
			this.proGV.HeaderText = "Product";
			this.proGV.Name = "proGV";
			this.proGV.ReadOnly = true;
			// 
			// barcodeGV
			// 
			this.barcodeGV.HeaderText = "Barcode";
			this.barcodeGV.Name = "barcodeGV";
			this.barcodeGV.ReadOnly = true;
			// 
			// expiryGV
			// 
			this.expiryGV.HeaderText = "Expiry Date";
			this.expiryGV.Name = "expiryGV";
			this.expiryGV.ReadOnly = true;
			// 
			// priceGV
			// 
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = "0";
			this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
			this.priceGV.HeaderText = "Price";
			this.priceGV.Name = "priceGV";
			this.priceGV.ReadOnly = true;
			// 
			// catIDGV
			// 
			this.catIDGV.HeaderText = "CatIDGV";
			this.catIDGV.Name = "catIDGV";
			this.catIDGV.ReadOnly = true;
			this.catIDGV.Visible = false;
			// 
			// catGV
			// 
			this.catGV.HeaderText = "Category";
			this.catGV.Name = "catGV";
			this.catGV.ReadOnly = true;
			// 
			// products
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1099, 567);
			this.Name = "products";
			this.Text = "Products";
			this.Load += new System.EventHandler(this.products_Load);
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox proTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label proErrorLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox barcodeTxt;
		private System.Windows.Forms.Label barcodeErrorLabel;
		private System.Windows.Forms.DateTimePicker expiryPicker;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox priceTxt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label expiryErrorLabel;
		private System.Windows.Forms.Label priceErrorLabel;
		private System.Windows.Forms.ComboBox categoryDD;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label catErrorLabel;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
	}
}