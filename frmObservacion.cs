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
    public partial class frmObservacion : Form
    {
        private readonly frmSupervisor supervisorForm;
        clsConexion con = new clsConexion();

        public frmObservacion(frmSupervisor form)
        {
            InitializeComponent();
            supervisorForm = form;
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string observacion = txtObservacion.Text.Trim();
            string idBuscado = supervisorForm.txt_idasis.Text.Trim();

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

            bool filaEncontrada = false;
            foreach (DataGridViewRow row in supervisorForm.dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == idBuscado)
                {
                    row.Cells[12].Value = observacion;
                    filaEncontrada = true;
                    break;
                }
            }

            if (!filaEncontrada)
            {
                MessageBox.Show("El ID ingresado no se encuentra en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conectar = con.Conectar())
            {
                conectar.Open();
               
                SqlCommand cmd = new SqlCommand("PA_AGREGAR_OBS_SUPERV", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idBuscado);
                cmd.Parameters.AddWithValue("@observacion", observacion);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Observación guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void lbObservacion_Click(object sender, EventArgs e)
        {
            // Opcional
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            // Opcional
        }
    }

}
