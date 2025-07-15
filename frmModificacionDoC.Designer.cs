namespace Proyecto_DesarrolloSoftware
{
    partial class frmModificacionDoC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionDoC));
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modificard = new FontAwesome.Sharp.IconButton();
            this.btn_concambios = new FontAwesome.Sharp.IconButton();
            this.txt_horafinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_estadoclase = new System.Windows.Forms.TextBox();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nuevahora = new System.Windows.Forms.TextBox();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.txt_nuevaula = new System.Windows.Forms.TextBox();
            this.txt_idclase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pan_modificardatos = new System.Windows.Forms.Panel();
            this.txt_existencia_usuario = new System.Windows.Forms.TextBox();
            this.txt_existencia_aula = new System.Windows.Forms.TextBox();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pan_modificardatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(138, 64);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(594, 23);
            this.txt_busqueda.TabIndex = 19;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            this.txt_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busqueda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(70, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Buscar:";
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
            this.label1.Location = new System.Drawing.Point(416, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modificación de Datos";
            // 
            // btn_modificard
            // 
            this.btn_modificard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_modificard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_modificard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificard.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btn_modificard.IconColor = System.Drawing.Color.Black;
            this.btn_modificard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_modificard.IconSize = 25;
            this.btn_modificard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificard.Location = new System.Drawing.Point(74, 440);
            this.btn_modificard.Name = "btn_modificard";
            this.btn_modificard.Size = new System.Drawing.Size(135, 30);
            this.btn_modificard.TabIndex = 58;
            this.btn_modificard.Text = "Modificar";
            this.btn_modificard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificard.UseVisualStyleBackColor = false;
            this.btn_modificard.Click += new System.EventHandler(this.btn_modificard_Click);
            // 
            // btn_concambios
            // 
            this.btn_concambios.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_concambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_concambios.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_concambios.IconColor = System.Drawing.Color.Black;
            this.btn_concambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_concambios.IconSize = 30;
            this.btn_concambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_concambios.Location = new System.Drawing.Point(192, 210);
            this.btn_concambios.Name = "btn_concambios";
            this.btn_concambios.Size = new System.Drawing.Size(135, 33);
            this.btn_concambios.TabIndex = 74;
            this.btn_concambios.Text = "Confirmar Cambios";
            this.btn_concambios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_concambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_concambios.UseVisualStyleBackColor = false;
            this.btn_concambios.Click += new System.EventHandler(this.btn_concambios_Click);
            // 
            // txt_horafinal
            // 
            this.txt_horafinal.Location = new System.Drawing.Point(109, 142);
            this.txt_horafinal.Name = "txt_horafinal";
            this.txt_horafinal.Size = new System.Drawing.Size(187, 20);
            this.txt_horafinal.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(16, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Hora Final:";
            // 
            // txt_estadoclase
            // 
            this.txt_estadoclase.Location = new System.Drawing.Point(20, 187);
            this.txt_estadoclase.Name = "txt_estadoclase";
            this.txt_estadoclase.ReadOnly = true;
            this.txt_estadoclase.Size = new System.Drawing.Size(100, 20);
            this.txt_estadoclase.TabIndex = 71;
            this.txt_estadoclase.Visible = false;
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmb_estado.Location = new System.Drawing.Point(109, 89);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(187, 21);
            this.cmb_estado.TabIndex = 70;
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.cmb_estado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Ejemplo: 08:30";
            // 
            // txt_nuevahora
            // 
            this.txt_nuevahora.Location = new System.Drawing.Point(109, 116);
            this.txt_nuevahora.Name = "txt_nuevahora";
            this.txt_nuevahora.Size = new System.Drawing.Size(187, 20);
            this.txt_nuevahora.TabIndex = 68;
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(109, 63);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(187, 20);
            this.txt_idempleado.TabIndex = 67;
            // 
            // txt_nuevaula
            // 
            this.txt_nuevaula.Location = new System.Drawing.Point(109, 36);
            this.txt_nuevaula.Name = "txt_nuevaula";
            this.txt_nuevaula.Size = new System.Drawing.Size(187, 20);
            this.txt_nuevaula.TabIndex = 66;
            // 
            // txt_idclase
            // 
            this.txt_idclase.Location = new System.Drawing.Point(109, 10);
            this.txt_idclase.Name = "txt_idclase";
            this.txt_idclase.ReadOnly = true;
            this.txt_idclase.Size = new System.Drawing.Size(187, 20);
            this.txt_idclase.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Hora Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nuevo Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Id Empleado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(16, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Nueva Aula:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(17, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Id Clase:";
            // 
            // pan_modificardatos
            // 
            this.pan_modificardatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_modificardatos.Controls.Add(this.txt_existencia_usuario);
            this.pan_modificardatos.Controls.Add(this.txt_existencia_aula);
            this.pan_modificardatos.Controls.Add(this.txt_nuevaula);
            this.pan_modificardatos.Controls.Add(this.btn_concambios);
            this.pan_modificardatos.Controls.Add(this.label9);
            this.pan_modificardatos.Controls.Add(this.txt_horafinal);
            this.pan_modificardatos.Controls.Add(this.label8);
            this.pan_modificardatos.Controls.Add(this.label7);
            this.pan_modificardatos.Controls.Add(this.label3);
            this.pan_modificardatos.Controls.Add(this.txt_estadoclase);
            this.pan_modificardatos.Controls.Add(this.label4);
            this.pan_modificardatos.Controls.Add(this.cmb_estado);
            this.pan_modificardatos.Controls.Add(this.label5);
            this.pan_modificardatos.Controls.Add(this.label6);
            this.pan_modificardatos.Controls.Add(this.txt_idclase);
            this.pan_modificardatos.Controls.Add(this.txt_nuevahora);
            this.pan_modificardatos.Controls.Add(this.txt_idempleado);
            this.pan_modificardatos.Location = new System.Drawing.Point(758, 124);
            this.pan_modificardatos.Name = "pan_modificardatos";
            this.pan_modificardatos.Size = new System.Drawing.Size(333, 263);
            this.pan_modificardatos.TabIndex = 75;
            // 
            // txt_existencia_usuario
            // 
            this.txt_existencia_usuario.Location = new System.Drawing.Point(20, 233);
            this.txt_existencia_usuario.Name = "txt_existencia_usuario";
            this.txt_existencia_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_existencia_usuario.TabIndex = 76;
            this.txt_existencia_usuario.Visible = false;
            // 
            // txt_existencia_aula
            // 
            this.txt_existencia_aula.Location = new System.Drawing.Point(20, 210);
            this.txt_existencia_aula.Name = "txt_existencia_aula";
            this.txt_existencia_aula.Size = new System.Drawing.Size(100, 20);
            this.txt_existencia_aula.TabIndex = 75;
            this.txt_existencia_aula.Visible = false;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "ID de clase",
            "Nombre de clase",
            "ID de Empleado"});
            this.cmb_filtro.Location = new System.Drawing.Point(138, 91);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_filtro.TabIndex = 76;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(70, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 77;
            this.label10.Text = "Filtrar por:";
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
            this.dataGridView1.Location = new System.Drawing.Point(74, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(658, 298);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmModificacionDoC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1028, 506);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.pan_modificardatos);
            this.Controls.Add(this.btn_modificard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmModificacionDoC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pan_modificardatos.ResumeLayout(false);
            this.pan_modificardatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_modificard;
        private FontAwesome.Sharp.IconButton btn_concambios;
        private System.Windows.Forms.TextBox txt_horafinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_estadoclase;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nuevahora;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.TextBox txt_nuevaula;
        private System.Windows.Forms.TextBox txt_idclase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pan_modificardatos;
        private System.Windows.Forms.TextBox txt_existencia_aula;
        private System.Windows.Forms.TextBox txt_existencia_usuario;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}