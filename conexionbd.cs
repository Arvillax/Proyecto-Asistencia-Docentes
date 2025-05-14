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

namespace Proyecto_DesarrolloSoftware
{
    class clsConexion
    {
        private string conexionString = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        public string ConexionString
        {
            get { return conexionString;}
        }

        public SqlConnection Conectar()
        {
            return new SqlConnection(conexionString);
        }

        public void busqueda_idempleado_admin(string busqueda, DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();

            conectar.ConnectionString = server;
            conectar.Open();


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_bus_idempleado_admin", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_empleado", busqueda);

            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
            conectar.Close();
        }

        public void busqueda_nomclase_admin(string busqueda, DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();

            conectar.ConnectionString = server;
            conectar.Open();


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_bus_nomclase_admin", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom_clase", busqueda);

            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
            conectar.Close();
        }

        public void busqueda_nombre_admin(string busqueda,DataGridView grid)
            {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();

            conectar.ConnectionString = server;
            conectar.Open();
            

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_bus_nom_admin", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", busqueda);

            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor; 
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
            conectar.Close();
        }

        public bool verificaraula(string nueva_aula)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();

            conectar.ConnectionString = server;
            conectar.Open();
            string query = "sp_veri_aula " + nueva_aula;


            SqlCommand cmd = new SqlCommand("sp_veri_aula", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_aula", nueva_aula);


            object result = cmd.ExecuteScalar();

            conectar.Close();

            return result != null && Convert.ToInt32(result) == 1;
        }

        //metodo para verificar si un usuario existe
        public bool verificacionusuario(int id_empleado)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();
            
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "sp_veri_usu " + id_empleado;


            SqlCommand cmd = new SqlCommand("sp_veri_usu", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", id_empleado);


            object result = cmd.ExecuteScalar();
           
            conectar.Close();

            return result != null && Convert.ToInt32(result) == 1;
        }


        public void mostrar_claseydocentes(DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "sp_MD_Tabla ";

            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
        }

        public void agregar_usuario(int id_empleado ,string nombre,int id_rol,string nombre_usuario,string contraseña)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();

            conectar.ConnectionString = server;
            conectar.Open();


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_Agregar_Empleado_Usuario", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idEmpleado", id_empleado);
            cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
            cmd.Parameters.AddWithValue("@idRol", id_rol);
            cmd.Parameters.AddWithValue("@NombreUsuario", nombre_usuario);
            cmd.Parameters.AddWithValue("@ContraUsuario", contraseña);

            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
            conectar.Close();
        }

        //(funciona asi)
        public void mostrar_usuarios_admin(DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "sp_GU_Tabla ";

            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
        }

        public void marcar_justificacion(string est_asis, int id_asistencia, int id_decano, DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "sp_justificacion " + est_asis + "," + id_asistencia + "," + id_decano ;

            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
        }

        public void visualizar_decano(int usu_decano, DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "sp_mos_decano " + usu_decano;

            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }

        }

      
        

        public void marcar_asistencia(string est_asis,int id_asistencia,string id_edifico, DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "sp_marcasis " + est_asis + "," + id_asistencia + ',' + id_edifico;

            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
        }

       

        //metodo para mostrar los edificios del supervisor
        public void mostrar_edificios(string id_edificio, DataGridView grid)
        {
            string server = conexionString;
            
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "exec sp_c_edificio " + id_edificio;
            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
        }

        //metedo por el que el supervisor visualizara el datagrid view al momento de ingresar al sistema
        public void mostrar_supervisor(int idrol, DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "exec sp_vs " +idrol;
            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
        }

        // metodo para mostrar las interfaces de los docentes dependiendo de que usuario entro al sistema
        public void mostrar(int id,DataGridView grid)
        {
            string server = conexionString;
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "exec sp_v_docente " + id;
            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.ToString());
                throw;
            }
        }

        // Método para validar usuario usando el procedimiento almacenado
        public string ValidarUsuario(int idUsuario, string contraseña)
        {
            try
            {
                using (SqlConnection conexion = Conectar())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        object resultado = cmd.ExecuteScalar();
                        return resultado != null ? resultado.ToString() : "Invalido";
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de conexión: " + ex.Message);
                return "Error";
            }
        }

        public DataTable ObtenerAsistencias(int idPeriodo)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_MostrarAsistenciasMatrizA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPeriodo", idPeriodo);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar asistencias: " + ex.Message);
            }

            return dt;
        }


    }
}

