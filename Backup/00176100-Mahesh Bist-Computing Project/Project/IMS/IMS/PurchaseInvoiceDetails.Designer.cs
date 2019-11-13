namespace IMS
{
	partial class PurchaseInvoiceDetails
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
			this.label2 = new System.Windows.Forms.Label();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.purDD = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label8 = new System.Windows.Forms.Label();
			this.grossTotLabel = new System.Windows.Forms.Label();
			this.mPIDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
			this.leftPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Size = new System.Drawing.Size(822, 55);
			// 
			// panel4
			// 
			this.panel4.Size = new System.Drawing.Size(244, 52);
			// 
			// searchTxt
			// 
			this.searchTxt.Size = new System.Drawing.Size(130, 22);
			// 
			// backBtn
			// 
			this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.backBtn.FlatAppearance.BorderSize = 3;
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.purDD);
			this.leftPanel.Controls.Add(this.label3);
			this.leftPanel.Controls.Add(this.datePicker);
			this.leftPanel.Controls.Add(this.label2);
			this.leftPanel.Size = new System.Drawing.Size(244, 594);
			this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
			this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
			this.leftPanel.Controls.SetChildIndex(this.label2, 0);
			this.leftPanel.Controls.SetChildIndex(this.datePicker, 0);
			this.leftPanel.Controls.SetChildIndex(this.label3, 0);
			this.leftPanel.Controls.SetChildIndex(this.purDD, 0);
			// 
			// panel2
			// 
			this.panel2.Size = new System.Drawing.Size(244, 49);
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.tableLayoutPanel2);
			this.rightPanel.Controls.Add(this.dataGridView1);
			this.rightPanel.Location = new System.Drawing.Point(244, 0);
			this.rightPanel.Size = new System.Drawing.Size(822, 594);
			this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
			this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
			this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
			this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(822, 49);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(105, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Select Date";
			// 
			// datePicker
			// 
			this.datePicker.CustomFormat = "MMMM- yyy";
			this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.datePicker.Location = new System.Drawing.Point(6, 125);
			this.datePicker.Name = "datePicker";
			this.datePicker.ShowUpDown = true;
			this.datePicker.Size = new System.Drawing.Size(223, 22);
			this.datePicker.TabIndex = 3;
			this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Select Purchase Invoice";
			// 
			// purDD
			// 
			this.purDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.purDD.FormattingEnabled = true;
			this.purDD.Location = new System.Drawing.Point(6, 180);
			this.purDD.Name = "purDD";
			this.purDD.Size = new System.Drawing.Size(223, 24);
			this.purDD.TabIndex = 2;
			this.purDD.SelectedIndexChanged += new System.EventHandler(this.purDD_SelectedIndexChanged);
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
            this.mPIDgv,
            this.proIDGV,
            this.proGV,
            this.quantGV,
            this.pupGV,
            this.TotGV,
            this.deleteGV});
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
			this.dataGridView1.Size = new System.Drawing.Size(822, 399);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.grossTotLabel, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 503);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(822, 91);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(405, 91);
			this.label8.TabIndex = 11;
			this.label8.Text = "Gross Total";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grossTotLabel
			// 
			this.grossTotLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grossTotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grossTotLabel.Location = new System.Drawing.Point(414, 0);
			this.grossTotLabel.Name = "grossTotLabel";
			this.grossTotLabel.Size = new System.Drawing.Size(405, 91);
			this.grossTotLabel.TabIndex = 12;
			this.grossTotLabel.Text = "0.00";
			this.grossTotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mPIDgv
			// 
			this.mPIDgv.HeaderText = "mPIDGV";
			this.mPIDgv.Name = "mPIDgv";
			this.mPIDgv.ReadOnly = true;
			this.mPIDgv.Visible = false;
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
			// pupGV
			// 
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.pupGV.DefaultCellStyle = dataGridViewCellStyle2;
			this.pupGV.HeaderText = "Per Unit Price";
			this.pupGV.Name = "pupGV";
			this.pupGV.ReadOnly = true;
			// 
			// TotGV
			// 
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = null;
			this.TotGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.TotGV.HeaderText = "Total Amount";
			this.TotGV.Name = "TotGV";
			this.TotGV.ReadOnly = true;
			// 
			// deleteGV
			// 
			this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.deleteGV.HeaderText = "Action";
			this.deleteGV.Name = "deleteGV";
			this.deleteGV.ReadOnly = true;
			this.deleteGV.Text = "DELETE";
			this.deleteGV.UseColumnTextForButtonValue = true;
			// 
			// PurchaseInvoiceDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 594);
			this.Name = "PurchaseInvoiceDetails";
			this.Text = "Purchase Invoice Details";
			this.Load += new System.EventHandler(this.PurchaseInvoiceDetails_Load);
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.ComboBox purDD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label grossTotLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn mPIDgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
		private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
	}
}