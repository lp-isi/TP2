﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic
    {

        public static void Create(Comision com)
        {
            ComisionAdapter.Create(com);
        }

        public static void Update(Comision com)
        {
            ComisionAdapter.Update(com);
        }

        public static void Delete(Comision com)
        {
            ComisionAdapter.Delete(com);
        }

		public static List<Comision> GetAll()
		{
			return ComisionAdapter.GetAll();
		}
    }
}