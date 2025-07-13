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
using OfficeOpenXml;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmMigracion : Form
    {
        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        SqlConnection conectar = new SqlConnection();

        public frmMigracion()
        {
            InitializeComponent();
        }



        private void btnMGestion_Click(object sender, EventArgs e)
        {
            Admin frmGestion = new Admin();
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
            Admin frmGestion = new Admin();
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

        public int MigrarDatos(DataTable tablaDatos)
        {
            int errores = 0;

            using (SqlConnection conectar = new SqlConnection(server))
            {
                conectar.Open();
                foreach (DataRow row in tablaDatos.Rows)
                {
                    try
                    {
                        using (SqlCommand cmdSql = new SqlCommand("sp_Migracion_Excel", conectar))
                        {
                            cmdSql.CommandType = CommandType.StoredProcedure;

                            cmdSql.Parameters.AddWithValue("@idFacultad", row["idFacultad"].ToString());
                            cmdSql.Parameters.AddWithValue("@idClase", row["idClase"].ToString());
                            cmdSql.Parameters.AddWithValue("@seccion", row["Seccion"].ToString());
                            cmdSql.Parameters.AddWithValue("@desc_clases", row["Desc_Clases"].ToString());
                            cmdSql.Parameters.AddWithValue("@idEmpleado", Convert.ToInt32(row["idEmpleado"]));
                            cmdSql.Parameters.AddWithValue("@NuevoNombre_empleados", row["NombreEmpleado"].ToString());
                            cmdSql.Parameters.AddWithValue("@hora_inicio", TimeSpan.Parse(row["Hora_Inicio"].ToString()));
                            cmdSql.Parameters.AddWithValue("@hora_final", TimeSpan.Parse(row["Hora_Final"].ToString()));
                            cmdSql.Parameters.AddWithValue("@idEdificio", row["idEdificio"].ToString());

                            string idAula = row["idAula"].ToString().Trim();
                            if (string.IsNullOrWhiteSpace(idAula))
                                idAula = "SN";
                            else
                                idAula = Convert.ToInt32(row["idAula"]).ToString();

                            cmdSql.Parameters.AddWithValue("@idAula", idAula);

                            cmdSql.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        errores++;
                        Console.WriteLine($"⚠️ Error en la fila: {ex.Message}");
                    }
                }
            }

            return errores;
        }



        static DataTable LeerExcel(string rutaArchivo)
        {
            DataTable dt = new DataTable();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(new FileInfo(rutaArchivo)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                if (worksheet == null)
                    throw new Exception("No se encontró ninguna hoja en el archivo Excel.");


                dt.Columns.Add("idFacultad");
                dt.Columns.Add("idClase");
                dt.Columns.Add("Seccion");
                dt.Columns.Add("Desc_Clases");
                dt.Columns.Add("idEmpleado");
                dt.Columns.Add("NombreEmpleado");
                dt.Columns.Add("Hora_Inicio");
                dt.Columns.Add("Hora_Final");
                dt.Columns.Add("idEdificio");
                dt.Columns.Add("idAula");

                int totalFilas = worksheet.Dimension.End.Row;

                for (int row = 2; row <= totalFilas; row++)
                {

                    bool filaVacia = true;
                    for (int col = 1; col <= 10; col++)
                    {
                        if (!string.IsNullOrWhiteSpace(worksheet.Cells[row, col].Text))
                        {
                            filaVacia = false;
                            break;
                        }
                    }

                    if (filaVacia)
                        continue;


                    DataRow newRow = dt.NewRow();
                    newRow["idFacultad"] = worksheet.Cells[row, 1].Text.Trim();
                    newRow["idClase"] = worksheet.Cells[row, 2].Text.Trim();
                    newRow["Seccion"] = worksheet.Cells[row, 3].Text.Trim();
                    newRow["Desc_Clases"] = worksheet.Cells[row, 4].Text.Trim();
                    newRow["idEmpleado"] = worksheet.Cells[row, 5].Text.Trim();
                    newRow["NombreEmpleado"] = worksheet.Cells[row, 6].Text.Trim();
                    newRow["Hora_Inicio"] = worksheet.Cells[row, 7].Text.Trim();
                    newRow["Hora_Final"] = worksheet.Cells[row, 8].Text.Trim();
                    newRow["idEdificio"] = worksheet.Cells[row, 9].Text.Trim();
                    newRow["idAula"] = worksheet.Cells[row, 10].Text.Trim();

                    dt.Rows.Add(newRow);
                }
            }

            return dt;
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

                    DataTable tablaDatos = LeerExcel(rutaArchivo);

                    if (tablaDatos == null || tablaDatos.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron datos en el archivo Excel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int errores = MigrarDatos(tablaDatos);

                    if (errores == 0)
                    {
                        dataGridView1.DataSource = tablaDatos;
                        MessageBox.Show("Migración completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"La migración se completó con {errores} errores. Verifica el Excel antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
