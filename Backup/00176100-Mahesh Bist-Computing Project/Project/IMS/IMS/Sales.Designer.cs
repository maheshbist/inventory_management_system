namespace IMS
{
	partial class Sales
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
			this.barCodeTxt = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label8 = new System.Windows.Forms.Label();
			this.grossTotLabel = new System.Windows.Forms.Label();
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
			this.panel3.Size = new System.Drawing.Size(902, 55);
			// 
			// panel4
			// 
			this.panel4.Size = new System.Drawing.Size(236, 52);
			// 
			// searchTxt
			// 
			this.searchTxt.Size = new System.Drawing.Size(140, 22);
			// 
			// backBtn
			// 
			this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.backBtn.FlatAppearance.BorderSize = 3;
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.barCodeTxt);
			this.leftPanel.Controls.Add(this.label2);
			this.leftPanel.Size = new System.Drawing.Size(236, 689);
			this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
			this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
			this.leftPanel.Controls.SetChildIndex(this.label2, 0);
			this.leftPanel.Controls.SetChildIndex(this.barCodeTxt, 0);
			// 
			// panel2
			// 
			this.panel2.Size = new System.Drawing.Size(236, 49);
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.tableLayoutPanel2);
			this.rightPanel.Controls.Add(this.dataGridView1);
			this.rightPanel.Location = new System.Drawing.Point(236, 0);
			this.rightPanel.Size = new System.Drawing.Size(902, 689);
			this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
			this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
			this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
			this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(902, 49);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(97, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(-2, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enter Barcode";
			// 
			// barCodeTxt
			// 
			this.barCodeTxt.Location = new System.Drawing.Point(0, 133);
			this.barCodeTxt.MaxLength = 100;
			this.barCodeTxt.Name = "barCodeTxt";
			this.barCodeTxt.Size = new System.Drawing.Size(230, 22);
			this.barCodeTxt.TabIndex = 2;
			this.barCodeTxt.TextChanged += new System.EventHandler(this.barCodeTxt_TextChanged);
			this.barCodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.barCodeTxt_Validating);
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
            this.pupGV,
            this.TotGV,
            this.deleteGV});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridView1.Location = new System.Drawing.Point(0, 104);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(902, 505);
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
			// pupGV
			// 
			this.pupGV.HeaderText = "Per Unit Price";
			this.pupGV.Name = "pupGV";
			this.pupGV.ReadOnly = true;
			// 
			// TotGV
			// 
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.TotGV.DefaultCellStyle = dataGridViewCellStyle2;
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
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.grossTotLabel, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 609);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 80);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(445, 80);
			this.label8.TabIndex = 11;
			this.label8.Text = "Gross Total";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grossTotLabel
			// 
			this.grossTotLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grossTotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grossTotLabel.Location = new System.Drawing.Point(454, 0);
			this.grossTotLabel.Name = "grossTotLabel";
			this.grossTotLabel.Size = new System.Drawing.Size(445, 80);
			this.grossTotLabel.TabIndex = 12;
			this.grossTotLabel.Text = "0.00";
			this.grossTotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Sales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1138, 689);
			this.Name = "Sales";
			this.Text = "Sales";
			this.Load += new System.EventHandler(this.Sales_Load);
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

		private System.Windows.Forms.TextBox barCodeTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label grossTotLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
		private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
	}
}