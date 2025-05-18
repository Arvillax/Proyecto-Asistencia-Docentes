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
            CustomizeDiseño();
            //CargarAsistencias();
        }

        

        private void CustomizeDiseño()
        {
            panel_p1.Visible = false;
            panel_p2.Visible = false;
            panel_p3.Visible = false;
        }

        private void EsconderMenu()
        {
            if (panel_p1.Visible == true)
                panel_p1.Visible = false;
            if (panel_p2.Visible == true)
                panel_p2.Visible = false;
            if (panel_p3.Visible == true)
                panel_p3.Visible = false;
        }

        private void MostrarMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();  
            frmLogin.Show();
            this.Close();
        }


        private void btnMdatos_Click(object sender, EventArgs e)
        {
                frmModificacionDoC frmmodiDatos = new frmModificacionDoC();
                frmmodiDatos.Show();
                this.Hide();
        }

        private void btnMGestion_Click(object sender, EventArgs e)
        {
            frmGestion_Usuarios frmGestion = new frmGestion_Usuarios();
            frmGestion.Show();
            this.Hide();
        }

        private void btnIPeriodo_Click_1(object sender, EventArgs e)
        {
            MostrarMenu(panel_p1);
            dgvPrimerP.DataSource = cn.ObtenerAsistencias(1);

        }

        

        private void btnIIPeriodo_Click_1(object sender, EventArgs e)
        {
            MostrarMenu(panel_p2);
            dgvSegundoP.DataSource = cn.ObtenerAsistencias(2);
        }

        private void btnIIIPeriodo_Click(object sender, EventArgs e)
        {
            MostrarMenu(panel_p3);
            dgvTercerP.DataSource = cn.ObtenerAsistencias(3);
        }

        private void btnMMigra_Click_1(object sender, EventArgs e)
        {
            frmMigracion migra = new frmMigracion();
            migra.Show();
            this.Hide();
        }

        private void btnMCierre_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmGestion_Usuarios frmGestion = new frmGestion_Usuarios();
            frmGestion.Show();
            this.Hide();
        }

        private void btn_mo_datos_Click(object sender, EventArgs e)
        {
            frmModificacionDoC frmmodiDatos = new frmModificacionDoC();
            frmmodiDatos.Show();
            this.Hide();
        }

        private void btn_migracion_Click(object sender, EventArgs e)
        {
            frmMigracion migra = new frmMigracion();
            migra.Show();
            this.Hide();
        }

        private void btn_cierre_periodo_Click(object sender, EventArgs e)
        {

        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btnCierrePeriodo_Click(object sender, EventArgs e)
        {
            
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
