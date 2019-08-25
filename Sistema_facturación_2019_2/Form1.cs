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
            // Se crea el objeto del formulario principal
            FrmPrincipal frmprincipal = new FrmPrincipal();
            this.Hide(); // oculta el formulario login
            frmprincipal.Show(); // muestra el formulario principal
        }
    }
}
