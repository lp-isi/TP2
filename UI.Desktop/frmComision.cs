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
    public partial class frmComision : Form
    {
        public frmComision()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmComisionAgregar frmAgregar = new frmComisionAgregar();
                
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //REVISAR SI FUNCIONA EL METODO, O NO FUNCIONA,PORQUE ESTA DEPUES DE LA CREACION DE LA VENTANA
            //LLama a la ventana agregar y le completa los parametros del seleccionado
            frmComisionAgregar frmEditar = new frmComisionAgregar();
            frmEditar.Text = "Editar comision";
            frmEditar.Editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Creo el objeto
            Comision com = new Comision();
            //FALTA ASIGNAR EL ID
            ComisionLogic.Delete(com);
        }
    }
}
