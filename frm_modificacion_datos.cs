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
    public partial class frm_modificacion_datos : Form
    {

        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();

        public frm_modificacion_datos()
        {
            InitializeComponent();
        }

        private void btn_con_cam_Click(object sender, EventArgs e)
        {
            string id_clase = txt_idclase.Text;
            string nueva_aula = txt_nuevaula.Text;
         // int nuevo_empleado = Convert.ToInt32( txt_idempleado.Text);
 
            string nuevo_estado = txt_estadoclase.Text;
            string nueva_hora = txt_nuevahora.Text;
            string hora_final = txt_horafinal.Text;

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("Clases_Modificar", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idClase", id_clase);
            cmd.Parameters.AddWithValue("@Nueva_Aula", nueva_aula);
            cmd.Parameters.AddWithValue("@Nuevo_Empleado", txt_idempleado.Text);
            cmd.Parameters.AddWithValue("@Nuevo_Estado", nuevo_estado);
            cmd.Parameters.AddWithValue("@Hora_inicio", nueva_hora);
            cmd.Parameters.AddWithValue("@Hora_Final", hora_final);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
            conectar.Close();

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_estado.SelectedIndex == 0)
            {

                txt_estadoclase.Text = "A";
            }
            else if (cmb_estado.SelectedIndex == 1)
            {

                txt_estadoclase.Text = "I";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_estadoclase.Text) || string.IsNullOrEmpty(txt_horafinal.Text) || string.IsNullOrEmpty(txt_idclase.Text)
                || string.IsNullOrEmpty(txt_idempleado.Text) || string.IsNullOrEmpty(txt_nuevahora.Text) || string.IsNullOrEmpty(txt_nuevaula.Text))
            {
                MessageBox.Show("No puede haber campos vacios");
            }
            else
            {
                string id_clase = txt_idclase.Text;
                string nueva_aula = txt_nuevaula.Text;
                string nuevo_estado = txt_estadoclase.Text;
                string nueva_hora = txt_nuevahora.Text;
                string hora_final = txt_horafinal.Text;

                conectar.ConnectionString = server;
                conectar.Open();
                SqlCommand cmd = new SqlCommand("sp_Clases_Modificar", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idClase", id_clase);
                cmd.Parameters.AddWithValue("@Nueva_Aula", nueva_aula);
                cmd.Parameters.AddWithValue("@Nuevo_Empleado", txt_idempleado.Text);
                cmd.Parameters.AddWithValue("@Nuevo_Estado", nuevo_estado);
                cmd.Parameters.AddWithValue("@Hora_inicio", nueva_hora);
                cmd.Parameters.AddWithValue("@Hora_Final", hora_final);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }

                conectar.Close();

                this.Close();
            }
                
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
