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
        public static void Save(Especialidad esp)
        {
            // Falta la cadena de conexion y que guarde el objeto
        }

        public static void Update(Especialidad esp)
        {
            // Falta la cadena de conexion y que detecte el objeto y lo cambie
        }

        public static void Delete(Especialidad esp)
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
                return null;
			}
			else
			{
				try
				{
					myconn.Open();
					System.Data.SqlClient.SqlCommand consulta = new System.Data.SqlClient.SqlCommand("select id, descripcion from especialidades", myconn);
					System.Data.SqlClient.SqlDataReader dr = consulta.ExecuteReader();
					while (dr.Read())
					{
						Especialidad esp = new Especialidad((int)dr["id"], dr["descripcion"].ToString());
                        Especialidad esp2 = new Especialidad();
                        if (dr.IsDBNull(0))
                        {
                            esp2.Id = 0;
                        }
                        else
                        {
                            esp2.Id = Convert.ToInt32(dr[0]);
                        }

                        if (dr.IsDBNull(1))
                        {
                            esp2.Descripcion = string.Empty; // ""
                        }
                        else
                        {
                            esp2.Descripcion = dr[1].ToString();
                        }

                        esp2.Id = dr.IsDBNull(0) ? 0 : Convert.ToInt32(dr[0]);
                        esp2.Descripcion = dr.IsDBNull(1) ? string.Empty : dr[1].ToString();

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
