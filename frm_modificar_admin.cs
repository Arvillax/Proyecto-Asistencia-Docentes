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
    public partial class frm_modificar_admin : Form
    {
        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();


        public frm_modificar_admin()
        {
            InitializeComponent();
        }

        private void btn_confir_Click(object sender, EventArgs e)
        {
            int id_empleado = Convert.ToInt32(txt_idempleado.Text);
            string nuevousuario = txt_nuevousuario.Text;
            string nuevacontra = txt_nuevacontra.Text;
            string nuevoestado = txt_nuevoestadoempleado.Text;


            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_Modificar_U", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idEmpleado", id_empleado);
            cmd.Parameters.AddWithValue("@NuevoUsuario", nuevousuario);
            cmd.Parameters.AddWithValue("@NuevaContra", nuevacontra);
            cmd.Parameters.AddWithValue("@NuevoEstado", nuevoestado);
            

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            //con.agregar_usuario(id_empleado,nombre,id_rol,nombre_usuario,contraseña);
            conectar.Close();

            frmGestion_Usuarios admin = new frmGestion_Usuarios();
            this.Hide();
            admin.Show();
        }

        private void cmb_estadoactual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_estadoactual.SelectedIndex == 0)
            {

                txt_nuevoestadoempleado.Text = "A";
            }
            else if (cmb_estadoactual.SelectedIndex == 1)
            {

                txt_nuevoestadoempleado.Text = "I";
            }
        }

        private void txt_nuevoestadoempleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
