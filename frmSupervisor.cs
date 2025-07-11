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
        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();
        Validaciones vali = new Validaciones();

        public frmSupervisor()
        {
            InitializeComponent();
            customdesign();
            mtabla_supervisor();
            escondertablas();
        }

        public void mtabla_supervisor()
        {
            int idrol = 4;

            con.mostrar_supervisor(idrol,dataGridView1);
            conectar.Close();
        }

        private void customdesign()
        {
            panel_btn_edificios.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panel_btn_edificios.Visible == true)
                panel_btn_edificios.Visible = false;
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
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
        
            txt_idasis.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txt_idasis_TextChanged(object sender, EventArgs e)
        {

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

        private void panel_btn_edificios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string id = "A";
            txt_edificios.Text = "A";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string id = "B";
            txt_edificios.Text = "B";

            con.mostrar_edificios(id, dataGridView1);
             
            
            conectar.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string id = "C";
            txt_edificios.Text = "C";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string id = "D";
            txt_edificios.Text = "D";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            string id = "E";
            txt_edificios.Text = "E";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            string id = "F";
            txt_edificios.Text = "F";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            string id = "G";
            txt_edificios.Text = "G";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            string id = "H";
            txt_edificios.Text = "H";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            string id = "I";
            txt_edificios.Text = "I";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            string id = "J";
            txt_edificios.Text = "J";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            string id = "K";
            txt_edificios.Text = "K";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            string id = "L";
            txt_edificios.Text = "L";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            string id = "M";
            txt_edificios.Text = "M";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            string id = "ND";
            txt_edificios.Text = "ND";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            string id = "P";
            txt_edificios.Text = "P";

            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_busqueda.Text))
            {
                MessageBox.Show("La busqueda no puede estar vacía");

            }
            else if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Seleccione un edificio para empezar la busqueda");
            }
            else
            {
                string edificio = txt_edificios.Text;
                string busqueda = txt_busqueda.Text;

                if (cmb_filtro.SelectedIndex == -1)
                {
                    MessageBox.Show("Escoja un filtro para empezar la busqueda");
                }
                else if (cmb_filtro.SelectedIndex == 0)
                {
                    conectar.ConnectionString = server;
                    conectar.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable contenedor = new DataTable();
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
                    conectar.Close();
                }

               
            }

        }

        private void iconButton16_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Escoga un edificio para marcar o quitar asistencia");
            }
            else if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Asegurese de que se haya seleccionado un registro");
            }
            else
            {

                string est_asis = "P";
                int id_asistencia = Convert.ToInt32(txt_idasis.Text);
                string id_edificio = txt_edificios.Text;
                
                con.marcar_asistencia(est_asis, id_asistencia, id_edificio, dataGridView1);
                conectar.Close();
            }
            
            
        }

        private void btn_noasistio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Escoga un edificio para marcar o quitar asistencia");
            }
            else if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Asegurese de que se haya seleccionado un registro");
            }
            else 
            {
                string est_asis = "A";
                int id_asistencia = Convert.ToInt32(txt_idasis.Text);
                string id_edificio = txt_edificios.Text;
                
                con.marcar_asistencia(est_asis, id_asistencia, id_edificio, dataGridView1);
                conectar.Close();

            }

        }

        private void btn_observacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                MessageBox.Show("Escoga un edificio y seleccione un registro para agregar una observacion");
            }
            else if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Asegurese de que se haya seleccionado un registro");
            }
            else
            {
                frmObservacion obsForm = new frmObservacion(this);
                obsForm.ShowDialog();
            }    
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
            dataGridView1.Columns[0].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
