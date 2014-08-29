using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ModuloLogic
    {

        public static List<Business.Entities.Modulo> GetAll()
        {
            return ModuloAdapter.GetAll();
        }

        public static void Delete(Modulo mod)
        {
            ModuloAdapter.Delete(mod);
        }
    }
}
