using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabGrilla
{
    public partial class formListaUsuarios : Form
    {
        public formListaUsuarios()
        {
            InitializeComponent();
            this.oUsuarios = new Business.Logic.Usuarios();
            this.dvgUsuarios.DataSource = this.oUsuarios.GetAll();

        }

        private Business.Logic.Usuarios _oUsuarios;
        public Business.Logic.Usuarios oUsuarios
        {   
            get { return _oUsuarios; }
            set { _oUsuarios = value; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.RecargarGrilla();
          
        }

        private void GuardarCambios()
        {
            this.oUsuarios.GuardarCambios((DataTable)this.dvgUsuarios.DataSource);
        }

        private void RecargarGrilla()
        {
            this.dvgUsuarios.DataSource= this.oUsuarios.GetAll();
        }

}
