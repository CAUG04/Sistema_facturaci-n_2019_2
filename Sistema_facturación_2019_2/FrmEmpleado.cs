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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void BtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            {
                Acceso_datos Acceso = new Acceso_datos(); if (txtBuscar.Text != "") { string sentencia = $"select * from TBLEMPLEADO where strNombre like '%{txtBuscar.Text}%'"; dgEmpleados.DataSource = Acceso.EjecutarComandoDatos(sentencia); txtBuscar.Text = ""; }
                else
                {
                    LLENAR_GRID();
                }
            }
        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {
            //verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnSalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombreEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreEmpleado, "debe ingresar el nombre del empleado");
                txtNombreEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreEmpleado, ""); }
            if (TxtDocumento.Text == "")
            {
                MensajeError.SetError(TxtDocumento, "debe ingresar el documento");
                TxtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtDocumento, ""); }
            if (!esNumerico(TxtDocumento.Text))
            {
                MensajeError.SetError(TxtDocumento, "El Documento debe ser numerico");
                TxtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(TxtDocumento, "");
            return errorCampos;
        }

        //función para validar si un valor dado es numérico
        private bool esNumerico(string num)
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

        // ------- funciones que permiten el ingreso , retiro y actualización de la información de empleados en la base de datos
        public bool Guardar()
        {
            Boolean actualizado = false;

            // fuentes buena: acceso datos :
            //https://www.youtube.com/watch?v=-99UfBDSZeE
            // https://www.youtube.com/watch?v=wzA5ZEJ6lvk
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Empleado '{txtNombreEmpleado.Text}','{ TxtDocumento.Text}' ,'{txtDireccion.Text}','{txtTelefono.Text}', '{txtEmail.Text}','{(cboRolEmpleado.SelectedValue)}','{dtpFechaIngreso.Value.ToString("yyyy-MM-DDTHH:MM:SS")}','{dtpFechaRetiro.Value.ToString("yyyy-MM-DDTHH:MM:SS")}', '{txtDatosAdicionales.Text}', ' select convert(DateTime,'{DateTime.Now.ToString("yyyy-MM-DDTHH:MM:SS")}',20)','admin'"; // select convert(datetime, '{DateTime.Now.ToString("AAAA-MM-DD HH:mm:ss")}', 20),'admin'"; "YYYY-MM-DDTHH:MM:SS"
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    LLENAR_GRID();
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

        // elimina un registro de empleado de la base de datos

        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_Empleado '{ Convert.ToInt32(txtIdEmpleado.Text)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            LLENAR_GRID(); // actualizamos de nuevo el grid para que refleje el cambio
        }
        // limpiamos los campos del formulario para ingresarle datos nuevos
        public void Nuevo()
        {
            txtIdEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
            TxtDocumento.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cboRolEmpleado.SelectedIndex = 0;
            dtpFechaIngreso.Value = DateTime.Now;
            dtpFechaRetiro.Value = DateTime.Now;
            //dtpFechaRetiro.Value = Convert.ToDateTime("01/01/1900");
            txtDatosAdicionales.Text = "";
        }
        //------- fin de funciones de actualización --------------------

        private void LLENAR_GRID()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase acceso_datos
            dt = Acceso.cargartabla("TBLEMPLEADO", "");
            dgEmpleados.DataSource = dt;
            dt = Acceso.cargartabla("TBLROLES", "");
            cboRolEmpleado.DataSource = dt;
            cboRolEmpleado.DisplayMember = "StrDescripcion";
            cboRolEmpleado.ValueMember = "IdRolEmpleado";

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void dgEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
* Cargamos el contenido de la fila del grid en los campos del formulario, la información se carga
* en los campos cada vez que damos clic en una fila del grid
*/
            int posActual = 0;
            posActual = dgEmpleados.CurrentRow.Index;
            txtIdEmpleado.Text = dgEmpleados[0, posActual].Value.ToString();
            txtNombreEmpleado.Text = dgEmpleados[1, posActual].Value.ToString();
            TxtDocumento.Text = dgEmpleados[2, posActual].Value.ToString();
            txtDireccion.Text = dgEmpleados[3, posActual].Value.ToString();
            txtTelefono.Text = dgEmpleados[4, posActual].Value.ToString();
            txtEmail.Text = dgEmpleados[5, posActual].Value.ToString();
            cboRolEmpleado.SelectedValue = Convert.ToInt16(dgEmpleados[6, posActual].Value.ToString());
            dtpFechaIngreso.Value = Convert.ToDateTime(dgEmpleados[7, posActual].Value.ToString());
            if (dgEmpleados[8, posActual].Value.ToString() != "")
            {
                dtpFechaRetiro.Value = Convert.ToDateTime(dgEmpleados[8, posActual].Value.ToString());
            }
            else
            {
                dtpFechaRetiro.Value = Convert.ToDateTime("01/01/1900");
            }
            txtDatosAdicionales.Text = dgEmpleados[9, posActual].Value.ToString();
        }

       
    }
}


