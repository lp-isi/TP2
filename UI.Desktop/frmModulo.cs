using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class frmModulo : Form
    {
        public frmModulo()
        {
            InitializeComponent();
        }

		private void dgvModulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Creo Modulo
            Modulo mod = new Modulo();
            mod.Descripcion = txtDescripcion.Text;
            mod.Id = Convert.ToInt32(txtId.Text);
            mod.Ejecuta = txtEjecuta.Text;
            //Guardo Modulo
            ModuloLogic.Save(mod);

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Falta decidir como Editar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Creo Modulo
            Modulo mod = new Modulo();
            mod.Descripcion = txtDescripcion.Text;
            mod.Id = Convert.ToInt32(txtId.Text);
            mod.Ejecuta = txtEjecuta.Text;
            //Mando Modulo
            ModuloLogic.Delete(mod);
            
        }
    }
}
