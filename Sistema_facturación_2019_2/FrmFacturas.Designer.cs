namespace Sistema_facturación_2019_2
{
    partial class FrmFacturas
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
            this.lblClienteFacturas = new MaterialSkin.Controls.MaterialLabel();
            this.cboClienteFacturas = new System.Windows.Forms.ComboBox();
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.BtnSalirFacturas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscarFacturas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminarFacturas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarFacturas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevoFacturas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDetalleFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValorTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValorImpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDescuentoFacturas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumeroFacturas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFacturas = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleadoFacturas = new MaterialSkin.Controls.MaterialLabel();
            this.cboEmpleadoFacturas = new System.Windows.Forms.ComboBox();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.cboEstadoFactura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClienteFacturas
            // 
            this.lblClienteFacturas.AutoSize = true;
            this.lblClienteFacturas.Depth = 0;
            this.lblClienteFacturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblClienteFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClienteFacturas.Location = new System.Drawing.Point(588, 76);
            this.lblClienteFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClienteFacturas.Name = "lblClienteFacturas";
            this.lblClienteFacturas.Size = new System.Drawing.Size(56, 19);
            this.lblClienteFacturas.TabIndex = 46;
            this.lblClienteFacturas.Text = "Cliente";
            // 
            // cboClienteFacturas
            // 
            this.cboClienteFacturas.FormattingEnabled = true;
            this.cboClienteFacturas.Location = new System.Drawing.Point(704, 77);
            this.cboClienteFacturas.Name = "cboClienteFacturas";
            this.cboClienteFacturas.Size = new System.Drawing.Size(144, 21);
            this.cboClienteFacturas.TabIndex = 45;
            // 
            // dgFacturas
            // 
            this.dgFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Location = new System.Drawing.Point(167, 348);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.Size = new System.Drawing.Size(710, 172);
            this.dgFacturas.TabIndex = 44;
            // 
            // BtnSalirFacturas
            // 
            this.BtnSalirFacturas.Depth = 0;
            this.BtnSalirFacturas.Location = new System.Drawing.Point(899, 397);
            this.BtnSalirFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirFacturas.Name = "BtnSalirFacturas";
            this.BtnSalirFacturas.Primary = true;
            this.BtnSalirFacturas.Size = new System.Drawing.Size(86, 24);
            this.BtnSalirFacturas.TabIndex = 43;
            this.BtnSalirFacturas.Text = "Salir";
            this.BtnSalirFacturas.UseVisualStyleBackColor = true;
            this.BtnSalirFacturas.Click += new System.EventHandler(this.BtnSalirFacturas_Click);
            // 
            // BtnBuscarFacturas
            // 
            this.BtnBuscarFacturas.Depth = 0;
            this.BtnBuscarFacturas.Location = new System.Drawing.Point(791, 319);
            this.BtnBuscarFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscarFacturas.Name = "BtnBuscarFacturas";
            this.BtnBuscarFacturas.Primary = true;
            this.BtnBuscarFacturas.Size = new System.Drawing.Size(86, 24);
            this.BtnBuscarFacturas.TabIndex = 42;
            this.BtnBuscarFacturas.Text = "Buscar";
            this.BtnBuscarFacturas.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarFacturas
            // 
            this.BtnEliminarFacturas.Depth = 0;
            this.BtnEliminarFacturas.Location = new System.Drawing.Point(899, 160);
            this.BtnEliminarFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminarFacturas.Name = "BtnEliminarFacturas";
            this.BtnEliminarFacturas.Primary = true;
            this.BtnEliminarFacturas.Size = new System.Drawing.Size(86, 23);
            this.BtnEliminarFacturas.TabIndex = 41;
            this.BtnEliminarFacturas.Text = "Eliminar";
            this.BtnEliminarFacturas.UseVisualStyleBackColor = true;
            // 
            // btnActualizarFacturas
            // 
            this.btnActualizarFacturas.Depth = 0;
            this.btnActualizarFacturas.Location = new System.Drawing.Point(899, 112);
            this.btnActualizarFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarFacturas.Name = "btnActualizarFacturas";
            this.btnActualizarFacturas.Primary = true;
            this.btnActualizarFacturas.Size = new System.Drawing.Size(86, 23);
            this.btnActualizarFacturas.TabIndex = 40;
            this.btnActualizarFacturas.Text = "Actualizar";
            this.btnActualizarFacturas.UseVisualStyleBackColor = true;
            // 
            // BtnNuevoFacturas
            // 
            this.BtnNuevoFacturas.Depth = 0;
            this.BtnNuevoFacturas.Location = new System.Drawing.Point(899, 71);
            this.BtnNuevoFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevoFacturas.Name = "BtnNuevoFacturas";
            this.BtnNuevoFacturas.Primary = true;
            this.BtnNuevoFacturas.Size = new System.Drawing.Size(86, 24);
            this.BtnNuevoFacturas.TabIndex = 39;
            this.BtnNuevoFacturas.Text = "Nuevo";
            this.BtnNuevoFacturas.UseVisualStyleBackColor = true;
            // 
            // txtDetalleFactura
            // 
            this.txtDetalleFactura.Depth = 0;
            this.txtDetalleFactura.Hint = "";
            this.txtDetalleFactura.Location = new System.Drawing.Point(52, 319);
            this.txtDetalleFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDetalleFactura.Name = "txtDetalleFactura";
            this.txtDetalleFactura.PasswordChar = '\0';
            this.txtDetalleFactura.SelectedText = "";
            this.txtDetalleFactura.SelectionLength = 0;
            this.txtDetalleFactura.SelectionStart = 0;
            this.txtDetalleFactura.Size = new System.Drawing.Size(117, 23);
            this.txtDetalleFactura.TabIndex = 38;
            this.txtDetalleFactura.Text = "Detalle Factura";
            this.txtDetalleFactura.UseSystemPasswordChar = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Depth = 0;
            this.txtValorTotal.Hint = "";
            this.txtValorTotal.Location = new System.Drawing.Point(52, 210);
            this.txtValorTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.PasswordChar = '\0';
            this.txtValorTotal.SelectedText = "";
            this.txtValorTotal.SelectionLength = 0;
            this.txtValorTotal.SelectionStart = 0;
            this.txtValorTotal.Size = new System.Drawing.Size(432, 23);
            this.txtValorTotal.TabIndex = 36;
            this.txtValorTotal.Text = "Valor Total";
            this.txtValorTotal.UseSystemPasswordChar = false;
            // 
            // txtValorImpuesto
            // 
            this.txtValorImpuesto.Depth = 0;
            this.txtValorImpuesto.Hint = "";
            this.txtValorImpuesto.Location = new System.Drawing.Point(52, 160);
            this.txtValorImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValorImpuesto.Name = "txtValorImpuesto";
            this.txtValorImpuesto.PasswordChar = '\0';
            this.txtValorImpuesto.SelectedText = "";
            this.txtValorImpuesto.SelectionLength = 0;
            this.txtValorImpuesto.SelectionStart = 0;
            this.txtValorImpuesto.Size = new System.Drawing.Size(432, 23);
            this.txtValorImpuesto.TabIndex = 35;
            this.txtValorImpuesto.Text = "Valor Impuesto";
            this.txtValorImpuesto.UseSystemPasswordChar = false;
            // 
            // TxtDescuentoFacturas
            // 
            this.TxtDescuentoFacturas.Depth = 0;
            this.TxtDescuentoFacturas.Hint = "";
            this.TxtDescuentoFacturas.Location = new System.Drawing.Point(52, 112);
            this.TxtDescuentoFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDescuentoFacturas.Name = "TxtDescuentoFacturas";
            this.TxtDescuentoFacturas.PasswordChar = '\0';
            this.TxtDescuentoFacturas.SelectedText = "";
            this.TxtDescuentoFacturas.SelectionLength = 0;
            this.TxtDescuentoFacturas.SelectionStart = 0;
            this.TxtDescuentoFacturas.Size = new System.Drawing.Size(432, 23);
            this.TxtDescuentoFacturas.TabIndex = 34;
            this.TxtDescuentoFacturas.Text = "% Descuento";
            this.TxtDescuentoFacturas.UseSystemPasswordChar = false;
            // 
            // txtNumeroFacturas
            // 
            this.txtNumeroFacturas.Depth = 0;
            this.txtNumeroFacturas.Hint = "";
            this.txtNumeroFacturas.Location = new System.Drawing.Point(52, 72);
            this.txtNumeroFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumeroFacturas.Name = "txtNumeroFacturas";
            this.txtNumeroFacturas.PasswordChar = '\0';
            this.txtNumeroFacturas.SelectedText = "";
            this.txtNumeroFacturas.SelectionLength = 0;
            this.txtNumeroFacturas.SelectionStart = 0;
            this.txtNumeroFacturas.Size = new System.Drawing.Size(432, 23);
            this.txtNumeroFacturas.TabIndex = 33;
            this.txtNumeroFacturas.Text = "Numero de  Facturas";
            this.txtNumeroFacturas.UseSystemPasswordChar = false;
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Depth = 0;
            this.lblFacturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFacturas.Location = new System.Drawing.Point(431, 11);
            this.lblFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(84, 19);
            this.lblFacturas.TabIndex = 32;
            this.lblFacturas.Text = "FACTURAS";
            // 
            // lblEmpleadoFacturas
            // 
            this.lblEmpleadoFacturas.AutoSize = true;
            this.lblEmpleadoFacturas.Depth = 0;
            this.lblEmpleadoFacturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleadoFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleadoFacturas.Location = new System.Drawing.Point(588, 136);
            this.lblEmpleadoFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleadoFacturas.Name = "lblEmpleadoFacturas";
            this.lblEmpleadoFacturas.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleadoFacturas.TabIndex = 51;
            this.lblEmpleadoFacturas.Text = "Empleado";
            // 
            // cboEmpleadoFacturas
            // 
            this.cboEmpleadoFacturas.FormattingEnabled = true;
            this.cboEmpleadoFacturas.Location = new System.Drawing.Point(704, 137);
            this.cboEmpleadoFacturas.Name = "cboEmpleadoFacturas";
            this.cboEmpleadoFacturas.Size = new System.Drawing.Size(144, 21);
            this.cboEmpleadoFacturas.TabIndex = 50;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Depth = 0;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoFactura.Location = new System.Drawing.Point(588, 209);
            this.lblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(110, 19);
            this.lblEstadoFactura.TabIndex = 53;
            this.lblEstadoFactura.Text = "Estado Factura";
            // 
            // cboEstadoFactura
            // 
            this.cboEstadoFactura.FormattingEnabled = true;
            this.cboEstadoFactura.Location = new System.Drawing.Point(704, 210);
            this.cboEstadoFactura.Name = "cboEstadoFactura";
            this.cboEstadoFactura.Size = new System.Drawing.Size(144, 21);
            this.cboEstadoFactura.TabIndex = 52;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 531);
            this.Controls.Add(this.lblEstadoFactura);
            this.Controls.Add(this.cboEstadoFactura);
            this.Controls.Add(this.lblEmpleadoFacturas);
            this.Controls.Add(this.cboEmpleadoFacturas);
            this.Controls.Add(this.lblClienteFacturas);
            this.Controls.Add(this.cboClienteFacturas);
            this.Controls.Add(this.dgFacturas);
            this.Controls.Add(this.BtnSalirFacturas);
            this.Controls.Add(this.BtnBuscarFacturas);
            this.Controls.Add(this.BtnEliminarFacturas);
            this.Controls.Add(this.btnActualizarFacturas);
            this.Controls.Add(this.BtnNuevoFacturas);
            this.Controls.Add(this.txtDetalleFactura);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValorImpuesto);
            this.Controls.Add(this.TxtDescuentoFacturas);
            this.Controls.Add(this.txtNumeroFacturas);
            this.Controls.Add(this.lblFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblClienteFacturas;
        private System.Windows.Forms.ComboBox cboClienteFacturas;
        private System.Windows.Forms.DataGridView dgFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminarFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevoFacturas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDetalleFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValorTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValorImpuesto;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDescuentoFacturas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumeroFacturas;
        private MaterialSkin.Controls.MaterialLabel lblFacturas;
        private MaterialSkin.Controls.MaterialLabel lblEmpleadoFacturas;
        private System.Windows.Forms.ComboBox cboEmpleadoFacturas;
        private MaterialSkin.Controls.MaterialLabel lblEstadoFactura;
        private System.Windows.Forms.ComboBox cboEstadoFactura;
    }
}