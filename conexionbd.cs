using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Controls;
using MessageBox = System.Windows.Forms.MessageBox;
using OfficeOpenXml;

namespace Proyecto_DesarrolloSoftware
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;
    using System.Windows.Forms;
    using Proyecto_DesarrolloSoftware;

    class clsConexion
    {
        private readonly Cadena cadena = new Cadena();

        public SqlConnection Conectar()
        {
            return cadena.Conectar();
        }

        public static int UsuarioActual = 0;

        public static class SesionActual
        {
            public static int IdUsuario { get; set; }
        }

        public void busqueda_docente_fecha(string busqueda, int id, DataGridView dgv_docente)
        {
            // Usar el método Conectar() en lugar de conexionString
            using (SqlConnection conectar = Conectar())
            {
                conectar.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable contenedor = new DataTable();
                SqlCommand cmd = new SqlCommand("PA_BUSCAR_FECHA_DOCENTE", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", busqueda);
                cmd.Parameters.AddWithValue("@id_docente", id);

                try
                {
                    cmd.ExecuteNonQuery();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(contenedor);
                    dgv_docente.DataSource = contenedor;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            } // La conexión se cierra automáticamente con using
        }

        public void busqueda_docente_clase(string busqueda, int id, DataGridView dgv_docente)
        {
            // Usar el método Conectar() en lugar de conexionString
            using (SqlConnection conectar = Conectar())
            {
                conectar.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable contenedor = new DataTable();
                SqlCommand cmd = new SqlCommand("PA_BUSCAR_CLASE_DOCENTE", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clase", busqueda);
                cmd.Parameters.AddWithValue("@id_docente", id);

                try
                {
                    cmd.ExecuteNonQuery();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(contenedor);
                    dgv_docente.DataSource = contenedor;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            } // La conexión se cierra automáticamente con using
        }

        public void buscar_tabla_decano_clase(String busqueda, int id, DataGridView dgv_decano)
        {
            // Usar el método Conectar() en lugar de conexionString
            using (SqlConnection conectar = Conectar())
            {
                conectar.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable contenedor = new DataTable();
                SqlCommand cmd = new SqlCommand("PA_BUSCAR_DATOS_DECANO", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clase", busqueda);
                cmd.Parameters.AddWithValue("@id_decano", id);

                try
                {
                    cmd.ExecuteNonQuery();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(contenedor);
                    dgv_decano.DataSource = contenedor;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            } // La conexión se cierra automáticamente con using
        }

        public void busqueda_idempleado_admin(string busqueda, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_BUSCAR_ID_CLASE_ADMIN", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_CLASE", busqueda);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void busqueda_nomclase_admin(string busqueda, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_BUSCAR_NOMBRE_CLASE_ADMIN", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom_clase", busqueda);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void busqueda_nombre_admin(string busqueda, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {



                SqlCommand cmd = new SqlCommand("PA_BUSCAR_GESTION_ADMIN", conectar);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", busqueda);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public bool verificaraula(string nueva_aula)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_VERIFICACION_AULA", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_aula", nueva_aula);

                object result = cmd.ExecuteScalar();
                return result != null && Convert.ToInt32(result) == 1;
            }
        }

        public bool verificacionusuario(int id_empleado)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_VERIFICACION_USUARIO", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", id_empleado);

                object result = cmd.ExecuteScalar();
                return result != null && Convert.ToInt32(result) == 1;
            }
        }

        public void mostrar_claseydocentes(DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_MOSTRAR_MODIFICAR_ADMIN", conectar);//admin

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void agregar_usuario(int id_empleado, string nombre, int id_rol,/* string nombre_usuario,*/ string contraseña)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_AGREGAR_EMPLEADO_ADMIN", conectar);// admin
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idEmpleado", id_empleado);
                cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                cmd.Parameters.AddWithValue("@idRol", id_rol);
                //cmd.Parameters.AddWithValue("@NombreUsuario", nombre_usuario); // campo eliminado en la nueva tabla
                cmd.Parameters.AddWithValue("@ContraUsuario", contraseña);

                cmd.ExecuteNonQuery();
            }
        }

        public void mostrar_usuarios_admin(DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_MOSTRAR_GESTION_ADMIN", conectar); //admin

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        

        public void visualizar_decano(int usu_decano, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_MOSTRAR_DATOS_DECANO", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", usu_decano);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void marcar_asistencia(string est_asis, int id_asistencia, string id_edifico, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_MARCAR_ASISTENCIA_SUPERV", conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@estado_asistencia", est_asis);
                cmd.Parameters.AddWithValue("@id_asistencia", id_asistencia);
                cmd.Parameters.AddWithValue("@id_edificio", id_edifico);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void mostrar_edificios(string id_edificio, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_MOSTRAR_EDIFICIOS_SUPERV", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_edificio", id_edificio);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void mostrar_supervisor(int idrol, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_MOSTRAR_DATOS_SUPERV", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_rol", idrol);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void mostrar(int id, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_MOSTRAR_DATOS_DOCENTE", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public string ValidarUsuario(int idUsuario, string contraseña)
        {
            try
            {
                using (SqlConnection conexion = Conectar())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("PA_TIPO_USUARIO_LOGIN", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado.ToString() != "Invalido")
                        {
                            UsuarioActual = idUsuario;

                            using (SqlCommand cmdSetContext = new SqlCommand("EXEC sp_set_session_context @key, @value", conexion))
                            {
                                cmdSetContext.Parameters.AddWithValue("@key", "usuario_id");
                                cmdSetContext.Parameters.AddWithValue("@value", idUsuario);
                                cmdSetContext.ExecuteNonQuery();
                            }

                            return resultado.ToString();
                        }
                        else
                        {
                            return "Invalido";
                        }
                    }
                }
            }
            catch
            {
                return "Error";
            }
        }

        public DataTable ObtenerAsistencias()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = Conectar())
                {
                    SqlCommand cmd = new SqlCommand("PA_MOSTRAR_MATRIZ_ADMIN", conexion); //matriz
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener asistencias: " + ex.Message);
            }

            return dt;
        }

        public void CerrarPeriodo(DateTime fechaFinal)
        {
            try
            {
                using (SqlConnection con = Conectar())
                {
                    con.InfoMessage += (s, ev) =>
                    {
                        MessageBox.Show(ev.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    SqlCommand cmd = new SqlCommand("PA_TABLA_MATRIZ_ADMIN", con);//matriz
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha_Final", fechaFinal);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar periodo: " + ex.Message);
            }
        }

        public int MigrarDatos(DataTable tablaDatos)
        {
            int errores = 0;

            using (SqlConnection conectar = Conectar())
            {
                conectar.Open();
                SqlTransaction transaccion = conectar.BeginTransaction();

                try
                {
                    foreach (DataRow row in tablaDatos.Rows)
                    {
                        try
                        {
                            using (SqlCommand cmdSql = new SqlCommand("PA_MIGRACION_EXCEL_ADMIN", conectar, transaccion))
                            {
                                cmdSql.CommandType = CommandType.StoredProcedure;

                                cmdSql.Parameters.AddWithValue("@idFacultad", row["idFacultad"].ToString());
                                cmdSql.Parameters.AddWithValue("@idClase", row["idClase"].ToString());
                                cmdSql.Parameters.AddWithValue("@seccion", row["Seccion"].ToString());
                                cmdSql.Parameters.AddWithValue("@desc_clases", row["Desc_Clases"].ToString());
                                cmdSql.Parameters.AddWithValue("@idEmpleado", Convert.ToInt32(row["idEmpleado"]));
                                cmdSql.Parameters.AddWithValue("@NuevoNombre_empleados", row["NombreEmpleado"].ToString());
                                cmdSql.Parameters.AddWithValue("@Correo_Usuario_Nuevo", row["Correo"].ToString());
                                cmdSql.Parameters.AddWithValue("@hora_inicio", TimeSpan.Parse(row["Hora_Inicio"].ToString()));
                                cmdSql.Parameters.AddWithValue("@hora_final", TimeSpan.Parse(row["Hora_Final"].ToString()));
                                cmdSql.Parameters.AddWithValue("@idEdificio", row["idEdificio"].ToString());

                                string idAula = row["idAula"].ToString().Trim();
                                if (string.IsNullOrWhiteSpace(idAula))
                                    idAula = "SN";

                                cmdSql.Parameters.AddWithValue("@idAula", idAula);


                                cmdSql.ExecuteNonQuery();
                            }
                        }
                        catch (Exception exFila)
                        {
                            errores++;
                            Console.WriteLine($"Error en la fila: {exFila.Message}");
                            break; // Salimos del foreach al primer error
                        }
                    }

                    if (errores == 0)
                    {
                        transaccion.Commit(); // Todo correcto
                    }
                    else
                    {
                        transaccion.Rollback(); // Hubo error
                    }
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    Console.WriteLine($"Error general durante la migración: {ex.Message}");
                    errores++;
                }
            }

            return errores;
        }


        public DataTable LeerExcel(string rutaArchivo)
        {
            DataTable dt = new DataTable();
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage.License.SetNonCommercialOrganization("Universidad Catolica de Honduras");

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
                dt.Columns.Add("Correo");
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
                    newRow["Correo"] = worksheet.Cells[row, 7].Text.Trim();
                    newRow["Hora_Inicio"] = worksheet.Cells[row, 8].Text.Trim();
                    newRow["Hora_Final"] = worksheet.Cells[row, 9].Text.Trim();
                    newRow["idEdificio"] = worksheet.Cells[row, 10].Text.Trim();
                    newRow["idAula"] = worksheet.Cells[row, 11].Text.Trim();

                    dt.Rows.Add(newRow);
                }
            }

            return dt;
        }

        public DataTable CargarBitacora()
        {
            DataTable tablaBitacora = new DataTable();

            try
            {
                using (SqlConnection conectar = Conectar())
                {
                    conectar.Open();
                    using (SqlCommand comando = new SqlCommand("PA_MOSTRAR_BITA_ADMIN", conectar))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tablaBitacora);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tablaBitacora;
        }

        
        public void FiltrarBitacoraPorUsuario(int idUsuario, DataGridView dgvBitacora)
        {


            try
            {
                using (SqlConnection conectar = Conectar())
                {
                    conectar.Open();
                    using (SqlCommand comando = new SqlCommand("PA_FILTRAR_BITA_ADMIN", conectar))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@idUsuarios", idUsuario);


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);
                        dgvBitacora.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }



}

