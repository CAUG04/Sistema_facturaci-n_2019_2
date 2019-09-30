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
    public partial class FrmSeguridad : Form
    {
        public FrmSeguridad()
        {
            InitializeComponent();
        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }

        private void btnActualizarEmpleadoSeguridad_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnNuevoEmpleadoSeguridad_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void BtnEliminarEmpleadoSeguridad_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        // limpiamos los campos del formulario para ingresarle datos nuevos
        public void Nuevo()
        {
            txtUsuarioSeguridad.Text = "";
            TxtClaveSeguridad.Text = "";
            cboEmpleadoSeguridad.SelectedIndex = 0;
            
        }

        private void BtnCancelarSeguridad_Click(object sender, EventArgs e)
        {
            //verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void llenar_combo_Empleados()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.cargartabla("TBLEMPLEADO", "");
            cboEmpleadoSeguridad.DataSource = dt;
            cboEmpleadoSeguridad.DisplayMember = "StrNombre";
            cboEmpleadoSeguridad.ValueMember = "IdEmpleado";
            Acceso.CerrarrBd();
        }
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsuarioSeguridad.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuarioSeguridad, "debe ingresar un valor de Usuario");
                txtUsuarioSeguridad.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtUsuarioSeguridad, ""); }
            if (TxtClaveSeguridad.Text == "")
            {
                MensajeError.SetError(TxtClaveSeguridad, "Debe ingresar un valor de cédula");
                TxtClaveSeguridad.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtClaveSeguridad, ""); }
            return errorCampos;


        }
        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // función que permite guardar los datos de ingreso a un usuario
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Seguridad '{ Convert.ToInt32(cboEmpleadoSeguridad.SelectedValue)}' ,'{txtUsuarioSeguridad.Text}','{TxtClaveSeguridad.Text}','{DateTime.Now.ToString("MM-dd-yyyy")}','admin'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;


        }

        // función que permite eliminar los datos de ingreso de un usuario
        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_Seguridad '{ Convert.ToInt32(cboEmpleadoSeguridad.SelectedValue)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            txtUsuarioSeguridad.Text = "";
            TxtClaveSeguridad.Text = "";
        }
        // función que permite consultar los datos de ingreso de un usuario
        public void Consultar()
        {
            DataTable dt = new DataTable();
            string sentencia = "select StrUsuario,StrClave from TBLSEGURIDAD where IdEmpleado=" + cboEmpleadoSeguridad.SelectedValue.ToString();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.EjecutarComandoDatos(sentencia);
            if (dt.Rows.Count > 0)
            {
                txtUsuarioSeguridad.Text = dt.Rows[0]["StrUsuario"].ToString();
                TxtClaveSeguridad.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                txtUsuarioSeguridad.Text = "";
                TxtClaveSeguridad.Text = "";
            }
        }

       
    }
}

