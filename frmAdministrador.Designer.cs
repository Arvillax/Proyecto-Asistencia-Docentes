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
            this.pnMenuLateral = new System.Windows.Forms.Panel();
            this.btnMMigra = new System.Windows.Forms.Button();
            this.btnMCierre = new System.Windows.Forms.Button();
            this.btnMdatos = new System.Windows.Forms.Button();
            this.btnMGestion = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.FacuUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContraUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuLateral
            // 
            this.pnMenuLateral.BackColor = System.Drawing.Color.Gainsboro;
            this.pnMenuLateral.Controls.Add(this.btnMMigra);
            this.pnMenuLateral.Controls.Add(this.btnMCierre);
            this.pnMenuLateral.Controls.Add(this.btnMdatos);
            this.pnMenuLateral.Controls.Add(this.btnMGestion);
            this.pnMenuLateral.Controls.Add(this.panelLogo);
            this.pnMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnMenuLateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMenuLateral.Name = "pnMenuLateral";
            this.pnMenuLateral.Size = new System.Drawing.Size(167, 413);
            this.pnMenuLateral.TabIndex = 17;
            // 
            // btnMMigra
            // 
            this.btnMMigra.BackColor = System.Drawing.Color.Khaki;
            this.btnMMigra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMMigra.Location = new System.Drawing.Point(0, 152);
            this.btnMMigra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMMigra.Name = "btnMMigra";
            this.btnMMigra.Size = new System.Drawing.Size(167, 29);
            this.btnMMigra.TabIndex = 14;
            this.btnMMigra.Text = "Migración de Datos";
            this.btnMMigra.UseVisualStyleBackColor = false;
            this.btnMMigra.Click += new System.EventHandler(this.btnMMigra_Click);
            // 
            // btnMCierre
            // 
            this.btnMCierre.BackColor = System.Drawing.Color.Khaki;
            this.btnMCierre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMCierre.Location = new System.Drawing.Point(0, 123);
            this.btnMCierre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMCierre.Name = "btnMCierre";
            this.btnMCierre.Size = new System.Drawing.Size(167, 29);
            this.btnMCierre.TabIndex = 13;
            this.btnMCierre.Text = "Cierre Período";
            this.btnMCierre.UseVisualStyleBackColor = false;
            this.btnMCierre.Click += new System.EventHandler(this.btnMCierre_Click);
            // 
            // btnMdatos
            // 
            this.btnMdatos.BackColor = System.Drawing.Color.Khaki;
            this.btnMdatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMdatos.Location = new System.Drawing.Point(0, 94);
            this.btnMdatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMdatos.Name = "btnMdatos";
            this.btnMdatos.Size = new System.Drawing.Size(167, 29);
            this.btnMdatos.TabIndex = 12;
            this.btnMdatos.Text = "Modificación Datos";
            this.btnMdatos.UseVisualStyleBackColor = false;
            this.btnMdatos.Click += new System.EventHandler(this.btnMdatos_Click);
            // 
            // btnMGestion
            // 
            this.btnMGestion.BackColor = System.Drawing.Color.Khaki;
            this.btnMGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMGestion.Location = new System.Drawing.Point(0, 65);
            this.btnMGestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMGestion.Name = "btnMGestion";
            this.btnMGestion.Size = new System.Drawing.Size(167, 29);
            this.btnMGestion.TabIndex = 11;
            this.btnMGestion.Text = "Gestión Usuarios";
            this.btnMGestion.UseVisualStyleBackColor = false;
            this.btnMGestion.Click += new System.EventHandler(this.btnMGestion_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(167, 65);
            this.panelLogo.TabIndex = 10;
            // 
            // FacuUsuario
            // 
            this.FacuUsuario.HeaderText = "Facultad";
            this.FacuUsuario.MinimumWidth = 8;
            this.FacuUsuario.Name = "FacuUsuario";
            this.FacuUsuario.Width = 150;
            // 
            // PermUsuario
            // 
            this.PermUsuario.HeaderText = "Permisos";
            this.PermUsuario.MinimumWidth = 8;
            this.PermUsuario.Name = "PermUsuario";
            this.PermUsuario.Width = 150;
            // 
            // ContraUsu
            // 
            this.ContraUsu.HeaderText = "Contraseña";
            this.ContraUsu.MinimumWidth = 8;
            this.ContraUsu.Name = "ContraUsu";
            this.ContraUsu.Width = 150;
            // 
            // NomUsuario
            // 
            this.NomUsuario.HeaderText = "Nombre de Usuario";
            this.NomUsuario.MinimumWidth = 8;
            this.NomUsuario.Name = "NomUsuario";
            this.NomUsuario.Width = 150;
            // 
            // UsuarioId
            // 
            this.UsuarioId.HeaderText = "Id";
            this.UsuarioId.MinimumWidth = 8;
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioId,
            this.NomUsuario,
            this.ContraUsu,
            this.PermUsuario,
            this.FacuUsuario});
            this.dataGridView1.Location = new System.Drawing.Point(243, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(544, 233);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(687, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 29);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(340, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 23);
            this.textBox1.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(597, 324);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 29);
            this.button7.TabIndex = 15;
            this.button7.Text = "Modificar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(693, 324);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 29);
            this.button8.TabIndex = 16;
            this.button8.Text = "Agregar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(255, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Búsqueda: ";
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
            this.label1.Location = new System.Drawing.Point(327, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestión de Usuarios";
            // 
            // frmGestion_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(864, 413);
            this.ControlBox = false;
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnMenuLateral);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestion_Usuarios";
            this.Text = "frmGestion_Usuarios";
            this.pnMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnMenuLateral;
        private System.Windows.Forms.Button btnMMigra;
        private System.Windows.Forms.Button btnMCierre;
        private System.Windows.Forms.Button btnMdatos;
        private System.Windows.Forms.Button btnMGestion;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacuUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContraUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}