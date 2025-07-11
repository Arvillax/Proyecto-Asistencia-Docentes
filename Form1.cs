using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DesarrolloSoftware
{
    

    public partial class Form1 : Form
    {
        Validaciones vali = new Validaciones();

        public Form1()
        {
            InitializeComponent();
            btnMaximizar.Text = "🗖";
        }


        private void lnContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperacion_De_Contraseñas frmRecuC = new frmRecuperacion_De_Contraseñas();
            frmRecuC.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtUsuario.Text.Trim(), out int idUsuario))
            {
                MessageBox.Show("El usuario debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contraseña = txtContraseña.Text.Trim();
            clsConexion conexion = new clsConexion();
            string tipoUsuario = conexion.ValidarUsuario(idUsuario, contraseña);

            switch (tipoUsuario)
            {
                case "ADMINISTRADOR":
                    frm_Admin_Principal adminForm = new frm_Admin_Principal();
                    adminForm.Show();
                    this.Hide();
                    break;

                case "SUPERVISOR":

                    frmSupervisor supervisorForm = new frmSupervisor();
                    supervisorForm.Show();
                    this.Hide();
                    break;

                case "DOCENTE":
                    int numero = Convert.ToInt32(txtUsuario.Text);
                    frmDocente docenteForm = new frmDocente(numero);

                    docenteForm.Show();
                    this.Hide();
                    break;

                case "DECANO":
                    int usuario_decano = Convert.ToInt32(txtUsuario.Text);

                    frmDecano decanoForm = new frmDecano(usuario_decano);
                    decanoForm.Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("Usuario o contraseña incorrectos o usuario inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.solonumeros(e);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizar.Text = "🗖"; 
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Text = "🗗"; 
            }
        }
    }
}
