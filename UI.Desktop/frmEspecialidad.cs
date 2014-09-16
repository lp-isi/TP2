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
    public partial class frmEspecialidad : frmBase
    {
        public frmEspecialidad()
        {
            InitializeComponent();
			this.dgvBase.AutoGenerateColumns = false;
			GenerarColumnas();
			this.cargaGrilla();
        }

		public void cargaGrilla()
		{
 			List<Especialidad> listadoEspecialidades = new List<Especialidad>();
			listadoEspecialidades = EspecialidadLogic.GetAll();
			this.dgvBase.DataSource = listadoEspecialidades;
		}

		private void GenerarColumnas()
		{
			DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
			colId.Name = "id";
			colId.HeaderText = "ID";
			colId.DataPropertyName = "Id";
			this.dgvBase.Columns.Add(colId);

			DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
			colDescripcion.Name = "descripcion";
			colDescripcion.HeaderText = "Descripción";
			colDescripcion.DataPropertyName="Descripcion";
			this.dgvBase.Columns.Add(colDescripcion);

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			
		}

    }
}
