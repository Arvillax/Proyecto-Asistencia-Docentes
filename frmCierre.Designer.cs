namespace Proyecto_DesarrolloSoftware
{
    partial class frmCierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierre));
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pnMenuPrincipal = new System.Windows.Forms.Panel();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btn_cerrar_periodo = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.pnMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(367, -68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 46);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cierre de Período";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(847, -76);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 36);
            this.button4.TabIndex = 25;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pnMenuPrincipal
            // 
            this.pnMenuPrincipal.AutoScroll = true;
            this.pnMenuPrincipal.Controls.Add(this.dgvMatriz);
            this.pnMenuPrincipal.Location = new System.Drawing.Point(55, 103);
            this.pnMenuPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenuPrincipal.Name = "pnMenuPrincipal";
            this.pnMenuPrincipal.Size = new System.Drawing.Size(1263, 581);
            this.pnMenuPrincipal.TabIndex = 30;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(4, 0);
            this.dgvMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.Size = new System.Drawing.Size(1255, 577);
            this.dgvMatriz.TabIndex = 0;
            // 
            // btn_cerrar_periodo
            // 
            this.btn_cerrar_periodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_periodo.BackColor = System.Drawing.Color.LightCoral;
            this.btn_cerrar_periodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_periodo.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btn_cerrar_periodo.IconColor = System.Drawing.Color.Black;
            this.btn_cerrar_periodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cerrar_periodo.IconSize = 30;
            this.btn_cerrar_periodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar_periodo.Location = new System.Drawing.Point(1236, 714);
            this.btn_cerrar_periodo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar_periodo.Name = "btn_cerrar_periodo";
            this.btn_cerrar_periodo.Size = new System.Drawing.Size(161, 46);
            this.btn_cerrar_periodo.TabIndex = 28;
            this.btn_cerrar_periodo.Text = "Cerrar Periodo";
            this.btn_cerrar_periodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar_periodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar_periodo.UseVisualStyleBackColor = false;
            this.btn_cerrar_periodo.Click += new System.EventHandler(this.btn_cerrar_periodo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(514, -3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "Visualizacíon De Periodos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(55, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Búscar:";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(144, 66);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(785, 26);
            this.txt_busqueda.TabIndex = 32;
            // 
            // frmCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1395, 760);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.btn_cerrar_periodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pnMenuPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnMenuPrincipal;
        private FontAwesome.Sharp.IconButton btn_cerrar_periodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_busqueda;
    }
}