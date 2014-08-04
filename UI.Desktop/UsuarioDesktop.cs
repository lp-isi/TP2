using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;


namespace UI.Desktop
{
    public partial class UsuarioDesktop : AplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
            
        }
        public UsuarioDesktop(ModoForm modo): this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo): this()
        { 
            this.Modo = modo;
            UsuarioLogic ul = new UsuarioLogic();
           this.UsuarioActual=ul.GetOne(ID);
           MapearDeDatos();
        }

        #region Metodos

        public virtual void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.Id.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtApellido.Text = this.UsuarioActual.Apellido.ToString();
            this.txtNombre.Text = this.UsuarioActual.Nombre.ToString();
            this.txtClave.Text = this.UsuarioActual.Clave.ToString();
            this.txtConfirmarClave.Text = this.UsuarioActual.ConfirmarClave.ToString();
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario.ToString();
            this.txtEmail.Text = this.UsuarioActual.Email.ToString();

            if ((this.Modo == ModoForm.Alta) || (this.Modo == ModoForm.Modificacion))
            { btnAceptar.Text = "Guardar";}
            else if (this.Modo == ModoForm.Baja)
            { btnAceptar.Text = "Eliminar"; }
            else if (this.Modo == ModoForm.Consulta)
            { btnAceptar.Text = "Aceptar"; }

        }

        public virtual void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            { }

        }

        public virtual void GuardarCambios()
        { }

        public virtual bool Validar()
        { return false; }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }


        #endregion

        public Business.Entities.Usuario UsuarioActual
        { get; set; }

    }
}
