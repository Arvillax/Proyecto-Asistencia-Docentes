namespace Proyecto_DesarrolloSoftware
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new FontAwesome.Sharp.IconButton();
            this.lnContraseña = new System.Windows.Forms.LinkLabel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_ingresar = new FontAwesome.Sharp.IconButton();
            this.btnMostrarContraseña = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.pictureBox1);
<<<<<<< HEAD
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 102);
=======
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 65);
>>>>>>> main
            this.panel1.TabIndex = 19;
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
            this.btnMinimizar.Location = new System.Drawing.Point(700, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(38, 33);
            this.btnMinimizar.TabIndex = 25;
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
            this.btnMaximizar.Location = new System.Drawing.Point(735, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(38, 33);
            this.btnMaximizar.TabIndex = 24;
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_DesarrolloSoftware.Properties.Resources.d3d7b312_6a18_4bf1_ad9e_59d16cf61af9__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;// se fija a la derecha 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btn_cerrar.IconColor = System.Drawing.Color.Black;
            this.btn_cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cerrar.IconSize = 25;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.btn_cerrar.Location = new System.Drawing.Point(902, 21);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(178, 67);
=======
            this.btn_cerrar.Location = new System.Drawing.Point(654, 430);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(119, 43);
>>>>>>> main
            this.btn_cerrar.TabIndex = 22;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
<<<<<<< HEAD
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_DesarrolloSoftware.Properties.Resources.d3d7b312_6a18_4bf1_ad9e_59d16cf61af9__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
=======
>>>>>>> main
            // lnContraseña
            // 
            this.lnContraseña.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lnContraseña.AutoSize = true;
            this.lnContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lnContraseña.Location = new System.Drawing.Point(376, 604);
            this.lnContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnContraseña.Name = "lnContraseña";
            this.lnContraseña.Size = new System.Drawing.Size(320, 29);
=======
            this.lnContraseña.Location = new System.Drawing.Point(269, 418);
            this.lnContraseña.Name = "lnContraseña";
            this.lnContraseña.Size = new System.Drawing.Size(200, 18);
>>>>>>> main
            this.lnContraseña.TabIndex = 18;
            this.lnContraseña.TabStop = true;
            this.lnContraseña.Text = "¿Ha olvidado su contraseña?";
            this.lnContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnContraseña_LinkClicked);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
<<<<<<< HEAD
            this.txtContraseña.Location = new System.Drawing.Point(380, 446);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(266, 31);
            this.txtContraseña.TabIndex = 15;
            this.txtContraseña.PasswordChar = '*';
=======
            this.txtContraseña.Location = new System.Drawing.Point(272, 318);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(179, 22);
            this.txtContraseña.TabIndex = 15;
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
>>>>>>> main
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
<<<<<<< HEAD
            this.txtUsuario.Location = new System.Drawing.Point(380, 352);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(266, 31);
=======
            this.txtUsuario.Location = new System.Drawing.Point(272, 257);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(179, 22);
>>>>>>> main
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label4.Location = new System.Drawing.Point(376, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
=======
            this.label4.Location = new System.Drawing.Point(270, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
>>>>>>> main
            this.label4.TabIndex = 21;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(376, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
=======
            this.label3.Location = new System.Drawing.Point(270, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
>>>>>>> main
            this.label3.TabIndex = 20;
            this.label3.Text = "Usuario:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Proyecto_DesarrolloSoftware.Properties.Resources.NewLogo;
<<<<<<< HEAD
            this.pictureBox2.Location = new System.Drawing.Point(350, 110);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;// imagen escala sin deformarse
=======
            this.pictureBox2.Location = new System.Drawing.Point(241, 70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
>>>>>>> main
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ingresar.BackColor = System.Drawing.Color.Khaki;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btn_ingresar.IconColor = System.Drawing.Color.Black;
            this.btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ingresar.IconSize = 35;
            this.btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.btn_ingresar.Location = new System.Drawing.Point(412, 502);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(208, 71);
=======
            this.btn_ingresar.Location = new System.Drawing.Point(294, 353);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(139, 46);
>>>>>>> main
            this.btn_ingresar.TabIndex = 22;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMostrarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMostrarContraseña.Location = new System.Drawing.Point(645, 442);
            this.btnMostrarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(51, 38);
            this.btnMostrarContraseña.TabIndex = 23;
            this.btnMostrarContraseña.Text = "👁️";
            this.btnMostrarContraseña.UseVisualStyleBackColor = true;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click);
            // 
            // Form1
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1104, 690);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(774, 474);
>>>>>>> main
            this.ControlBox = false;
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lnContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
<<<<<<< HEAD
            this.Controls.Add(this.btnMostrarContraseña);
            this.Margin = new System.Windows.Forms.Padding(4);
=======
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> main
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lnContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btn_cerrar;
        private FontAwesome.Sharp.IconButton btn_ingresar;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnMostrarContraseña;
=======
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
>>>>>>> main
    }
}

