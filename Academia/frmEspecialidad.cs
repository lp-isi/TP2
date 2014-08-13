﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;



namespace Academia
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
                Data.Database.EspecialidadAdapter esp = new Data.Database.EspecialidadAdapter();
                Business.Entities.Especialidad especialidad = new Business.Entities.Especialidad(txtDescripcion.Text);
                esp.Save(especialidad);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.Validaciones())
            {
                Data.Database.EspecialidadAdapter esp = new Data.Database.EspecialidadAdapter();
                Business.Entities.Especialidad especialidad = new Business.Entities.Especialidad(txtDescripcion.Text);
                esp.Update(especialidad);
                
				//cargar los datos y poner en blanco la caja de texto
				frmEspecialidad_Load(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.Validaciones())
            {
                Data.Database.EspecialidadAdapter esp = new Data.Database.EspecialidadAdapter();
                Business.Entities.Especialidad especialidad = new Business.Entities.Especialidad(txtDescripcion.Text);
                esp.Delete(especialidad);

				//cargar los datos y poner en blanco la caja de texto
				frmEspecialidad_Load(sender, e);
            }

        }

        public void CargaCombos()
        { 
			List<Business.Entities.Especialidad> listadoEspecialidades = new List<Business.Entities.Especialidad>();
           
			//listadoEspecialidades = EspecialidadAdapter.ObtenerListado();

			cmbEspecialidad.DataSource = listadoEspecialidades;
			cmbEspecialidad.DisplayMember = "Descripcion";
			txtDescripcion.Text = string.Empty;
		}

		private void frmEspecialidad_Load(object sender, EventArgs e)
		{
			this.CargaCombos();
		}


       

    }
}
