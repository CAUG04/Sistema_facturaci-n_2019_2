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
    }
}
