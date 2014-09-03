namespace UI.Desktop
{
    partial class frmComisionAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdComision = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAnoEspecialidad = new System.Windows.Forms.TextBox();
            this.cmbIdPlan = new System.Windows.Forms.ComboBox();
            this.btnAceptarEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año especialidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id plan:";
            // 
            // txtIdComision
            // 
            this.txtIdComision.Location = new System.Drawing.Point(128, 65);
            this.txtIdComision.Name = "txtIdComision";
            this.txtIdComision.Size = new System.Drawing.Size(162, 20);
            this.txtIdComision.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(128, 92);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(162, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtAnoEspecialidad
            // 
            this.txtAnoEspecialidad.Location = new System.Drawing.Point(128, 120);
            this.txtAnoEspecialidad.Name = "txtAnoEspecialidad";
            this.txtAnoEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtAnoEspecialidad.TabIndex = 6;
            // 
            // cmbIdPlan
            // 
            this.cmbIdPlan.FormattingEnabled = true;
            this.cmbIdPlan.Location = new System.Drawing.Point(128, 149);
            this.cmbIdPlan.Name = "cmbIdPlan";
            this.cmbIdPlan.Size = new System.Drawing.Size(162, 21);
            this.cmbIdPlan.TabIndex = 7;
            // 
            // btnAceptarEditar
            // 
            this.btnAceptarEditar.Location = new System.Drawing.Point(58, 320);
            this.btnAceptarEditar.Name = "btnAceptarEditar";
            this.btnAceptarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarEditar.TabIndex = 8;
            this.btnAceptarEditar.Text = "Agregar";
            this.btnAceptarEditar.UseVisualStyleBackColor = true;
            this.btnAceptarEditar.Click += new System.EventHandler(this.btnAceptarEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(214, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmComisionAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 374);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarEditar);
            this.Controls.Add(this.cmbIdPlan);
            this.Controls.Add(this.txtAnoEspecialidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdComision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComisionAgregar";
            this.Text = "Agregar Comision";
            this.Load += new System.EventHandler(this.frmComisionAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdComision;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAnoEspecialidad;
        private System.Windows.Forms.ComboBox cmbIdPlan;
        private System.Windows.Forms.Button btnAceptarEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}