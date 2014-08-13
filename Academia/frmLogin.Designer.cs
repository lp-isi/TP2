namespace Academia
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblPass = new System.Windows.Forms.Label();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.lnkOlvidaPass = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "¡Bienvenido al Sistema! \r\nPor favor digite su informacion de ingreso";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(15, 78);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(101, 13);
			this.lblUsuario.TabIndex = 1;
			this.lblUsuario.Text = "Nombre de Usuario:";
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.Location = new System.Drawing.Point(15, 122);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(64, 13);
			this.lblPass.TabIndex = 2;
			this.lblPass.Text = "Contraseña:";
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(225, 148);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(75, 23);
			this.btnIngresar.TabIndex = 3;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(122, 78);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 4;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(122, 122);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(100, 20);
			this.txtPass.TabIndex = 5;
			// 
			// lnkOlvidaPass
			// 
			this.lnkOlvidaPass.AutoSize = true;
			this.lnkOlvidaPass.Location = new System.Drawing.Point(10, 204);
			this.lnkOlvidaPass.Name = "lnkOlvidaPass";
			this.lnkOlvidaPass.Size = new System.Drawing.Size(106, 13);
			this.lnkOlvidaPass.TabIndex = 6;
			this.lnkOlvidaPass.TabStop = true;
			this.lnkOlvidaPass.Text = "Olvide mi contraseña";
			this.lnkOlvidaPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOlvidaPass_LinkClicked);
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnIngresar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 226);
			this.Controls.Add(this.lnkOlvidaPass);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel lnkOlvidaPass;
    }
}

