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
            this.btnGuardarP = new FontAwesome.Sharp.IconButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lb_descr = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lb_fechaF = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lb_fechaI = new System.Windows.Forms.Label();
            this.btn_AgregarP = new FontAwesome.Sharp.IconButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarP.IconColor = System.Drawing.Color.Black;
            this.btnGuardarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarP.Location = new System.Drawing.Point(226, 348);
            this.btnGuardarP.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(157, 28);
            this.btnGuardarP.TabIndex = 49;
            this.btnGuardarP.Text = "Guardar Periodo";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(38, 256);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcion.TabIndex = 48;
            this.txtDescripcion.Visible = false;
            // 
            // lb_descr
            // 
            this.lb_descr.AutoSize = true;
            this.lb_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_descr.Location = new System.Drawing.Point(38, 230);
            this.lb_descr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_descr.Name = "lb_descr";
            this.lb_descr.Size = new System.Drawing.Size(104, 22);
            this.lb_descr.TabIndex = 47;
            this.lb_descr.Text = "Descripción";
            this.lb_descr.Visible = false;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(38, 197);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFinal.TabIndex = 46;
            this.dtpFechaFinal.Visible = false;
            // 
            // lb_fechaF
            // 
            this.lb_fechaF.AutoSize = true;
            this.lb_fechaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fechaF.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaF.Location = new System.Drawing.Point(38, 172);
            this.lb_fechaF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaF.Name = "lb_fechaF";
            this.lb_fechaF.Size = new System.Drawing.Size(115, 22);
            this.lb_fechaF.TabIndex = 45;
            this.lb_fechaF.Text = "Fecha de Fin";
            this.lb_fechaF.Visible = false;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(38, 123);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicio.TabIndex = 44;
            this.dtpFechaInicio.Visible = false;
            // 
            // lb_fechaI
            // 
            this.lb_fechaI.AutoSize = true;
            this.lb_fechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fechaI.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaI.Location = new System.Drawing.Point(34, 96);
            this.lb_fechaI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaI.Name = "lb_fechaI";
            this.lb_fechaI.Size = new System.Drawing.Size(131, 22);
            this.lb_fechaI.TabIndex = 43;
            this.lb_fechaI.Text = "Fecha de Inicio";
            this.lb_fechaI.Visible = false;
            // 
            // btn_AgregarP
            // 
            this.btn_AgregarP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_AgregarP.IconColor = System.Drawing.Color.Black;
            this.btn_AgregarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AgregarP.Location = new System.Drawing.Point(13, 348);
            this.btn_AgregarP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarP.Name = "btn_AgregarP";
            this.btn_AgregarP.Size = new System.Drawing.Size(164, 28);
            this.btn_AgregarP.TabIndex = 42;
            this.btn_AgregarP.Text = "Agregar Nuevo Periodo";
            this.btn_AgregarP.UseVisualStyleBackColor = true;
            this.btn_AgregarP.Click += new System.EventHandler(this.btn_AgregarP_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(513, 123);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 50;
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
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 52);
            this.label2.TabIndex = 51;
            this.label2.Text = "Creacion de periodos";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(510, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Periodo Actual";
            this.label3.Visible = false;
            // 
            // frmNuevoPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1135, 558);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lb_descr);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.lb_fechaF);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lb_fechaI);
            this.Controls.Add(this.btn_AgregarP);
            this.Name = "frmNuevoPeriodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardarP;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lb_descr;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label lb_fechaF;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lb_fechaI;
        private FontAwesome.Sharp.IconButton btn_AgregarP;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}