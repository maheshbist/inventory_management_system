using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{ 
	class retrieval
	{
		public void showUsers(DataGridView gv,DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statGV, string data = null)
		{
			try
			{
				SqlCommand cmd;
				if (data == null)
				{
					cmd = new SqlCommand("st_getUsersData", MainClass.con);
				}
				else
				{
					cmd = new SqlCommand("st_getUsersDataLIKE", MainClass.con);
					cmd.Parameters.AddWithValue("@data",data);
				}
				
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd); //to excute the query this class is responsible.
				DataTable dt = new DataTable();
				da.Fill(dt);
				userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
				nameGV.DataPropertyName = dt.Columns["Name"].ToString();
				usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
				passGV.DataPropertyName = dt.Columns["Password"].ToString();
				emailGV.DataPropertyName = dt.Columns["Email"].ToString();
				phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
				statGV.DataPropertyName = dt.Columns["Status"].ToString();

				gv.DataSource = dt;
			}
			catch (Exception)
			{

			}
		}
		public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn statGV)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_getCategoriesDate", MainClass.con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd); //to excute the query this class is responsible.
				DataTable dt = new DataTable();
				da.Fill(dt);
				catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
				catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
				statGV.DataPropertyName = dt.Columns["Status"].ToString();
				gv.DataSource = dt;
			}
			catch (Exception)
			{
				MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
			}
		}

		public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
		{
			try
			{
				cb.DataSource = null;
				SqlCommand cmd = new SqlCommand(proc, MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DataRow dr = dt.NewRow();
				dr.ItemArray = new object[] { 0, "Select Suppliers......" };
				dt.Rows.InsertAt(dr, 0);
				cb.DisplayMember = displayMember;
				cb.ValueMember = valueMember;
				cb.DataSource = dt;
			}
			catch (Exception)
			{

			}
		}

		public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
		{
			try
			{
				cb.DataSource = null;
				SqlCommand cmd = new SqlCommand(proc, MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(param1, val1);
				cmd.Parameters.AddWithValue(param2, val2);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DataRow dr = dt.NewRow();
				dr.ItemArray = new object[] { 0, "Select Suppliers......" };
				dt.Rows.InsertAt(dr, 0);
				cb.DisplayMember = displayMember;
				cb.ValueMember = valueMember;
				cb.DataSource = dt;
			}
			catch (Exception)
			{
			}
		}

		public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, DataGridViewColumn priceGV, DataGridViewColumn barGV, DataGridViewColumn catIDGV)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd); //to excute the query this class is responsible.
				DataTable dt = new DataTable();
				da.Fill(dt);
				proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
				proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
				barGV.DataPropertyName = dt.Columns["Barcode"].ToString();
				priceGV.DataPropertyName = dt.Columns["price"].ToString();
				expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
				
				catGV.DataPropertyName = dt.Columns["Category"].ToString();
				catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
				gv.DataSource = dt;
			}
			catch (Exception)
			{
				MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
			}
		}

		private object productStockCount = 0;
		public object getProductQuantity(int proID)
		{ 
			try
			{
				SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@proID", proID);
				MainClass.con.Open();
				productStockCount = cmd.ExecuteScalar();
				MainClass.con.Close();
			}
			catch (Exception)
			{
			}
			return productStockCount;
		}

		public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDGV, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quantGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_getPurchaseINvoiceDetails", MainClass.con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@pid",pid);
				SqlDataAdapter da = new SqlDataAdapter(cmd); //to excute the query this class is responsible.
				DataTable dt = new DataTable();
				da.Fill(dt);
				mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
				proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
				proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
				pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
				totGV.DataPropertyName = dt.Columns["Total Price"].ToString();
				quantGV.DataPropertyName = dt.Columns["Qunatity"].ToString();
				gv.DataSource = dt;
			}
			catch (Exception)
			{
				MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
			}
		}


		public static int USER_ID
		{
			get;
			private set;
		}
		public static string EMP_NAME
		{
			get;
			private set;
		}

		public string[] productsData = new string[4];
		public string[] GetProductsWRTBarcode(string barcode)
		{
			try
			{		
				SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@barcode", barcode);
				MainClass.con.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows)
				{
					while (dr.Read())
					{
						productsData[0] = dr[0].ToString();
						productsData[1] = dr[1].ToString();
						productsData[2] = dr[2].ToString();
						productsData[3] = dr[3].ToString();
					}
				}
				else
				{
					
				}
				MainClass.con.Close();
			}
			catch (Exception)
			{

				MainClass.con.Close();
				throw;
			}
			return productsData;
		}

		private static string user_name=null, pass_word=null;
		private static bool checkLogin;
		public static bool getUserDetails(string username, string password)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@user",username);
				cmd.Parameters.AddWithValue("@pass",password);
				MainClass.con.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				if(dr.HasRows)
				{
					checkLogin = true;
					while (dr.Read())
					{
						USER_ID = Convert.ToInt32(dr["ID"].ToString());
						EMP_NAME = dr["Name"].ToString();
						user_name = dr["Username"].ToString();
						pass_word = dr["Password"].ToString();


					}
				
				}
				else
				{
					checkLogin = false;
					if (username != null && password != null)
					{
						if (user_name != username && pass_word == password)
						{
							MainClass.ShowMSG("Invalid Username", "Error", "Error");
						}
						else if (user_name == username && pass_word != password)
						{
							MainClass.ShowMSG("Invalid Password", "Error", "Error");
						}
						if (user_name != username && pass_word != password)
						{
							MainClass.ShowMSG("Invalid Username and Password", "Error", "Error");
						}
					}
				}
				MainClass.con.Close();
			}
			catch (Exception)
			{
				MainClass.con.Close();
				MainClass.ShowMSG("Unable to login...", "Error", "Error");
			}
			return checkLogin;
		}

		public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn comNameGV, DataGridViewColumn personGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV,DataGridViewColumn statusGV)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd); //to excute the query this class is responsible.
				DataTable dt = new DataTable();
				da.Fill(dt);
				suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
				comNameGV.DataPropertyName = dt.Columns["Company"].ToString();
				personGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
				phone1GV.DataPropertyName = dt.Columns["Phone1"].ToString();
				phone2GV.DataPropertyName = dt.Columns["Phone2"].ToString();

				addressGV.DataPropertyName = dt.Columns["Address"].ToString();
				statusGV.DataPropertyName  = dt.Columns["Status"].ToString();
				ntnGV.DataPropertyName     = dt.Columns["NTN #"].ToString();

				gv.DataSource = dt;
			}
			catch (Exception)
			{
				MainClass.ShowMSG("Unable to load suppliers data.", "Error", "Error");
			}
		}

		public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcadeGV, DataGridViewColumn expiryGV, DataGridViewColumn priceGV, DataGridViewColumn catGV, DataGridViewColumn availStGV, DataGridViewColumn statusGV,DataGridViewColumn totGV)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_getALLStock", MainClass.con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd); //to excute the query this class is responsible.
				DataTable dt = new DataTable();
				da.Fill(dt);
				proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
				proGV.DataPropertyName = dt.Columns["Product"].ToString();
				barcadeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
				expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
				priceGV.DataPropertyName = dt.Columns["Price"].ToString();
				catGV.DataPropertyName = dt.Columns["Category"].ToString();
				availStGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
				statusGV.DataPropertyName = dt.Columns["Status"].ToString();
				totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
				gv.DataSource = dt;
			}
			catch (Exception)
			{
				MainClass.ShowMSG("Unable to load stock data.", "Error", "Error");
			}
		}

	}
}
