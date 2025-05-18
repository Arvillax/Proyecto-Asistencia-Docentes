namespace Proyecto_DesarrolloSoftware
{
    partial class obs_justificacion
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
            this.btn_volver = new FontAwesome.Sharp.IconButton();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lbObservacion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_volver.IconColor = System.Drawing.Color.Black;
            this.btn_volver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_volver.Location = new System.Drawing.Point(45, 152);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(70, 30);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(45, 36);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(260, 95);
            this.txtObservacion.TabIndex = 7;
            // 
            // lbObservacion
            // 
            this.lbObservacion.AutoSize = true;
            this.lbObservacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbObservacion.Location = new System.Drawing.Point(43, 21);
            this.lbObservacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbObservacion.Name = "lbObservacion";
            this.lbObservacion.Size = new System.Drawing.Size(120, 13);
            this.lbObservacion.TabIndex = 6;
            this.lbObservacion.Text = "Escriba su observación:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(235, 152);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // obs_justificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.ControlBox = false;
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lbObservacion);
            this.Controls.Add(this.btnGuardar);
            this.Name = "obs_justificacion";
            this.Text = "obs_justificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_volver;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lbObservacion;
        private System.Windows.Forms.Button btnGuardar;
    }
}