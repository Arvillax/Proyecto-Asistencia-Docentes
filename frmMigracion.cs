using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmMigracion : Form
    {
        public frmMigracion()
        {
            InitializeComponent();
        }



        private void btnMGestion_Click(object sender, EventArgs e)
        {
            frmGestion_Usuarios frmGestion = new frmGestion_Usuarios();
            frmGestion.Show();
            this.Hide();
        }

        private void btnMdatos_Click(object sender, EventArgs e)
        {
            frmModificacion_Datos frmmodiDatos = new frmModificacion_Datos();
            frmmodiDatos.Show();
            this.Hide();
        }

        private void btnMCierre_Click(object sender, EventArgs e)
        {
            frmCierre cierre = new frmCierre();
            cierre.Show();
            this.Hide();
        }

        private void btnMMigra_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
