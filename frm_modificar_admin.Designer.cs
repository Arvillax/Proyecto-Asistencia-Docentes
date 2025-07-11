namespace Proyecto_DesarrolloSoftware
{
    partial class frm_modificar_admin
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
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.txt_nuevousuario = new System.Windows.Forms.TextBox();
            this.txt_nuevacontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_estadoactual = new System.Windows.Forms.ComboBox();
            this.btn_confir = new System.Windows.Forms.Button();
            this.txt_nuevoestadoempleado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(168, 30);
            this.txt_idempleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(251, 22);
            this.txt_idempleado.TabIndex = 0;
            // 
            // txt_nuevousuario
            // 
            this.txt_nuevousuario.Location = new System.Drawing.Point(168, 62);
            this.txt_nuevousuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nuevousuario.Name = "txt_nuevousuario";
            this.txt_nuevousuario.Size = new System.Drawing.Size(251, 22);
            this.txt_nuevousuario.TabIndex = 1;
            // 
            // txt_nuevacontra
            // 
            this.txt_nuevacontra.Location = new System.Drawing.Point(168, 94);
            this.txt_nuevacontra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nuevacontra.Name = "txt_nuevacontra";
            this.txt_nuevacontra.Size = new System.Drawing.Size(251, 22);
            this.txt_nuevacontra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nueva Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado del Empleado:";
            // 
            // cmb_estadoactual
            // 
            this.cmb_estadoactual.FormattingEnabled = true;
            this.cmb_estadoactual.Items.AddRange(new object[] {
            "Activo",
            "Incativo"});
            this.cmb_estadoactual.Location = new System.Drawing.Point(168, 129);
            this.cmb_estadoactual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_estadoactual.Name = "cmb_estadoactual";
            this.cmb_estadoactual.Size = new System.Drawing.Size(251, 24);
            this.cmb_estadoactual.TabIndex = 8;
            this.cmb_estadoactual.SelectedIndexChanged += new System.EventHandler(this.cmb_estadoactual_SelectedIndexChanged);
            // 
            // btn_confir
            // 
            this.btn_confir.Location = new System.Drawing.Point(137, 185);
            this.btn_confir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_confir.Name = "btn_confir";
            this.btn_confir.Size = new System.Drawing.Size(168, 28);
            this.btn_confir.TabIndex = 9;
            this.btn_confir.Text = "Confirmar Cambios";
            this.btn_confir.UseVisualStyleBackColor = true;
            this.btn_confir.Click += new System.EventHandler(this.btn_confir_Click);
            // 
            // txt_nuevoestadoempleado
            // 
            this.txt_nuevoestadoempleado.Location = new System.Drawing.Point(137, 220);
            this.txt_nuevoestadoempleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nuevoestadoempleado.Name = "txt_nuevoestadoempleado";
            this.txt_nuevoestadoempleado.ReadOnly = true;
            this.txt_nuevoestadoempleado.Size = new System.Drawing.Size(167, 22);
            this.txt_nuevoestadoempleado.TabIndex = 10;
            this.txt_nuevoestadoempleado.Visible = false;
            this.txt_nuevoestadoempleado.TextChanged += new System.EventHandler(this.txt_nuevoestadoempleado_TextChanged);
            // 
            // frm_modificar_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(448, 260);
            this.ControlBox = false;
            this.Controls.Add(this.txt_nuevoestadoempleado);
            this.Controls.Add(this.btn_confir);
            this.Controls.Add(this.cmb_estadoactual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nuevacontra);
            this.Controls.Add(this.txt_nuevousuario);
            this.Controls.Add(this.txt_idempleado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_modificar_admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.TextBox txt_nuevousuario;
        private System.Windows.Forms.TextBox txt_nuevacontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_estadoactual;
        private System.Windows.Forms.Button btn_confir;
        private System.Windows.Forms.TextBox txt_nuevoestadoempleado;
    }
}