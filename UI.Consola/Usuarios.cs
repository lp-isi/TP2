using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        private UsuarioLogic usuarioLogic = new UsuarioLogic();

        public Usuarios()
        {
            UsuarioNegocio = new Business.Logic.UsuarioLogic();
        }

        private Business.Logic.UsuarioLogic _usuarioNegocio;
        Business.Logic.UsuarioLogic UsuarioNegocio
        {
            get {return _usuarioNegocio; }
            set { _usuarioNegocio = value; }
        }

        //METODO MENU

        //NO HAGO EL MAIN ESTATICO PORQUE SINO EN CADA OPCION DEL SWITCH TENDRIA QUE USAR UNA INSTANCIA DE LA CLASE USUARIO, EN CAMBIO,
        // SI LO DEJO DE INSTANCIA LLAMO A LOS METODOS ListadoGeneral, Consultar, etc de manera directa.
        // ES MEJOR QUE CREE LA INSTANCIA DE USUARIO EN PROGRAM Y LLAME AL MENU A TRAVES DE ELLA.

        public void Menu()
        {
           
            ConsoleKeyInfo opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1- Listado General");
                Console.WriteLine("2-Consulta");
                Console.WriteLine("3-Agregar");
                Console.WriteLine("4-Modificar");
                Console.WriteLine("5-Eliminar");
                Console.WriteLine("6-Salir");

                Console.WriteLine("Ingrese su opcion");
                opcion = Console.ReadKey();

                switch (opcion.Key)
                {

                    case ConsoleKey.D1: ListadoGeneral(); break;
                    case ConsoleKey.D2: Consultar(); break;
                    case ConsoleKey.D3: Agregar();break;
                    case ConsoleKey.D4: Modificar(); break;
                    case ConsoleKey.D5: Eliminar(); break;
                    case ConsoleKey.D6: break;
                   default: Console.WriteLine("  Opcion no valida, intente nuevamente"); break;

                }

                Console.ReadLine();

            } while (opcion.Key != ConsoleKey.D6);
                

            if (opcion.Key == ConsoleKey.D6)
            {
                Console.WriteLine("Hasta la proxima!");
            }
        }
           
        #region METODOS_VARIOS

            public void ListadoGeneral()
            {
                List<Usuario> ListaDevuelta;
                //Agrego esta variable para guardar la lista que me devuelve el metodo GetAll() y asi impido que llame al metodo
                // GetAll cada vez que el foreach necesita recorrer.

                Console.Clear();
                ListaDevuelta = usuarioLogic.GetAll();

                foreach( Usuario usr in ListaDevuelta )
                {
                        MostrarDatos(usr);

                 }
            }

            public void MostrarDatos(Usuario usr)
            {
                Console.WriteLine("Usuario: {0}", usr.Id);
                Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
                Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
                Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
                Console.WriteLine("\t\tClave: {0}", usr.Clave);
                Console.WriteLine("\t\tEmail: {0}", usr.Email);
                Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
                Console.WriteLine();
             }

            public void Consultar()
            {
                try
                {
                    Console.Clear();
                    Console.Write("Ingrese el ID de usuario a consultar ");
                    int ID = int.Parse(Console.ReadLine());
                    this.MostrarDatos(usuarioLogic.GetOne(ID));
                }

                catch (FormatException fe)
                {
                    Console.WriteLine();
                    Console.WriteLine("El ID ingresado debe ser un numero entero");

                }

                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                }

                finally 
                {
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }

            }

            public void Modificar()
            {
                int id;
                try
                {
                    Console.Clear();
                    Console.Write("Ingrese el ID del usuario a modificar: ");
                    id = int.Parse(Console.ReadLine());
                    Usuario user = usuarioLogic.GetOne(id);
                    Console.Write("Ingrese nombre: ");
                    user.Nombre = Console.ReadLine();
                    Console.Write("Ingrese apellido: ");
                    user.Apellido = Console.ReadLine();
                    Console.Write("Ingrese Nombre de usuario: ");
                    user.NombreUsuario = Console.ReadLine();
                    Console.Write("Ingrese Clave: ");
                    user.Clave = Console.ReadLine();
                    Console.Write("Ingrese Email: ");
                    user.Email = Console.ReadLine();
                    Console.Write("Ingrese Habilitacion de usuario (1-Si/otro num-No): ");
                    user.Habilitado = (Console.ReadLine() == "1");
                    user.State = BusinessEntity.States.Modified;
                    usuarioLogic.Save(user);
                }

                catch (FormatException fe)
                {
                    Console.WriteLine();
                    Console.WriteLine("El ID ingresado debe ser un numero entero");

                }

                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                }

                finally
                {
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            }
                public void Agregar ()
                {
                    Usuario user=new Usuario();
                    Console.Clear();

                    Console.Write("Ingrese nombre: ");
                    user.Nombre=Console.ReadLine();
                    Console.Write("Ingrese apellido: ");
                    user.Apellido = Console.ReadLine();
                    Console.Write("Ingrese Nombre de usuario: ");
                    user.NombreUsuario = Console.ReadLine();
                    Console.Write("Ingrese Clave: ");
                    user.Clave = Console.ReadLine();
                    Console.Write("Ingrese Email: ");
                    user.Email = Console.ReadLine();
                    Console.Write("Ingrese Habilitacion de usuario (1-Si/otro num-No): ");
                    user.Habilitado = (Console.ReadLine() == "1");
                    user.State=BusinessEntity.States.New;
                    usuarioLogic.Save(user);
                    Console.WriteLine();
                    Console.WriteLine("ID asignado:{0}",user.Id);

                }

                public void Eliminar()
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Ingrese el ID del usuario a eliminar: ");
                        int id = int.Parse(Console.ReadLine());
                        usuarioLogic.Delete(id);
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine();
                        Console.WriteLine("El ID ingresado debe ser un numero entero");

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine(e.Message);
                    }

                    finally
                    {
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                    }
                }


                #endregion
        }

       

    }

