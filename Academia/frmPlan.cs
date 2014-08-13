using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmPlan : Form
    {
        public frmPlan() //Solo usa Descripcion, el id del plan lo trabaja la base de datos 
        {
            InitializeComponent();
            
        }

		private void frmPlan_Load(object sender, EventArgs e)
		{

		}

		public void cargaCombos()
		{
			List<Business.Entities.Especialidad> listadoPlanes = new List<Business.Entities.Especialidad>;

			
			DataTable dtPlanes = new DataTable();
			dtEspecialidades.Columns.Add("Text");
			dtEspecialidades.Columns.Add("Value");
		}

    }
}
