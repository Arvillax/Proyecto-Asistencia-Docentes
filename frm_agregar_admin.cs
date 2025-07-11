using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DesarrolloSoftware
{
    public partial class frm_agregar_admin : Form
    {
        string server = "workstation id=ProyectoFinal.mssql.somee.com;packet size=4096;user id=JRivera_SQLLogin_1;pwd=cokdua1z5a;data source=ProyectoFinal.mssql.somee.com;persist security info=False;initial catalog=ProyectoFinal;TrustServerCertificate=True";
        clsConexion con = new clsConexion();
        SqlConnection conectar = new SqlConnection();
        

       

        public frm_agregar_admin()
        {
            InitializeComponent();
            cmb_permiso.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_permiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_permiso.Text = cmb_permiso.SelectedItem.ToString();

            if (cmb_permiso.SelectedIndex == 0)
            {
                
                txt_permiso.Text = "4";
            }
            else if (cmb_permiso.SelectedIndex == 1)
            {
                
                txt_permiso.Text = "1";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
  
            if (/*string.IsNullOrEmpty(txt_existe.Text) ||*/ string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_permiso.Text)
                || string.IsNullOrEmpty(txt_usuarioempleado.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || string.IsNullOrEmpty(cmb_permiso.Text) || 
                string.IsNullOrEmpty(txt_idempleado.Text))
            {
                MessageBox.Show("hay campos que estan vacios");
            }
            else
            {
                int id_rol = Convert.ToInt32(txt_permiso.Text);
                int id_empleado = Convert.ToInt32(txt_idempleado.Text);
                string nombre = txt_nombre.Text;
                string nombre_usuario = txt_usuarioempleado.Text;
                string contraseña = txt_contraseña.Text;


                bool existe = con.verificacionusuario(id_empleado);
                txt_existe.Text = existe ? "existe" : "no existe";

                if (txt_existe.Text == "existe")
                {
                    MessageBox.Show("el id del empleado ya existe");
                }
                else if(txt_existe.Text == "no existe")
                {
                    
                    con.agregar_usuario(id_empleado,nombre,id_rol,nombre_usuario,contraseña);
                    frmGestion_Usuarios admin = new frmGestion_Usuarios();
                    this.Hide();
                }
                
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
