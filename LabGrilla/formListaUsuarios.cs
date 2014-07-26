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
            this.dvgUsuarios.AutoGenerateColumns = false;
            this.GenerarColumnas();
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
            this.dvgUsuarios.DataSource = this.oUsuarios.GetAll();
        }

        private void GenerarColumnas()
        {
            //CREANDO LA COLUMNA NRO DE DOCUMENTO

            DataGridViewTextBoxColumn colNroDoc = new DataGridViewTextBoxColumn();
            // creamos la nueva columna y definimos el tipo

            colNroDoc.Name = "nro_doc";
            //asignamos un nombre a la columna

            colNroDoc.HeaderText = "Numero de Documento";
            //indicamos el titulo a mostrar

            colNroDoc.DataPropertyName = "nro_doc";
            //indicamos con cual columna del DataTable que asignamos en el DataSource de la grilla debe vincularse

            colNroDoc.DisplayIndex = 0;
            // en que posicion debe mostrarse, todas las columnas a la derecha
            //de la posicion que indiquemos se moveran una posicion a la derecha.

            this.dvgUsuarios.Columns.Add(colNroDoc);
            // agregamos la columna al DataGridView para que la muestre

            //CREANDO LA COLUMNA TIPO DE DOCUMENTO

            DataGridViewComboBoxColumn colTipoDoc = new DataGridViewComboBoxColumn();

            colTipoDoc.Name = "tipo_doc";
            colTipoDoc.HeaderText = "Tipo de Documento";
            colTipoDoc.DataPropertyName = "tipo_doc";
            colTipoDoc.DisplayIndex = 0;

            // Agrego  items manualmente para evitar que de error. Esto luego se reemplaza por la linea de codigo inferior.
            //colTipoDoc.Items.Add(1);
            //colTipoDoc.Items.Add(2);
            //colTipoDoc.Items.Add(3);
            //colTipoDoc.Items.Add(4);
            //colTipoDoc.Items.Add(5);

            // asigno la lista de items que son validos
            colTipoDoc.DataSource=this.getTiposDocumento();

            colTipoDoc.ValueMember="cod_tipo_doc";
                //indico que el valor interno del combo es el valor de la fila elegida
                //y la columna cod_tipo_doc del DataSource que asigne a la columna colTipoDoc

            colTipoDoc.DisplayMember="desc_tipo_doc";
            // indico que el valor que se muestra al usuario es el que se corresponde con la columna
            //desc_tipo_doc del Data Source que asigne a colTipoDoc independientemente de la columna de
            //la cual obtiene su valor.

            this.dvgUsuarios.Columns.Add(colTipoDoc);

            //CREANDO LA COLUMNA TELEFONO
            DataGridViewTextBoxColumn colTelefono = new DataGridViewTextBoxColumn();
            colTelefono.Name = "telefono";
            colTelefono.HeaderText = "Telefono";
            colTelefono.DataPropertyName = "telefono";
            colTelefono.DisplayIndex = 7;

           

            //CREANDO LA COLUMNA CELULAR
            DataGridViewTextBoxColumn colCelular = new DataGridViewTextBoxColumn();
            colCelular.Name = "celular";
            colCelular.HeaderText = "Celular";
            colCelular.DataPropertyName = "celular";
            colCelular.DisplayIndex = 9;

            //CREANDO LA COLUMNA EMAIL
            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "email";
            colEmail.HeaderText = "Email";
            colEmail.DataPropertyName = "email";
            colEmail.DisplayIndex = 8;

            //CREANDO LA COLUMNA USUARIO
            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.DataPropertyName = "usuario";
            colUsuario.DisplayIndex = 10;
           
            //CREANDO LA COLUMNA CLAVE
            DataGridViewTextBoxColumn colClave = new DataGridViewTextBoxColumn();
            colClave.Name = "clave";
            colClave.HeaderText = "Clave";
            colClave.DataPropertyName = "clave";
            colClave.DisplayIndex = 11;


            colEmail.Width = 250;
            colNroDoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colClave.Visible = false;

            //como las columnas direccion, nombre, apellido y fecha de nacimiento las creamos desde el diseñador
            //de formularios no disponemos de una variable para hacer referencia a ellas. Entonces debemos referenciarlas
            //con this.dvgUsuarios.Columns["nombre_columna"] donde el nombre_columna es lo que indicamos en la propiedad
            //Name de las columnas.

            this.dvgUsuarios.Columns["direccion"].Width = 250;
            this.dvgUsuarios.Columns["apellido"].DefaultCellStyle.Font = new Font(this.dvgUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dvgUsuarios.Columns["nombre"].DefaultCellStyle.Font = new Font(this.dvgUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dvgUsuarios.Columns["fecha_nac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            this.dvgUsuarios.Columns.Add(colTelefono);
            this.dvgUsuarios.Columns.Add(colCelular);
            this.dvgUsuarios.Columns.Add(colEmail);
            this.dvgUsuarios.Columns.Add(colUsuario);
            this.dvgUsuarios.Columns.Add(colClave);
        }

        private DataTable getTiposDocumento()
        {
            //creo el datatable
            DataTable dtTiposDoc = new DataTable();


            //agrego columnas
            dtTiposDoc.Columns.Add("cod_tipo_doc", typeof(int));
            dtTiposDoc.Columns.Add("desc_tipo_doc", typeof(string));

            //agrego filas
            dtTiposDoc.Rows.Add(new object[] { 1, "DNI" });
            dtTiposDoc.Rows.Add(new object[] { 2, "Cedula" });
            dtTiposDoc.Rows.Add(new object[] { 3, "Pasaporte" });
            dtTiposDoc.Rows.Add(new object[] { 4, "Libreta Civica" });
            dtTiposDoc.Rows.Add(new object[] { 5, "Libreta de Enrolamiento" });

            return dtTiposDoc;
        }



    }
}
