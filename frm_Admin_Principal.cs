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
    public partial class frm_Admin_Principal : Form
    {
        public frm_Admin_Principal()
        {
            InitializeComponent();
        }



        private void AbrirFormularioHijo(Form childForm)
        {
            
            PnlPadre.Controls.Clear();

            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            
            PnlPadre.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Admin());
        }

        private void btnCreacionPeriodo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmNuevoPeriodo());
        }

        private void btnModificacion_Datos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmModificacionDoC());
        }

        private void btnCierrePeriodo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmCierre());
        }

        private void btnMigracionDatos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmMigracion());
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }
    }
}
