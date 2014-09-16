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
    public partial class frmComision : frmBase
    {
        public frmComision()
        {
            InitializeComponent();
        }

       private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmComisionAgregar frmAgregar = new frmComisionAgregar();
                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Creo el objeto
            Comision com = new Comision();
            //FALTA ASIGNAR EL ID
            ComisionLogic.Delete(com);
        }

		private void btnAgregar_Click_1(object sender, EventArgs e)
		{

		}

    
    }
}
