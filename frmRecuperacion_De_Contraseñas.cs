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
        //INICIADOR DE FORMULARIO 
        clsrecuperacion rec = new clsrecuperacion();
        public frmRecuperacion_De_Contraseñas()
        {
            InitializeComponent();
            btnVerificarCod.Enabled = false;
        }

        
        private int idUsuario;
        // boton de regresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }
        // boton de ingresar codigo
        /*
        private void btnIngresarCod_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(txtUsuario.Text);
            frmCodigo_Acceso frm = new frmCodigo_Acceso(idUsuario);
            frm.Show();
            this.Hide();
        }*/
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // enviar solicitud 
        private async void btnEnviarSoli_Click(object sender, EventArgs e)
        {
           //conversion de usuario a entero
            if (!int.TryParse(txtUsuario.Text, out int idUsuario))
            {
                MessageBox.Show("Ingrese un ID de usuario válido.");
                return;
            }
            // si el usuario no existe mensaje de error
            if (!rec.ValidarUsuario(idUsuario))/*verifica el  id*/
            {
                MessageBox.Show("El usuario no existe.");
                return;
            }

            string codigo = rec.GenerarCodigo(idUsuario);// crea codigo de recuperacion
            //mensajes posibles para las diferentes casos 
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Hubo un error al generar el código de recuperación.");
                return;
            }
            //
            try
            {
                await rec.EnviarCorreoAsync(codigo);
                lbmensaje.Text = "Código de recuperación enviado a tu correo.";
                btnVerificarCod.Enabled = true;
            }
            catch (Exception ex)
            {
                lbmensaje.Text = "Error al enviar el correo. Inténtalo de nuevo más tarde.";
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
                btnVerificarCod.Enabled = false;
            }
        }
        


        private void btnVerificarCod_Click(object sender, EventArgs e)
        {
            if (rec.ValidarCodigo(idUsuario, txtUsuario2.Text))
            {
                frmNueva_Contraseña frm = new frmNueva_Contraseña(idUsuario);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Código incorrecto o expirado.");
            }
        }
        private void txtUsuario2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btn_regrsar_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }

        private async void btn_enviar_Click(object sender, EventArgs e)
        {

        }
    }
}
