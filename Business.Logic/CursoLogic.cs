using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
	public class CursoLogic
	{

		public static List<Curso> GetAll()
		{
			return CursoAdapter.GetAll();
		}

		public static void Create(Curso curso)
		{
			CursoAdapter.Create(curso);
		}

		public static void Update(Curso curso)
		{
			CursoAdapter.Update(curso);
		}

		public static void Delete(Curso curso)
		{
			CursoAdapter.Delete(curso);
		}

	}
}
