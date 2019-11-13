using System;

namespace IMS
{
	partial class Sample2
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.addBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.viewBtn = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.backBtn = new System.Windows.Forms.Button();
			this.leftPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.panel4);
			this.leftPanel.Size = new System.Drawing.Size(250, 571);
			this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
			this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.backBtn);
			this.panel2.Controls.SetChildIndex(this.label1, 0);
			this.panel2.Controls.SetChildIndex(this.backBtn, 0);
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.panel3);
			this.rightPanel.ForeColor = System.Drawing.Color.Black;
			this.rightPanel.Size = new System.Drawing.Size(870, 571);
			this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
			this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(870, 49);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(111, 0);
			this.label1.Size = new System.Drawing.Size(139, 49);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tableLayoutPanel1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 49);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(870, 55);
			this.panel3.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Controls.Add(this.deleteBtn, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.saveBtn, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.editBtn, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.addBtn, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.viewBtn, 4, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 55);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.deleteBtn.FlatAppearance.BorderSize = 2;
			this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn.ForeColor = System.Drawing.Color.White;
			this.deleteBtn.Location = new System.Drawing.Point(435, 3);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(138, 49);
			this.deleteBtn.TabIndex = 3;
			this.deleteBtn.Text = "DELETE";
			this.deleteBtn.UseVisualStyleBackColor = false;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.saveBtn.FlatAppearance.BorderSize = 2;
			this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveBtn.ForeColor = System.Drawing.Color.White;
			this.saveBtn.Location = new System.Drawing.Point(291, 3);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(138, 49);
			this.saveBtn.TabIndex = 2;
			this.saveBtn.Text = "SAVE";
			this.saveBtn.UseVisualStyleBackColor = false;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.editBtn.FlatAppearance.BorderSize = 2;
			this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editBtn.ForeColor = System.Drawing.Color.White;
			this.editBtn.Location = new System.Drawing.Point(147, 3);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(138, 49);
			this.editBtn.TabIndex = 1;
			this.editBtn.Text = "EDIT";
			this.editBtn.UseVisualStyleBackColor = false;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// addBtn
			// 
			this.addBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.addBtn.FlatAppearance.BorderSize = 2;
			this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.ForeColor = System.Drawing.Color.White;
			this.addBtn.Location = new System.Drawing.Point(3, 3);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(138, 49);
			this.addBtn.TabIndex = 0;
			this.addBtn.Text = "ADD";
			this.addBtn.UseVisualStyleBackColor = false;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.searchTxt);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(723, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 49);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search";
			// 
			// searchTxt
			// 
			this.searchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchTxt.Location = new System.Drawing.Point(3, 18);
			this.searchTxt.MaxLength = 100;
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(138, 22);
			this.searchTxt.TabIndex = 0;
			this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
			// 
			// viewBtn
			// 
			this.viewBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.viewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.viewBtn.FlatAppearance.BorderSize = 2;
			this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewBtn.ForeColor = System.Drawing.Color.White;
			this.viewBtn.Location = new System.Drawing.Point(579, 3);
			this.viewBtn.Name = "viewBtn";
			this.viewBtn.Size = new System.Drawing.Size(138, 49);
			this.viewBtn.TabIndex = 5;
			this.viewBtn.Text = "VIEW";
			this.viewBtn.UseVisualStyleBackColor = false;
			this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 49);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(250, 52);
			this.panel4.TabIndex = 1;
			// 
			// backBtn
			// 
			this.backBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.backBtn.FlatAppearance.BorderSize = 3;
			this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backBtn.Location = new System.Drawing.Point(0, 0);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(78, 49);
			this.backBtn.TabIndex = 2;
			this.backBtn.Text = "BACK";
			this.backBtn.UseVisualStyleBackColor = false;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
			// 
			// Sample2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 571);
			this.ControlBox = false;
			this.Name = "Sample2";
			this.Text = "";
			this.leftPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		protected System.Windows.Forms.Panel panel3;
		protected System.Windows.Forms.Panel panel4;
		protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		protected System.Windows.Forms.Button deleteBtn;
		protected System.Windows.Forms.Button saveBtn;
		protected System.Windows.Forms.Button editBtn;
		protected System.Windows.Forms.Button addBtn;
		protected System.Windows.Forms.GroupBox groupBox1;
		protected System.Windows.Forms.TextBox searchTxt;
		protected System.Windows.Forms.Button backBtn;
		protected System.Windows.Forms.Button viewBtn;
	}
}