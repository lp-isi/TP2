using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic
    {

        public static void Create(Materia mat)
        {
            MateriaAdapter.Create(mat);
        }

        public static void Update(Materia mat)
        {
            MateriaAdapter.Update(mat);
        }

        public static void Delete(Materia mat)
        {
            MateriaAdapter.Delete(mat);
        }

		public static List<Materia> GetAll()
		{
			return MateriaAdapter.GetAll();
		}

    }
}