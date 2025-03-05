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
    public partial class frmObservacion: Form
    {
        private frmSupervisor supervisorForm;
        private clsConexion conexion;
        public frmObservacion(frmSupervisor form)
        {
            InitializeComponent();
            supervisorForm = form;
            conexion = new clsConexion();
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string observacion = txtObservacion.Text.Trim();
            string idBuscado = supervisorForm.txt_idasis.Text.Trim(); // Obtener el ID del frmSupervisor

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
            foreach (DataGridViewRow row in supervisorForm.dataGridView1.Rows)
            {
                if (row.Cells["idAsistencia"].Value != null && row.Cells["idAsistencia"].Value.ToString() == idBuscado)
                {
                    row.Cells["Observaciones"].Value = observacion; // Guardar la observación
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
            using (SqlConnection conn = new SqlConnection(conexion.ConexionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarObservacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idBuscado); // Usar el ID del TextBox
                    cmd.Parameters.AddWithValue("@observacion", observacion);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Observación guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
