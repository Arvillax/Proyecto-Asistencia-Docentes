namespace Proyecto_DesarrolloSoftware
{
    partial class frmModificacion_Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacion_Datos));
            this.pnMenuLateral = new System.Windows.Forms.Panel();
            this.btnMMigra = new System.Windows.Forms.Button();
            this.btnMCierre = new System.Windows.Forms.Button();
            this.btnMdatos = new System.Windows.Forms.Button();
            this.btnMGestion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContraUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacuUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
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
            this.pnMenuLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenuLateral.Name = "pnMenuLateral";
            this.pnMenuLateral.Size = new System.Drawing.Size(223, 534);
            this.pnMenuLateral.TabIndex = 21;
            // 
            // btnMMigra
            // 
            this.btnMMigra.BackColor = System.Drawing.Color.Khaki;
            this.btnMMigra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMMigra.Location = new System.Drawing.Point(0, 188);
            this.btnMMigra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMMigra.Name = "btnMMigra";
            this.btnMMigra.Size = new System.Drawing.Size(223, 36);
            this.btnMMigra.TabIndex = 14;
            this.btnMMigra.Text = "Migración de Datos";
            this.btnMMigra.UseVisualStyleBackColor = false;
            this.btnMMigra.Click += new System.EventHandler(this.btnMMigra_Click);
            // 
            // btnMCierre
            // 
            this.btnMCierre.BackColor = System.Drawing.Color.Khaki;
            this.btnMCierre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMCierre.Location = new System.Drawing.Point(0, 152);
            this.btnMCierre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMCierre.Name = "btnMCierre";
            this.btnMCierre.Size = new System.Drawing.Size(223, 36);
            this.btnMCierre.TabIndex = 13;
            this.btnMCierre.Text = "Cierre Período";
            this.btnMCierre.UseVisualStyleBackColor = false;
            this.btnMCierre.Click += new System.EventHandler(this.btnMCierre_Click);
            // 
            // btnMdatos
            // 
            this.btnMdatos.BackColor = System.Drawing.Color.Khaki;
            this.btnMdatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMdatos.Location = new System.Drawing.Point(0, 116);
            this.btnMdatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMdatos.Name = "btnMdatos";
            this.btnMdatos.Size = new System.Drawing.Size(223, 36);
            this.btnMdatos.TabIndex = 12;
            this.btnMdatos.Text = "Modificación Datos";
            this.btnMdatos.UseVisualStyleBackColor = false;
            this.btnMdatos.Click += new System.EventHandler(this.btnMdatos_Click);
            // 
            // btnMGestion
            // 
            this.btnMGestion.BackColor = System.Drawing.Color.Khaki;
            this.btnMGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMGestion.Location = new System.Drawing.Point(0, 80);
            this.btnMGestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMGestion.Name = "btnMGestion";
            this.btnMGestion.Size = new System.Drawing.Size(223, 36);
            this.btnMGestion.TabIndex = 11;
            this.btnMGestion.Text = "Gestión Usuarios";
            this.btnMGestion.UseVisualStyleBackColor = false;
            this.btnMGestion.Click += new System.EventHandler(this.btnMGestion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(367, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 26);
            this.textBox1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioId,
            this.NomUsuario,
            this.ContraUsu,
            this.PermUsuario,
            this.FacuUsuario});
            this.dataGridView1.Location = new System.Drawing.Point(239, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(725, 287);
            this.dataGridView1.TabIndex = 16;
            // 
            // UsuarioId
            // 
            this.UsuarioId.HeaderText = "Aula";
            this.UsuarioId.MinimumWidth = 8;
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.Width = 150;
            // 
            // NomUsuario
            // 
            this.NomUsuario.HeaderText = "Asignatura";
            this.NomUsuario.MinimumWidth = 8;
            this.NomUsuario.Name = "NomUsuario";
            this.NomUsuario.Width = 150;
            // 
            // ContraUsu
            // 
            this.ContraUsu.HeaderText = "Hora";
            this.ContraUsu.MinimumWidth = 8;
            this.ContraUsu.Name = "ContraUsu";
            this.ContraUsu.Width = 150;
            // 
            // PermUsuario
            // 
            this.PermUsuario.HeaderText = "Docente";
            this.PermUsuario.MinimumWidth = 8;
            this.PermUsuario.Name = "PermUsuario";
            this.PermUsuario.Width = 150;
            // 
            // FacuUsuario
            // 
            this.FacuUsuario.HeaderText = "Estado";
            this.FacuUsuario.MinimumWidth = 8;
            this.FacuUsuario.Name = "FacuUsuario";
            this.FacuUsuario.Width = 150;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(223, 80);
            this.panelLogo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(254, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Búsqueda: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(350, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modificación de Datos";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(847, 11);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(135, 36);
            this.btnCerrarSesion.TabIndex = 18;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmModificacion_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(994, 534);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.pnMenuLateral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmModificacion_Datos";
            this.Text = "frmModificacion_Datos";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContraUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacuUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}