namespace Sistema_facturación_2019_2
{
    partial class FrmProductos
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
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.BtnSalirProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevoProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblaAdminitracionProductos = new MaterialSkin.Controls.MaterialLabel();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoriaProducto = new MaterialSkin.Controls.MaterialLabel();
            this.txtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDetallesProducto = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDetallesProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductos
            // 
            this.dgProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(120, 360);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(710, 172);
            this.dgProductos.TabIndex = 25;
            // 
            // BtnSalirProducto
            // 
            this.BtnSalirProducto.Depth = 0;
            this.BtnSalirProducto.Location = new System.Drawing.Point(852, 409);
            this.BtnSalirProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirProducto.Name = "BtnSalirProducto";
            this.BtnSalirProducto.Primary = true;
            this.BtnSalirProducto.Size = new System.Drawing.Size(86, 24);
            this.BtnSalirProducto.TabIndex = 24;
            this.BtnSalirProducto.Text = "Salir";
            this.BtnSalirProducto.UseVisualStyleBackColor = true;
            this.BtnSalirProducto.Click += new System.EventHandler(this.BtnSalirProducto_Click);
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.Depth = 0;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(744, 331);
            this.BtnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Primary = true;
            this.BtnBuscarProducto.Size = new System.Drawing.Size(86, 24);
            this.BtnBuscarProducto.TabIndex = 23;
            this.BtnBuscarProducto.Text = "Buscar";
            this.BtnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Depth = 0;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(852, 172);
            this.BtnEliminarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Primary = true;
            this.BtnEliminarProducto.Size = new System.Drawing.Size(86, 23);
            this.BtnEliminarProducto.TabIndex = 22;
            this.BtnEliminarProducto.Text = "Eliminar";
            this.BtnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Depth = 0;
            this.btnActualizarProducto.Location = new System.Drawing.Point(852, 124);
            this.btnActualizarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Primary = true;
            this.btnActualizarProducto.Size = new System.Drawing.Size(86, 23);
            this.btnActualizarProducto.TabIndex = 21;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            // 
            // BtnNuevoProducto
            // 
            this.BtnNuevoProducto.Depth = 0;
            this.BtnNuevoProducto.Location = new System.Drawing.Point(852, 83);
            this.BtnNuevoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevoProducto.Name = "BtnNuevoProducto";
            this.BtnNuevoProducto.Primary = true;
            this.BtnNuevoProducto.Size = new System.Drawing.Size(86, 24);
            this.BtnNuevoProducto.TabIndex = 20;
            this.BtnNuevoProducto.Text = "Nuevo";
            this.BtnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Depth = 0;
            this.txtBuscarProducto.Hint = "";
            this.txtBuscarProducto.Location = new System.Drawing.Point(5, 331);
            this.txtBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.SelectionLength = 0;
            this.txtBuscarProducto.SelectionStart = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(117, 23);
            this.txtBuscarProducto.TabIndex = 19;
            this.txtBuscarProducto.Text = "Buscar Producto";
            this.txtBuscarProducto.UseSystemPasswordChar = false;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Depth = 0;
            this.txtCantidadStock.Hint = "";
            this.txtCantidadStock.Location = new System.Drawing.Point(5, 276);
            this.txtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.PasswordChar = '\0';
            this.txtCantidadStock.SelectedText = "";
            this.txtCantidadStock.SelectionLength = 0;
            this.txtCantidadStock.SelectionStart = 0;
            this.txtCantidadStock.Size = new System.Drawing.Size(432, 23);
            this.txtCantidadStock.TabIndex = 18;
            this.txtCantidadStock.Text = "Cantidad Stock";
            this.txtCantidadStock.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "";
            this.txtPrecioVenta.Location = new System.Drawing.Point(5, 222);
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(432, 23);
            this.txtPrecioVenta.TabIndex = 17;
            this.txtPrecioVenta.Text = "Precio Venta";
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "";
            this.txtPrecioCompra.Location = new System.Drawing.Point(5, 172);
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(432, 23);
            this.txtPrecioCompra.TabIndex = 16;
            this.txtPrecioCompra.Text = "Precio Compra";
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // TxtCodigoReferencia
            // 
            this.TxtCodigoReferencia.Depth = 0;
            this.TxtCodigoReferencia.Hint = "";
            this.TxtCodigoReferencia.Location = new System.Drawing.Point(5, 124);
            this.TxtCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigoReferencia.Name = "TxtCodigoReferencia";
            this.TxtCodigoReferencia.PasswordChar = '\0';
            this.TxtCodigoReferencia.SelectedText = "";
            this.TxtCodigoReferencia.SelectionLength = 0;
            this.TxtCodigoReferencia.SelectionStart = 0;
            this.TxtCodigoReferencia.Size = new System.Drawing.Size(432, 23);
            this.TxtCodigoReferencia.TabIndex = 15;
            this.TxtCodigoReferencia.Text = "Código Referencia";
            this.TxtCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "";
            this.txtNombreProducto.Location = new System.Drawing.Point(5, 84);
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(432, 23);
            this.txtNombreProducto.TabIndex = 14;
            this.txtNombreProducto.Text = "Nombre Producto";
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // lblaAdminitracionProductos
            // 
            this.lblaAdminitracionProductos.AutoSize = true;
            this.lblaAdminitracionProductos.Depth = 0;
            this.lblaAdminitracionProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblaAdminitracionProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblaAdminitracionProductos.Location = new System.Drawing.Point(384, 23);
            this.lblaAdminitracionProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblaAdminitracionProductos.Name = "lblaAdminitracionProductos";
            this.lblaAdminitracionProductos.Size = new System.Drawing.Size(246, 19);
            this.lblaAdminitracionProductos.TabIndex = 13;
            this.lblaAdminitracionProductos.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(621, 86);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(154, 21);
            this.cboCategoria.TabIndex = 26;
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Depth = 0;
            this.lblCategoriaProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoriaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoriaProducto.Location = new System.Drawing.Point(541, 88);
            this.lblCategoriaProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(74, 19);
            this.lblCategoriaProducto.TabIndex = 27;
            this.lblCategoriaProducto.Text = "Categoría";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Depth = 0;
            this.txtRutaImagen.Hint = "";
            this.txtRutaImagen.Location = new System.Drawing.Point(545, 124);
            this.txtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.PasswordChar = '\0';
            this.txtRutaImagen.SelectedText = "";
            this.txtRutaImagen.SelectionLength = 0;
            this.txtRutaImagen.SelectionStart = 0;
            this.txtRutaImagen.Size = new System.Drawing.Size(230, 23);
            this.txtRutaImagen.TabIndex = 28;
            this.txtRutaImagen.Text = "Ruta Imagen";
            this.txtRutaImagen.UseSystemPasswordChar = false;
            // 
            // lblDetallesProducto
            // 
            this.lblDetallesProducto.AutoSize = true;
            this.lblDetallesProducto.Depth = 0;
            this.lblDetallesProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetallesProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetallesProducto.Location = new System.Drawing.Point(541, 176);
            this.lblDetallesProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetallesProducto.Name = "lblDetallesProducto";
            this.lblDetallesProducto.Size = new System.Drawing.Size(129, 19);
            this.lblDetallesProducto.TabIndex = 29;
            this.lblDetallesProducto.Text = "Detalles Producto";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDetallesProducto
            // 
            this.txtDetallesProducto.Location = new System.Drawing.Point(546, 213);
            this.txtDetallesProducto.Multiline = true;
            this.txtDetallesProducto.Name = "txtDetallesProducto";
            this.txtDetallesProducto.Size = new System.Drawing.Size(229, 86);
            this.txtDetallesProducto.TabIndex = 31;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.txtDetallesProducto);
            this.Controls.Add(this.lblDetallesProducto);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.lblCategoriaProducto);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.BtnSalirProducto);
            this.Controls.Add(this.BtnBuscarProducto);
            this.Controls.Add(this.BtnEliminarProducto);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.BtnNuevoProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.TxtCodigoReferencia);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblaAdminitracionProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductos;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirProducto;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevoProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidadStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigoReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private MaterialSkin.Controls.MaterialLabel lblaAdminitracionProductos;
        private System.Windows.Forms.ComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCategoriaProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImagen;
        private MaterialSkin.Controls.MaterialLabel lblDetallesProducto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDetallesProducto;
    }
}