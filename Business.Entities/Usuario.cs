using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
		
		
		//A ver si hace el push
        //Probando que estos estan re sida mal

        #region Propiedades

        private string _nombreUsuario;
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        //public string _NombreUsuario { get; set; }

        private string _clave;
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private bool _habilitado;
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        //PROPIEDADES AGREGADAS U5LAB02
        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private string _telefono;
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _tipoDocumento;
        public string TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }

        private int _nroDocumento;
        public int NroDocumento
        {
            get { return _nroDocumento; }
            set { _nroDocumento = value; }
        }

        private string _celular;
        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        # endregion


        
    }
}