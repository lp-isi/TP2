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
    public partial class frmEspecialidadAgregar : Form
    {
        public frmEspecialidadAgregar()
        {
            InitializeComponent();
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

		private void frmEspecialidadAgregar_Load(object sender, EventArgs e)
		{

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Especialidad especialidad = new Especialidad(txtDescripcion.Text);
			EspecialidadLogic.Create(especialidad);
		}

    }
}
