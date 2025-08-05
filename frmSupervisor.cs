using FontAwesome.Sharp;
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


        public frmSupervisor(int numero)
        {
            InitializeComponent();
            customdesign();
            mtabla_supervisor();
            escondertablas();
            btnMaximizar.Text = "🗖";

            txt_usuario.Text = numero.ToString();
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

        List<IconButton> botonesEdificio;

        private void frmSupervisor_Load(object sender, EventArgs e)
        {

            botonesEdificio = new List<IconButton> {
            iconButton1, iconButton2, iconButton3, iconButton4,
            iconButton5, iconButton6, iconButton7, iconButton8,
            iconButton9, iconButton10, iconButton11, iconButton12,
            iconButton13, iconButton14, iconButton15
            };

            this.MinimumSize = new Size(1600, 700);
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Hide();
        }

        // Métodos para botones de edificios (A, B, C, ...)

        private void CargarEdificio(string id, IconButton botonPresionado)
        {
            txt_edificios.Text = id;
            con.mostrar_edificios(id, dataGridView1);

            // Reiniciar el color de todos los botones
            foreach (var boton in botonesEdificio)
            {
                boton.BackColor = Color.LightGray; // o el color original que usas
                boton.ForeColor = Color.Black;
            }

            // Cambiar color del botón presionado
            botonPresionado.BackColor = Color.FromArgb(0, 120, 215); // Azul, por ejemplo
            botonPresionado.ForeColor = Color.White;
        }

        private void iconButton1_Click(object sender, EventArgs e) => CargarEdificio("A", (IconButton)sender);
        private void iconButton2_Click(object sender, EventArgs e) => CargarEdificio("B", (IconButton)sender);
        private void iconButton3_Click(object sender, EventArgs e) => CargarEdificio("C", (IconButton)sender);
        private void iconButton4_Click(object sender, EventArgs e) => CargarEdificio("D", (IconButton)sender);
        private void iconButton5_Click(object sender, EventArgs e) => CargarEdificio("E", (IconButton)sender);
        private void iconButton6_Click(object sender, EventArgs e) => CargarEdificio("F", (IconButton)sender);
        private void iconButton7_Click(object sender, EventArgs e) => CargarEdificio("G", (IconButton)sender);
        private void iconButton8_Click(object sender, EventArgs e) => CargarEdificio("H", (IconButton)sender);
        private void iconButton9_Click(object sender, EventArgs e) => CargarEdificio("I", (IconButton)sender);
        private void iconButton10_Click(object sender, EventArgs e) => CargarEdificio("J", (IconButton)sender);
        private void iconButton11_Click(object sender, EventArgs e) => CargarEdificio("K", (IconButton)sender);
        private void iconButton12_Click(object sender, EventArgs e) => CargarEdificio("L", (IconButton)sender);
        private void iconButton13_Click(object sender, EventArgs e) => CargarEdificio("M", (IconButton)sender);
        private void iconButton14_Click(object sender, EventArgs e) => CargarEdificio("ND", (IconButton)sender);
        private void iconButton15_Click(object sender, EventArgs e) => CargarEdificio("P", (IconButton)sender);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string edificio = txt_edificios.Text;
            string busqueda = txt_busqueda.Text;

            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                lbl_aviso.Text = "";
                lbl_aviso.Text = "Seleccione un edificio para empezar la búsqueda"; 
            }
            else if (cmb_filtro.SelectedIndex == -1)
            {
                lbl_aviso.Text = "";
                lbl_aviso.Text = "Escoja un filtro para empezar la búsqueda";
            }
            else if (cmb_filtro.SelectedIndex == 0)
            {
                
                lbl_aviso.Text = "";
                DataTable contenedor = new DataTable();
                using (SqlConnection conectar = con.Conectar())
                {
                    conectar.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("PA_BUSCAR_NOMBRE_SUPERV", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nom_docente", busqueda);
                    cmd.Parameters.AddWithValue("@id_edificio", edificio);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(contenedor);
                        dataGridView1.DataSource = contenedor;
                        lbl_aviso.Text = "";
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
            }
        }

        //boton  de marcar asistio
        private void iconButton16_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                lbl_aviso.Text = "";
                lbl_aviso.Text = "Escoja un edificio para marcar o quitar asistencia";

            }
            else if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                lbl_aviso.Text = "";
                lbl_aviso.Text = "Asegúrese de que se haya seleccionado un registro";

            }
            else
            {
                string est_asis = "A";
                int id_asistencia = Convert.ToInt32(txt_idasis.Text);
                string id_edificio = txt_edificios.Text;

                con.marcar_asistencia(est_asis, id_asistencia, id_edificio, dataGridView1);
                lbl_aviso.Text = "";
                MessageBox.Show("Asistencia marcada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int id_usuario = int.Parse(txt_usuario.Text);
                String Accion = "Marca de asistencia";

                con.Registro_bitacora(id_usuario, Accion);

            }
        }

        //boton para marcar que no asistio
        private void btn_noasistio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                lbl_aviso.Text = "";
                lbl_aviso.Text = "Escoja un edificio para marcar o quitar asistencia";

            }
            else if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                lbl_aviso.Text = "";
                lbl_aviso.Text = "Asegúrese de que se haya seleccionado un registro";

            }
            else 
            {
                string est_asis = "NA";
                int id_asistencia = Convert.ToInt32(txt_idasis.Text);
                string id_edificio = txt_edificios.Text;

                con.marcar_asistencia(est_asis, id_asistencia, id_edificio, dataGridView1);
                lbl_aviso.Text = "";
                MessageBox.Show("Inasistencia marcada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int id_usuario = int.Parse(txt_usuario.Text);
                String Accion = "Marca de Inasistencia";

                con.Registro_bitacora(id_usuario, Accion);


            }

        }

        private void btn_observacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_edificios.Text))
            {
                lbl_aviso.Text = "";
                lbl_aviso.Text = "Escoja un edificio y seleccione un registro para agregar una observación";

            }
            else if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                lbl_aviso.Text = "";
                lbl_aviso.Text = "Asegúrese de que se haya seleccionado un registro";

            }
            else
            {
                int id_usuario = int.Parse(txt_usuario.Text);

                frmObservacion obsForm = new frmObservacion(this, id_usuario);
                obsForm.ShowDialog();
            }
                
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
        private void panel_btn_edificios_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void txt_idasis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(800, 600);

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
