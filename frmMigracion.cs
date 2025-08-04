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
    public partial class frmMigracion : Form
    {
        clsConexion con = new clsConexion();

        public frmMigracion()
        {
            InitializeComponent();
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

        private void frmMigracion_Load(object sender, EventArgs e)
        {

        }
    }
}
