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
	public partial class Sample2 : Sample
	{
		public Sample2()
		{
			InitializeComponent();
		}

		public virtual void backBtn_Click_1(object sender, EventArgs e)
		{
			HomeScreen obj = new HomeScreen();
			MainClass.showWindow(obj, this, MDI.ActiveForm);
		}

		public virtual void addBtn_Click(object sender, EventArgs e)
		{

		}


		public virtual void editBtn_Click(object sender, EventArgs e)
		{

		}

		public virtual void saveBtn_Click(object sender, EventArgs e)
		{

		}

		public virtual void deleteBtn_Click(object sender, EventArgs e)
		{

		}

		public virtual void searchTxt_TextChanged(object sender, EventArgs e)
		{

		}

		public virtual void viewBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
