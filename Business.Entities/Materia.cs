using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Materia :BusinessEntity
    {
        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int _hsSemanales;
        public int HsSemanales
        {
            get { return _hsSemanales;}
            set { _hsSemanales = value; }
        }

        private int _hsTotales;
        public int HsTotales
        {
            get { return _hsTotales; }
            set { _hsTotales = value; }
        }

        private int _idPlan;
        public int IdPlan
        {
            get { return _idPlan;}
            set { _idPlan = value; }
        }
    }
}
