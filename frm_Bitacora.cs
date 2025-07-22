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
    public partial class frm_Bitacora : Form
    {
        clsConexion con = new clsConexion();
        public frm_Bitacora()
        {
            InitializeComponent();
        }

        private void frm_Bitacora_Load(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = con.CargarBitacora();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            int idUsuario ;

            // Si el textbox está vacío, restauramos todo sin mostrar mensaje
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                con.CargarBitacora(); 
            }

            // Validamos si el texto es numérico
            if (int.TryParse(txtBuscar.Text.Trim(), out idUsuario))
            {
                con.FiltrarBitacoraPorUsuario(idUsuario,dgvBitacora);
                lbl_aviso.Text = "";
            }
            else
            {
                con.CargarBitacora();
                lbl_aviso.Text = "Por favor, ingresa un ID de usuario válido (solo números)";
               
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
