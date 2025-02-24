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
    public partial class frmCierre : Form
    {
        public frmCierre()
        {
            InitializeComponent();
            CustomizeDiseño();
        }

        private void CustomizeDiseño()
        {
            panel_p1.Visible = false;
            panel_p2.Visible = false;
            panel_p3.Visible = false;
        }

        private void EsconderMenu()
        {
            if (panel_p1.Visible == true)
                panel_p1.Visible = false;
            if (panel_p2.Visible == true)
                panel_p2.Visible = false;
            if (panel_p3.Visible == true)
                panel_p3.Visible = false;
        }

        private void MostrarMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();  
            frmLogin.Show();
            this.Close();
        }


        private void btnMdatos_Click(object sender, EventArgs e)
        {
                frmModificacion_Datos frmmodiDatos = new frmModificacion_Datos();
                frmmodiDatos.Show();
                this.Hide();
        }

        private void btnMGestion_Click(object sender, EventArgs e)
        {
            frmGestion_Usuarios frmGestion = new frmGestion_Usuarios();
            frmGestion.Show();
            this.Hide();
        }

        private void btnIPeriodo_Click_1(object sender, EventArgs e)
        {
            MostrarMenu(panel_p1);
        }

        private void btnIIPeriodo_Click_1(object sender, EventArgs e)
        {
            MostrarMenu(panel_p2);
        }

        private void btnIIIPeriodo_Click(object sender, EventArgs e)
        {
            MostrarMenu(panel_p3);
        }

        private void btnMMigra_Click_1(object sender, EventArgs e)
        {
            frmMigracion migra = new frmMigracion();
            migra.Show();
            this.Hide();
        }

        private void btnMCierre_Click(object sender, EventArgs e)
        {

        }
    }
}
