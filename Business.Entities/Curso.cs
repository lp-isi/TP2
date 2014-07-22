using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Curso :BusinessEntity
    {
        private int _añoCalendario;
        public int AñoCalendario
        {
            get { return _añoCalendario;}
            set { _añoCalendario = value; }
        }

        private int _cupo;
            public int Cupo
            {
                get {return _cupo;}
                set {_cupo=value;}
            }

        private string _descripcion;
            public string Descripcion
            {
                get {return _descripcion;}
                set {_descripcion=value;}
            }

        private int _idComision;
        public int IdComision
        {
            get {return _idComision;}
            set {_idComision=value;}
        }

        private int _idMateria;
        public int IdMateria
        {
            get {return _idMateria;}
            set {_idMateria=value;}
        }

    }
}
