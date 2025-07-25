namespace Proyecto_DesarrolloSoftware
{
    partial class frmRecuperacion_De_Contraseñas
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
            this.lbmensaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btn_regrsar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviarSoli = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnVerificarCod = new System.Windows.Forms.Button();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmensaje
            // 
            this.lbmensaje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.ForeColor = System.Drawing.Color.LightGreen;
            this.lbmensaje.Location = new System.Drawing.Point(36, 594);
            this.lbmensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(0, 25);
            this.lbmensaje.TabIndex = 32;
            this.lbmensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ingrese su usuario:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ingrese código de acceso";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(94)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 102);
            this.panel1.TabIndex = 30;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(94)))), ((int)(((byte)(185)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.Snow;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimizar.IconSize = 20;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizar.Location = new System.Drawing.Point(996, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(52, 50);
            this.btnMinimizar.TabIndex = 27;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.AutoSize = true;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaximizar.IconColor = System.Drawing.Color.Snow;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximizar.IconSize = 25;
            this.btnMaximizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximizar.Location = new System.Drawing.Point(1049, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(52, 50);
            this.btnMaximizar.TabIndex = 26;
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btn_regrsar
            // 
            this.btn_regrsar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regrsar.BackColor = System.Drawing.Color.Khaki;
            this.btn_regrsar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regrsar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_regrsar.IconColor = System.Drawing.Color.Black;
            this.btn_regrsar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_regrsar.IconSize = 35;
            this.btn_regrsar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regrsar.Location = new System.Drawing.Point(910, 606);
            this.btn_regrsar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_regrsar.Name = "btn_regrsar";
            this.btn_regrsar.Size = new System.Drawing.Size(192, 69);
            this.btn_regrsar.TabIndex = 34;
            this.btn_regrsar.Text = "Regresar";
            this.btn_regrsar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regrsar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_regrsar.UseVisualStyleBackColor = false;
            this.btn_regrsar.Click += new System.EventHandler(this.btn_regrsar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 28;
            // 
            // btnEnviarSoli
            // 
            this.btnEnviarSoli.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnviarSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSoli.Location = new System.Drawing.Point(672, 431);
            this.btnEnviarSoli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnviarSoli.Name = "btnEnviarSoli";
            this.btnEnviarSoli.Size = new System.Drawing.Size(185, 41);
            this.btnEnviarSoli.TabIndex = 27;
            this.btnEnviarSoli.Text = "Enviar Solicitud";
            this.btnEnviarSoli.UseVisualStyleBackColor = true;
            this.btnEnviarSoli.Click += new System.EventHandler(this.btnEnviarSoli_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUsuario.Location = new System.Drawing.Point(353, 438);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(312, 29);
            this.txtUsuario.TabIndex = 26;
            // 
            // btnVerificarCod
            // 
            this.btnVerificarCod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerificarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarCod.Location = new System.Drawing.Point(672, 523);
            this.btnVerificarCod.Margin = new System.Windows.Forms.Padding(6);
            this.btnVerificarCod.Name = "btnVerificarCod";
            this.btnVerificarCod.Size = new System.Drawing.Size(190, 41);
            this.btnVerificarCod.TabIndex = 33;
            this.btnVerificarCod.Text = "Verificar Código";
            this.btnVerificarCod.UseVisualStyleBackColor = true;
            this.btnVerificarCod.Click += new System.EventHandler(this.btnVerificarCod_Click);
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUsuario2.Location = new System.Drawing.Point(353, 530);
            this.txtUsuario2.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.Size = new System.Drawing.Size(312, 29);
            this.txtUsuario2.TabIndex = 32;
            this.txtUsuario2.TextChanged += new System.EventHandler(this.txtUsuario2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Proyecto_DesarrolloSoftware.Properties.Resources.NewLogo;
            this.pictureBox2.Location = new System.Drawing.Point(370, 155);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // frmRecuperacion_De_Contraseñas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1102, 677);
            this.ControlBox = false;
            this.Controls.Add(this.btn_regrsar);
            this.Controls.Add(this.lbmensaje);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviarSoli);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnVerificarCod);
            this.Controls.Add(this.txtUsuario2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1126, 701);
            this.Name = "frmRecuperacion_De_Contraseñas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRecuperacion_De_Contraseñas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbmensaje;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviarSoli;
        private System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btn_regrsar;
        private System.Windows.Forms.Button btnVerificarCod;
        private System.Windows.Forms.TextBox txtUsuario2;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
    }
}