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
            this.btnIngresarCod = new System.Windows.Forms.Button();
            this.lbmensaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_regrsar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviarSoli = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnVerificarCod = new System.Windows.Forms.Button();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarCod
            // 
            this.btnIngresarCod.Location = new System.Drawing.Point(0, 0);
            this.btnIngresarCod.Name = "btnIngresarCod";
            this.btnIngresarCod.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarCod.TabIndex = 35;
            // 
            // lbmensaje
            // 
            this.lbmensaje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.ForeColor = System.Drawing.Color.LightGreen;
            this.lbmensaje.Location = new System.Drawing.Point(39, 619);
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
            this.label3.Location = new System.Drawing.Point(380, 424);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ingrese su usuario:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 517);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ingrese código de acceso";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 106);
            this.panel1.TabIndex = 30;
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
            this.btnMinimizar.Location = new System.Drawing.Point(1059, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(57, 52);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1144, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(57, 52);
            this.btnMaximizar.TabIndex = 26;
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_DesarrolloSoftware.Properties.Resources.d3d7b312_6a18_4bf1_ad9e_59d16cf61af9__1_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            this.btn_regrsar.Location = new System.Drawing.Point(993, 631);
            this.btn_regrsar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_regrsar.Name = "btn_regrsar";
            this.btn_regrsar.Size = new System.Drawing.Size(210, 72);
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
            this.label2.Location = new System.Drawing.Point(340, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 28;
            // 
            // btnEnviarSoli
            // 
            this.btnEnviarSoli.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnviarSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSoli.Location = new System.Drawing.Point(733, 449);
            this.btnEnviarSoli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnviarSoli.Name = "btnEnviarSoli";
            this.btnEnviarSoli.Size = new System.Drawing.Size(202, 43);
            this.btnEnviarSoli.TabIndex = 27;
            this.btnEnviarSoli.Text = "Enviar Solicitud";
            this.btnEnviarSoli.UseVisualStyleBackColor = true;
            this.btnEnviarSoli.Click += new System.EventHandler(this.btnEnviarSoli_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUsuario.Location = new System.Drawing.Point(385, 456);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(340, 31);
            this.txtUsuario.TabIndex = 26;
            // 
            // btnVerificarCod
            // 
            this.btnVerificarCod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerificarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarCod.Location = new System.Drawing.Point(733, 545);
            this.btnVerificarCod.Margin = new System.Windows.Forms.Padding(6);
            this.btnVerificarCod.Name = "btnVerificarCod";
            this.btnVerificarCod.Size = new System.Drawing.Size(207, 43);
            this.btnVerificarCod.TabIndex = 33;
            this.btnVerificarCod.Text = "Verificar Código";
            this.btnVerificarCod.UseVisualStyleBackColor = true;
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUsuario2.Location = new System.Drawing.Point(385, 552);
            this.txtUsuario2.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.Size = new System.Drawing.Size(340, 31);
            this.txtUsuario2.TabIndex = 32;
            this.txtUsuario2.TextChanged += new System.EventHandler(this.txtUsuario2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Proyecto_DesarrolloSoftware.Properties.Resources.NewLogo;
            this.pictureBox2.Location = new System.Drawing.Point(404, 161);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // frmRecuperacion_De_Contraseñas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_regrsar);
            this.Controls.Add(this.btnIngresarCod);
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
            this.MinimumSize = new System.Drawing.Size(1226, 729);
            this.Name = "frmRecuperacion_De_Contraseñas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRecuperacion_De_Contraseñas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarCod;
        private System.Windows.Forms.Label lbmensaje;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
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