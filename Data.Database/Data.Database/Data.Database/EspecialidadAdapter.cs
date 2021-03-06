﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Database;
using Business.Entities;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public static void Create(Especialidad esp)
        {
			System.Data.SqlClient.SqlConnection myconn = Connection.Connect();
			if (myconn==null)
			{
				//ERROR
			}
			else
			{
				try
				{
					System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("insert into especialidades (descripcion) values (@descripcion)");
					cmd.Connection = myconn;
					cmd.Parameters.AddWithValue("@descripcion", esp.Descripcion);
					myconn.Open();
					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
				}
				finally
				{
					Connection.Dispose(myconn);
				}
			}

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
					
					//En la consulta conviene poner id, descripción y no * entonces se sabe que id es el 0 del data reader y descripción el 1
					
					System.Data.SqlClient.SqlDataReader dr = consulta.ExecuteReader();
					while (dr.Read())
					{
						//Tres formas
						
						//1ra
							//Especialidad esp = new Especialidad((int)dr["id"], dr["descripcion"].ToString());
							//No es la óptima
						
						//2da
						
							//Especialidad esp2 = new Especialidad();
							//if (dr.IsDBNull(0)) //Igualmente según la base de datos el Id no puede ser nulo
							//{
							//    esp2.Id = 0;
							//}
							//else
							//{
							//    esp2.Id = Convert.ToInt32(dr[0]);
							//}

							//if (dr.IsDBNull(1))
							//{
							//    esp2.Descripcion = string.Empty; // ""
							//}
							//else
							//{
							//    esp2.Descripcion = dr[1].ToString();
							//}

						//3ra
						
						Especialidad esp = new Especialidad();
						//esp.Id = dr.IsDBNull(0) ? 0 : Convert.ToInt32(dr[0]); //No va porque ya es no nulo en la base de datos
                        esp.Descripcion = dr.IsDBNull(1) ? string.Empty : dr[1].ToString();

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
					//if (myconn.State == System.Data.ConnectionState.Open)
					//{
					//    myconn.Close();
					//}
					//myconn.Dispose();
					//myconn = null;

					//Creo un método en Connection para reutilizar código o está mal?
					
					Connection.Dispose(myconn);
				}
			}
		}
    }

}
