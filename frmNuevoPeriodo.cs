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
    public partial class frmNuevoPeriodo : Form
    {
        clsConexion con = new clsConexion();

        public frmNuevoPeriodo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPeriodoActivoEnCalendario();
        }


        private void btn_AgregarP_Click(object sender, EventArgs e)
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
            using (SqlConnection conectar = con.Conectar())
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

                    // Validar si ya hay un período activo
                    using (SqlCommand cmdActivo = new SqlCommand("sp_PeriodoActivo", conectar))
                    {
                        int periodoActivo = (int)cmdActivo.ExecuteScalar();
                        if (periodoActivo > 0)
                        {
                            MessageBox.Show("Ya hay un período activo. Debe finalizar antes de crear uno nuevo.", "Periodo Activo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Validar si el nuevo período se superpone con otro existente
                    using (SqlCommand cmdSolapado = new SqlCommand("sp_ValidarPeriodoSuperpuesto", conectar))
                    {
                        cmdSolapado.CommandType = CommandType.StoredProcedure;
                        cmdSolapado.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmdSolapado.Parameters.AddWithValue("@FechaFinal", fechaFin);

                        int solapado = (int)cmdSolapado.ExecuteScalar();
                        if (solapado > 0)
                        {
                            MessageBox.Show("El nuevo período se traslapa con uno existente.", "Solapamiento de fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MostrarPeriodoActivoEnCalendario();

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el período: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
                }
            }

        private void MostrarPeriodoActivoEnCalendario()
        {
            using (SqlConnection conectar = con.Conectar())
            {
                try
                {
                    conectar.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_Calendario", conectar))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime fechaInicio = reader.GetDateTime(0);
                                DateTime fechaFinal = reader.GetDateTime(1);

                                
                                monthCalendar1.MinDate = fechaInicio;
                                monthCalendar1.MaxDate = fechaFinal;

                                monthCalendar1.SelectionStart = fechaInicio;
                                monthCalendar1.SelectionEnd = fechaFinal;

                                
                                monthCalendar1.Enabled = true;

                                
                                lblPeriodoActivo.Text = $"Período activo: del {fechaInicio:dd/MM/yyyy} al {fechaFinal:dd/MM/yyyy}";
                            }
                            else
                            {
                                
                                monthCalendar1.Enabled = false;

                                
                                monthCalendar1.SelectionStart = DateTime.Today;
                                monthCalendar1.SelectionEnd = DateTime.Today;

                                
                                lblPeriodoActivo.Text = "No hay período activo actualmente.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el período activo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
