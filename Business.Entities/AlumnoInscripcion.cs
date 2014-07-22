using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
   public class AlumnoInscripcion :BusinessEntity
    {
        private string _condicion;
        public string Condicion
        {
            get { return _condicion; }
            set { _condicion = value; }
        }

        private int _idAlumno;
        public int IdAlumno
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }
        private int _idCurso;

        public int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        private int _nota;
        public int Nota
        {
            get { return _nota;}
            set {_idCurso = value;}
        }


    }
}
