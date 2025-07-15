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
            clsConexion con = new clsConexion();
            con.mostrar_usuarios_admin(dataGridView1);
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idempleado.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            cmb_permiso.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            cmb_estado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
            if (string.IsNullOrEmpty(txt_idempleado.Text) || string.IsNullOrEmpty(txt_nombre.Text) ||
                string.IsNullOrEmpty(txtpermiso.Text) || string.IsNullOrEmpty(txt_estado.Text))
            {
                MessageBox.Show("Asegúrese de que todos los campos estén con información");
                return;
            }

            int id_empleado = Convert.ToInt32(txt_idempleado.Text);
            string nombreempleado = txt_nombre.Text;
            int codrol = Convert.ToInt32(txtpermiso.Text);
            string nuevoestado = txt_estado.Text;

            clsConexion con = new clsConexion();

            try
            {
                using (SqlConnection conectar = con.Conectar())
                {
                    conectar.Open();
                    SqlCommand cmd = new SqlCommand("sp_Modificar_U", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idEmpleado", id_empleado);
                    cmd.Parameters.AddWithValue("@NuevoNombre", nombreempleado);
                    cmd.Parameters.AddWithValue("@NuevoPermiso", codrol);
                    cmd.Parameters.AddWithValue("@NuevoEstado", nuevoestado);

                    cmd.ExecuteNonQuery();
                }

                // Ocultar controles
                txt_idempleado.Visible = false;
                txt_nombre.Visible = false;
                cmb_permiso.Visible = false;
                cmb_estado.Visible = false;

                lbl_estado.Visible = false;
                lbl_id.Visible = false;
                lbl_nombre.Visible = false;
                lbl_permiso.Visible = false;

                btn_guardarc.Visible = false;

                m_tabla_usuarios_admin(); // recargar tabla
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el usuario:\n" + ex.Message);
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

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            clsConexion con = new clsConexion();

            if (string.IsNullOrEmpty(txt_busqueda.Text))
            {
                m_tabla_usuarios_admin();
                return;
            }

            string busqueda = txt_busqueda.Text;

            if (cmb_filtro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro antes para empezar la búsqueda");
                return;
            }

            if (cmb_filtro.SelectedIndex == 0)
            {
                try
                {
                    using (SqlConnection conectar = con.Conectar())
                    {
                        conectar.Open();

                        SqlCommand cmd = new SqlCommand("sp_bus_usuarios_admin", conectar);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", busqueda);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable contenedor = new DataTable();

                        adapter.Fill(contenedor);
                        dataGridView1.DataSource = contenedor;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al buscar usuario:\n" + ex.Message);
                }
            }
            else if (cmb_filtro.SelectedIndex == 1)
            {
                con.busqueda_nombre_admin(busqueda, dataGridView1); // ya encapsulado
            }
        }

    }
}
