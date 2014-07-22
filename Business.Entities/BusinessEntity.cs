using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class BusinessEntity
    {

        public BusinessEntity()
        {
            this.State = States.New;
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private States _state;
        public States State
        {
            get { return _state; }
            set { _state = value; }
        }

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }

        public enum TiposPersonas
        {
            Docente,
            Alumno
        }

        public enum TiposCargos
        {
            Titular,
            Asociado,
            Adjunto,
            Jtp,
            Auxiliar
        }
       

    }
}

