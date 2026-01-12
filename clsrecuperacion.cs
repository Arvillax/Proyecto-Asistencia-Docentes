using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DesarrolloSoftware
{
    class clsrecuperacion: clsConexion
    {
        private MemoryCache cache = MemoryCache.Default;

        public bool ValidarUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection con = Conectar())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_VU", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar usuario: " + ex.Message);
                return false;
            }
        }

        public string GenerarCodigo(int idUsuario)
        {
            try
            {
                Random rand = new Random();
                string codigo = rand.Next(100000, 999999).ToString();

                using (SqlConnection con = Conectar())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GCodigo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.ExecuteNonQuery();
                }

                cache.Set(idUsuario.ToString(), codigo, DateTimeOffset.Now.AddMinutes(10));
                return codigo;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al generar el código: " + ex.Message);
                return null;
            }
        }

        public bool ValidarCodigo(int idUsuario, string codigoIngresado)
        {
            string codigoGuardado = cache.Get(idUsuario.ToString()) as string;

            return codigoGuardado != null && codigoGuardado == codigoIngresado;
        }

        public bool CambiarContraseña(int idUsuario, string nuevaContraseña)
        {


            try
            {
                using (SqlConnection con = Conectar())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_CContraseña", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@NuevaContra", nuevaContraseña);

                    // Agregamos el parámetro OUTPUT
                    SqlParameter resultado = new SqlParameter("@Resultado", SqlDbType.Int);
                    resultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultado);

                    cmd.ExecuteNonQuery();  // Ejecutamos el procedimiento

                    int filasAfectadas = (int)cmd.Parameters["@Resultado"].Value;  // Leemos el valor del parámetro OUTPUT

                    // Verificamos si se afectaron filas
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Contraseña cambiada con éxito.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la contraseña: " + ex.Message);
                return false;
            }
        }

        public async Task EnviarCorreoAsync(string codigo)
        {
            try
            {
                var client = new SendGridClient("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");
                var from = new EmailAddress("administracion@ditechonduras.com", "Administracion");
                var subject = "Código de recuperación";
                var to = new EmailAddress("arvillax05@gmail.com", "Usuario");
                var plainTextContent = "El código de recuperación es: " + codigo;
                var htmlContent = "<strong>El código de recuperación es: " + codigo + "</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("Correo enviado con éxito.");
                }
                else
                {
                    Console.WriteLine($"Error al enviar el correo: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}

