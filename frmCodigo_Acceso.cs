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
    public partial class frmCodigo_Acceso : Form
    {
        clsrecuperacion rec = new clsrecuperacion();
        private int idUsuario;

        public frmCodigo_Acceso(int usuario)
        {
            InitializeComponent();
            idUsuario = usuario;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmRecuperacion_De_Contraseñas recucon = new frmRecuperacion_De_Contraseñas();
            recucon.Show();
            this.Hide();
        }

        private void btnVerificarCod_Click(object sender, EventArgs e)
        {
            if (rec.ValidarCodigo(idUsuario, txtUsuario.Text))
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
    }
}
