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

        protected SqlConnection Conectar()
        {
            return new SqlConnection(conexionString);
        }

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
