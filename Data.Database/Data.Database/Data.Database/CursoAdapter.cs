﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {

        public static void Create(Curso curso)
        {
            // Falta la cadena de conexion y que guarde el objeto
        }

        public static void Update(Curso curso)
        {
            // Falta la cadena de conexion y que detecte el objeto y lo cambie
        }

        public static void Delete(Curso curso)
        {
            // Falta la cadena de conexion y que detecte el objeto y lo elimine
        }

        public static List<Curso> GetAll()
        {
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