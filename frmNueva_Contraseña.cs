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
    public partial class frmNueva_Contraseña : Form
    {
        clsrecuperacion rec = new clsrecuperacion();
        private int idUsuario;
        public frmNueva_Contraseña(int usuario)
        {
            InitializeComponent();
            idUsuario = usuario;
        }
        private void btnGuardarContra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtncon.Text) || string.IsNullOrEmpty(txtccon.Text))
            {
                MessageBox.Show("Ingrese y confirme su contraseña.");
                return;
            }

            if (txtncon.Text != txtccon.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (rec.CambiarContraseña(idUsuario, txtncon.Text))
            {
                //MessageBox.Show("Contraseña cambiada con éxito.");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al cambiar la contraseña.");
            }
        }

        private void btn_regrsar_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(800, 600);
                btnMaximizar.Text = "🗖";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Text = "🗗";
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmNueva_Contraseña_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 600);
        }
    }
}
