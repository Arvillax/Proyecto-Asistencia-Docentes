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
        public frmNueva_Contraseña()
        {
            InitializeComponent();
            // fijar pantalla
            this.MinimumSize = new Size(1130, 761);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)// forzar que la aventana conserve el tamaño
        {
            if (this.Width < 1130)
                this.Width = 1130;

            if (this.Height < 761)
                this.Height = 761;
        }
        clsrecuperacion rec = new clsrecuperacion();
        private int idUsuario;
        public frmNueva_Contraseña(int usuario)
        {
            InitializeComponent();
            idUsuario = usuario;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
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
    }
}
