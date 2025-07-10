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

        public void MigrarDatos(DataTable tablaDatos)
        {
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
                            if (string.IsNullOrWhiteSpace(idAula)) idAula = "SN";
                            else idAula = Convert.ToInt32(row["idAula"]).ToString(); // convierte a int y luego a string limpio

                            cmdSql.Parameters.AddWithValue("@idAula", idAula);




                            cmdSql.ExecuteNonQuery();
                            Console.WriteLine($"✅ Migración de clase {row["idClase"]} completada correctamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"⚠️ Error en la migración de {row["idClase"]}: " + ex.Message);
                    }
                }
            }
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

        private void btn_AgregarP_Click(object sender, EventArgs e)
        {
            lb_fechaI.Visible = true;
            lb_fechaF.Visible = true;
            lb_descr.Visible = true;

            dtpFechaInicio.Visible = true;
            dtpFechaFinal.Visible = true;
            txtDescripcion.Visible = true;

            btnGuardarP.Visible = true;
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            string descripcionPeriodo = txtDescripcion.Text.Trim();
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFinal.Value.Date;
            int anioActual = DateTime.Now.Year;

            //Validación campos vacíos o fuera del rango del año
            if (string.IsNullOrEmpty(descripcionPeriodo))
            {
                MessageBox.Show("Debes ingresar la descripción del período.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fechaInicio.Year != anioActual || fechaFin.Year != anioActual)
            {
                MessageBox.Show($"Las fechas deben estar dentro del año actual: {anioActual}.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha de fin no puede ser menor que la fecha de inicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan duracion = fechaFin - fechaInicio;
            if (duracion.TotalDays < 30)
            {
                MessageBox.Show("El período debe durar al menos 1 mes (30 días).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario
            DialogResult confirmacion = MessageBox.Show(
                $"¿Estás seguro de que deseas crear el nuevo período '{descripcionPeriodo}' del {fechaInicio:dd/MM/yyyy} al {fechaFin:dd/MM/yyyy}?",
                "Confirmar creación de período",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            // Validaciones sql
            using (SqlConnection conectar = new SqlConnection(server))
            {
                try
                {
                    conectar.Open();

                    // Validar si ya existe un período con esas fechas
                    using (SqlCommand cmdValidar = new SqlCommand("sp_ValidarFechaPeriodo", conectar))
                    {
                        cmdValidar.CommandType = CommandType.StoredProcedure;
                        cmdValidar.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmdValidar.Parameters.AddWithValue("@FechaFinal", fechaFin);

                        int existe = (int)cmdValidar.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("Ya existe un período con esas fechas de inicio o fin.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insertar el nuevo período
                    using (SqlCommand cmdInsertar = new SqlCommand("sp_AgregarPeriodo", conectar))
                    {
                        cmdInsertar.CommandType = CommandType.StoredProcedure;
                        cmdInsertar.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmdInsertar.Parameters.AddWithValue("@FechaFin", fechaFin);
                        cmdInsertar.Parameters.AddWithValue("@Descripcion", descripcionPeriodo);

                        cmdInsertar.ExecuteNonQuery();

                        MessageBox.Show("El período se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnImportar.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el período: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            lb_fechaI.Visible = false;
            lb_fechaF.Visible = false;
            lb_descr.Visible = false;

            dtpFechaInicio.Visible = false;
            dtpFechaFinal.Visible = false;
            txtDescripcion.Visible = false;

            btnGuardarP.Visible = false;
            btn_AgregarP.Enabled = false;
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

                    // Leer datos del Excel
                    DataTable tablaDatos = LeerExcel(rutaArchivo);

                    // Verificar si la tabla tiene datos
                    if (tablaDatos == null || tablaDatos.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron datos en el archivo Excel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dataGridView1.DataSource = tablaDatos;
                    // Insertar datos en la base de datos
                    MigrarDatos(tablaDatos);
                    MessageBox.Show("Migración completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al migrar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
