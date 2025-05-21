using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmDocente : Form
    {
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();
        Validaciones vali = new Validaciones();

        public frmDocente(int numero)
        {
            InitializeComponent();
            txt_usu_docente.Text = numero.ToString();
            m_tabla();
            escondertablas();
        }

        public void m_tabla()
        {
            int id = Convert.ToInt32(txt_usu_docente.Text);
            con.mostrar(id, dataGridView1);
        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_busqueda.Text))
            {
                MessageBox.Show("La busqueda no puede estar vacía");
            }
            else
            {
                if (cmb_filtro.SelectedIndex == -1)
                {
                    MessageBox.Show("Escoja un filtro para iniciar la busqueda");
                }
                else if (cmb_filtro.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(txt_usu_docente.Text);
                    string busqueda = txt_busqueda.Text;

                    con.busqueda_docente_clase(id, busqueda, dataGridView1);

                    txt_busqueda.Clear();
                }
                else if (cmb_filtro.SelectedIndex == 1)
                {
                    DateTime fecha;

                    if (!DateTime.TryParseExact(txt_busqueda.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None, out fecha))
                    {
                        MessageBox.Show("Fecha inválida. Usa el formato yyyy-MM-dd");
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(txt_usu_docente.Text);
                        string busqueda = txt_busqueda.Text;

                        con.busqueda_docente_fecha(id, busqueda, dataGridView1);

                        txt_busqueda.Clear();
                    }


                }
            }

        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            m_tabla();
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_filtro.SelectedIndex == 0)
            {
                vali.solonletras(e);
            }
            
        }

        public void escondertablas()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_busqueda.Clear();
        }
    }
}
