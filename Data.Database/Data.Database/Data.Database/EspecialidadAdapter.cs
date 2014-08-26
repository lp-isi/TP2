using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Database;
using Business.Entities;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public void Save(Especialidad esp)
        {
            // Falta la cadena de conexion y que guarde el objeto
        }

        public void Update(Especialidad esp)
        {
            // Falta la cadena de conexion y que detecte el objeto y lo cambie
        }

        public void Delete(Especialidad esp)
        {
            // Falta la cadena de conexion y que detecte el objeto y lo elimine
        }

		public static List<Especialidad> GetAll()
		{
			System.Data.SqlClient.SqlConnection myconn = Connection.Connect();
			if (myconn == null)
			{
				//Error
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
