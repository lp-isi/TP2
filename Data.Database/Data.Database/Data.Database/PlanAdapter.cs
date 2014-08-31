using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;

namespace Data.Database
{
	public class PlanAdapter : Adapter
	{

		public static void Create(Plan plan)
		{
			// Falta la cadena de conexion y que guarde el objeto
		}

		public static void Update(Plan plan)
		{
			// Falta la cadena de conexion y que detecte el objeto y lo cambie
		}

		public static void Delete(Plan plan)
		{
			// Falta la cadena de conexion y que detecte el objeto y lo elimine
		}

		public static List<Plan> GetAll()
		{
			System.Data.SqlClient.SqlConnection myconn = Connection.Connect();
			if (myconn == null)
			{
				//ERROR
			}
			else
			{
				try
				{
					myconn.Open();
				}
				catch (Exception e)
				{
				}
				finally
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
	}
}
