namespace Proyecto_DesarrolloSoftware
{
    partial class frmDocente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelsemana = new System.Windows.Forms.Panel();
            this.btn_sem5 = new System.Windows.Forms.Button();
            this.btn_sem4 = new System.Windows.Forms.Button();
            this.btn_sem3 = new System.Windows.Forms.Button();
            this.btn_sem2 = new System.Windows.Forms.Button();
            this.btn_sem1 = new System.Windows.Forms.Button();
            this.btn_semana = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.btn_cierre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usu_docente = new System.Windows.Forms.TextBox();
            this.pruebitaDataSet = new Proyecto_DesarrolloSoftware.pruebitaDataSet();
            this.vdocenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_docenteTableAdapter = new Proyecto_DesarrolloSoftware.pruebitaDataSetTableAdapters.v_docenteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelsemana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruebitaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vdocenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panelsemana);
            this.panel1.Controls.Add(this.btn_semana);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 500);
            this.panel1.TabIndex = 13;
            // 
            // panelsemana
            // 
            this.panelsemana.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelsemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelsemana.Controls.Add(this.btn_sem5);
            this.panelsemana.Controls.Add(this.btn_sem4);
            this.panelsemana.Controls.Add(this.btn_sem3);
            this.panelsemana.Controls.Add(this.btn_sem2);
            this.panelsemana.Controls.Add(this.btn_sem1);
            this.panelsemana.Location = new System.Drawing.Point(0, 145);
            this.panelsemana.Name = "panelsemana";
            this.panelsemana.Size = new System.Drawing.Size(250, 356);
            this.panelsemana.TabIndex = 10;
            // 
            // btn_sem5
            // 
            this.btn_sem5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_sem5.BackColor = System.Drawing.Color.Khaki;
            this.btn_sem5.Location = new System.Drawing.Point(0, 159);
            this.btn_sem5.Name = "btn_sem5";
            this.btn_sem5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_sem5.Size = new System.Drawing.Size(250, 40);
            this.btn_sem5.TabIndex = 4;
            this.btn_sem5.Text = "Semana #5";
            this.btn_sem5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sem5.UseVisualStyleBackColor = false;
            this.btn_sem5.Click += new System.EventHandler(this.btn_sem5_Click);
            // 
            // btn_sem4
            // 
            this.btn_sem4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_sem4.BackColor = System.Drawing.Color.Khaki;
            this.btn_sem4.Location = new System.Drawing.Point(0, 119);
            this.btn_sem4.Name = "btn_sem4";
            this.btn_sem4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_sem4.Size = new System.Drawing.Size(250, 40);
            this.btn_sem4.TabIndex = 3;
            this.btn_sem4.Text = "Semana #4";
            this.btn_sem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sem4.UseVisualStyleBackColor = false;
            this.btn_sem4.Click += new System.EventHandler(this.btn_sem4_Click);
            // 
            // btn_sem3
            // 
            this.btn_sem3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_sem3.BackColor = System.Drawing.Color.Khaki;
            this.btn_sem3.Location = new System.Drawing.Point(0, 80);
            this.btn_sem3.Name = "btn_sem3";
            this.btn_sem3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_sem3.Size = new System.Drawing.Size(250, 40);
            this.btn_sem3.TabIndex = 2;
            this.btn_sem3.Text = "Semana #3";
            this.btn_sem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sem3.UseVisualStyleBackColor = false;
            this.btn_sem3.Click += new System.EventHandler(this.btn_sem3_Click);
            // 
            // btn_sem2
            // 
            this.btn_sem2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_sem2.BackColor = System.Drawing.Color.Khaki;
            this.btn_sem2.Location = new System.Drawing.Point(0, 40);
            this.btn_sem2.Name = "btn_sem2";
            this.btn_sem2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_sem2.Size = new System.Drawing.Size(250, 40);
            this.btn_sem2.TabIndex = 1;
            this.btn_sem2.Text = "Semana #2";
            this.btn_sem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sem2.UseVisualStyleBackColor = false;
            this.btn_sem2.Click += new System.EventHandler(this.btn_sem2_Click);
            // 
            // btn_sem1
            // 
            this.btn_sem1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_sem1.BackColor = System.Drawing.Color.Khaki;
            this.btn_sem1.Location = new System.Drawing.Point(0, 0);
            this.btn_sem1.Name = "btn_sem1";
            this.btn_sem1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_sem1.Size = new System.Drawing.Size(250, 40);
            this.btn_sem1.TabIndex = 0;
            this.btn_sem1.Text = "Semana #1";
            this.btn_sem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sem1.UseVisualStyleBackColor = false;
            this.btn_sem1.Click += new System.EventHandler(this.btn_sem1_Click);
            // 
            // btn_semana
            // 
            this.btn_semana.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_semana.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_semana.FlatAppearance.BorderSize = 0;
            this.btn_semana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_semana.Location = new System.Drawing.Point(0, 100);
            this.btn_semana.Name = "btn_semana";
            this.btn_semana.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_semana.Size = new System.Drawing.Size(250, 45);
            this.btn_semana.TabIndex = 9;
            this.btn_semana.Text = "Semana(Marzo)";
            this.btn_semana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_semana.UseVisualStyleBackColor = false;
            this.btn_semana.Click += new System.EventHandler(this.btn_semana_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 100);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(177, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Busqueda:";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_busqueda.Location = new System.Drawing.Point(289, 48);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(727, 20);
            this.txt_busqueda.TabIndex = 10;
            this.txt_busqueda.Text = "escriba los caracteres para empezar la busqueda";
            // 
            // btn_cierre
            // 
            this.btn_cierre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cierre.Location = new System.Drawing.Point(924, 12);
            this.btn_cierre.Name = "btn_cierre";
            this.btn_cierre.Size = new System.Drawing.Size(92, 30);
            this.btn_cierre.TabIndex = 8;
            this.btn_cierre.Text = "Cerrar Sesión";
            this.btn_cierre.UseVisualStyleBackColor = true;
            this.btn_cierre.Click += new System.EventHandler(this.btn_cierre_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(289, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Visualización de Asistencias";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txt_usu_docente
            // 
            this.txt_usu_docente.Enabled = false;
            this.txt_usu_docente.Location = new System.Drawing.Point(265, 468);
            this.txt_usu_docente.Name = "txt_usu_docente";
            this.txt_usu_docente.Size = new System.Drawing.Size(175, 20);
            this.txt_usu_docente.TabIndex = 15;
            // 
            // pruebitaDataSet
            // 
            this.pruebitaDataSet.DataSetName = "pruebitaDataSet";
            this.pruebitaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vdocenteBindingSource
            // 
            this.vdocenteBindingSource.DataMember = "v_docente";
            this.vdocenteBindingSource.DataSource = this.pruebitaDataSet;
            // 
            // v_docenteTableAdapter
            // 
            this.v_docenteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 308);
            this.dataGridView1.TabIndex = 16;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1025, 500);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_usu_docente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.btn_cierre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDocente";
            this.Text = "frmDocente";
            this.panel1.ResumeLayout(false);
            this.panelsemana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pruebitaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vdocenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelsemana;
        private System.Windows.Forms.Button btn_sem5;
        private System.Windows.Forms.Button btn_sem4;
        private System.Windows.Forms.Button btn_sem3;
        private System.Windows.Forms.Button btn_sem2;
        private System.Windows.Forms.Button btn_sem1;
        private System.Windows.Forms.Button btn_semana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Button btn_cierre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usu_docente;
        private System.Windows.Forms.BindingSource vdocenteBindingSource;
        private pruebitaDataSet pruebitaDataSet;
        private pruebitaDataSetTableAdapters.v_docenteTableAdapter v_docenteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}