namespace UI.Desktop
{
    partial class frmEspecialidad
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
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(403, 365);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(120, 28);
			this.btnEliminar.TabIndex = 0;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(217, 365);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(120, 28);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// cmbEspecialidad
			// 
			this.cmbEspecialidad.FormattingEnabled = true;
			this.cmbEspecialidad.Location = new System.Drawing.Point(217, 55);
			this.cmbEspecialidad.MaxDropDownItems = 10;
			this.cmbEspecialidad.Name = "cmbEspecialidad";
			this.cmbEspecialidad.Size = new System.Drawing.Size(184, 21);
			this.cmbEspecialidad.TabIndex = 2;
			this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(103, 110);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(93, 13);
			this.lblDescripcion.TabIndex = 3;
			this.lblDescripcion.Text = "ABM Especialidad";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(217, 107);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(184, 20);
			this.txtDescripcion.TabIndex = 4;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 365);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(120, 28);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Especialidades existentes";
			// 
			// frmEspecialidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 406);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.lblDescripcion);
			this.Controls.Add(this.cmbEspecialidad);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Name = "frmEspecialidad";
			this.Text = "Carga de Especialidades";
			this.Load += new System.EventHandler(this.frmEspecialidad_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label1;
    }
}