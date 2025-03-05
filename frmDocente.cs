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
    public partial class frmDocente : Form
    {
        string server = "Data Source = LAPTOP-U0ITJDJB\\SQLEXPRESS; Initial Catalog = pruebita; Integrated Security=True";
        SqlConnection conectar = new SqlConnection();
       clsConexion con = new clsConexion();

        public frmDocente(int numero)
        {
            InitializeComponent();
            customdesign();
            txt_usu_docente.Text = numero.ToString();
            m_tabla();
        }

        

        public void m_tabla()
        {
            int id = Convert.ToInt32(txt_usu_docente.Text);

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("v_docente",conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_empleado", id);

            try
            { 
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar(id, dataGridView1);
            conectar.Close();

        }

        private void customdesign()
        {
            panelsemana.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelsemana.Visible == true)
                panelsemana.Visible = false;
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

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_semana_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsemana);
        }

        private void btn_sem1_Click(object sender, EventArgs e)
        {
            int idempleado = Convert.ToInt32(txt_usu_docente.Text);
            int dia = 2;

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("VerAsistenciaDocente_1 ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoEmpleado", idempleado);
            cmd.Parameters.AddWithValue("@Dia", dia);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_semanas(idempleado , dia, dataGridView1);
            conectar.Close();
        }

        private void btn_sem2_Click(object sender, EventArgs e)
        {
            int idempleado = Convert.ToInt32(txt_usu_docente.Text);
            int dia = 8;

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("VerAsistenciaDocente_1 ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoEmpleado", idempleado);
            cmd.Parameters.AddWithValue("@Dia", dia);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_semanas(idempleado, dia, dataGridView1);
            conectar.Close();
        }

        private void btn_sem3_Click(object sender, EventArgs e)
        {
            int idempleado = Convert.ToInt32(txt_usu_docente.Text);
            int dia = 15;

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("VerAsistenciaDocente_1 ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoEmpleado", idempleado);
            cmd.Parameters.AddWithValue("@Dia", dia);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_semanas(idempleado, dia, dataGridView1);
            conectar.Close();
        }

        private void btn_sem4_Click(object sender, EventArgs e)
        {
            int idempleado = Convert.ToInt32(txt_usu_docente.Text);
            int dia = 22;

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("VerAsistenciaDocente_1 ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoEmpleado", idempleado);
            cmd.Parameters.AddWithValue("@Dia", dia);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_semanas(idempleado, dia, dataGridView1);
            conectar.Close();
        }

        private void btn_sem5_Click(object sender, EventArgs e)
        {
            int idempleado = Convert.ToInt32(txt_usu_docente.Text);
            int dia = 29;

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("VerAsistenciaDocente_1 ", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodigoEmpleado", idempleado);
            cmd.Parameters.AddWithValue("@Dia", dia);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_semanas(idempleado, dia, dataGridView1);
            conectar.Close();
        }
    }
}
