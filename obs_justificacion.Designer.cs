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
            this.btn_volver.Location = new System.Drawing.Point(60, 187);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(93, 37);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(60, 44);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(345, 116);
            this.txtObservacion.TabIndex = 7;
            // 
            // lbObservacion
            // 
            this.lbObservacion.AutoSize = true;
            this.lbObservacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbObservacion.Location = new System.Drawing.Point(57, 26);
            this.lbObservacion.Name = "lbObservacion";
            this.lbObservacion.Size = new System.Drawing.Size(151, 16);
            this.lbObservacion.TabIndex = 6;
            this.lbObservacion.Text = "Escriba su observación:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(313, 187);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 37);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // obs_justificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(459, 247);
            this.ControlBox = false;
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lbObservacion);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "obs_justificacion";
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