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
    public partial class frmDecano : Form
    {
        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();

        public frmDecano(int usuario_decano)
        {
            InitializeComponent();
            customdesign();
            txt_usu_decano.Text = usuario_decano.ToString();
            mtabla_decano();
            escondertablas();

        }

        public void escondertablas()
        {
            dataGridView1.Columns[0].Visible = false;
        }

        public void mtabla_decano()
        {
            int usu_decano = Convert.ToInt32(txt_usu_decano.Text);

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_mos_decano", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_decano", usu_decano);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.visualizar_decano(usu_decano, dataGridView1);
            conectar.Close();
        }

        private void customdesign()
        {
            
        }

        private void hidesubmenu()
        {
            
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_most_sem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_most_sem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idasis.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void rdb_observacion_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdb_justificado_CheckedChanged(object sender, EventArgs e)
        {
            string est_asis = "R";
            int id_asistencia = Convert.ToInt32(txt_idasis.Text);
            int id_decano = Convert.ToInt32(txt_usu_decano.Text);
            
            
            conectar.ConnectionString = server;
            conectar.Open();

            SqlCommand cmd = new SqlCommand("sp_justificacion ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado_justificacion", est_asis);
            cmd.Parameters.AddWithValue("@id_asistencia", id_asistencia);
            cmd.Parameters.AddWithValue("@id_decano", id_decano);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.marcar_justificacion(est_asis, id_asistencia, id_decano, dataGridView1);
            conectar.Close();
        }

        private void rdb_no_justificado_CheckedChanged(object sender, EventArgs e)
        {
            string est_asis = "N";
            int id_asistencia = Convert.ToInt32(txt_idasis.Text);
            int id_decano = Convert.ToInt32(txt_usu_decano.Text);

            conectar.ConnectionString = server;
            conectar.Open();
            

            SqlCommand cmd = new SqlCommand("sp_justificacion ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado_justificacion", est_asis);
            cmd.Parameters.AddWithValue("@id_asistencia", id_asistencia);
            cmd.Parameters.AddWithValue("@id_decano", id_decano);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.marcar_justificacion(est_asis, id_asistencia, id_decano, dataGridView1);
            conectar.Close();
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           // rdb_justificado.Checked = false;
           // rdb_no_justificado.Checked = false;
        }

        private void btn_justificado_Click(object sender, EventArgs e)
        {
            string est_asis = "R";
            int id_asistencia = Convert.ToInt32(txt_idasis.Text);
            int id_decano = Convert.ToInt32(txt_usu_decano.Text);


            conectar.ConnectionString = server;
            conectar.Open();

            SqlCommand cmd = new SqlCommand("sp_justificacion ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado_justificacion", est_asis);
            cmd.Parameters.AddWithValue("@id_asistencia", id_asistencia);
            cmd.Parameters.AddWithValue("@id_decano", id_decano);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.marcar_justificacion(est_asis, id_asistencia, id_decano, dataGridView1);
            conectar.Close();
        }

        private void btn_nojustificado_Click(object sender, EventArgs e)
        {
            string est_asis = "N";
            int id_asistencia = Convert.ToInt32(txt_idasis.Text);
            int id_decano = Convert.ToInt32(txt_usu_decano.Text);

            conectar.ConnectionString = server;
            conectar.Open();


            SqlCommand cmd = new SqlCommand("sp_justificacion ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado_justificacion", est_asis);
            cmd.Parameters.AddWithValue("@id_asistencia", id_asistencia);
            cmd.Parameters.AddWithValue("@id_decano", id_decano);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.marcar_justificacion(est_asis, id_asistencia, id_decano, dataGridView1);
            conectar.Close();
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            mtabla_decano();
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_usu_decano.Text);
            string busqueda = txt_busqueda.Text;


            if (string.IsNullOrEmpty(txt_busqueda.Text))
            {
                MessageBox.Show("la busqueda no puede quedar vacia");
            }
            else
            {
                if (cmb_filtro.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un filtro antes de iniciar la busqueda");
                }
                else if(cmb_filtro.SelectedIndex == 0)
                {
                    conectar.ConnectionString = server;
                    conectar.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable contenedor = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_bus_decano", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clase", busqueda);
                    cmd.Parameters.AddWithValue("@id_decano", id);

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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Asegurese de que se haya seleccionado un registro");
            }
            else
            {
                obs_justificacion con = new obs_justificacion(this);
                con.ShowDialog();
            }

           
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

        private void frmDecano_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1600, 700);
        }
    }
}
