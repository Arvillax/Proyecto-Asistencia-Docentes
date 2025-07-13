namespace Proyecto_DesarrolloSoftware
{
    partial class frmObservacion
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btn_volver = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(261, 179);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbObservacion
            // 
            this.lbObservacion.AutoSize = true;
            this.lbObservacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbObservacion.Location = new System.Drawing.Point(69, 48);
            this.lbObservacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbObservacion.Name = "lbObservacion";
            this.lbObservacion.Size = new System.Drawing.Size(120, 13);
            this.lbObservacion.TabIndex = 2;
            this.lbObservacion.Text = "Escriba su observación:";
            this.lbObservacion.Click += new System.EventHandler(this.lbObservacion_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(71, 63);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(260, 95);
            this.txtObservacion.TabIndex = 3;
            this.txtObservacion.TextChanged += new System.EventHandler(this.txtObservacion_TextChanged);
            // 
            // btn_volver
            // 
            this.btn_volver.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_volver.IconColor = System.Drawing.Color.Black;
            this.btn_volver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_volver.Location = new System.Drawing.Point(71, 179);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(70, 30);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // frmObservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(401, 229);
            this.ControlBox = false;
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lbObservacion);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmObservacion";
            this.ShowIcon = false;
            this.Text = "Observación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private FontAwesome.Sharp.IconButton btn_volver;
    }
}