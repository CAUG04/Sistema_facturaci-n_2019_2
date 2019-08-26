using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_facturación_2019_2
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmCliente = new FrmClientes();
            AbrirForm(frmCliente);
        }

        private void AbrirForm(Form formHijo)
        {
            if (this.Pnlcontenedor.Controls.Count > 0)
                this.Pnlcontenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.Pnlcontenedor.Controls.Add(formHijo);
            this.Pnlcontenedor.Tag = formHijo;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            AbrirForm(frmProductos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            AbrirForm(frmCategorias);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmFacturas frmFacturas = new FrmFacturas();
            AbrirForm(frmFacturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FrmInformes frmInformes = new FrmInformes();
            AbrirForm(frmInformes);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            FrmSeguridad frmSeguridad = new FrmSeguridad();
            AbrirForm(frmSeguridad);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRoles frmRoles = new FrmRoles();
            AbrirForm(frmRoles);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            AbrirForm(frmEmpleado);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frmAyuda = new FrmAyuda();
            AbrirForm(frmAyuda);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            AbrirForm(frmAcercaDe);
        }
    }
}
