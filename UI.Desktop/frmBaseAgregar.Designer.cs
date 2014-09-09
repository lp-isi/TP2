namespace UI.Desktop
{
    partial class frmBaseAgregar
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
            this.tlBaseNuevoModificacion = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlBaseNuevoModificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlBaseNuevoModificacion
            // 
            this.tlBaseNuevoModificacion.ColumnCount = 2;
            this.tlBaseNuevoModificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBaseNuevoModificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlBaseNuevoModificacion.Controls.Add(this.btnAceptar, 0, 1);
            this.tlBaseNuevoModificacion.Controls.Add(this.btnCancelar, 1, 1);
            this.tlBaseNuevoModificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBaseNuevoModificacion.Location = new System.Drawing.Point(0, 0);
            this.tlBaseNuevoModificacion.Name = "tlBaseNuevoModificacion";
            this.tlBaseNuevoModificacion.RowCount = 2;
            this.tlBaseNuevoModificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBaseNuevoModificacion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlBaseNuevoModificacion.Size = new System.Drawing.Size(331, 304);
            this.tlBaseNuevoModificacion.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 275);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 26);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 26);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmBaseAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 304);
            this.Controls.Add(this.tlBaseNuevoModificacion);
            this.Name = "frmBaseAgregar";
            this.Text = "frmBaseNuevoModificacion";
            this.tlBaseNuevoModificacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlBaseNuevoModificacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

    }
}