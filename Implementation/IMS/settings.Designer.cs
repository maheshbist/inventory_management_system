namespace IMS
{
	partial class settings
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
			this.label2 = new System.Windows.Forms.Label();
			this.serverTxt = new System.Windows.Forms.TextBox();
			this.databaseTxt = new System.Windows.Forms.TextBox();
			this.databaseLabel = new System.Windows.Forms.Label();
			this.userTxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.passTxt = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.isCB = new System.Windows.Forms.CheckBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.leftPanel.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.saveBtn);
			this.leftPanel.Controls.Add(this.isCB);
			this.leftPanel.Controls.Add(this.passTxt);
			this.leftPanel.Controls.Add(this.label6);
			this.leftPanel.Controls.Add(this.userTxt);
			this.leftPanel.Controls.Add(this.label5);
			this.leftPanel.Controls.Add(this.databaseTxt);
			this.leftPanel.Controls.Add(this.databaseLabel);
			this.leftPanel.Controls.Add(this.serverTxt);
			this.leftPanel.Controls.Add(this.label2);
			this.leftPanel.Size = new System.Drawing.Size(275, 549);
			//this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
			this.leftPanel.Controls.SetChildIndex(this.label2, 0);
			this.leftPanel.Controls.SetChildIndex(this.serverTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.databaseLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.databaseTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.label5, 0);
			this.leftPanel.Controls.SetChildIndex(this.userTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.label6, 0);
			this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
			this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
			// 
			// rightPanel
			// 
			this.rightPanel.Location = new System.Drawing.Point(275, 0);
			this.rightPanel.Size = new System.Drawing.Size(834, 549);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(275, 57);
			// 
			// panel2
			// 
			this.panel2.Size = new System.Drawing.Size(834, 57);
			// 
			// label3
			// 
			this.userLabel.Size = new System.Drawing.Size(834, 57);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Server";
			// 
			// serverTxt
			// 
			this.serverTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serverTxt.Location = new System.Drawing.Point(12, 165);
			this.serverTxt.MaxLength = 50;
			this.serverTxt.Name = "serverTxt";
			this.serverTxt.Size = new System.Drawing.Size(248, 30);
			this.serverTxt.TabIndex = 2;
			// 
			// databaseTxt
			// 
			this.databaseTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.databaseTxt.Location = new System.Drawing.Point(12, 233);
			this.databaseTxt.MaxLength = 100;
			this.databaseTxt.Name = "databaseTxt";
			this.databaseTxt.Size = new System.Drawing.Size(248, 30);
			this.databaseTxt.TabIndex = 4;
			// 
			// databaseLabel
			// 
			this.databaseLabel.AutoSize = true;
			this.databaseLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.databaseLabel.Location = new System.Drawing.Point(8, 207);
			this.databaseLabel.Name = "databaseLabel";
			this.databaseLabel.Size = new System.Drawing.Size(81, 23);
			this.databaseLabel.TabIndex = 3;
			this.databaseLabel.Text = "Database";
			// 
			// userTxt
			// 
			this.userTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userTxt.Location = new System.Drawing.Point(12, 302);
			this.userTxt.MaxLength = 50;
			this.userTxt.Name = "userTxt";
			this.userTxt.Size = new System.Drawing.Size(248, 30);
			this.userTxt.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 276);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "User ID";
			// 
			// passTxt
			// 
			this.passTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passTxt.Location = new System.Drawing.Point(12, 374);
			this.passTxt.MaxLength = 50;
			this.passTxt.Name = "passTxt";
			this.passTxt.Size = new System.Drawing.Size(248, 30);
			this.passTxt.TabIndex = 8;
			this.passTxt.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 347);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Password";
			// 
			// isCB
			// 
			this.isCB.AutoSize = true;
			this.isCB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.isCB.Location = new System.Drawing.Point(12, 412);
			this.isCB.Name = "isCB";
			this.isCB.Size = new System.Drawing.Size(177, 27);
			this.isCB.TabIndex = 11;
			this.isCB.Text = "Integrated Security";
			this.isCB.UseVisualStyleBackColor = true;
			this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
			// 
			// saveBtn
			// 
			this.saveBtn.FlatAppearance.BorderSize = 2;
			this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveBtn.Location = new System.Drawing.Point(12, 450);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(106, 40);
			this.saveBtn.TabIndex = 12;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// settings
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 549);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "settings";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "settings";
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.rightPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.CheckBox isCB;
		private System.Windows.Forms.TextBox passTxt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox userTxt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox databaseTxt;
		private System.Windows.Forms.Label databaseLabel;
		private System.Windows.Forms.TextBox serverTxt;
		private System.Windows.Forms.Label label2;
	}
}