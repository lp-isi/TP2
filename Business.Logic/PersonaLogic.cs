using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonaLogic
    {

        public static void Create(Persona per)
        {
            PersonaAdapter.Create(per);
        }

        public static void Update(Persona per)
        {
            PersonaAdapter.Update(per);
        }

        public static void Delete(Persona per)
        {
            PersonaAdapter.Delete(per);
        }

		public static List<Persona> GetAll()
		{
			return PersonaAdapter.GetAll();
		}

    }
}