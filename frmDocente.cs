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
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.IO;
using System.Drawing.Drawing2D;
using System.Windows.Media;
using Column = MigraDoc.DocumentObjectModel.Tables.Column;
using Colors = MigraDoc.DocumentObjectModel.Colors;

namespace Proyecto_DesarrolloSoftware
{
    //
    public partial class frmDocente : Form
    {
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

            con.mostrar(id, dgv_docente);
        }

        private void btn_cierre_sesion_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            frmLogin.Show();
            this.Close();
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
            dgv_docente.Columns[0].Visible = false;
            dgv_docente.Columns[1].Visible = false;
        }

        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_busqueda.Clear();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            if (dgv_docente.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"Reporte de Asistencias - {DateTime.Now:dd-MM-yyyy}.pdf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Crear el documento
                        Document document = new Document();
                        Section section = document.AddSection();
                        section.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;

                        // Título del reporte
                        Paragraph title = section.AddParagraph("Reporte de Docentes");
                        title.Format.Font.Size = 14;
                        title.Format.Font.Bold = true;
                        title.Format.SpaceAfter = 10;
                        title.Format.Alignment = ParagraphAlignment.Center;

                        // Crear tabla
                        Table table = new Table();
                        table.Borders.Width = 0.75;
                        table.Format.Font.Size = 8; // Tamaño más pequeño para que todo quepa

                        // Calcular ancho dinámico de columna
                        double anchoDisponible = 27.0; // A4 landscape útil en cm
                        double anchoColumna = anchoDisponible / dgv_docente.Columns.Count;

                        // Crear columnas con ancho calculado
                        foreach (DataGridViewColumn col in dgv_docente.Columns)
                        {
                            Column column = table.AddColumn(Unit.FromCentimeter(anchoColumna));
                            column.Format.Alignment = ParagraphAlignment.Left;
                        }

                        // Encabezado de tabla
                        Row headerRow = table.AddRow();
                        headerRow.Shading.Color = Colors.LightGray;
                        headerRow.Format.Font.Bold = true;
                        headerRow.HeadingFormat = true;
                        for (int i = 0; i < dgv_docente.Columns.Count; i++)
                        {
                            headerRow.Cells[i].AddParagraph(dgv_docente.Columns[i].HeaderText);
                        }

                        // Filas de datos
                        foreach (DataGridViewRow dgvRow in dgv_docente.Rows)
                        {
                            if (!dgvRow.IsNewRow)
                            {
                                Row row = table.AddRow();
                                for (int i = 0; i < dgv_docente.Columns.Count; i++)
                                {
                                    string value = dgvRow.Cells[i].Value?.ToString() ?? "";
                                    row.Cells[i].AddParagraph(value);
                                }
                            }
                        }

                        // Agregar tabla al documento
                        section.Add(table);

                        // Crear y guardar PDF
                        PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                        renderer.Document = document;
                        renderer.RenderDocument();
                        renderer.PdfDocument.Save(save.FileName);

                        MessageBox.Show("Exportación exitosa", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_usu_docente.Text);
            string busqueda = txt_busqueda.Text;

            if (cmb_filtro.SelectedIndex == -1)
            {
                

                con.busqueda_docente_clase(busqueda,id,dgv_docente);
            }
            else if (cmb_filtro.SelectedIndex == 0)
            {

                con.busqueda_docente_clase(busqueda, id, dgv_docente);

            }
            else if (cmb_filtro.SelectedIndex == 1)
            {
                DateTime fecha;
                if (!DateTime.TryParseExact(txt_busqueda.Text, "yyyy-MM-dd",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out fecha))
                {
                    m_tabla();
                }
                else
                {
                    con.busqueda_docente_fecha(busqueda, id, dgv_docente);

                   
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_controles_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
