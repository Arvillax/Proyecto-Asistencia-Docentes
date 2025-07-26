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
                            PdfPTable ptable = new PdfPTable(dgv_docente.Columns.Count);
                            ptable.DefaultCell.Padding = 2;
                            ptable.WidthPercentage = 100;
                            ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dgv_docente.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                ptable.AddCell(pCell);

                            }
                            foreach (DataGridViewRow viewRow in dgv_docente.Rows)
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
