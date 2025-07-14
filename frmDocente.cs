using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Drawing.Drawing2D;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frmDocente : Form
    {
        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        SqlConnection conectar = new SqlConnection();
        clsConexion con = new clsConexion();
        Validaciones vali = new Validaciones();

        public frmDocente(int numero)
        {
            InitializeComponent();
            txt_usu_docente.Text = numero.ToString();
            m_tabla();
            escondertablas();
        }

        public void m_tabla()
        {
            int id = Convert.ToInt32(txt_usu_docente.Text);

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_v_docente",conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_empleado", id);

            try
            { 
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            con.mostrar(id, dataGridView1);
            conectar.Close();

        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_busqueda.Text))
            {
                MessageBox.Show("La busqueda no puede estar vacía");
            }
            else
            {
                if (cmb_filtro.SelectedIndex == -1)
                {
                    int id = Convert.ToInt32(txt_usu_docente.Text);
                    string busqueda = txt_busqueda.Text;

                    conectar.ConnectionString = server;
                    conectar.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable contenedor = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_bus_docente_clase", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clase", busqueda);
                    cmd.Parameters.AddWithValue("@id_docente", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(contenedor);
                        dataGridView1.DataSource = contenedor;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                    conectar.Close();

                    txt_busqueda.Clear();
                }
                else if (cmb_filtro.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(txt_usu_docente.Text);
                    string busqueda = txt_busqueda.Text;

                    conectar.ConnectionString = server;
                    conectar.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable contenedor = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_bus_docente_clase", conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clase", busqueda);
                    cmd.Parameters.AddWithValue("@id_docente", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(contenedor);
                        dataGridView1.DataSource = contenedor;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                    conectar.Close();

                    txt_busqueda.Clear() ;
                }
                else if (cmb_filtro.SelectedIndex == 1)
                {
                    DateTime fecha;
                    if (!DateTime.TryParseExact(txt_busqueda.Text, "yyyy-MM-dd",
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None, out fecha))
                    {
                        MessageBox.Show("Fecha inválida. Usa el formato yyyy-MM-dd");
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(txt_usu_docente.Text);
                        string busqueda = txt_busqueda.Text;

                        conectar.ConnectionString = server;
                        conectar.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        DataTable contenedor = new DataTable();
                        SqlCommand cmd = new SqlCommand("sp_bus_docente_fecha", conectar);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecha", busqueda);
                        cmd.Parameters.AddWithValue("@id_docente", id);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(contenedor);
                            dataGridView1.DataSource = contenedor;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                            throw;
                        }
                        conectar.Close();

                        txt_busqueda.Clear();
                    }

                    
                }
            }

        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            m_tabla();
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_filtro.SelectedIndex == 0)
            {
                vali.solonletras(e);
            }
            
        }

        public void escondertablas()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_busqueda.Clear();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";

                bool errormessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);

                        }
                        catch (Exception ex)
                        {
                            errormessage = true;
                            MessageBox.Show("No se puedo guardar el archivo" + ex.Message);

                        }
                    }
                    if (!errormessage)
                    {
                        try
                        {
                            PdfPTable ptable = new PdfPTable(dataGridView1.Columns.Count);
                            ptable.DefaultCell.Padding = 2;
                            ptable.WidthPercentage = 100;
                            ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                ptable.AddCell(pCell);

                            }
                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                if (!viewRow.IsNewRow) 
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        ptable.AddCell(dcell.Value != null ? dcell.Value.ToString() : "");
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter writer = PdfWriter.GetInstance(document, fileStream);

                                document.Open();
                                document.Add(ptable);
                                document.Close();
                            }
                            MessageBox.Show("Exportacion exitosa", "info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error al exportar" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("no encontrado","info");
            }
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
