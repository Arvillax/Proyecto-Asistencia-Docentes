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
        clsConexion con = new clsConexion();


        public Form1()
        {
            InitializeComponent();
          
            // fijar pantalla
            this.MinimumSize = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)// forzar que la aventana conserve el tamaño
        {
            if (this.Width < 800)
                this.Width = 800;

            if (this.Height < 600)
                this.Height = 600;
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
            if (!int.TryParse(txtUsuario.Text.Trim(), out int idUsuario)) // Verificar que el usuario sea numérico
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

                    int id_usuario = int.Parse(txtUsuario.Text);
                    String Accion = "Inicio de sesion";

                    con.Registro_bitacora(id_usuario, Accion);

                    new frm_Admin_Principal(idUsuario).Show();
                    this.Hide();
                    break;

                case "SUPERVISOR":

                    int id_usuario1 = int.Parse(txtUsuario.Text);
                    String Accion1 = "Inicio de sesion";

                    con.Registro_bitacora(id_usuario1, Accion1);

                    new frmSupervisor(idUsuario).Show();
                    this.Hide();
                    break;

                case "DOCENTE":

                    int id_usuario2 = int.Parse(txtUsuario.Text);
                    String Accion2 = "Inicio de sesion";

                    con.Registro_bitacora(id_usuario2, Accion2);

                    new frmDocente(idUsuario).Show();
                    this.Hide();
                    break;

                case "DECANO":

                    int id_usuario3 = int.Parse(txtUsuario.Text);
                    String Accion3 = "Inicio de sesion";

                    con.Registro_bitacora(id_usuario3, Accion3);

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

        

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ingresar();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(800, 600);

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

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
