namespace Proyecto_DesarrolloSoftware
{
    partial class frmDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cierre_sesion = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usu_docente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.btn_recargar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_cierre_sesion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 500);
            this.panel1.TabIndex = 13;
            // 
            // btn_cierre_sesion
            // 
            this.btn_cierre_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cierre_sesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cierre_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cierre_sesion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cierre_sesion.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btn_cierre_sesion.IconColor = System.Drawing.Color.Black;
            this.btn_cierre_sesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cierre_sesion.IconSize = 40;
            this.btn_cierre_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cierre_sesion.Location = new System.Drawing.Point(0, 460);
            this.btn_cierre_sesion.Name = "btn_cierre_sesion";
            this.btn_cierre_sesion.Size = new System.Drawing.Size(250, 40);
            this.btn_cierre_sesion.TabIndex = 57;
            this.btn_cierre_sesion.Text = "Cerrar Sesión";
            this.btn_cierre_sesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cierre_sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cierre_sesion.UseVisualStyleBackColor = false;
            this.btn_cierre_sesion.Click += new System.EventHandler(this.btn_cierre_sesion_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 100);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(177, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Busqueda:";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_busqueda.Location = new System.Drawing.Point(335, 48);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(599, 20);
            this.txt_busqueda.TabIndex = 10;
            this.txt_busqueda.Text = "escriba los caracteres para empezar la busqueda";
            this.txt_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busqueda_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(289, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Visualización de Asistencias";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txt_usu_docente
            // 
            this.txt_usu_docente.Enabled = false;
            this.txt_usu_docente.Location = new System.Drawing.Point(289, 468);
            this.txt_usu_docente.Name = "txt_usu_docente";
            this.txt_usu_docente.ReadOnly = true;
            this.txt_usu_docente.Size = new System.Drawing.Size(151, 20);
            this.txt_usu_docente.TabIndex = 15;
            this.txt_usu_docente.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(706, 289);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_busqueda.IconColor = System.Drawing.Color.Black;
            this.btn_busqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busqueda.IconSize = 18;
            this.btn_busqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busqueda.Location = new System.Drawing.Point(969, 46);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(26, 23);
            this.btn_busqueda.TabIndex = 36;
            this.btn_busqueda.UseVisualStyleBackColor = true;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(286, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Buscar:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(286, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Filtrar por:";
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "clase",
            "fecha"});
            this.cmb_filtro.Location = new System.Drawing.Point(341, 91);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_filtro.TabIndex = 39;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // btn_recargar
            // 
            this.btn_recargar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btn_recargar.IconColor = System.Drawing.Color.Black;
            this.btn_recargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_recargar.IconSize = 20;
            this.btn_recargar.Location = new System.Drawing.Point(940, 46);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(23, 23);
            this.btn_recargar.TabIndex = 57;
            this.btn_recargar.UseVisualStyleBackColor = true;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(335, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Ejemplo de Fecha: 2025-04-10";
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1025, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_usu_docente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_busqueda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDocente";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usu_docente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btn_cierre_sesion;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private FontAwesome.Sharp.IconButton btn_recargar;
        private System.Windows.Forms.Label label5;
    }
}