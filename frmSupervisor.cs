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
        string server = "Data Source = LAPTOP-U0ITJDJB\\SQLEXPRESS; Initial Catalog = pruebita; Integrated Security=True";
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();

        public frmSupervisor()
        {
            InitializeComponent();
            customdesign();
            mtabla_supervisor();
            rbOb.Enabled = false;
        }

        public void mtabla_supervisor()
        {
            int idrol = 4;

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_vs", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_rol", idrol);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }

        private void btn_j_Click(object sender, EventArgs e)
        {
            int id = 2;
            txt_edificios.Text = "2";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            int id = 3;
            txt_edificios.Text = "3";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            int id = 4;
            txt_edificios.Text = "4";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            int id = 5;
            txt_edificios.Text = "5";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            int id = 6;
            txt_edificios.Text = "6";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            int id = 7;
            txt_edificios.Text = "7";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            int id = 8;
            txt_edificios.Text = "8";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            int id = 10;
            txt_edificios.Text = "10";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            int id = 1;
            txt_edificios.Text = "1";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_I_Click_1(object sender, EventArgs e)
        {
            int id = 9;
            txt_edificios.Text = "9";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_k_Click_1(object sender, EventArgs e)
        {
            int id = 11;
            txt_edificios.Text = "11";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            int id = 12;
            txt_edificios.Text = "12";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            int id = 13;
            txt_edificios.Text = "13";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            int id = 14;
            txt_edificios.Text = "14";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            int id = 15;
            txt_edificios.Text = "15";

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("c_edificio", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_edificio", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_edificios(id, dataGridView1);
            conectar.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string est_asis = "P";
            int id_asistencia = Convert.ToInt32(txt_idasis.Text);
            int id_edificio = Convert.ToInt32(txt_edificios.Text);

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_marcasis ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado_asistencia", est_asis);
            cmd.Parameters.AddWithValue("@id_asistencia", id_asistencia);
            cmd.Parameters.AddWithValue("@id_edificio", id_edificio);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.marcar_asistencia(est_asis, id_asistencia,id_edificio, dataGridView1);
            conectar.Close();

            rbOb.Enabled = true;

        }

        private void rdb_retirar_asis_CheckedChanged(object sender, EventArgs e)
        {
            string est_asis = "A";
            int id_asistencia = Convert.ToInt32(txt_idasis.Text);
            int id_edificio = Convert.ToInt32(txt_edificios.Text);

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_marcasis ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado_asistencia", est_asis);
            cmd.Parameters.AddWithValue("@id_asistencia", id_asistencia);
            cmd.Parameters.AddWithValue("@id_edificio", id_edificio);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.marcar_asistencia(est_asis, id_asistencia,id_edificio, dataGridView1);
            conectar.Close();

            rbOb.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idasis.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                
            }
            
        }

        private void rbOb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOb.Checked)
            {
                frmObservacion obsForm = new frmObservacion(this); // Pasamos una referencia de frmSupervisor
                obsForm.ShowDialog();
            }
        }

        public int ObtenerIDSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            }
            return -1; // Si no hay una fila seleccionada, devuelve -1
        }

    }
}
