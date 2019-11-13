using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
	public partial class settings : Sample
	{
		public settings()
		{
			InitializeComponent();
		}

		private void isCB_CheckedChanged(object sender, EventArgs e)
		{
			if(isCB.Checked)
			{
				userTxt.Enabled = false;
				passTxt.Enabled = false;
				userTxt.Text = "";
				passTxt.Text = "";
			}
			else
			{
				userTxt.Enabled = true;
				passTxt.Enabled = true;
			}
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			string s;
			string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			if (isCB.Checked)
			{
				if(serverTxt.Text != "" && databaseTxt.Text != "" )
				{
					s = "datasource="+ serverTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true;";
					File.WriteAllText(path+"\\connect", s);

					DialogResult dr = MessageBox.Show("Setting successfully saved....", "information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (dr == DialogResult.OK)
					{
						login log = new login();
						MainClass.showWindow(log, this, MDI.ActiveForm);
					}
				}
				else
				{
					MessageBox.Show("Please fill complete Data to continue.");
				}
			}
			else
			{
				if(serverTxt.Text != "" && databaseTxt.Text != "" && userTxt.Text != "" && passTxt.Text != "")
				{
					s = "datasource=" + serverTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";User ID=" + userTxt.Text + ";Password=" + passTxt.Text + ";MultipleActiveResultSets=true;";
					File.WriteAllText(path + "\\connect", s);

					DialogResult dr = MessageBox.Show("Setting successfully saved....", "information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (dr == DialogResult.OK)
					{
						login log = new login();
						MainClass.showWindow(log, this, MDI.ActiveForm);
					}

				}
				else
				{
					MessageBox.Show("Please fill complete Data to continue.");
				}
			}
			
		}
	}
}
