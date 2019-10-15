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
	public partial class Stocks : Sample2
	{
		public Stocks()
		{
			InitializeComponent();
		}

		private void Stocks_Load(object sender, EventArgs e)
		{
			
		}

		public override void addBtn_Click(object sender, EventArgs e)
		{

		}


		public override void editBtn_Click(object sender, EventArgs e)
		{

		}

		public override void saveBtn_Click(object sender, EventArgs e)
		{

		}

		public override void deleteBtn_Click(object sender, EventArgs e)
		{

		}

		public override void searchTxt_TextChanged(object sender, EventArgs e)
		{

		}

		retrieval r = new retrieval();
		public override void viewBtn_Click(object sender, EventArgs e)
		{
			r.showStockDetails(dataGridView1, proIDGV, proGV, barGV, expiryGV, priceGV, catGV, quantGV, statusGV, finalGV);
		}
	}
}
