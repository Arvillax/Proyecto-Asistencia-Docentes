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
    public partial class frmDecano : Form
    {
        public frmDecano()
        {
            InitializeComponent();
            customdesign();
        }

        private void customdesign()
        {
            panel_sem.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panel_sem.Visible == true)
                panel_sem.Visible = false;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_most_sem_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_sem);
        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_most_sem_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panel_sem);
        }
    }
}
