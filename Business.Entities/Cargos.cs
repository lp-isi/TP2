using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    class Cargos: BusinessEntity
    {
        private TiposCargos _cargo;
        public TiposCargos Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        private int _idCurso;
        public int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        private int _idDocente;
        public int IdDocente
        {
            get { return _idDocente; }
            set { _idDocente = value; }
        }

       
    }
}
