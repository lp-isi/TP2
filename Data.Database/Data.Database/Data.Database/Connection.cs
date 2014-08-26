using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Database
{
	class Connection
	{
		public static System.Data.SqlClient.SqlConnection Connect()
		{
			System.Data.SqlClient.SqlConnection myconn = new System.Data.SqlClient.SqlConnection();
			try
			{
				myconn.ConnectionString = "Data Source=localhost;Initial Catalog=ACADEMIA;User=adminAcademia;Password=adminAcademia";
			}
			catch (Exception e)
			{
				myconn = null;
				//Cartel error
			}

			return myconn;
		}
	}
}
