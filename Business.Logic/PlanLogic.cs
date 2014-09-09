using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic
    {

        public static void Create(Plan plan)
        {
            PlanAdapter.Create(plan);
        }

        public static void Update(Plan plan)
        {
            PlanAdapter.Update(plan);
        }

        public static void Delete(Plan plan)
        {
            PlanAdapter.Delete(plan);
        }

		public static List<Plan> GetAll()
		{
			return PlanAdapter.GetAll();
		}

    }
}