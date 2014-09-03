using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmComisionAgregar : Form
    {
        public frmComisionAgregar()
        {
            InitializeComponent(); //IMPORTANTE: CUANDO SE CREA CAMBIAR TEXTO A EL btnAceptarEditar ,
                                   // EL TITULO DEL FORM, 
                                   // ASIGNAR LOS DATOS A CADA ELEMENTO
                                   // FIJAR EL IdComision COMO IMPOSIBLE DE ESCRIBIR.
        }
        public void Editar()
        {
            this.btnAceptarEditar.Text = "Editar";
            //FALTA ASIGNAR DATOS A CADA ELEMENTO
            //FALTA FIJAR EL IdComision COMO IMPOSIBLE DE ESCRIBIR
        }


        private void btnAceptarEditar_Click(object sender, EventArgs e)  
        {
            //Elegir opcion de editar o aceptar
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Vuelve a la ventana anterior (frmComision)
        }

        private void frmComisionAgregar_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
