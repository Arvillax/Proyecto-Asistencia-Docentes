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
    public partial class frmGestion_Usuarios : Form
    {
        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();
        Validaciones vali = new Validaciones();
        public frmGestion_Usuarios()
        {
            InitializeComponent();
            m_tabla_usuarios_admin();

            txt_idempleado.Visible = false;
            txt_nombre.Visible = false;
            cmb_permiso.Visible = false;
            cmb_estado.Visible = false;

            lbl_estado.Visible = false;
            lbl_id.Visible = false;
            lbl_nombre.Visible = false;
            lbl_permiso.Visible = false;

            btn_guardarc.Visible = false;
        }

        public void m_tabla_usuarios_admin()
        {
            

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_GU_Tabla", conectar);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar_usuarios_admin(dataGridView1);
            conectar.Close();

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idempleado.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            cmb_permiso.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            cmb_estado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {


            
            txt_idempleado.Visible = false;
            txt_nombre.Visible = false;
            cmb_permiso.Visible = false;
            cmb_estado.Visible = false;

            lbl_estado.Visible = false;
            lbl_id.Visible = false;
            lbl_nombre.Visible = false;
            lbl_permiso.Visible = false;

            btn_guardarc.Visible = false;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            txt_idempleado.Visible = true;
            txt_nombre.Visible = true;
            cmb_permiso.Visible = true;
            cmb_estado.Visible = true;

            lbl_estado.Visible = true;
            lbl_id.Visible = true;
            lbl_nombre.Visible = true;
            lbl_permiso.Visible = true;

            btn_guardarc.Visible = true;
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            frm_agregar_admin frm_Agregar = new frm_agregar_admin();
            frm_Agregar.Show();
        }

        private void btn_guardarc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idempleado.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txtpermiso.Text) || string.IsNullOrEmpty(txt_estado.Text))
            {
                MessageBox.Show("aegurese de que todos los campos esten con información");
            }
            else
            {
                int id_empleado = Convert.ToInt32(txt_idempleado.Text);
                string nombreempleado = txt_nombre.Text;
                int codrol = Convert.ToInt32(txtpermiso.Text);
                string nuevoestado = txt_estado.Text;


                conectar.ConnectionString = server;
                conectar.Open();
                SqlCommand cmd = new SqlCommand("sp_Modificar_U", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", id_empleado);
                cmd.Parameters.AddWithValue("@NuevoNombre", nombreempleado);
                cmd.Parameters.AddWithValue("@NuevoPermiso", codrol);
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


                txt_idempleado.Visible = false;
                txt_nombre.Visible = false;
                cmb_permiso.Visible = false;
                cmb_estado.Visible = false;

                lbl_estado.Visible = false;
                lbl_id.Visible = false;
                lbl_nombre.Visible = false;
                lbl_permiso.Visible = false;

                btn_guardarc.Visible = false;

                m_tabla_usuarios_admin();
            }

           
        }
        private void cmb_permiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_permiso.SelectedIndex == 0)
            {

                txtpermiso.Text = "4";
            }
            else if (cmb_permiso.SelectedIndex == 1)
            {

                txtpermiso.Text = "1";
            }
            else if (cmb_permiso.SelectedIndex == 2)
            {
                txtpermiso.Text = "2";
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_estado.SelectedIndex == 0)
            {

                txt_estado.Text = "A";
            }
            else if (cmb_estado.SelectedIndex == 1)
            {

                txt_estado.Text = "I";
            }
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            m_tabla_usuarios_admin();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_busqueda.Text))
            {
                MessageBox.Show("la busqueda no puede estar vacia");
            }
            else
            {
                string busqueda = txt_busqueda.Text;

                if (cmb_filtro.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un filtro antes para empezar la busqueda");
                }
                else if (cmb_filtro.SelectedIndex == 0)
                {
                    conectar.ConnectionString = server;
                    conectar.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable contenedor = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_bus_usuarios_admin", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", busqueda);

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
                    txt_busqueda.Clear();

                }
                else if (cmb_filtro.SelectedIndex == 1)
                {
                    con.busqueda_nombre_admin(busqueda,dataGridView1);
                    txt_busqueda.Clear();
                }
            }
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_filtro.SelectedIndex == 0)
            {
                vali.solonumeros(e);
            }
            if (cmb_filtro.SelectedIndex == 1)
            { 
                vali.solonletras(e);
            }
        }

        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_busqueda.Clear();
        }
    }
}
