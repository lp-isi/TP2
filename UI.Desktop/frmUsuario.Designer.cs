namespace UI.Desktop
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblId = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.gpxDatosPersonales = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
			this.lblCelular = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblNacimiento = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNroDocumento = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblDocumento = new System.Windows.Forms.Label();
			this.gpxDatosUsuario = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRepetirClave = new System.Windows.Forms.TextBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblRepetirClave = new System.Windows.Forms.Label();
			this.lblClave = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblCampoObligatorio = new System.Windows.Forms.Label();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.gpxDatosPersonales.SuspendLayout();
			this.gpxDatosUsuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(108, 19);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(16, 13);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "Id";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(136, 16);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(87, 20);
			this.txtId.TabIndex = 1;
			// 
			// gpxDatosPersonales
			// 
			this.gpxDatosPersonales.Controls.Add(this.label1);
			this.gpxDatosPersonales.Controls.Add(this.label5);
			this.gpxDatosPersonales.Controls.Add(this.label4);
			this.gpxDatosPersonales.Controls.Add(this.label3);
			this.gpxDatosPersonales.Controls.Add(this.cbxTipoDocumento);
			this.gpxDatosPersonales.Controls.Add(this.txtCelular);
			this.gpxDatosPersonales.Controls.Add(this.txtTelefono);
			this.gpxDatosPersonales.Controls.Add(this.txtNombre);
			this.gpxDatosPersonales.Controls.Add(this.txtFechaNacimiento);
			this.gpxDatosPersonales.Controls.Add(this.lblCelular);
			this.gpxDatosPersonales.Controls.Add(this.lblTelefono);
			this.gpxDatosPersonales.Controls.Add(this.lblNombre);
			this.gpxDatosPersonales.Controls.Add(this.lblNacimiento);
			this.gpxDatosPersonales.Controls.Add(this.txtEmail);
			this.gpxDatosPersonales.Controls.Add(this.txtDireccion);
			this.gpxDatosPersonales.Controls.Add(this.txtApellido);
			this.gpxDatosPersonales.Controls.Add(this.txtNroDocumento);
			this.gpxDatosPersonales.Controls.Add(this.lblEmail);
			this.gpxDatosPersonales.Controls.Add(this.lblDireccion);
			this.gpxDatosPersonales.Controls.Add(this.lblApellido);
			this.gpxDatosPersonales.Controls.Add(this.lblDocumento);
			this.gpxDatosPersonales.Location = new System.Drawing.Point(15, 48);
			this.gpxDatosPersonales.Name = "gpxDatosPersonales";
			this.gpxDatosPersonales.Size = new System.Drawing.Size(588, 152);
			this.gpxDatosPersonales.TabIndex = 2;
			this.gpxDatosPersonales.TabStop = false;
			this.gpxDatosPersonales.Text = "Datos Personales";
			this.gpxDatosPersonales.Enter += new System.EventHandler(this.gpxDatosPersonales_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(573, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "*";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(321, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(11, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(321, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(11, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "*";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(321, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(11, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "*";
			// 
			// cbxTipoDocumento
			// 
			this.cbxTipoDocumento.FormattingEnabled = true;
			this.cbxTipoDocumento.Location = new System.Drawing.Point(121, 21);
			this.cbxTipoDocumento.Name = "cbxTipoDocumento";
			this.cbxTipoDocumento.Size = new System.Drawing.Size(100, 21);
			this.cbxTipoDocumento.TabIndex = 16;
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(417, 108);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(100, 20);
			this.txtCelular.TabIndex = 15;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(417, 79);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(100, 20);
			this.txtTelefono.TabIndex = 14;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(417, 51);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(150, 20);
			this.txtNombre.TabIndex = 13;
			// 
			// txtFechaNacimiento
			// 
			this.txtFechaNacimiento.Location = new System.Drawing.Point(417, 21);
			this.txtFechaNacimiento.Name = "txtFechaNacimiento";
			this.txtFechaNacimiento.Size = new System.Drawing.Size(76, 20);
			this.txtFechaNacimiento.TabIndex = 12;
			// 
			// lblCelular
			// 
			this.lblCelular.AutoSize = true;
			this.lblCelular.Location = new System.Drawing.Point(372, 111);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(39, 13);
			this.lblCelular.TabIndex = 11;
			this.lblCelular.Text = "Celular";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(362, 82);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(49, 13);
			this.lblTelefono.TabIndex = 10;
			this.lblTelefono.Text = "Telefono";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(367, 51);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 9;
			this.lblNombre.Text = "Nombre";
			// 
			// lblNacimiento
			// 
			this.lblNacimiento.AutoSize = true;
			this.lblNacimiento.Location = new System.Drawing.Point(351, 24);
			this.lblNacimiento.Name = "lblNacimiento";
			this.lblNacimiento.Size = new System.Drawing.Size(60, 13);
			this.lblNacimiento.TabIndex = 8;
			this.lblNacimiento.Text = "Nacimiento";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(121, 104);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(198, 20);
			this.txtEmail.TabIndex = 7;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(121, 78);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(198, 20);
			this.txtDireccion.TabIndex = 6;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(121, 48);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(198, 20);
			this.txtApellido.TabIndex = 5;
			// 
			// txtNroDocumento
			// 
			this.txtNroDocumento.Location = new System.Drawing.Point(227, 21);
			this.txtNroDocumento.Name = "txtNroDocumento";
			this.txtNroDocumento.Size = new System.Drawing.Size(92, 20);
			this.txtNroDocumento.TabIndex = 4;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(77, 107);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(32, 13);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "Email";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(59, 81);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(52, 13);
			this.lblDireccion.TabIndex = 2;
			this.lblDireccion.Text = "Direccion";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(67, 48);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(44, 13);
			this.lblApellido.TabIndex = 1;
			this.lblApellido.Text = "Apellido";
			// 
			// lblDocumento
			// 
			this.lblDocumento.AutoSize = true;
			this.lblDocumento.Location = new System.Drawing.Point(53, 24);
			this.lblDocumento.Name = "lblDocumento";
			this.lblDocumento.Size = new System.Drawing.Size(62, 13);
			this.lblDocumento.TabIndex = 0;
			this.lblDocumento.Text = "Documento";
			// 
			// gpxDatosUsuario
			// 
			this.gpxDatosUsuario.Controls.Add(this.label7);
			this.gpxDatosUsuario.Controls.Add(this.label6);
			this.gpxDatosUsuario.Controls.Add(this.label2);
			this.gpxDatosUsuario.Controls.Add(this.txtRepetirClave);
			this.gpxDatosUsuario.Controls.Add(this.txtClave);
			this.gpxDatosUsuario.Controls.Add(this.txtUsuario);
			this.gpxDatosUsuario.Controls.Add(this.lblRepetirClave);
			this.gpxDatosUsuario.Controls.Add(this.lblClave);
			this.gpxDatosUsuario.Controls.Add(this.lblUsuario);
			this.gpxDatosUsuario.Location = new System.Drawing.Point(15, 206);
			this.gpxDatosUsuario.Name = "gpxDatosUsuario";
			this.gpxDatosUsuario.Size = new System.Drawing.Size(588, 99);
			this.gpxDatosUsuario.TabIndex = 3;
			this.gpxDatosUsuario.TabStop = false;
			this.gpxDatosUsuario.Text = "Datos de Usuario";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(224, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(11, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(224, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(11, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(571, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "*";
			// 
			// txtRepetirClave
			// 
			this.txtRepetirClave.Location = new System.Drawing.Point(417, 60);
			this.txtRepetirClave.Name = "txtRepetirClave";
			this.txtRepetirClave.PasswordChar = '*';
			this.txtRepetirClave.Size = new System.Drawing.Size(150, 20);
			this.txtRepetirClave.TabIndex = 10;
			this.txtRepetirClave.UseSystemPasswordChar = true;
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(133, 61);
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(87, 20);
			this.txtClave.TabIndex = 9;
			this.txtClave.UseSystemPasswordChar = true;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(133, 28);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(87, 20);
			this.txtUsuario.TabIndex = 8;
			// 
			// lblRepetirClave
			// 
			this.lblRepetirClave.AutoSize = true;
			this.lblRepetirClave.Location = new System.Drawing.Point(340, 63);
			this.lblRepetirClave.Name = "lblRepetirClave";
			this.lblRepetirClave.Size = new System.Drawing.Size(71, 13);
			this.lblRepetirClave.TabIndex = 2;
			this.lblRepetirClave.Text = "Repetir Clave";
			// 
			// lblClave
			// 
			this.lblClave.AutoSize = true;
			this.lblClave.Location = new System.Drawing.Point(77, 64);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(34, 13);
			this.lblClave.TabIndex = 1;
			this.lblClave.Text = "Clave";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(68, 31);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(43, 13);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "Usuario";
			// 
			// lblCampoObligatorio
			// 
			this.lblCampoObligatorio.AutoSize = true;
			this.lblCampoObligatorio.Location = new System.Drawing.Point(12, 323);
			this.lblCampoObligatorio.Name = "lblCampoObligatorio";
			this.lblCampoObligatorio.Size = new System.Drawing.Size(100, 13);
			this.lblCampoObligatorio.TabIndex = 4;
			this.lblCampoObligatorio.Text = "* Campo Obligatorio";
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(380, 318);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(70, 25);
			this.btnBorrar.TabIndex = 5;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(460, 318);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(70, 25);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(540, 318);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(70, 25);
			this.btnCerrar.TabIndex = 7;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(425, 22);
			this.maskedTextBox1.Mask = "00/00/0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(104, 20);
			this.maskedTextBox1.TabIndex = 8;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// frmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 362);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.lblCampoObligatorio);
			this.Controls.Add(this.gpxDatosUsuario);
			this.Controls.Add(this.gpxDatosPersonales);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblId);
			this.Name = "frmUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ABM Usuario";
			this.Load += new System.EventHandler(this.frmUsuario_Load);
			this.gpxDatosPersonales.ResumeLayout(false);
			this.gpxDatosPersonales.PerformLayout();
			this.gpxDatosUsuario.ResumeLayout(false);
			this.gpxDatosUsuario.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gpxDatosPersonales;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.GroupBox gpxDatosUsuario;
        private System.Windows.Forms.TextBox txtRepetirClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblRepetirClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCampoObligatorio;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}