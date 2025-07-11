namespace Proyecto_DesarrolloSoftware
{
    partial class frmGestion_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestion_Usuarios));
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_permiso = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_permiso = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txtpermiso = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guardarc = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.btn_recargar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_modificard = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(132, 61);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(829, 26);
            this.txt_busqueda.TabIndex = 13;
            this.txt_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busqueda_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 380);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmb_permiso
            // 
            this.cmb_permiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_permiso.FormattingEnabled = true;
            this.cmb_permiso.Items.AddRange(new object[] {
            "SUPERVISOR",
            "ADMINISTRADOR",
            "DECANO"});
            this.cmb_permiso.Location = new System.Drawing.Point(197, 89);
            this.cmb_permiso.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_permiso.Name = "cmb_permiso";
            this.cmb_permiso.Size = new System.Drawing.Size(236, 24);
            this.cmb_permiso.TabIndex = 46;
            this.cmb_permiso.SelectedIndexChanged += new System.EventHandler(this.cmb_permiso_SelectedIndexChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombre.Location = new System.Drawing.Point(4, 62);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(147, 16);
            this.lbl_nombre.TabIndex = 45;
            this.lbl_nombre.Text = "Nombre del Empleado:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(197, 56);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(236, 22);
            this.txt_nombre.TabIndex = 44;
            // 
            // lbl_permiso
            // 
            this.lbl_permiso.AutoSize = true;
            this.lbl_permiso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_permiso.Location = new System.Drawing.Point(4, 97);
            this.lbl_permiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_permiso.Name = "lbl_permiso";
            this.lbl_permiso.Size = new System.Drawing.Size(148, 16);
            this.lbl_permiso.TabIndex = 40;
            this.lbl_permiso.Text = "Permiso del Empleado:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_id.Location = new System.Drawing.Point(4, 26);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(111, 16);
            this.lbl_id.TabIndex = 39;
            this.lbl_id.Text = "ID del Empleado:";
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(197, 20);
            this.txt_idempleado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.ReadOnly = true;
            this.txt_idempleado.Size = new System.Drawing.Size(236, 22);
            this.txt_idempleado.TabIndex = 36;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_estado.Location = new System.Drawing.Point(4, 129);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(141, 16);
            this.lbl_estado.TabIndex = 48;
            this.lbl_estado.Text = "Estado del Empleado:";
            // 
            // cmb_estado
            // 
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmb_estado.Location = new System.Drawing.Point(197, 128);
            this.cmb_estado.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(236, 24);
            this.cmb_estado.TabIndex = 49;
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.cmb_estado_SelectedIndexChanged);
            // 
            // txtpermiso
            // 
            this.txtpermiso.Location = new System.Drawing.Point(123, 270);
            this.txtpermiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtpermiso.Name = "txtpermiso";
            this.txtpermiso.Size = new System.Drawing.Size(132, 22);
            this.txtpermiso.TabIndex = 54;
            this.txtpermiso.Visible = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(281, 270);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(132, 22);
            this.txt_estado.TabIndex = 55;
            this.txt_estado.Visible = false;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "ID de Empleado",
            "Nombre de Empleado"});
            this.cmb_filtro.Location = new System.Drawing.Point(132, 99);
            this.cmb_filtro.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(295, 24);
            this.cmb_filtro.TabIndex = 60;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(43, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Filtrar por:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.txt_idempleado);
            this.panel1.Controls.Add(this.lbl_permiso);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.txt_estado);
            this.panel1.Controls.Add(this.cmb_permiso);
            this.panel1.Controls.Add(this.txtpermiso);
            this.panel1.Controls.Add(this.lbl_estado);
            this.panel1.Controls.Add(this.btn_guardarc);
            this.panel1.Controls.Add(this.cmb_estado);
            this.panel1.Location = new System.Drawing.Point(1206, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 377);
            this.panel1.TabIndex = 62;
            // 
            // btn_guardarc
            // 
            this.btn_guardarc.BackColor = System.Drawing.Color.Purple;
            this.btn_guardarc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_guardarc.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_guardarc.IconColor = System.Drawing.Color.Black;
            this.btn_guardarc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardarc.IconSize = 25;
            this.btn_guardarc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardarc.Location = new System.Drawing.Point(268, 174);
            this.btn_guardarc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardarc.Name = "btn_guardarc";
            this.btn_guardarc.Size = new System.Drawing.Size(165, 37);
            this.btn_guardarc.TabIndex = 53;
            this.btn_guardarc.Text = "Guardar Cambios";
            this.btn_guardarc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardarc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardarc.UseVisualStyleBackColor = false;
            this.btn_guardarc.Click += new System.EventHandler(this.btn_guardarc_Click);
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_busqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_busqueda.IconColor = System.Drawing.Color.Black;
            this.btn_busqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busqueda.IconSize = 18;
            this.btn_busqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busqueda.Location = new System.Drawing.Point(1042, 62);
            this.btn_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(49, 28);
            this.btn_busqueda.TabIndex = 59;
            this.btn_busqueda.UseVisualStyleBackColor = true;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // btn_recargar
            // 
            this.btn_recargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recargar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btn_recargar.IconColor = System.Drawing.Color.Black;
            this.btn_recargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_recargar.IconSize = 20;
            this.btn_recargar.Location = new System.Drawing.Point(985, 62);
            this.btn_recargar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(49, 28);
            this.btn_recargar.TabIndex = 56;
            this.btn_recargar.UseVisualStyleBackColor = true;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(999, 542);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(147, 37);
            this.iconButton1.TabIndex = 52;
            this.iconButton1.Text = "Agregar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_2);
            // 
            // btn_modificard
            // 
            this.btn_modificard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_modificard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificard.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btn_modificard.IconColor = System.Drawing.Color.Black;
            this.btn_modificard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_modificard.IconSize = 25;
            this.btn_modificard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificard.Location = new System.Drawing.Point(829, 542);
            this.btn_modificard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modificard.Name = "btn_modificard";
            this.btn_modificard.Size = new System.Drawing.Size(147, 37);
            this.btn_modificard.TabIndex = 51;
            this.btn_modificard.Text = "Modificar";
            this.btn_modificard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificard.UseVisualStyleBackColor = false;
            this.btn_modificard.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Búscar:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(559, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestión de Usuarios";
            // 
            // frmGestion_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1656, 644);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_modificard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestion_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_permiso;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_permiso;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cmb_estado;
        private FontAwesome.Sharp.IconButton btn_modificard;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_guardarc;
        private System.Windows.Forms.TextBox txtpermiso;
        private System.Windows.Forms.TextBox txt_estado;
        private FontAwesome.Sharp.IconButton btn_recargar;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}