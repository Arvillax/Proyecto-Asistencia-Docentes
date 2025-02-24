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
    public partial class frmRecuperacion_De_Contraseñas : Form
    {
        clsrecuperacion rec = new clsrecuperacion();
        public frmRecuperacion_De_Contraseñas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }

        private void btnIngresarCod_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(txtUsuario.Text);
            frmCodigo_Acceso frm = new frmCodigo_Acceso(idUsuario);
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnEnviarSoli_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUsuario.Text, out int idUsuario))
            {
                MessageBox.Show("Ingrese un ID de usuario válido.");
                return;
            }

            if (!rec.ValidarUsuario(idUsuario))
            {
                MessageBox.Show("El usuario no existe.");
                return;
            }

            string codigo = rec.GenerarCodigo(idUsuario);

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Hubo un error al generar el código de recuperación.");
                return;
            }

            try
            {
                await rec.EnviarCorreoAsync(codigo);
                lbmensaje.Text = "Código de recuperación enviado a tu correo.";
            }
            catch (Exception ex)
            {
                lbmensaje.Text = "Error al enviar el correo. Inténtalo de nuevo más tarde.";
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}
