using System;
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
            this.CargaCombos();
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
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.Validaciones())
            {
                Data.Database.EspecialidadAdapter esp = new Data.Database.EspecialidadAdapter();
                Business.Entities.Especialidad especialidad = new Business.Entities.Especialidad(txtDescripcion.Text);
                esp.Delete(especialidad);
            }

        }

        public void CargaCombos()
        { 
			List<Business.Entities.Especialidad> listadoEspecialidades = new List<Business.Entities.Especialidad>();
           
			// Creo DataTable con origen de datos para la lista
			DataTable dtEspecialidades = new DataTable();
			dtEspecialidades.Columns.Add("Text");
			dtEspecialidades.Columns.Add("Value");
			dtEspecialidades.Rows.Add(new object[] { "NombreEspecialidad", "1" });
			// Aquí se agregaria resto de la lista como la linea anterior

			//// Cargo lista de Tipos de Documento
			cbxEspecialidad.DataSource = dtEspecialidades;
			cbxEspecialidad.DisplayMember = "Text"; 

            // listadoEspecialidades = EspecialidadAdapter.ObtenerListado();
            //foreach ( ) ACA HACER EL FOREACH QUE ASIGNE ROWS AL DATATABLE DEL LISTADO
        }

		private void frmEspecialidad_Load(object sender, EventArgs e)
		{

		}


       

    }
}
