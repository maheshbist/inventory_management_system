﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
	public partial class HomeScreen : Sample
	{
		public HomeScreen()
		{
			InitializeComponent();
		}

		private void userBtn_Click(object sender, EventArgs e)
		{
			Users u = new Users();
			MainClass.showWindow(u, this, MDI.ActiveForm);
		}

		private void catBtn_Click(object sender, EventArgs e)
		{
			Categories u = new Categories();
			MainClass.showWindow(u, this, MDI.ActiveForm);
		}

		private void proDD_Click(object sender, EventArgs e)
		{
			products u = new products();
			MainClass.showWindow(u, this, MDI.ActiveForm);
		}

		private void HomeScreen_Load(object sender, EventArgs e)
		{

			MDI.logoutToolStripMenuItem.Enabled = true;
			userLabel.Text = retrieval.EMP_NAME;
		}

		private void suppBtn_Click(object sender, EventArgs e)
		{
			Supplier u = new Supplier();
			MainClass.showWindow(u, this, MDI.ActiveForm);
		}

		private void purchaseBtn_Click(object sender, EventArgs e)
		{
			PurchaseInvoice u = new PurchaseInvoice();
			MainClass.showWindow(u, this, MDI.ActiveForm);
		}

		private void stockBtn_Click(object sender, EventArgs e)
		{
			Stocks u = new Stocks();
			MainClass.showWindow(u, this, MDI.ActiveForm);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Sales u = new Sales();
			MainClass.showWindow(u, this, MDI.ActiveForm);
		}
	}
}
