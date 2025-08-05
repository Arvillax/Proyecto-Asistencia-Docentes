using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DesarrolloSoftware
{
    public partial class obs_justificacion : Form
    {
        public frmDecano decanoform;
        private clsConexion conexion;

        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();

        public obs_justificacion(frmDecano form, int numero)
        {
            InitializeComponent();
            decanoform = form;
            conexion = new clsConexion();

            txt_usuario.Text = numero.ToString();

        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string observacion = txtObservacion.Text.Trim();
            string idBuscado = decanoform.txt_idasis.Text.Trim(); // Obtener el ID del frmSupervisor

            if (string.IsNullOrEmpty(observacion))
            {
                MessageBox.Show("Debe ingresar una observación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(idBuscado))
            {
                MessageBox.Show("Debe ingresar o seleccionar un ID antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar la fila en el DataGridView con el mismo ID
            bool filaEncontrada = false;
            foreach (DataGridViewRow row in decanoform.dgv_decano.Rows)
            {
                if (row.Cells["id Asistencia"].Value != null && row.Cells["id Asistencia"].Value.ToString() == idBuscado)
                {
                    row.Cells["Justificacion de Asistencia"].Value = observacion; // Guardar la observación y linea de la excepcion
                    filaEncontrada = true;
                    break;
                }
            }

            if (!filaEncontrada)
            {
                MessageBox.Show("El ID ingresado no se encuentra en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar en la base de datos
            using (SqlConnection conectar = con.Conectar())
            {
                conectar.Open();
                using (SqlCommand cmd = new SqlCommand("PA_ACTUALIZAROBSERVACION_JUSTIFICACION", conectar)) //xs
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idBuscado); // Usar el ID del TextBox
                    cmd.Parameters.AddWithValue("@observacion", observacion);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Observación guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int id_usuario = int.Parse(txt_usuario.Text);
            String Accion = "Justificación agregada";

            con.Registro_bitacora(id_usuario, Accion);

            this.Close();
        }
    }
}
