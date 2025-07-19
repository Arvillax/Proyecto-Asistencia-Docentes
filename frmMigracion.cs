using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using OfficeOpenXml;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmMigracion : Form1
    {
        clsConexion con = new clsConexion();

        public frmMigracion()
        {
            InitializeComponent();
        }



        private void btnMGestion_Click(object sender, EventArgs e)
        {
            frm_Admin_Principal frmGestion = new frm_Admin_Principal();
            frmGestion.Show();
            this.Hide();
        }

        private void btnMdatos_Click(object sender, EventArgs e)
        {
            frmModificacionDoC frmmodiDatos = new frmModificacionDoC();
            frmmodiDatos.Show();
            this.Hide();
        }

        private void btnMCierre_Click(object sender, EventArgs e)
        {
            frmCierre cierre = new frmCierre();
            cierre.Show();
            this.Hide();
        }

        private void btnMMigra_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frm_Admin_Principal frmGestion = new frm_Admin_Principal();
            frmGestion.Show();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            frmModificacionDoC frmmodiDatos = new frmModificacionDoC();
            frmmodiDatos.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frmCierre cierre = new frmCierre();
            cierre.Show();
            this.Hide();
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Archivos de Excel|*.xlsx",
                    Title = "Selecciona el archivo de Excel"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = openFileDialog.FileName;
                    Console.WriteLine($"📂 Archivo seleccionado: {rutaArchivo}");

                    DataTable tablaDatos = con.LeerExcel(rutaArchivo);

                    if (tablaDatos == null || tablaDatos.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron datos en el archivo Excel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int errores = con.MigrarDatos(tablaDatos);

                    if (errores == 0)
                    {
                        dataGridView1.DataSource = tablaDatos;
                        MessageBox.Show("Migración completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrieron errores durante la migración. No se guardó ningún dato. Verifica el archivo Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al migrar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
