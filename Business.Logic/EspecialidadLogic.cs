using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
	public class EspecialidadLogic
	{

		public static List<Business.Entities.Especialidad> GetAll()
		{
			return EspecialidadAdapter.GetAll();
		}
        public static void Create(Especialidad esp)
        {
            EspecialidadAdapter.Save(esp);
        }

        public static void Update(Especialidad esp)
        {
            EspecialidadAdapter.Update(esp);
        }


		public static void Delete(Especialidad esp)
		{
			EspecialidadAdapter.Delete(esp);
		}
	}
}
