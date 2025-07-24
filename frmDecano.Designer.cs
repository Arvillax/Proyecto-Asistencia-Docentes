namespace Proyecto_DesarrolloSoftware
{
    partial class frmDecano
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
            this.btn_cierre_sesion = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.dgv_decano = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_observacion = new FontAwesome.Sharp.IconButton();
            this.txt_idasis = new System.Windows.Forms.TextBox();
            this.txt_usu_decano = new System.Windows.Forms.TextBox();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_controles = new System.Windows.Forms.Panel();
            this.btn_minimizar = new FontAwesome.Sharp.IconButton();
            this.btn_maximizar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_decano)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_cierre_sesion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 1053);
            this.panel1.TabIndex = 18;
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
            this.btn_cierre_sesion.Location = new System.Drawing.Point(0, 979);
            this.btn_cierre_sesion.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cierre_sesion.Name = "btn_cierre_sesion";
            this.btn_cierre_sesion.Size = new System.Drawing.Size(428, 74);
            this.btn_cierre_sesion.TabIndex = 55;
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
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 184);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(78)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(153, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1518, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "Justificación de Asistencias";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(186, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Busqueda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(702, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Formato de fecha dd/mm/aa";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_busqueda.Location = new System.Drawing.Point(612, 158);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(6);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(1303, 29);
            this.txt_busqueda.TabIndex = 15;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // dgv_decano
            // 
            this.dgv_decano.AllowUserToAddRows = false;
            this.dgv_decano.AllowUserToDeleteRows = false;
            this.dgv_decano.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_decano.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_decano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_decano.Location = new System.Drawing.Point(472, 298);
            this.dgv_decano.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_decano.Name = "dgv_decano";
            this.dgv_decano.ReadOnly = true;
            this.dgv_decano.RowHeadersWidth = 51;
            this.dgv_decano.Size = new System.Drawing.Size(1540, 663);
            this.dgv_decano.TabIndex = 20;
            this.dgv_decano.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_decano_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.btn_observacion);
            this.groupBox1.Location = new System.Drawing.Point(2050, 298);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(221, 142);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btn_observacion
            // 
            this.btn_observacion.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_observacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_observacion.ForeColor = System.Drawing.Color.Black;
            this.btn_observacion.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btn_observacion.IconColor = System.Drawing.Color.Black;
            this.btn_observacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_observacion.IconSize = 35;
            this.btn_observacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_observacion.Location = new System.Drawing.Point(6, 10);
            this.btn_observacion.Margin = new System.Windows.Forms.Padding(6);
            this.btn_observacion.Name = "btn_observacion";
            this.btn_observacion.Size = new System.Drawing.Size(210, 102);
            this.btn_observacion.TabIndex = 27;
            this.btn_observacion.Text = "Observacion Justificación";
            this.btn_observacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_observacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_observacion.UseVisualStyleBackColor = false;
            this.btn_observacion.Click += new System.EventHandler(this.btn_observacion_Click);
            // 
            // txt_idasis
            // 
            this.txt_idasis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_idasis.Location = new System.Drawing.Point(727, 986);
            this.txt_idasis.Margin = new System.Windows.Forms.Padding(6);
            this.txt_idasis.Name = "txt_idasis";
            this.txt_idasis.ReadOnly = true;
            this.txt_idasis.Size = new System.Drawing.Size(180, 29);
            this.txt_idasis.TabIndex = 23;
            // 
            // txt_usu_decano
            // 
            this.txt_usu_decano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_usu_decano.Location = new System.Drawing.Point(921, 986);
            this.txt_usu_decano.Margin = new System.Windows.Forms.Padding(6);
            this.txt_usu_decano.Name = "txt_usu_decano";
            this.txt_usu_decano.ReadOnly = true;
            this.txt_usu_decano.Size = new System.Drawing.Size(180, 29);
            this.txt_usu_decano.TabIndex = 24;
            this.txt_usu_decano.Visible = false;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "Nombre de clase",
            "Nombre de empleado",
            "Fecha"});
            this.cmb_filtro.Location = new System.Drawing.Point(472, 225);
            this.cmb_filtro.Margin = new System.Windows.Forms.Padding(6);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(218, 32);
            this.cmb_filtro.TabIndex = 59;
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_id.Location = new System.Drawing.Point(468, 990);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(209, 25);
            this.lbl_id.TabIndex = 63;
            this.lbl_id.Text = "Registro seleccionado:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(466, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 72;
            this.label1.Text = "Busqueda:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.panel_controles);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(428, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1866, 110);
            this.panel3.TabIndex = 73;
            // 
            // panel_controles
            // 
            this.panel_controles.BackColor = System.Drawing.Color.Silver;
            this.panel_controles.Controls.Add(this.btn_minimizar);
            this.panel_controles.Controls.Add(this.btn_maximizar);
            this.panel_controles.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_controles.Location = new System.Drawing.Point(1712, 0);
            this.panel_controles.Margin = new System.Windows.Forms.Padding(6);
            this.panel_controles.Name = "panel_controles";
            this.panel_controles.Size = new System.Drawing.Size(154, 110);
            this.panel_controles.TabIndex = 61;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(78)))));
            this.btn_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_minimizar.IconColor = System.Drawing.Color.Black;
            this.btn_minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimizar.IconSize = 20;
            this.btn_minimizar.Location = new System.Drawing.Point(-4, 0);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(77, 110);
            this.btn_minimizar.TabIndex = 62;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(78)))));
            this.btn_maximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.14286F);
            this.btn_maximizar.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.btn_maximizar.IconColor = System.Drawing.Color.Black;
            this.btn_maximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_maximizar.IconSize = 20;
            this.btn_maximizar.Location = new System.Drawing.Point(73, 0);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(81, 110);
            this.btn_maximizar.TabIndex = 61;
            this.btn_maximizar.UseVisualStyleBackColor = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // frmDecano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(2294, 1053);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.txt_usu_decano);
            this.Controls.Add(this.txt_idasis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_decano);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_busqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDecano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDecano_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_decano)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_controles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_usu_decano;
        private FontAwesome.Sharp.IconButton btn_cierre_sesion;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private FontAwesome.Sharp.IconButton btn_observacion;
        public System.Windows.Forms.TextBox txt_idasis;
        public System.Windows.Forms.DataGridView dgv_decano;
        private System.Windows.Forms.Label lbl_id;
        
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_controles;
        private FontAwesome.Sharp.IconButton btn_minimizar;
        private FontAwesome.Sharp.IconButton btn_maximizar;
    }
}