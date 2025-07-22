namespace Proyecto_DesarrolloSoftware
{
    partial class frmNuevoPeriodo
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lb_descr = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lb_fechaF = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lb_fechaI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblPeriodoActivo = new System.Windows.Forms.Label();
            this.btn_AgregarP = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(69, 277);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcion.TabIndex = 48;
            // 
            // lb_descr
            // 
            this.lb_descr.AutoSize = true;
            this.lb_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_descr.Location = new System.Drawing.Point(65, 236);
            this.lb_descr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_descr.Name = "lb_descr";
            this.lb_descr.Size = new System.Drawing.Size(104, 22);
            this.lb_descr.TabIndex = 47;
            this.lb_descr.Text = "Descripción";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(69, 190);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFinal.TabIndex = 46;
            // 
            // lb_fechaF
            // 
            this.lb_fechaF.AutoSize = true;
            this.lb_fechaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fechaF.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaF.Location = new System.Drawing.Point(65, 151);
            this.lb_fechaF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaF.Name = "lb_fechaF";
            this.lb_fechaF.Size = new System.Drawing.Size(115, 22);
            this.lb_fechaF.TabIndex = 45;
            this.lb_fechaF.Text = "Fecha de Fin";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(69, 108);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicio.TabIndex = 44;
            // 
            // lb_fechaI
            // 
            this.lb_fechaI.AutoSize = true;
            this.lb_fechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fechaI.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaI.Location = new System.Drawing.Point(65, 80);
            this.lb_fechaI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaI.Name = "lb_fechaI";
            this.lb_fechaI.Size = new System.Drawing.Size(131, 22);
            this.lb_fechaI.TabIndex = 43;
            this.lb_fechaI.Text = "Fecha de Inicio";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(291, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 51);
            this.label2.TabIndex = 51;
            this.label2.Text = "Creacion de periodos";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(436, 95);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 52;
            // 
            // lblPeriodoActivo
            // 
            this.lblPeriodoActivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPeriodoActivo.AutoSize = true;
            this.lblPeriodoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoActivo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPeriodoActivo.Location = new System.Drawing.Point(436, 338);
            this.lblPeriodoActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodoActivo.Name = "lblPeriodoActivo";
            this.lblPeriodoActivo.Size = new System.Drawing.Size(286, 22);
            this.lblPeriodoActivo.TabIndex = 53;
            this.lblPeriodoActivo.Text = "No hay período activo actualmente";
            // 
            // btn_AgregarP
            // 
            this.btn_AgregarP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_AgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarP.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btn_AgregarP.IconColor = System.Drawing.Color.Black;
            this.btn_AgregarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AgregarP.IconSize = 25;
            this.btn_AgregarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarP.Location = new System.Drawing.Point(69, 331);
            this.btn_AgregarP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AgregarP.Name = "btn_AgregarP";
            this.btn_AgregarP.Size = new System.Drawing.Size(196, 37);
            this.btn_AgregarP.TabIndex = 59;
            this.btn_AgregarP.Text = "Agregar Nuevo Periodo";
            this.btn_AgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AgregarP.UseVisualStyleBackColor = false;
            this.btn_AgregarP.Click += new System.EventHandler(this.btn_AgregarP_Click);
            // 
            // frmNuevoPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1135, 558);
            this.ControlBox = false;
            this.Controls.Add(this.btn_AgregarP);
            this.Controls.Add(this.lblPeriodoActivo);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lb_descr);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.lb_fechaF);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lb_fechaI);
            this.Name = "frmNuevoPeriodo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lb_descr;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label lb_fechaF;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lb_fechaI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblPeriodoActivo;
        private FontAwesome.Sharp.IconButton btn_AgregarP;
    }
}