namespace UI.Desktop
{
    partial class frmPlan
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
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
			this.dvgPlanes = new System.Windows.Forms.DataGridView();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.lblEspecialidad = new System.Windows.Forms.Label();
			this.lblPlanes = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dvgPlanes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 359);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(140, 40);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "Agregar plan";
			this.btnAgregar.UseVisualStyleBackColor = true;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(482, 359);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(140, 40);
			this.btnBorrar.TabIndex = 3;
			this.btnBorrar.Text = "Borrar plan";
			this.btnBorrar.UseVisualStyleBackColor = true;
			// 
			// cmbEspecialidad
			// 
			this.cmbEspecialidad.FormattingEnabled = true;
			this.cmbEspecialidad.Location = new System.Drawing.Point(211, 12);
			this.cmbEspecialidad.Name = "cmbEspecialidad";
			this.cmbEspecialidad.Size = new System.Drawing.Size(187, 21);
			this.cmbEspecialidad.TabIndex = 4;
			// 
			// dvgPlanes
			// 
			this.dvgPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgPlanes.Location = new System.Drawing.Point(211, 54);
			this.dvgPlanes.Name = "dvgPlanes";
			this.dvgPlanes.Size = new System.Drawing.Size(276, 200);
			this.dvgPlanes.TabIndex = 5;
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(177, 266);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
			this.lblDescripcion.TabIndex = 6;
			this.lblDescripcion.Text = "Descripcion:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(249, 263);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
			this.txtDescripcion.TabIndex = 7;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(230, 359);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(140, 40);
			this.btnModificar.TabIndex = 8;
			this.btnModificar.Text = "Modificar plan";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// lblEspecialidad
			// 
			this.lblEspecialidad.AutoSize = true;
			this.lblEspecialidad.Location = new System.Drawing.Point(113, 15);
			this.lblEspecialidad.Name = "lblEspecialidad";
			this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
			this.lblEspecialidad.TabIndex = 9;
			this.lblEspecialidad.Text = "Especialidad:";
			// 
			// lblPlanes
			// 
			this.lblPlanes.AutoSize = true;
			this.lblPlanes.Location = new System.Drawing.Point(141, 54);
			this.lblPlanes.Name = "lblPlanes";
			this.lblPlanes.Size = new System.Drawing.Size(42, 13);
			this.lblPlanes.TabIndex = 10;
			this.lblPlanes.Text = "Planes:";
			// 
			// frmPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 411);
			this.Controls.Add(this.lblPlanes);
			this.Controls.Add(this.lblEspecialidad);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.lblDescripcion);
			this.Controls.Add(this.dvgPlanes);
			this.Controls.Add(this.cmbEspecialidad);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnAgregar);
			this.Name = "frmPlan";
			this.Text = "ABM Plan";
			this.Load += new System.EventHandler(this.frmPlan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dvgPlanes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.DataGridView dvgPlanes;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Label lblEspecialidad;
		private System.Windows.Forms.Label lblPlanes;
    }
}