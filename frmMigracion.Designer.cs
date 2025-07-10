namespace Proyecto_DesarrolloSoftware
{
    partial class frmMigracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMigracion));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnImportar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarP = new FontAwesome.Sharp.IconButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lb_descr = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lb_fechaF = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lb_fechaI = new System.Windows.Forms.Label();
            this.btn_AgregarP = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(665, 370);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImportar.IconColor = System.Drawing.Color.Black;
            this.btnImportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportar.Location = new System.Drawing.Point(118, 86);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(100, 28);
            this.btnImportar.TabIndex = 33;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
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
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 46);
            this.label1.TabIndex = 25;
            this.label1.Text = "Migración Nuevo Período";
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarP.IconColor = System.Drawing.Color.Black;
            this.btnGuardarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarP.Location = new System.Drawing.Point(1026, 363);
            this.btnGuardarP.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(157, 28);
            this.btnGuardarP.TabIndex = 60;
            this.btnGuardarP.Text = "Guardar Periodo";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(838, 271);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcion.TabIndex = 59;
            this.txtDescripcion.Visible = false;
            // 
            // lb_descr
            // 
            this.lb_descr.AutoSize = true;
            this.lb_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_descr.Location = new System.Drawing.Point(838, 245);
            this.lb_descr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_descr.Name = "lb_descr";
            this.lb_descr.Size = new System.Drawing.Size(104, 22);
            this.lb_descr.TabIndex = 58;
            this.lb_descr.Text = "Descripción";
            this.lb_descr.Visible = false;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(838, 212);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFinal.TabIndex = 57;
            this.dtpFechaFinal.Visible = false;
            // 
            // lb_fechaF
            // 
            this.lb_fechaF.AutoSize = true;
            this.lb_fechaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fechaF.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaF.Location = new System.Drawing.Point(838, 187);
            this.lb_fechaF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaF.Name = "lb_fechaF";
            this.lb_fechaF.Size = new System.Drawing.Size(115, 22);
            this.lb_fechaF.TabIndex = 56;
            this.lb_fechaF.Text = "Fecha de Fin";
            this.lb_fechaF.Visible = false;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(838, 138);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicio.TabIndex = 55;
            this.dtpFechaInicio.Visible = false;
            // 
            // lb_fechaI
            // 
            this.lb_fechaI.AutoSize = true;
            this.lb_fechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fechaI.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaI.Location = new System.Drawing.Point(834, 111);
            this.lb_fechaI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaI.Name = "lb_fechaI";
            this.lb_fechaI.Size = new System.Drawing.Size(131, 22);
            this.lb_fechaI.TabIndex = 54;
            this.lb_fechaI.Text = "Fecha de Inicio";
            this.lb_fechaI.Visible = false;
            // 
            // btn_AgregarP
            // 
            this.btn_AgregarP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgregarP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_AgregarP.IconColor = System.Drawing.Color.Black;
            this.btn_AgregarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AgregarP.Location = new System.Drawing.Point(925, 52);
            this.btn_AgregarP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarP.Name = "btn_AgregarP";
            this.btn_AgregarP.Size = new System.Drawing.Size(164, 28);
            this.btn_AgregarP.TabIndex = 53;
            this.btn_AgregarP.Text = "Agregar Nuevo Periodo";
            this.btn_AgregarP.UseVisualStyleBackColor = true;
            // 
            // frmMigracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1222, 528);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lb_descr);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.lb_fechaF);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lb_fechaI);
            this.Controls.Add(this.btn_AgregarP);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMigracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnImportar;
        private FontAwesome.Sharp.IconButton btnGuardarP;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lb_descr;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label lb_fechaF;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lb_fechaI;
        private FontAwesome.Sharp.IconButton btn_AgregarP;
    }
}