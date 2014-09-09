using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public void Save(Comision com)
        {
            // Falta la cadena de conexion y que guarde el objeto
        }

        public void Update(Comision com)
        {
            // Falta la cadena de conexion y que detecte el objeto y lo cambie
        }

        public static void Delete(Comision com)
        {
            // Falta la cadena de conexion y que detecte el objeto y lo elimine
        }

        public static List<Comision> GetAll()
        {
            System.Data.SqlClient.SqlConnection myconn = Connection.Connect();
            if (myconn == null)
            {
                //Error
                return null;
            }
            else
            {
                try
                {
                    myconn.Open();
                    return null;
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

                } return null;
            } 
        }
    }
}
