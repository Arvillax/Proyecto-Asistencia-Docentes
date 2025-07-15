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
            // fijar pantalla
            this.MinimumSize = new Size(1187, 767);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)// forzar que la aventana conserve el tamaño
        {
            if (this.Width < 1187)
                this.Width = 1187;

            if (this.Height < 761)
                this.Height = 761;
        }
        private bool contraseñaVisible = false;
        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            contraseñaVisible = !contraseñaVisible;

            if (contraseñaVisible)
            {
                txtContraseña.PasswordChar = '\0'; // Mostrar texto normal
                btnMostrarContraseña.Text = "🙈";
            }
            else
            {
                txtContraseña.PasswordChar = '*'; // Ocultar con asteriscos
                btnMostrarContraseña.Text = "👁️";
            }
        }

        private void Ingresar()
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que el usuario sea numérico
            if (!int.TryParse(txtUsuario.Text.Trim(), out int idUsuario))
            {
                MessageBox.Show("El usuario debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar a la lógica de conexión y autenticación
            string contraseña = txtContraseña.Text.Trim();
            clsConexion conexion = new clsConexion();
            string tipoUsuario = conexion.ValidarUsuario(idUsuario, contraseña);

            // Redireccionar según el tipo de usuario
            switch (tipoUsuario)
            {
                case "ADMINISTRADOR":
                    new frm_Admin_Principal().Show();
                    this.Hide();
                    break;

                case "SUPERVISOR":
                    new frmSupervisor().Show();
                    this.Hide();
                    break;

                case "DOCENTE":
                    new frmDocente(idUsuario).Show();
                    this.Hide();
                    break;

                case "DECANO":
                    new frmDecano(idUsuario).Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("Usuario o contraseña incorrectos o usuario inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }



        private void lnContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperacion_De_Contraseñas frmRecuC = new frmRecuperacion_De_Contraseñas();
            frmRecuC.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 600);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Ingresar();
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
                this.Size = new Size(800, 600);
                btnMaximizar.Text = "🗖"; 
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Text = "🗗"; 
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ingresar();
                e.SuppressKeyPress = true;
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ingresar();
                e.SuppressKeyPress = true;
            }
        }
    }
}
