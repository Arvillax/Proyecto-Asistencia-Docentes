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
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();

        public frmDecano(int usuario_decano)
        {
            InitializeComponent();
            
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

            con.visualizar_decano(usu_decano, dataGridView1);
            conectar.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idasis.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_justificado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Escoja un registro para marcar la asistencia");
            }
            else
            {
                string est_asis = "R";
                int id_asistencia = Convert.ToInt32(txt_idasis.Text);
                int id_decano = Convert.ToInt32(txt_usu_decano.Text);

                con.marcar_justificacion(est_asis, id_asistencia, id_decano, dataGridView1);
                conectar.Close();
            } 
        }

        private void btn_nojustificado_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_idasis.Text))
            {
                MessageBox.Show("Escoja una registro para marcar la asistencia");
            }
            else 
            {
                string est_asis = "N";
                int id_asistencia = Convert.ToInt32(txt_idasis.Text);
                int id_decano = Convert.ToInt32(txt_usu_decano.Text);

                con.marcar_justificacion(est_asis, id_asistencia, id_decano, dataGridView1);
                conectar.Close();
            }
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
                MessageBox.Show("La busqueda no puede quedar vacia");
            }
            else
            {
                if (cmb_filtro.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un filtro antes de iniciar la busqueda");
                }
                else if(cmb_filtro.SelectedIndex == 0)
                {
                    con.busqueda_decano_clase(id,busqueda,dataGridView1);
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
    }
}
