﻿namespace IMS
{
	partial class Stocks
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.finalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leftPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Size = new System.Drawing.Size(817, 55);
			// 
			// searchTxt
			// 
			this.searchTxt.Size = new System.Drawing.Size(125, 22);
			// 
			// backBtn
			// 
			this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.backBtn.FlatAppearance.BorderSize = 3;
			// 
			// leftPanel
			// 
			this.leftPanel.Size = new System.Drawing.Size(250, 555);
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.dataGridView1);
			this.rightPanel.Size = new System.Drawing.Size(817, 555);
			this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
			this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
			this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(817, 49);
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
            this.quantGV,
            this.barGV,
            this.expiryGV,
            this.priceGV,
            this.catGV,
            this.finalGV,
            this.statusGV});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridView1.Location = new System.Drawing.Point(0, 104);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(817, 361);
			this.dataGridView1.TabIndex = 6;
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
			// quantGV
			// 
			this.quantGV.HeaderText = "Quantity";
			this.quantGV.Name = "quantGV";
			this.quantGV.ReadOnly = true;
			// 
			// barGV
			// 
			this.barGV.HeaderText = "Barcode";
			this.barGV.Name = "barGV";
			this.barGV.ReadOnly = true;
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
			dataGridViewCellStyle2.NullValue = null;
			this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
			this.priceGV.HeaderText = "Price";
			this.priceGV.Name = "priceGV";
			this.priceGV.ReadOnly = true;
			// 
			// catGV
			// 
			this.catGV.HeaderText = "Category";
			this.catGV.Name = "catGV";
			this.catGV.ReadOnly = true;
			// 
			// finalGV
			// 
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = null;
			this.finalGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.finalGV.HeaderText = "Total Amount";
			this.finalGV.Name = "finalGV";
			this.finalGV.ReadOnly = true;
			// 
			// statusGV
			// 
			this.statusGV.HeaderText = "Status";
			this.statusGV.Name = "statusGV";
			this.statusGV.ReadOnly = true;
			// 
			// Stocks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 555);
			this.Name = "Stocks";
			this.Text = "Stocks";
			this.Load += new System.EventHandler(this.Stocks_Load);
			this.leftPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn barGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn finalGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
	}
}