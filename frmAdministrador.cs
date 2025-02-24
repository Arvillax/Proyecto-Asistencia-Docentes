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
    public partial class frmGestion_Usuarios : Form
    {
        public frmGestion_Usuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btnMGestion_Click(object sender, EventArgs e)
        {

        }

        private void btnMdatos_Click(object sender, EventArgs e)
        {
            frmModificacion_Datos frmmodiDatos = new frmModificacion_Datos();
            frmmodiDatos.Show();
            this.Hide();
        }

        private void btnMCierre_Click(object sender, EventArgs e)
        {
            frmCierre frmcierre = new frmCierre();
            frmcierre.Show();
            this.Hide();
        }

        private void btnMMigra_Click(object sender, EventArgs e)
        {
            frmMigracion frmmigra = new frmMigracion();
            frmmigra.Show();
            this.Hide();
        }
    }
}
