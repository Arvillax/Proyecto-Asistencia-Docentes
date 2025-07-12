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
            //CargarAsistencias();
        }
        private void btn_cerrar_periodo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = cn.Conectar())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_MoverAsistenciasAMatriz", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Fecha_Final", DateTime.Now.Date);

                        // Capturar mensajes de SQL Server
                        con.InfoMessage += (s, ev) =>
                        {
                            MessageBox.Show(ev.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar periodo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
