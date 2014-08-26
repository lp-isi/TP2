using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Entities;


namespace UI.Desktop
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        #region Constructores

        private EstadoForm.tipoOperacion _operacion;
        public EstadoForm.tipoOperacion Operacion
        {
            get { return _operacion; }
            set { _operacion = value; }

        }
        #endregion

        #region Eventos

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            
            Operacion = EstadoForm.tipoOperacion.Alta;

    //        Creo DataTable con origen de datos para la lista
    //        DataTable dtTiposDocumento = new DataTable();
    //        dtTiposDocumento.Columns.Add("Text");
    //        dtTiposDocumento.Columns.Add("Value");
    //        dtTiposDocumento.Rows.Add(new object[] { "DNI", "1" });
    //      // Aquí se agregaria resto de la lista como la linea anterior

    //// Cargo lista de Tipos de Documento
    //      cbxTipoDocumento.DataSource = dtTiposDocumento;
    //      cbxTipoDocumento.DisplayMember = "Text"; 

          // Cargo lista de Tipos de Documento
            cbxTipoDocumento.Items.Add("DNI");
            cbxTipoDocumento.Items.Add("Cedula");
            cbxTipoDocumento.Items.Add("Pasaporte");
            cbxTipoDocumento.Items.Add("Libreta Civica");
            cbxTipoDocumento.Items.Add("Libreta Enrolamiento");

        }

        #endregion

        #region Metodos

      private void Guardar() //PREGUNTAR EN QUE PARTE DE LA EXCEPCION VA EL CODIGO (AL FINAL DEL BOTON GUARDAR). VALIDAR TODAS LAS CONVERSIONES 

        {
            // Genero una nueva instancia de la Entidad
            Business.Entities.Usuario oUsuario = new Usuario();
            Business.Logic.UsuarioLogic oUsuariosNegocio = new Business.Logic.UsuarioLogic();

            // Verifico los datos de entrada
            if (Validar())
            {
                
                try
                {
                    // Completo la entidad con informacion del formulario.
                    //oUsuario.Id = Convert.ToInt32(txtId.Text.Trim());
                    // La linea del Id no va, porque estoy en un alta.
                    oUsuario.Apellido = txtApellido.Text.Trim();
                    oUsuario.Nombre = txtNombre.Text.Trim();
                    oUsuario.TipoDocumento = cbxTipoDocumento.SelectedItem.ToString();
                    oUsuario.NroDocumento = Convert.ToInt32(txtNroDocumento.Text.Trim());
                    oUsuario.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text.Trim());
                    oUsuario.FechaNacimiento.ToShortDateString();
                    oUsuario.Direccion = txtDireccion.Text.Trim();
                    oUsuario.Telefono = txtTelefono.Text.Trim();
                    oUsuario.Celular = txtCelular.Text.Trim();
                    oUsuario.Email = txtEmail.Text.Trim();
                    // Agrego / Actualizo
                    if (Operacion == EstadoForm.tipoOperacion.Alta)
                    {
                        // Agrego registro nuevo
                        oUsuariosNegocio.Save(oUsuario);
                        MessageBox.Show("Registro agregado exitosamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Actualizo registro existente
                        oUsuario.Id = Convert.ToInt32(txtId.Text);
                        oUsuariosNegocio.Update(oUsuario);
                        MessageBox.Show("Registro actualizado exitosamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error de la aplicacion
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                finally
                {
                    // Libero objetos
                    oUsuario = null;
                    
                    
                }

            }
        }
        private bool Validar()
        {
            string mensaje = "", campoClave, campoUsuario,campoNombre,campoApellido, campoEmail;
     
            if (Operacion == EstadoForm.tipoOperacion.Alta || (Operacion == EstadoForm.tipoOperacion.Edicion && !String.IsNullOrEmpty(txtClave.Text.Trim())))
            {
                // Clave Valida
                if (txtClave.Text.Trim().Length < 6)
                    mensaje += "- La clave debe tener al menos 6 caracteres." + "\n";

                // Repetir Clave coincide con Clave
                if (txtClave.Text.Trim() != txtRepetirClave.Text.Trim())
                    mensaje += "- El campo Repetir Clave debe coincidir con el campo Clave." + "\n";
            }



            //if (String.IsNullOrEmpty(mskFechaNacimiento.Text))
            //{
            //    mensaje += "La fecha de nacimiento asignada es la actual." + "\n";
            //    mskFechaNacimiento.Text = Convert.ToString(DateTime.Now.ToShortDateString());
            //}


            //if ((Convert.ToDateTime(mskFechaNacimiento.Text) >= DateTime.Now) || (Convert.ToDateTime(mskFechaNacimiento.Text).Year <= 1900))
            //    mensaje += "- La fecha ingresada no es valida" + "\n";

            if (txtApellido.Text.Trim() == "")
                mensaje += "- El Apellido no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtFechaNacimiento.Text))
            {
                mensaje += "La fecha de nacimiento asignada es la actual." +"\n";
                txtFechaNacimiento.Text= Convert.ToString(DateTime.Now.ToShortDateString());
            }
            if ((Convert.ToDateTime(txtFechaNacimiento.Text)>=DateTime.Now) ||  (Convert.ToDateTime(txtFechaNacimiento.Text).Year<=1900))
                mensaje += "- La fecha ingresada no es valida" + "\n";

            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
                mensaje += "- El Nombre no puede estar en blanco." + "\n";
            // Nota: 2 formas previas de validar string vacio son equivalentes.

            if (String.IsNullOrEmpty(txtDireccion.Text.Trim()))
                mensaje+= "- La Direccion no puede estar en blanco." + "\n";
            if (String.IsNullOrEmpty(txtNroDocumento.Text.Trim()))
                mensaje += "- El numero de documento no puede estar en blanco" + "\n";
            if (String.IsNullOrEmpty(txtUsuario.Text.Trim()))
                mensaje += "- El Nombre de Usuario no puede estar en blanco" + "\n";
            if (String.IsNullOrEmpty(txtClave.Text.Trim()))
                mensaje += "- La clave no puede estar en blanco" + "\n";

            campoClave = Convert.ToString((txtClave.Text.Trim()));
            if (campoClave.Length < 6)
                mensaje += "- La clave debe tener un minimo de 6 caracteres"+"\n";

            campoUsuario = txtUsuario.Text;

            for (int k = 0; k < campoUsuario.Length; ++k)
                if (((Convert.ToChar(campoUsuario[k]) >= 65) && (Convert.ToChar(campoUsuario[k]) <= 90)) || ((Convert.ToChar(campoUsuario[k]) >= 97) && (Convert.ToChar(campoUsuario[k]) <= 122)))
                    { 
                    continue;
                    }
                else 
                    {
                    mensaje += "- El Nombre de Usuario no puede contener caracteres especiales como @#$%^&*()|{}[] ni espacios en blanco, solo letras" + "\n";
                    break;
                    }

            campoNombre = txtNombre.Text;
            for (int k = 0; k < campoNombre.Length; ++k)
                if (((Convert.ToChar(campoNombre[k]) >= 65) && (Convert.ToChar(campoNombre[k]) <= 90)) || ((Convert.ToChar(campoNombre[k]) >= 97) && (Convert.ToChar(campoNombre[k]) <= 122)))
                {
                    continue;
                }
                else
                {
                    mensaje += "- El Nombre no puede contener caracteres especiales como @#$%^&*()|{}[] ni espacios en blanco, ni numeros" + "\n";
                    break;
                }

            campoApellido = txtApellido.Text;
            for (int k = 0; k < campoApellido.Length; ++k)
                if (((Convert.ToChar(campoApellido[k]) >= 65) && (Convert.ToChar(campoApellido[k]) <= 90)) || ((Convert.ToChar(campoApellido[k]) >= 97) && (Convert.ToChar(campoApellido[k]) <= 122)))
                {
                    continue;
                }
                else
                {
                    mensaje += "- El Apellido no puede contener caracteres especiales como @#$%^&*()|{}[] ni espacios en blanco, ni numeros" + "\n";
                    break;
                }

            campoEmail = txtEmail.Text;
            int b = 0;
            if (campoEmail != "")
            {
                for (int k = 0; k < campoEmail.Length; ++k)
                    if (Convert.ToChar(campoEmail[k]) != 64)
                    {
                        continue;
                    }
                    else
                    {
                        b = 1;
                        break;
                    }
              if (b != 1)
              mensaje += "- El Email debe contener un @" + "\n";
            }
            


                if (cbxTipoDocumento.SelectedIndex == -1)
                    mensaje += "- Debe seleccionar un Tipo de Documento." + "\n";

        // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

    return true;
}
        private void Borrar()
            {
                string mensaje = "¿Desea confirmar la eliminacion del registro?";

                //Solicito confirmacion para eliminar el registro
                if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == (System.Windows.Forms.DialogResult.Yes))
                        {
                            // Antes de eliminar verifico que exista un registro seleccionado


                            //if (!String.IsNullOrEmpty(txtId.Text))
                            if (Operacion == EstadoForm.tipoOperacion.Edicion)
                            {
                                // Para eliminar necesito delegar el trabajo a la capa de negocios
                                Business.Logic.UsuarioLogic oUsuariosNegocio = new Business.Logic.UsuarioLogic();

                                // Al intentar eliminar capturo el error si ocurre.
                                try
                                {
                                    // Obtengo el Id a eliminar
                                    int Id = Convert.ToInt32(txtId);

                                    // Elimino el registro
                                    oUsuariosNegocio.Delete(Id);

                                    // Informo que la eliminación se realizo correctamente
                                    mensaje = "Eliminación del registro realizado con éxito!";
                                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    // Muestro cualquier error que ocurra
                                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    // Elimino objetos de memoria
                                    oUsuariosNegocio = null;
                                }
                            }
                            else
                            {
                                // Informo que no se ha seleccionado un Contacto
                                mensaje = "El registro no puede ser recuperado o no existe.";
                                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
            }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            Borrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Guardar();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Esta seguro que desea cerrar?";
            
            if ((MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)==(System.Windows.Forms.DialogResult.Yes)))
                this.Close();
            
        }

        #endregion

		private void gpxDatosPersonales_Enter(object sender, EventArgs e)
		{

		}

       


   } // llave de la clase


    } // llave del namespace

