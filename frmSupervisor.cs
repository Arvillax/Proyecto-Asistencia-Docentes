using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmSupervisor : Form
    {
       

        public frmSupervisor()
        {
            InitializeComponent();
            customdesign();
        }

       

        private void customdesign()
        {
            panel_btn_edificios.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panel_btn_edificios.Visible == true)
                panel_btn_edificios.Visible = false;
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_edificios_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_btn_edificios);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }
    }
}
