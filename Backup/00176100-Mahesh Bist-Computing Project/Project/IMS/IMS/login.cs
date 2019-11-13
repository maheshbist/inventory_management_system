using System;
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
	public partial class login : Sample
	{
		public login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (usernameTXt.Text == "") { nameErrorLabel.Visible = true; }
			else { nameErrorLabel.Visible = false; }

			if (passTxt.Text == "") { passErrorLabel.Visible = true; }
			else { passErrorLabel.Visible = false; }
			
			if(nameErrorLabel.Visible || passErrorLabel.Visible)
			{
				MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");//Error is the type of message.
			}
			else
			{

					if (retrieval.getUserDetails(usernameTXt.Text, passTxt.Text))
					{
						HomeScreen hm = new HomeScreen();
						MainClass.showWindow(hm, this, MDI.ActiveForm);
					}
					else
					{

					}
			}

			
		}

		private void usernameTXt_TextChanged(object sender, EventArgs e)
		{
			if (usernameTXt.Text == "") { nameErrorLabel.Visible = true; }
			else { nameErrorLabel.Visible = false; }
		}

		private void passTxt_TextChanged(object sender, EventArgs e)
		{
			if (passTxt.Text == "") { passErrorLabel.Visible = true; }
			else { passErrorLabel.Visible = false; }
		}
	}
}
