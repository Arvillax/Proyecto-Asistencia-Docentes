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

namespace Proyecto_DesarrolloSoftware
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
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

        public void busqueda_idempleado_admin(string busqueda, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_BUS_IDEMPLEADO_ADMIN", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", busqueda);

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
                SqlCommand cmd = new SqlCommand("PA_BUS_NOMCLASE_ADMIN", conectar);
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
                SqlCommand cmd = new SqlCommand("PA_BUS_NOM_ADMIN", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", busqueda);

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
                SqlCommand cmd = new SqlCommand("sp_MD_Tabla", conectar);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void agregar_usuario(int id_empleado, string nombre, int id_rol, string nombre_usuario, string contraseña)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_Agregar_Empleado_Usuario", conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idEmpleado", id_empleado);
                cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                cmd.Parameters.AddWithValue("@idRol", id_rol);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombre_usuario);
                cmd.Parameters.AddWithValue("@ContraUsuario", contraseña);

                cmd.ExecuteNonQuery();
            }
        }

        public void mostrar_usuarios_admin(DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_GU_Tabla", conectar);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable contenedor = new DataTable();

                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
        }

        public void marcar_justificacion(string est_asis, int id_asistencia, int id_decano, DataGridView grid)
        {
            using (SqlConnection conectar = Conectar())
            {
                SqlCommand cmd = new SqlCommand("PA_MARCAR_JUSTIFICACION_DECANO", conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@estado_asistencia", est_asis);
                cmd.Parameters.AddWithValue("@id_asistencia", id_asistencia);
                cmd.Parameters.AddWithValue("@id_decano", id_decano);

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
                SqlCommand cmd = new SqlCommand("sp_marcasis", conectar);
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
                SqlCommand cmd = new SqlCommand("sp_c_edificio", conectar);
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
                SqlCommand cmd = new SqlCommand("sp_vs", conectar);
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
                SqlCommand cmd = new SqlCommand("sp_v_docente", conectar);
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
                    SqlCommand cmd = new SqlCommand("sp_MostrarAsistenciasMatrizA", conexion);
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

                    SqlCommand cmd = new SqlCommand("sp_MoverAsistenciasAMatriz", con);
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
    }

}

