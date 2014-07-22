using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Persona: BusinessEntity
    {
        private string _apellido;
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }

        }
        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }

        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }

        }

        private DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private int _idPlan;
        public int IdPlan
        {
            get { return _idPlan; }
            set { _idPlan = value; }
        }

        private string _legajo;
        public string Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _telefono;
        public string Telefono
        {
            get { return _telefono;}
            set {_telefono=value;}
        }

        private TiposPersonas _tipoPersona;
        public TiposPersonas TipoPersona 
        {
            get { return _tipoPersona; }
            set { _tipoPersona = value; }
        }

    }
}
