﻿namespace IMS
{
	partial class Sample
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
			this.leftPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.rightPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.userLabel = new System.Windows.Forms.Label();
			this.leftPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.leftPanel.Controls.Add(this.panel2);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.ForeColor = System.Drawing.Color.White;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(250, 537);
			this.leftPanel.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 49);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Right;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 49);
			this.label1.TabIndex = 1;
			this.label1.Text = "Welcome";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.panel1);
			this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightPanel.Location = new System.Drawing.Point(250, 0);
			this.rightPanel.Name = "rightPanel";
			this.rightPanel.Size = new System.Drawing.Size(783, 537);
			this.rightPanel.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.userLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(783, 49);
			this.panel1.TabIndex = 0;
			// 
			// userLabel
			// 
			this.userLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.userLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userLabel.Location = new System.Drawing.Point(0, 0);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(684, 49);
			this.userLabel.TabIndex = 1;
			this.userLabel.Text = "User";
			this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Sample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 537);
			this.Controls.Add(this.rightPanel);
			this.Controls.Add(this.leftPanel);
			this.Name = "Sample";
			this.Text = "Sample";
			this.leftPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Panel leftPanel;
		protected System.Windows.Forms.Panel panel2;
		protected System.Windows.Forms.Panel rightPanel;
		protected System.Windows.Forms.Panel panel1;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.Label userLabel;
	}
}