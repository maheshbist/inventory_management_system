namespace IMS
{
	partial class Categories
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label4 = new System.Windows.Forms.Label();
			this.catTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.catErrorLabel = new System.Windows.Forms.Label();
			this.activeErrorLabel = new System.Windows.Forms.Label();
			this.activeDD = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.panel3.Size = new System.Drawing.Size(550, 55);
			// 
			// searchTxt
			// 
			this.searchTxt.Size = new System.Drawing.Size(83, 22);
			// 
			// backBtn
			// 
			this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.backBtn.FlatAppearance.BorderSize = 3;
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.activeDD);
			this.leftPanel.Controls.Add(this.label4);
			this.leftPanel.Controls.Add(this.catTxt);
			this.leftPanel.Controls.Add(this.label2);
			this.leftPanel.Controls.Add(this.catErrorLabel);
			this.leftPanel.Controls.Add(this.activeErrorLabel);
			this.leftPanel.Size = new System.Drawing.Size(250, 450);
			this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
			this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
			this.leftPanel.Controls.SetChildIndex(this.activeErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.catErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.label2, 0);
			this.leftPanel.Controls.SetChildIndex(this.catTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.label4, 0);
			this.leftPanel.Controls.SetChildIndex(this.activeDD, 0);
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.dataGridView1);
			this.rightPanel.Size = new System.Drawing.Size(550, 450);
			this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
			this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
			this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(550, 49);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 17);
			this.label4.TabIndex = 20;
			this.label4.Text = "Is Active";
			// 
			// catTxt
			// 
			this.catTxt.Location = new System.Drawing.Point(10, 133);
			this.catTxt.Name = "catTxt";
			this.catTxt.Size = new System.Drawing.Size(234, 22);
			this.catTxt.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Category Name";
			// 
			// catErrorLabel
			// 
			this.catErrorLabel.AutoSize = true;
			this.catErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.catErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.catErrorLabel.Location = new System.Drawing.Point(111, 105);
			this.catErrorLabel.Name = "catErrorLabel";
			this.catErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.catErrorLabel.TabIndex = 19;
			this.catErrorLabel.Text = "*";
			this.catErrorLabel.Visible = false;
			// 
			// activeErrorLabel
			// 
			this.activeErrorLabel.AutoSize = true;
			this.activeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activeErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.activeErrorLabel.Location = new System.Drawing.Point(109, 153);
			this.activeErrorLabel.Name = "activeErrorLabel";
			this.activeErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.activeErrorLabel.TabIndex = 22;
			this.activeErrorLabel.Text = "*";
			this.activeErrorLabel.Visible = false;
			// 
			// activeDD
			// 
			this.activeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.activeDD.FormattingEnabled = true;
			this.activeDD.Items.AddRange(new object[] {
            "Yes",
            "No"});
			this.activeDD.Location = new System.Drawing.Point(10, 181);
			this.activeDD.Name = "activeDD";
			this.activeDD.Size = new System.Drawing.Size(234, 24);
			this.activeDD.TabIndex = 23;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDGV,
            this.NameGV,
            this.statusGV});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 104);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(550, 346);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// catIDGV
			// 
			this.catIDGV.HeaderText = "catID";
			this.catIDGV.Name = "catIDGV";
			this.catIDGV.ReadOnly = true;
			this.catIDGV.Visible = false;
			// 
			// NameGV
			// 
			this.NameGV.HeaderText = "Name";
			this.NameGV.Name = "NameGV";
			this.NameGV.ReadOnly = true;
			// 
			// statusGV
			// 
			this.statusGV.HeaderText = "Status";
			this.statusGV.Name = "statusGV";
			this.statusGV.ReadOnly = true;
			// 
			// Categories
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "Categories";
			this.Text = "Categories";
			this.Load += new System.EventHandler(this.Categories_Load);
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox catTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label catErrorLabel;
		private System.Windows.Forms.Label activeErrorLabel;
		private System.Windows.Forms.ComboBox activeDD;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
	}
}