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

       protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmComisionAgregar frmAgregar = new frmComisionAgregar();
                
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            //Creo el objeto
            Comision com = new Comision();
            //FALTA ASIGNAR EL ID
            ComisionLogic.Delete(com);
        }

    
    }
}
