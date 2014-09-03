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
			List<Especialidad> listadoEspecialidades = new List<Especialidad>();
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
					System.Data.SqlClient.SqlCommand consulta = new System.Data.SqlClient.SqlCommand("select * from especialidades", myconn);
					System.Data.SqlClient.SqlDataReader dr = consulta.ExecuteReader();
					while (dr.Read())
					{
						Especialidad esp = new Especialidad((int)dr["id"], dr["descripcion"].ToString());
						listadoEspecialidades.Add(esp);
					}
					return listadoEspecialidades;

				}
				catch (Exception e)
				{
					return null;
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
