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
using System.Globalization;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmModificacionDoC : Form
    {
        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();
        Validaciones vali = new Validaciones();
        public frmModificacionDoC()
        {
            InitializeComponent();
            m_tabla();
            pan_modificardatos.Visible = false;

        }

        public void m_tabla()
        {

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_MD_Tabla", conectar);
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
            con.mostrar_claseydocentes(dataGridView1);
            conectar.Close();

        }

        private void btnMdatos_Click(object sender, EventArgs e)
        {

        }

        private void btnMGestion_Click(object sender, EventArgs e)
        {
            Admin frmGestion = new Admin();
            frmGestion.Show();
            this.Hide();
        }

        private void btnMCierre_Click(object sender, EventArgs e)
        {
            frmCierre frmcierre = new frmCierre();
            frmcierre.Show();
            this.Hide();
        }

        private void btnMMigra_Click(object sender, EventArgs e)
        {
            frmMigracion frmmigra = new frmMigracion();
            frmmigra.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_modificardatos_Click(object sender, EventArgs e)
        {
            frm_modificacion_datos modidatos = new frm_modificacion_datos();
            modidatos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_MD_Tabla", conectar);
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
            con.mostrar_claseydocentes(dataGridView1);
            conectar.Close();
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            m_tabla();
        }

        private void btn_modificard_Click(object sender, EventArgs e)
        {
            /*frm_modificacion_datos modidatos = new frm_modificacion_datos();
            modidatos.Show();*/
            pan_modificardatos.Visible = true;

        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_busqueda.Text))
            {
                MessageBox.Show("lo busqueda no puede estar vacia");
            }
            else
            {
                string busqueda = txt_busqueda.Text;

                if (cmb_filtro.SelectedIndex == -1)
                {
                    MessageBox.Show("Elija un filtro antes de empezar la busqueda");
                }
                else if (cmb_filtro.SelectedIndex == 0)
                {
                    conectar.ConnectionString = server;
                    conectar.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable contenedor = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_bus_modi_admin", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_clase", busqueda);


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
                    con.busqueda_nomclase_admin(busqueda,dataGridView1);
                    txt_busqueda.Clear();
                }
                else if (cmb_filtro.SelectedIndex == 2)
                { 
                    con.busqueda_idempleado_admin(busqueda,dataGridView1);
                    txt_busqueda.Clear();
                }

                    
               


            }

            
        }

        private void btn_concambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_estadoclase.Text) || string.IsNullOrEmpty(txt_horafinal.Text) || string.IsNullOrEmpty(txt_idclase.Text)
                || string.IsNullOrEmpty(txt_idempleado.Text) || string.IsNullOrEmpty(txt_nuevahora.Text) || string.IsNullOrEmpty(txt_nuevaula.Text))
            {
                MessageBox.Show("No puede haber campos vacios");
            }
            else
            {
                string formatohora = "HH:mm";
                DateTime horainicio, horafin;

                bool horainiciovalida = DateTime.TryParseExact(
                    txt_nuevahora.Text, formatohora,CultureInfo.InvariantCulture, DateTimeStyles.None,out horainicio
                    );

                bool horafinvalida = DateTime.TryParseExact(
                    txt_horafinal.Text, formatohora , CultureInfo.InvariantCulture, DateTimeStyles.None, out horafin
                    );

                if (!horainiciovalida || !horafinvalida)
                {
                    MessageBox.Show("Por favor, ingresa las horas en el formato correcto (HH:mm).", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (horainicio >= horafin)
                {
                    MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.", "Validación de tiempo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string id_clase = txt_idclase.Text;
                    string nueva_aula = txt_nuevaula.Text;
                    string nuevo_estado = txt_estadoclase.Text;
                    string nueva_hora = txt_nuevahora.Text;
                    string hora_final = txt_horafinal.Text;

                    bool existe = con.verificaraula(nueva_aula);
                    txt_existencia_aula.Text = existe ? "existe" : "no existe";

                    bool existe2 = con.verificacionusuario(Convert.ToInt32(txt_idempleado.Text));
                    txt_existencia_usuario.Text = existe2 ? "existe" : "no existe";

                    if (txt_existencia_aula.Text == "existe")
                    {

                        if (txt_existencia_usuario.Text == "existe")
                        {
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

                            m_tabla();
                            pan_modificardatos.Visible = false;
                        }
                        else if (txt_existencia_usuario.Text == "no existe")
                        {
                            MessageBox.Show("el empleado que ingresó no existe");
                        }

                    }
                    else if (txt_existencia_aula.Text == "no existe")
                    {
                        MessageBox.Show("El aula que ingresó no existe");
                    }
                }
            }
        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idclase.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_nuevaula.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_idempleado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmb_estado.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_nuevahora.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_horafinal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_filtro.SelectedIndex == 1)
            {
                vali.solonletras(e);
            }
            else if (cmb_filtro.SelectedIndex == 2)
            {
                vali.solonumeros(e);
            }

        }

        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_busqueda.Clear();
        }
    }
}
