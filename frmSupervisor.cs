using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmSupervisor : Form
    {
        clsConexion con = new clsConexion();
        Validaciones vali = new Validaciones();

        public frmSupervisor()
        {
            InitializeComponent();
            customdesign();
            mtabla_supervisor();
            escondertablas();
            btnMaximizar.Text = "🗖";
        }

        public void mtabla_supervisor()
        {
            int idrol = 4;
            con.mostrar_supervisor(idrol, dataGridView1);
        }

        private void customdesign()
        {
            panel_btn_edificios.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panel_btn_edificios.Visible)
                panel_btn_edificios.Visible = false;
        }

        private void showsubmenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_edificios_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_btn_edificios);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
                txt_idasis.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void frmSupervisor_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1600, 700);
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }

        // Métodos para botones de edificios (A, B, C, ...)

        private void CargarEdificio(string id)
        {
            txt_edificios.Text = id;
            con.mostrar_edificios(id, dataGridView1);
        }

        private void iconButton1_Click(object sender, EventArgs e) => CargarEdificio("A");
        private void iconButton2_Click(object sender, EventArgs e) => CargarEdificio("B");
        private void iconButton3_Click(object sender, EventArgs e) => CargarEdificio("C");
        private void iconButton4_Click(object sender, EventArgs e) => CargarEdificio("D");
        private void iconButton5_Click(object sender, EventArgs e) => CargarEdificio("E");
        private void iconButton6_Click(object sender, EventArgs e) => CargarEdificio("F");
        private void iconButton7_Click(object sender, EventArgs e) => CargarEdificio("G");
        private void iconButton8_Click(object sender, EventArgs e) => CargarEdificio("H");
        private void iconButton9_Click(object sender, EventArgs e) => CargarEdificio("I");
        private void iconButton10_Click(object sender, EventArgs e) => CargarEdificio("J");
        private void iconButton11_Click(object sender, EventArgs e) => CargarEdificio("K");
        private void iconButton12_Click(object sender, EventArgs e) => CargarEdificio("L");
        private void iconButton13_Click(object sender, EventArgs e) => CargarEdificio("M");
        private void iconButton14_Click(object sender, EventArgs e) => CargarEdificio("ND");
        private void iconButton15_Click(object sender, EventArgs e) => CargarEdificio("P");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Seleccione un edificio para empezar la búsqueda");
                return;
            }

            string edificio = txt_edificios.Text;
            string busqueda = txt_busqueda.Text;

            if (cmb_filtro.SelectedIndex == -1)
            {
                MessageBox.Show("Escoja un filtro para empezar la búsqueda");
                return;
            }

            if (cmb_filtro.SelectedIndex == 0)
            {
                DataTable contenedor = new DataTable();
                using (SqlConnection conectar = con.Conectar())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("sp_bus_super", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nom_docente", busqueda);
                    cmd.Parameters.AddWithValue("@id_edificio", edificio);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(contenedor);
                        dataGridView1.DataSource = contenedor;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
            }
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_busqueda.Text))
            {
                MessageBox.Show("La búsqueda no puede estar vacía");
                return;
            }

            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Seleccione un edificio para empezar la búsqueda");
                return;
            }

            string edificio = txt_edificios.Text;
            string busqueda = txt_busqueda.Text;

            if (cmb_filtro.SelectedIndex == -1)
            {
                MessageBox.Show("Escoja un filtro para empezar la búsqueda");
                return;
            }

            if (cmb_filtro.SelectedIndex == 0)
            {
                DataTable contenedor = new DataTable();
                using (SqlConnection conectar = con.Conectar())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("sp_bus_super", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nom_docente", busqueda);
                    cmd.Parameters.AddWithValue("@id_edificio", edificio);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(contenedor);
                        dataGridView1.DataSource = contenedor;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
            }
        }

        private void iconButton16_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Escoja un edificio para marcar o quitar asistencia");
                return;
            }
            if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Asegúrese de que se haya seleccionado un registro");
                return;
            }

            string est_asis = "P";
            int id_asistencia = Convert.ToInt32(txt_idasis.Text);
            string id_edificio = txt_edificios.Text;

            con.marcar_asistencia(est_asis, id_asistencia, id_edificio, dataGridView1);
        }

        private void btn_noasistio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Escoja un edificio para marcar o quitar asistencia");
                return;
            }
            if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Asegúrese de que se haya seleccionado un registro");
                return;
            }

            string est_asis = "A";
            int id_asistencia = Convert.ToInt32(txt_idasis.Text);
            string id_edificio = txt_edificios.Text;

            con.marcar_asistencia(est_asis, id_asistencia, id_edificio, dataGridView1);
        }

        private void btn_observacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Escoja un edificio y seleccione un registro para agregar una observación");
                return;
            }
            if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Asegúrese de que se haya seleccionado un registro");
                return;
            }

            frmObservacion obsForm = new frmObservacion(this);
            obsForm.ShowDialog();
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            mtabla_supervisor();
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.solonletras(e);
        }

        public void escondertablas()
        {
            if (dataGridView1.Columns.Count > 0)
                dataGridView1.Columns[0].Visible = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1600, 700);
                btnMaximizar.Text = "🗖";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Text = "🗗";
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }


}
