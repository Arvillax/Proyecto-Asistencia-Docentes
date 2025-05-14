namespace Proyecto_DesarrolloSoftware
{
    partial class frm_modificacion_datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idclase = new System.Windows.Forms.TextBox();
            this.txt_nuevaula = new System.Windows.Forms.TextBox();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.txt_nuevahora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txt_estadoclase = new System.Windows.Forms.TextBox();
            this.txt_horafinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_concambios = new FontAwesome.Sharp.IconButton();
            this.btn_volver = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Clase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Aula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nuevo Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora Inicial:";
            // 
            // txt_idclase
            // 
            this.txt_idclase.Location = new System.Drawing.Point(90, 5);
            this.txt_idclase.Name = "txt_idclase";
            this.txt_idclase.Size = new System.Drawing.Size(187, 20);
            this.txt_idclase.TabIndex = 5;
            // 
            // txt_nuevaula
            // 
            this.txt_nuevaula.Location = new System.Drawing.Point(90, 31);
            this.txt_nuevaula.Name = "txt_nuevaula";
            this.txt_nuevaula.Size = new System.Drawing.Size(187, 20);
            this.txt_nuevaula.TabIndex = 6;
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(90, 59);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(187, 20);
            this.txt_idempleado.TabIndex = 7;
            // 
            // txt_nuevahora
            // 
            this.txt_nuevahora.Location = new System.Drawing.Point(90, 112);
            this.txt_nuevahora.Name = "txt_nuevahora";
            this.txt_nuevahora.Size = new System.Drawing.Size(187, 20);
            this.txt_nuevahora.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(90, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ejemplo: 08:30:00";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.cmb_estado.Location = new System.Drawing.Point(90, 85);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(187, 21);
            this.cmb_estado.TabIndex = 12;
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_estadoclase
            // 
            this.txt_estadoclase.Location = new System.Drawing.Point(16, 182);
            this.txt_estadoclase.Name = "txt_estadoclase";
            this.txt_estadoclase.Size = new System.Drawing.Size(100, 20);
            this.txt_estadoclase.TabIndex = 13;
            this.txt_estadoclase.Visible = false;
            // 
            // txt_horafinal
            // 
            this.txt_horafinal.Location = new System.Drawing.Point(90, 138);
            this.txt_horafinal.Name = "txt_horafinal";
            this.txt_horafinal.Size = new System.Drawing.Size(187, 20);
            this.txt_horafinal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hora Final:";
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
            this.btn_concambios.Location = new System.Drawing.Point(188, 204);
            this.btn_concambios.Name = "btn_concambios";
            this.btn_concambios.Size = new System.Drawing.Size(135, 33);
            this.btn_concambios.TabIndex = 16;
            this.btn_concambios.Text = "Confirmar Cambios";
            this.btn_concambios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_concambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_concambios.UseVisualStyleBackColor = false;
            this.btn_concambios.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_volver.IconColor = System.Drawing.Color.Black;
            this.btn_volver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_volver.IconSize = 25;
            this.btn_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_volver.Location = new System.Drawing.Point(15, 206);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(110, 30);
            this.btn_volver.TabIndex = 55;
            this.btn_volver.Text = "volver";
            this.btn_volver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // frm_modificacion_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_concambios);
            this.Controls.Add(this.txt_horafinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_estadoclase);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nuevahora);
            this.Controls.Add(this.txt_idempleado);
            this.Controls.Add(this.txt_nuevaula);
            this.Controls.Add(this.txt_idclase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_modificacion_datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_modificacion_datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idclase;
        private System.Windows.Forms.TextBox txt_nuevaula;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.TextBox txt_nuevahora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.TextBox txt_estadoclase;
        private System.Windows.Forms.TextBox txt_horafinal;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btn_concambios;
        private FontAwesome.Sharp.IconButton btn_volver;
    }
}