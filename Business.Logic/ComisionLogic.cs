using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic
    {
        public static void Eliminar(Comision com)
        {
            ComisionAdapter.Delete(com);
        }

        public static List<Comision> GetAll()
        {
            return ComisionAdapter.GetAll();
        }

    }
}
