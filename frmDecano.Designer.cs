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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDecano));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cierre_sesion = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_observacion = new FontAwesome.Sharp.IconButton();
            this.btn_nojustificado = new FontAwesome.Sharp.IconButton();
            this.btn_justificado = new FontAwesome.Sharp.IconButton();
            this.txt_idasis = new System.Windows.Forms.TextBox();
            this.txt_usu_decano = new System.Windows.Forms.TextBox();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.btn_recargar = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_cierre_sesion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 702);
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
            this.btn_cierre_sesion.Location = new System.Drawing.Point(0, 653);
            this.btn_cierre_sesion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cierre_sesion.Name = "btn_cierre_sesion";
            this.btn_cierre_sesion.Size = new System.Drawing.Size(311, 49);
            this.btn_cierre_sesion.TabIndex = 55;
            this.btn_cierre_sesion.Text = "Cerrar Sesión";
            this.btn_cierre_sesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cierre_sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cierre_sesion.UseVisualStyleBackColor = false;
            this.btn_cierre_sesion.Click += new System.EventHandler(this.btn_cierre_sesion_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 123);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(341, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1321, 28);
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
            this.label2.Location = new System.Drawing.Point(135, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Busqueda:";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_busqueda.Location = new System.Drawing.Point(341, 57);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(1199, 22);
            this.txt_busqueda.TabIndex = 15;
            this.txt_busqueda.Text = "escriba los caracteres para empezar la busqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1285, 442);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.btn_observacion);
            this.groupBox1.Controls.Add(this.btn_nojustificado);
            this.groupBox1.Controls.Add(this.btn_justificado);
            this.groupBox1.Location = new System.Drawing.Point(1649, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(161, 156);
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
            this.btn_observacion.Location = new System.Drawing.Point(5, 81);
            this.btn_observacion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_observacion.Name = "btn_observacion";
            this.btn_observacion.Size = new System.Drawing.Size(153, 68);
            this.btn_observacion.TabIndex = 27;
            this.btn_observacion.Text = "Observacion Justificación";
            this.btn_observacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_observacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_observacion.UseVisualStyleBackColor = false;
            this.btn_observacion.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_nojustificado
            // 
            this.btn_nojustificado.BackColor = System.Drawing.Color.LightCoral;
            this.btn_nojustificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nojustificado.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_nojustificado.IconColor = System.Drawing.Color.Black;
            this.btn_nojustificado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nojustificado.IconSize = 20;
            this.btn_nojustificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nojustificado.Location = new System.Drawing.Point(8, 46);
            this.btn_nojustificado.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nojustificado.Name = "btn_nojustificado";
            this.btn_nojustificado.Size = new System.Drawing.Size(145, 28);
            this.btn_nojustificado.TabIndex = 26;
            this.btn_nojustificado.Text = "No Justificado";
            this.btn_nojustificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nojustificado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nojustificado.UseVisualStyleBackColor = false;
            this.btn_nojustificado.Click += new System.EventHandler(this.btn_nojustificado_Click);
            // 
            // btn_justificado
            // 
            this.btn_justificado.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_justificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_justificado.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_justificado.IconColor = System.Drawing.Color.Black;
            this.btn_justificado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_justificado.IconSize = 20;
            this.btn_justificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_justificado.Location = new System.Drawing.Point(8, 14);
            this.btn_justificado.Margin = new System.Windows.Forms.Padding(4);
            this.btn_justificado.Name = "btn_justificado";
            this.btn_justificado.Size = new System.Drawing.Size(145, 28);
            this.btn_justificado.TabIndex = 25;
            this.btn_justificado.Text = "Justificado";
            this.btn_justificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_justificado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_justificado.UseVisualStyleBackColor = false;
            this.btn_justificado.Click += new System.EventHandler(this.btn_justificado_Click);
            // 
            // txt_idasis
            // 
            this.txt_idasis.Location = new System.Drawing.Point(512, 604);
            this.txt_idasis.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idasis.Name = "txt_idasis";
            this.txt_idasis.ReadOnly = true;
            this.txt_idasis.Size = new System.Drawing.Size(132, 22);
            this.txt_idasis.TabIndex = 23;
            // 
            // txt_usu_decano
            // 
            this.txt_usu_decano.Location = new System.Drawing.Point(512, 636);
            this.txt_usu_decano.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usu_decano.Name = "txt_usu_decano";
            this.txt_usu_decano.ReadOnly = true;
            this.txt_usu_decano.Size = new System.Drawing.Size(132, 22);
            this.txt_usu_decano.TabIndex = 24;
            this.txt_usu_decano.Visible = false;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "nombre de clase"});
            this.cmb_filtro.Location = new System.Drawing.Point(341, 97);
            this.cmb_filtro.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(160, 24);
            this.cmb_filtro.TabIndex = 59;
            // 
            // btn_recargar
            // 
            this.btn_recargar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btn_recargar.IconColor = System.Drawing.Color.Black;
            this.btn_recargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_recargar.IconSize = 20;
            this.btn_recargar.Location = new System.Drawing.Point(1555, 57);
            this.btn_recargar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(31, 28);
            this.btn_recargar.TabIndex = 58;
            this.btn_recargar.UseVisualStyleBackColor = true;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_busqueda.IconColor = System.Drawing.Color.Black;
            this.btn_busqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busqueda.IconSize = 18;
            this.btn_busqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busqueda.Location = new System.Drawing.Point(1593, 57);
            this.btn_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(35, 28);
            this.btn_busqueda.TabIndex = 37;
            this.btn_busqueda.UseVisualStyleBackColor = true;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_id.Location = new System.Drawing.Point(349, 609);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(146, 16);
            this.lbl_id.TabIndex = 63;
            this.lbl_id.Text = "Registro seleccionado:";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.Snow;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimizar.IconSize = 20;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizar.Location = new System.Drawing.Point(1755, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(38, 33);
            this.btnMinimizar.TabIndex = 71;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaximizar.IconColor = System.Drawing.Color.Snow;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximizar.IconSize = 25;
            this.btnMaximizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximizar.Location = new System.Drawing.Point(1790, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(38, 33);
            this.btnMaximizar.TabIndex = 70;
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // frmDecano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1827, 702);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.txt_usu_decano);
            this.Controls.Add(this.txt_idasis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_busqueda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDecano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDecano_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_usu_decano;
        private FontAwesome.Sharp.IconButton btn_cierre_sesion;
        private FontAwesome.Sharp.IconButton btn_nojustificado;
        private FontAwesome.Sharp.IconButton btn_justificado;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private FontAwesome.Sharp.IconButton btn_recargar;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private FontAwesome.Sharp.IconButton btn_observacion;
        public System.Windows.Forms.TextBox txt_idasis;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_id;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
    }
}