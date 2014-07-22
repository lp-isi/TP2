using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Logic;
using Business.Entities;

namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuarios users= new Usuarios();
            users.Menu();
            Console.ReadKey();



        }
    }
}
