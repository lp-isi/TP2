using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int _añoEspecialidad;
        public int AñoEspecialidad
        {
            get { return _añoEspecialidad;}
            set { _añoEspecialidad = value; }
        }

        private string _descripcion;
            public string Descripcion
            {
                get {return _descripcion;}
                set {_descripcion=value;}
            }
        private int _idPlan;
        public int IdPlan
        {
            get {return _idPlan;}
            set {_idPlan=value;}
        }
    }
}
