using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Data.Database
{
	class Connection
	{
		public static System.Data.SqlClient.SqlConnection Connect()
		{
			System.Data.SqlClient.SqlConnection myconn = new System.Data.SqlClient.SqlConnection();
			try
			{
				myconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionbd"].ConnectionString ;
			}
			catch (Exception e)
			{
				myconn = null;
				Console.Write("ERROR WACHO");
			}

			return myconn;
		}

		public static void Dispose(System.Data.SqlClient.SqlConnection myconn)
		{
			if (myconn.State == System.Data.ConnectionState.Open)
			{
				myconn.Close();
			}
			myconn.Dispose();
			myconn = null;
		}
	}
}
