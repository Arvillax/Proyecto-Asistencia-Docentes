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
            this.dgvPrimerP = new System.Windows.Forms.DataGridView();
            this.btn_cerrar_periodo = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerP)).BeginInit();
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
            this.pnMenuPrincipal.Controls.Add(this.dgvPrimerP);
            this.pnMenuPrincipal.Location = new System.Drawing.Point(12, 74);
            this.pnMenuPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenuPrincipal.Name = "pnMenuPrincipal";
            this.pnMenuPrincipal.Size = new System.Drawing.Size(1058, 598);
            this.pnMenuPrincipal.TabIndex = 30;
            // 
            // dgvPrimerP
            // 
            this.dgvPrimerP.AllowUserToAddRows = false;
            this.dgvPrimerP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrimerP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimerP.Location = new System.Drawing.Point(1, 4);
            this.dgvPrimerP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrimerP.Name = "dgvPrimerP";
            this.dgvPrimerP.RowHeadersWidth = 51;
            this.dgvPrimerP.Size = new System.Drawing.Size(1053, 594);
            this.dgvPrimerP.TabIndex = 0;
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
            this.btn_cerrar_periodo.Location = new System.Drawing.Point(934, 678);
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
            this.label2.Location = new System.Drawing.Point(293, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "Visualizacíon De Periodos";
            // 
            // frmCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1096, 737);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cerrar_periodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pnMenuPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Periodo";
            this.pnMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimerP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnMenuPrincipal;
        private FontAwesome.Sharp.IconButton btn_cerrar_periodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPrimerP;
    }
}