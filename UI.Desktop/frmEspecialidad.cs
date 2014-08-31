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
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
        }


        public bool Validaciones() 
        {
            //FALTAN AGREGAR MAS VALIDACIONES
            string mensaje = "";
            if (String.IsNullOrEmpty(txtDescripcion.Text))
            { 
                mensaje += "El campo de descripcion no puede estar vacio";
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.Validaciones())
            {
				Especialidad especialidad = new Especialidad(cmbEspecialidad.SelectedItem.ToString());
				EspecialidadLogic.Create(especialidad);

				//cargar los datos y poner en blanco la caja de texto
				frmEspecialidad_Load(sender, e);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.Validaciones())
            {
				Especialidad especialidad = new Especialidad(((Especialidad)cmbEspecialidad.SelectedItem).Id,txtDescripcion.Text);
                EspecialidadLogic.Update(especialidad);

				//cargar los datos y poner en blanco la caja de texto
				frmEspecialidad_Load(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.Validaciones())
            {
				Especialidad especialidad = new Especialidad(cmbEspecialidad.SelectedItem.ToString());
				EspecialidadLogic.Delete(especialidad);

				//cargar los datos y poner en blanco la caja de texto
				frmEspecialidad_Load(sender, e);
            } 

        }

        public void CargaCombos()
        { 
			List<Especialidad> listadoEspecialidades = new List<Especialidad>();
			listadoEspecialidades = EspecialidadLogic.GetAll();
			cmbEspecialidad.DataSource = listadoEspecialidades;
			cmbEspecialidad.DisplayMember = "Descripcion";
			txtDescripcion.Text = string.Empty;
		}

		private void frmEspecialidad_Load(object sender, EventArgs e)
		{
			this.CargaCombos();
		}

		private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtDescripcion.Text = cmbEspecialidad.SelectedItem.ToString();
		}


       

    }
}
