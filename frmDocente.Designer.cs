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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_reportes = new FontAwesome.Sharp.IconButton();
            this.btn_asistencias = new FontAwesome.Sharp.IconButton();
            this.btn_cierre_sesion = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usu_docente = new System.Windows.Forms.TextBox();
            this.dgv_docente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_controles = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docente)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_cierre_sesion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 565);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_reportes);
            this.panel3.Controls.Add(this.btn_asistencias);
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 449);
            this.panel3.TabIndex = 58;
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.Khaki;
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_reportes.IconColor = System.Drawing.Color.Black;
            this.btn_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reportes.IconSize = 40;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 40);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_reportes.Size = new System.Drawing.Size(250, 40);
            this.btn_reportes.TabIndex = 58;
            this.btn_reportes.Text = "Exportar a pdf";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_asistencias
            // 
            this.btn_asistencias.BackColor = System.Drawing.Color.Khaki;
            this.btn_asistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_asistencias.FlatAppearance.BorderSize = 0;
            this.btn_asistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asistencias.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_asistencias.IconColor = System.Drawing.Color.Black;
            this.btn_asistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_asistencias.IconSize = 40;
            this.btn_asistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asistencias.Location = new System.Drawing.Point(0, 0);
            this.btn_asistencias.Name = "btn_asistencias";
            this.btn_asistencias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_asistencias.Size = new System.Drawing.Size(250, 40);
            this.btn_asistencias.TabIndex = 57;
            this.btn_asistencias.Text = "Visualiazcion de asistencias";
            this.btn_asistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_asistencias.UseVisualStyleBackColor = false;
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
            this.btn_cierre_sesion.Location = new System.Drawing.Point(0, 525);
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
            this.panel2.BackgroundImage = global::Proyecto_DesarrolloSoftware.Properties.Resources.HorizontalFullColor;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 81);
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
            this.txt_busqueda.Location = new System.Drawing.Point(329, 78);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(664, 20);
            this.txt_busqueda.TabIndex = 10;
            this.txt_busqueda.Text = "escriba los caracteres para empezar la busqueda";
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            this.txt_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busqueda_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(85, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(604, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Visualización de Asistencias";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txt_usu_docente
            // 
            this.txt_usu_docente.Enabled = false;
            this.txt_usu_docente.Location = new System.Drawing.Point(283, 473);
            this.txt_usu_docente.Name = "txt_usu_docente";
            this.txt_usu_docente.ReadOnly = true;
            this.txt_usu_docente.Size = new System.Drawing.Size(151, 20);
            this.txt_usu_docente.TabIndex = 15;
            this.txt_usu_docente.Visible = false;
            // 
            // dgv_docente
            // 
            this.dgv_docente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_docente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_docente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_docente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docente.Location = new System.Drawing.Point(283, 169);
            this.dgv_docente.Name = "dgv_docente";
            this.dgv_docente.ReadOnly = true;
            this.dgv_docente.RowHeadersWidth = 51;
            this.dgv_docente.Size = new System.Drawing.Size(706, 289);
            this.dgv_docente.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(280, 82);
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
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(280, 123);
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
            this.cmb_filtro.Location = new System.Drawing.Point(335, 121);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_filtro.TabIndex = 39;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(329, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Ejemplo de Fecha: 2025-04-10";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.panel_controles);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(250, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(779, 67);
            this.panel4.TabIndex = 59;
            // 
            // panel_controles
            // 
            this.panel_controles.BackColor = System.Drawing.Color.Silver;
            this.panel_controles.Controls.Add(this.iconButton2);
            this.panel_controles.Controls.Add(this.iconButton1);
            this.panel_controles.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_controles.Location = new System.Drawing.Point(695, 0);
            this.panel_controles.Name = "panel_controles";
            this.panel_controles.Size = new System.Drawing.Size(84, 67);
            this.panel_controles.TabIndex = 60;
            this.panel_controles.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_controles_Paint);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Silver;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(-1, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(42, 67);
            this.iconButton2.TabIndex = 62;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Silver;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(41, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 67);
            this.iconButton1.TabIndex = 61;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1029, 565);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_docente);
            this.Controls.Add(this.txt_usu_docente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_busqueda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDocente_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docente)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel_controles.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgv_docente;
        private FontAwesome.Sharp.IconButton btn_cierre_sesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_reportes;
        private FontAwesome.Sharp.IconButton btn_asistencias;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel_controles;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}