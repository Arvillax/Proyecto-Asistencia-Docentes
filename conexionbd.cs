using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_DesarrolloSoftware
{
    class clsConexion
    {
        private string conexionString = "Server=LAPTOP-U0ITJDJB\\SQLEXPRESS;Database=pruebita;Integrated Security=True;";

        public string ConexionString
        {
            get { return conexionString; }
        }

        protected SqlConnection Conectar()
        {
            return new SqlConnection(conexionString);
        }

      /*  public void agregar_observacion()
        {
            string server = "Data Source = LAPTOP-U0ITJDJB\\SQLEXPRESS; Initial Catalog = pruebita; Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "sp_marcasis " + est_asis + "," + id_asistencia;

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
        }*/

        public void marcar_asistencia(string est_asis,int id_asistencia,int id_edifico, DataGridView grid)
        {
            string server = "Data Source = LAPTOP-U0ITJDJB\\SQLEXPRESS; Initial Catalog = pruebita; Integrated Security=True";
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

        //metodo parav mostrar las semanas en la interfaz del docente
        public void mostrar_semanas(int id_empleado ,int dia, DataGridView grid)
        {
            string server = "Data Source = LAPTOP-U0ITJDJB\\SQLEXPRESS; Initial Catalog = pruebita; Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "exec VerAsistenciaDocente_1 " + id_empleado + "," + dia;
            
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
        public void mostrar_edificios(int id_edificio, DataGridView grid)
        {
            string server = "Data Source = LAPTOP-U0ITJDJB\\SQLEXPRESS; Initial Catalog = pruebita; Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "exec c_edificio " + id_edificio;
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
            string server = "Data Source = LAPTOP-U0ITJDJB\\SQLEXPRESS; Initial Catalog = pruebita; Integrated Security=True";
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
            string server = "Data Source = LAPTOP-U0ITJDJB\\SQLEXPRESS; Initial Catalog = pruebita; Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "exec v_docente " + id;
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
                MessageBox.Show("Error de conexión: " + ex.Message);
                return "Error";
            }
        }

     
    }
}
