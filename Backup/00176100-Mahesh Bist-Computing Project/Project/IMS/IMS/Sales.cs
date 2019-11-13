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
	public partial class Sales : Sample2
	{
		public Sales()
		{
			InitializeComponent();
		}

		private void Sales_Load(object sender, EventArgs e)
		{

		}

		retrieval r = new retrieval();
		string[] prodARR = new string[4];
		float GROSS;
		private void barCodeTxt_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void barCodeTxt_Validating(object sender, CancelEventArgs e)
		{
			if (barCodeTxt.Text != "")
			{
				prodARR = r.GetProductsWRTBarcode(barCodeTxt.Text);
				dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]),prodARR[1], 1,Convert.ToSingle(prodARR[2]),prodARR[2]);
				foreach (DataGridViewRow item in dataGridView1.Rows)
				{
					GROSS += Convert.ToSingle(item.Cells["TotGV"].Value.ToString());
				}
				grossTotLabel.Text = GROSS.ToString();
				GROSS = 0;
				barCodeTxt.Focus();
				barCodeTxt.Text = "";
			}
		}
	}
}
