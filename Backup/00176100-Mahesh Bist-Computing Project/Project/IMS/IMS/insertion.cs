﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS
{
	class insertion
	{
		public void insertUser(string name,string username,string pass,string email,string phone,Int16 status)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@name",name);
				cmd.Parameters.AddWithValue("@username",username);
				cmd.Parameters.AddWithValue("@pwd",pass);
				cmd.Parameters.AddWithValue("@phone",phone);
				cmd.Parameters.AddWithValue("@email",email);
				cmd.Parameters.AddWithValue("@status", status);
				MainClass.con.Open();
				cmd.ExecuteNonQuery();
				MainClass.con.Close();
				MainClass.ShowMSG(name+" added to the system successfully","Success...", "success");
			}
			catch(Exception ex)
			{
				MainClass.con.Close();
				MainClass.ShowMSG(ex.Message, "Error...", "Error");
			}
		}
		public void insertCat(string name, Int16 status)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@name", name);
				cmd.Parameters.AddWithValue("@isActive", status);
				MainClass.con.Open();
				cmd.ExecuteNonQuery();
				MainClass.con.Close();
				MainClass.ShowMSG(name + " added to the system successfully", "Success...", "success");
			}
			catch (Exception ex)
			{
				MainClass.con.Close();
				MainClass.ShowMSG(ex.Message, "Error...", "Error");
			}
		}
		public void insertProduct(string product, string barcode, float price, int catID, DateTime? expiry = null)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_productInsert", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@name", product);
				cmd.Parameters.AddWithValue("@barcode", barcode);
				cmd.Parameters.AddWithValue("@price", price);
				if(expiry == null)
				{
					cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
				}
				else
				{
					cmd.Parameters.AddWithValue("@expiry", expiry);
				}
				cmd.Parameters.AddWithValue("@catID", catID);

				MainClass.con.Open();
				cmd.ExecuteNonQuery();
				MainClass.con.Close();
				MainClass.ShowMSG(product + " added to the system successfully", "Success...", "success");
			}
			catch (Exception ex)
			{
				MainClass.con.Close();
				MainClass.ShowMSG(ex.Message, "Error...", "Error");
			}
		}
		public void insertSupplier(string company, string person, string phone1, string address, Int16 status, string phone2=null,string ntn =null)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@company", company);
				cmd.Parameters.AddWithValue("@conPerson", person);
				cmd.Parameters.AddWithValue("@phone1", phone1);
				if (phone2 == null)
				{
					cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
				}
				else
				{
					cmd.Parameters.AddWithValue("@phone2", phone2);
				}
				if (ntn == null)
				{
					cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
				}
				else
				{
					cmd.Parameters.AddWithValue("@ntn", ntn);
				}

				cmd.Parameters.AddWithValue("@address", address);
				cmd.Parameters.AddWithValue("@status", status);

				MainClass.con.Open();
				cmd.ExecuteNonQuery();
				MainClass.con.Close();
				MainClass.ShowMSG(company + " added to the system successfully", "Success...", "success");
			}
			catch (Exception ex)
			{
				MainClass.con.Close();
				MainClass.ShowMSG(ex.Message, "Error...", "Error");
			}
		}

		private Int64 purchaseInvoiceID;
		public Int64 insertPurchaseInvoice(DateTime date,int doneBy,int suppID)
		{
			try
			{
					SqlCommand cmd = new SqlCommand("st_insertPurchaseINvoice", MainClass.con);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@date", date);
					cmd.Parameters.AddWithValue("@doneBy", doneBy);
					cmd.Parameters.AddWithValue("@suppID", suppID);
					MainClass.con.Open();
					cmd.ExecuteNonQuery();
					cmd.CommandText = "st_getLastPurchaseID";
					cmd.Parameters.Clear();
					purchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());
					MainClass.con.Close();
			}
			catch (Exception ex)
			{
				MainClass.con.Close();
				MainClass.ShowMSG(ex.Message, "Error...", "Error");
			}
			return purchaseInvoiceID;
		}

		int pidCount;
		public int insertPurchaseInvoiceDetails(Int64 purID, int proID,int quan, float totPrice)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@purchaseID",purID);
				cmd.Parameters.AddWithValue("@proID",proID);
				cmd.Parameters.AddWithValue("@quan",quan);
				cmd.Parameters.AddWithValue("@totPrice",totPrice);
				MainClass.con.Open();
				pidCount = cmd.ExecuteNonQuery();
				MainClass.con.Close();
			}
			catch
			{
				MainClass.con.Close();

			}
			return pidCount;
		}

		public void insertStock(int proID, int quan)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@proID", proID);
				cmd.Parameters.AddWithValue("@quan", quan);
				MainClass.con.Open();
				cmd.ExecuteNonQuery();
				MainClass.con.Close();
			}
			catch
			{
				MainClass.con.Close();

			}
		}

		public void insertDeletedItem(Int64 pid,int proid,int quan,int userid,DateTime date)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("st_insertDeletedItemPI", MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@pi", pid);
				cmd.Parameters.AddWithValue("@usrID", userid);
				cmd.Parameters.AddWithValue("@proID", proid);
				cmd.Parameters.AddWithValue("@quan", quan);
				cmd.Parameters.AddWithValue("@date", date);
				MainClass.con.Open();
				cmd.ExecuteNonQuery();
				MainClass.con.Close();
			}
			catch (Exception ex)
			{
				MainClass.con.Close();
				MainClass.ShowMSG(ex.Message, "Error...", "Error");
			}
		}
	}
}
