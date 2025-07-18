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
        
        clsConexion con = new clsConexion();

        public frmDecano(int usuario_decano)
        {
            InitializeComponent();
            
            txt_usu_decano.Text = usuario_decano.ToString();
            mtabla_decano();
            escondertablas();
            btnMaximizar.Text = "🗖";

        }

        public void escondertablas()
        {
            dgv_decano.Columns[0].Visible = false;
        }

        public void mtabla_decano()
        {
            int usu_decano = Convert.ToInt32(txt_usu_decano.Text);
            con.visualizar_decano(usu_decano, dgv_decano);
            
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_justificado_Click(object sender, EventArgs e)
        {
           

            
        }

        private void btn_nojustificado_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_observacion_Click(object sender, EventArgs e)
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

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_usu_decano.Text);
            string busqueda = txt_busqueda.Text;

            if (cmb_filtro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro antes de iniciar la busqueda");
            }
            else if (cmb_filtro.SelectedIndex == 0)
            {
                con.buscar_tabla_decano_clase(busqueda,id,dgv_decano);
            }
        }

        private void dgv_decano_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_decano.Rows[e.RowIndex];

                txt_idasis.Text = fila.Cells[1].Value?.ToString() ?? "";
            }
        }
    }
}
