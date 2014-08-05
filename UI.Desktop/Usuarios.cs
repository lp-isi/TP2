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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dvgUsuarios.AutoGenerateColumns = false;
            this.GenerarColumnas();
        }
        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dvgUsuarios.DataSource = ul.GetAll();  

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GenerarColumnas()
        {
            //CREAMOS LAS COLUMNAS

            // CREANDO COLUMNA ID
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "id";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "ID";
            colId.DisplayIndex = 0;
            this.dvgUsuarios.Columns.Add(colId);

            //CREANDO COLUMNA APELLIDO
            DataGridViewTextBoxColumn colApellido = new DataGridViewTextBoxColumn();
            colApellido.Name = "apellido";
            colApellido.HeaderText = "Apellido";
            colApellido.DataPropertyName = "Apellido";

            this.dvgUsuarios.Columns.Add(colApellido);

            //CREANDO COLUMNA NOMBRE
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre";

            this.dvgUsuarios.Columns.Add(colNombre);

            //CREANDO LA COLUMNA EMAIL
            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "email";
            colEmail.HeaderText = "Email";
            colEmail.DataPropertyName = "Email";

            this.dvgUsuarios.Columns.Add(colEmail);

            //CREANDO LA COLUMNA USUARIO
            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.DataPropertyName = "NombreUsuario";

            this.dvgUsuarios.Columns.Add(colUsuario);

            // CREANDO LA COLUMNA HABILITADO
            DataGridViewCheckBoxColumn colHabilitado = new DataGridViewCheckBoxColumn();
            colHabilitado.Name = "habilitado";
            colHabilitado.HeaderText = "Habilitado";
            colHabilitado.DataPropertyName = "Habilitado";
            this.dvgUsuarios.Columns.Add(colHabilitado);

        }

		private void dvgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tcUsuarios_TopToolStripPanel_Click(object sender, EventArgs e)
		{

		}

    }
}
