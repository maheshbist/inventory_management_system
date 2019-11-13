namespace IMS
{
	partial class login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.label2 = new System.Windows.Forms.Label();
			this.usernameTXt = new System.Windows.Forms.TextBox();
			this.passTxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.LoginBtn = new System.Windows.Forms.Button();
			this.nameErrorLabel = new System.Windows.Forms.Label();
			this.passErrorLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.leftPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.LoginBtn);
			this.leftPanel.Controls.Add(this.passTxt);
			this.leftPanel.Controls.Add(this.label4);
			this.leftPanel.Controls.Add(this.usernameTXt);
			this.leftPanel.Controls.Add(this.label2);
			this.leftPanel.Controls.Add(this.nameErrorLabel);
			this.leftPanel.Controls.Add(this.passErrorLabel);
			this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.leftPanel.Size = new System.Drawing.Size(283, 582);
			this.leftPanel.Controls.SetChildIndex(this.passErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.nameErrorLabel, 0);
			this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
			this.leftPanel.Controls.SetChildIndex(this.label2, 0);
			this.leftPanel.Controls.SetChildIndex(this.usernameTXt, 0);
			this.leftPanel.Controls.SetChildIndex(this.label4, 0);
			this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
			this.leftPanel.Controls.SetChildIndex(this.LoginBtn, 0);
			// 
			// panel2
			// 
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Size = new System.Drawing.Size(283, 46);
			// 
			// rightPanel
			// 
			this.rightPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightPanel.BackgroundImage")));
			this.rightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rightPanel.Controls.Add(this.label3);
			this.rightPanel.Location = new System.Drawing.Point(283, 0);
			this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rightPanel.Size = new System.Drawing.Size(955, 582);
			this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
			this.rightPanel.Controls.SetChildIndex(this.label3, 0);
			// 
			// panel1
			// 
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Size = new System.Drawing.Size(955, 46);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(88, 0);
			this.label1.Size = new System.Drawing.Size(195, 46);
			// 
			// userLabel
			// 
			this.userLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.userLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userLabel.ForeColor = System.Drawing.Color.Black;
			this.userLabel.Size = new System.Drawing.Size(955, 46);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 224);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username";
			// 
			// usernameTXt
			// 
			this.usernameTXt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTXt.Location = new System.Drawing.Point(3, 250);
			this.usernameTXt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.usernameTXt.MaxLength = 30;
			this.usernameTXt.Name = "usernameTXt";
			this.usernameTXt.Size = new System.Drawing.Size(270, 30);
			this.usernameTXt.TabIndex = 0;
			this.usernameTXt.TextChanged += new System.EventHandler(this.usernameTXt_TextChanged);
			// 
			// passTxt
			// 
			this.passTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passTxt.Location = new System.Drawing.Point(3, 310);
			this.passTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.passTxt.MaxLength = 30;
			this.passTxt.Name = "passTxt";
			this.passTxt.Size = new System.Drawing.Size(270, 30);
			this.passTxt.TabIndex = 1;
			this.passTxt.UseSystemPasswordChar = true;
			this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 285);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// LoginBtn
			// 
			this.LoginBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.LoginBtn.FlatAppearance.BorderSize = 2;
			this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginBtn.Location = new System.Drawing.Point(12, 351);
			this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(124, 48);
			this.LoginBtn.TabIndex = 2;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = false;
			this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// nameErrorLabel
			// 
			this.nameErrorLabel.AutoSize = true;
			this.nameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.nameErrorLabel.Location = new System.Drawing.Point(123, 219);
			this.nameErrorLabel.Name = "nameErrorLabel";
			this.nameErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.nameErrorLabel.TabIndex = 13;
			this.nameErrorLabel.Text = "*";
			this.nameErrorLabel.Visible = false;
			// 
			// passErrorLabel
			// 
			this.passErrorLabel.AutoSize = true;
			this.passErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passErrorLabel.ForeColor = System.Drawing.Color.Salmon;
			this.passErrorLabel.Location = new System.Drawing.Point(123, 281);
			this.passErrorLabel.Name = "passErrorLabel";
			this.passErrorLabel.Size = new System.Drawing.Size(29, 40);
			this.passErrorLabel.TabIndex = 14;
			this.passErrorLabel.Text = "*";
			this.passErrorLabel.Visible = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label3.Font = new System.Drawing.Font("Stencil", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label3.Location = new System.Drawing.Point(0, 481);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(955, 101);
			this.label3.TabIndex = 2;
			this.label3.Text = "Inventory Management System";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// login
			// 
			this.AcceptButton = this.LoginBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1238, 582);
			this.ControlBox = false;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "login";
			this.Text = "login";
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox passTxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox usernameTXt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button LoginBtn;
		private System.Windows.Forms.Label nameErrorLabel;
		private System.Windows.Forms.Label passErrorLabel;
		protected System.Windows.Forms.Label label3;
	}
}