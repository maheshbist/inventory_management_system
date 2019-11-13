using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
	class deletion
	{
		public void delete(object id, string proc, string param)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(proc , MainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(param, id);				
				MainClass.con.Open();
				cmd.ExecuteNonQuery();
				MainClass.con.Close();
				MainClass.ShowMSG("Data Deleted successfully", "Success...", "success");
			}
			catch (Exception ex)
			{
				MainClass.con.Close();
				MainClass.ShowMSG(ex.Message, "Error...", "Error");
			}
		}
	}
}
