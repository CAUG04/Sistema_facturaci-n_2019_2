using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_facturación_2019_2
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //// Se crea el objeto del formulario principal
            //FrmPrincipal frmprincipal = new FrmPrincipal();
            //this.Hide(); // oculta el formulario login
            //frmprincipal.Show(); // muestra el formulario principal

            string Respuesta = ""; // creamos variable para controlar si encontró el usuario en la base de datos
            if (TxtUsuario.Text != "" && TxtPassword.Text != string.Empty) // verifico que el usuario y la clave del los campos del formulario no estén vacíos
            {
                Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
                Respuesta = Acceso.ValidarUsuario(TxtUsuario.Text, TxtPassword.Text);
                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido : " + Respuesta);
                    FrmPrincipal frmppal = new FrmPrincipal(); //Creamos el objeto del formulario FrmPrincipal
                    this.Hide(); // Ocultamos el formulario login
                    frmppal.Show(); // Mostramos el formulario principal
                }
                else
                {
                    MessageBox.Show("USUARIOS Y CLAVE NO ENCONTRADOS");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }
        }
    }
}

