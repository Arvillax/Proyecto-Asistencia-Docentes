using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmCierre : Form
    {
        clsConexion cn = new clsConexion();

        public frmCierre()
        {
            InitializeComponent();
            CargarAsistencias();

        }

        private void CargarAsistencias()
        {
            try
            {
                dgvMatriz.DataSource = cn.ObtenerAsistencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_cerrar_periodo_Click(object sender, EventArgs e)
        {
            try
            {
                cn.CerrarPeriodo(DateTime.Now.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
