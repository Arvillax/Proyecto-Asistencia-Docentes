namespace Proyecto_DesarrolloSoftware
{
    partial class frm_agregar_admin
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
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.txt_usuarioempleado = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_permiso = new System.Windows.Forms.ComboBox();
            this.txt_permiso = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txt_existe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(212, 52);
            this.txt_idempleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(236, 22);
            this.txt_idempleado.TabIndex = 0;
            // 
            // txt_usuarioempleado
            // 
            this.txt_usuarioempleado.Location = new System.Drawing.Point(212, 151);
            this.txt_usuarioempleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_usuarioempleado.Name = "txt_usuarioempleado";
            this.txt_usuarioempleado.Size = new System.Drawing.Size(236, 22);
            this.txt_usuarioempleado.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(212, 183);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(236, 22);
            this.txt_contraseña.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID del Empleado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(51, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Permiso del Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(55, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario del Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(51, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña del Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(51, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre del Empleado:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(212, 87);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(236, 22);
            this.txt_nombre.TabIndex = 11;
            // 
            // cmb_permiso
            // 
            this.cmb_permiso.FormattingEnabled = true;
            this.cmb_permiso.Items.AddRange(new object[] {
            "Supervisor",
            "Administrador"});
            this.cmb_permiso.Location = new System.Drawing.Point(212, 118);
            this.cmb_permiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_permiso.Name = "cmb_permiso";
            this.cmb_permiso.Size = new System.Drawing.Size(236, 24);
            this.cmb_permiso.TabIndex = 13;
            this.cmb_permiso.SelectedIndexChanged += new System.EventHandler(this.cmb_permiso_SelectedIndexChanged);
            // 
            // txt_permiso
            // 
            this.txt_permiso.Location = new System.Drawing.Point(316, 15);
            this.txt_permiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_permiso.Name = "txt_permiso";
            this.txt_permiso.ReadOnly = true;
            this.txt_permiso.Size = new System.Drawing.Size(132, 22);
            this.txt_permiso.TabIndex = 14;
            this.txt_permiso.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(303, 222);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(147, 37);
            this.iconButton1.TabIndex = 53;
            this.iconButton1.Text = "Agregar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(55, 222);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(147, 37);
            this.iconButton2.TabIndex = 54;
            this.iconButton2.Text = "volver";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // txt_existe
            // 
            this.txt_existe.Location = new System.Drawing.Point(160, 15);
            this.txt_existe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_existe.Name = "txt_existe";
            this.txt_existe.ReadOnly = true;
            this.txt_existe.Size = new System.Drawing.Size(132, 22);
            this.txt_existe.TabIndex = 55;
            this.txt_existe.Visible = false;
            // 
            // frm_agregar_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(517, 281);
            this.ControlBox = false;
            this.Controls.Add(this.txt_existe);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txt_permiso);
            this.Controls.Add(this.cmb_permiso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuarioempleado);
            this.Controls.Add(this.txt_idempleado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_agregar_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.TextBox txt_usuarioempleado;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_permiso;
        private System.Windows.Forms.TextBox txt_permiso;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txt_existe;
    }
}