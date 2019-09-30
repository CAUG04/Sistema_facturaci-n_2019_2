namespace Sistema_facturación_2019_2
{
    partial class FrmEmpleado
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
            this.lblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.lblRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.cboRolEmpleado = new System.Windows.Forms.ComboBox();
            this.BtnSalirEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevoEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Depth = 0;
            this.lblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosAdicionales.Location = new System.Drawing.Point(502, 221);
            this.lblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(132, 19);
            this.lblDatosAdicionales.TabIndex = 71;
            this.lblDatosAdicionales.Text = "Datos Adicionales";
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Depth = 0;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolEmpleado.Location = new System.Drawing.Point(502, 86);
            this.lblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(102, 19);
            this.lblRolEmpleado.TabIndex = 67;
            this.lblRolEmpleado.Text = "Rol Empleado";
            // 
            // cboRolEmpleado
            // 
            this.cboRolEmpleado.FormattingEnabled = true;
            this.cboRolEmpleado.Location = new System.Drawing.Point(630, 86);
            this.cboRolEmpleado.Name = "cboRolEmpleado";
            this.cboRolEmpleado.Size = new System.Drawing.Size(200, 21);
            this.cboRolEmpleado.TabIndex = 66;
            // 
            // BtnSalirEmpleado
            // 
            this.BtnSalirEmpleado.Depth = 0;
            this.BtnSalirEmpleado.Location = new System.Drawing.Point(855, 409);
            this.BtnSalirEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirEmpleado.Name = "BtnSalirEmpleado";
            this.BtnSalirEmpleado.Primary = true;
            this.BtnSalirEmpleado.Size = new System.Drawing.Size(86, 24);
            this.BtnSalirEmpleado.TabIndex = 64;
            this.BtnSalirEmpleado.Text = "Salir";
            this.BtnSalirEmpleado.UseVisualStyleBackColor = true;
            this.BtnSalirEmpleado.Click += new System.EventHandler(this.BtnSalirEmpleado_Click);
            // 
            // BtnBuscarEmpleado
            // 
            this.BtnBuscarEmpleado.Depth = 0;
            this.BtnBuscarEmpleado.Location = new System.Drawing.Point(744, 354);
            this.BtnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            this.BtnBuscarEmpleado.Primary = true;
            this.BtnBuscarEmpleado.Size = new System.Drawing.Size(86, 24);
            this.BtnBuscarEmpleado.TabIndex = 63;
            this.BtnBuscarEmpleado.Text = "Buscar";
            this.BtnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.BtnBuscarEmpleado.Click += new System.EventHandler(this.BtnBuscarEmpleado_Click);
            // 
            // BtnEliminarEmpleado
            // 
            this.BtnEliminarEmpleado.Depth = 0;
            this.BtnEliminarEmpleado.Location = new System.Drawing.Point(855, 172);
            this.BtnEliminarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado";
            this.BtnEliminarEmpleado.Primary = true;
            this.BtnEliminarEmpleado.Size = new System.Drawing.Size(86, 23);
            this.BtnEliminarEmpleado.TabIndex = 62;
            this.BtnEliminarEmpleado.Text = "Eliminar";
            this.BtnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.BtnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Depth = 0;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(855, 124);
            this.btnActualizarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Primary = true;
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(86, 23);
            this.btnActualizarEmpleado.TabIndex = 61;
            this.btnActualizarEmpleado.Text = "Actualizar";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // BtnNuevoEmpleado
            // 
            this.BtnNuevoEmpleado.Depth = 0;
            this.BtnNuevoEmpleado.Location = new System.Drawing.Point(855, 83);
            this.BtnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevoEmpleado.Name = "BtnNuevoEmpleado";
            this.BtnNuevoEmpleado.Primary = true;
            this.BtnNuevoEmpleado.Size = new System.Drawing.Size(86, 24);
            this.BtnNuevoEmpleado.TabIndex = 60;
            this.BtnNuevoEmpleado.Text = "Nuevo";
            this.BtnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.BtnNuevoEmpleado.Click += new System.EventHandler(this.BtnNuevoEmpleado_Click);
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "";
            this.TxtDocumento.Location = new System.Drawing.Point(8, 172);
            this.TxtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PasswordChar = '\0';
            this.TxtDocumento.SelectedText = "";
            this.TxtDocumento.SelectionLength = 0;
            this.TxtDocumento.SelectionStart = 0;
            this.TxtDocumento.Size = new System.Drawing.Size(432, 23);
            this.TxtDocumento.TabIndex = 56;
            this.TxtDocumento.Text = "Documento";
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Hint = "";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(12, 124);
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(432, 23);
            this.txtNombreEmpleado.TabIndex = 55;
            this.txtNombreEmpleado.Text = "Empleado";
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleado.Location = new System.Drawing.Point(387, 23);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(87, 19);
            this.lblEmpleado.TabIndex = 54;
            this.lblEmpleado.Text = "EMPLEADO";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(8, 215);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(432, 23);
            this.txtDireccion.TabIndex = 77;
            this.txtDireccion.Text = "Dirección";
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(8, 253);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(432, 23);
            this.txtTelefono.TabIndex = 78;
            this.txtTelefono.Text = "Teléfono";
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(8, 299);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(432, 23);
            this.txtEmail.TabIndex = 79;
            this.txtEmail.Text = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(630, 127);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 81;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Depth = 0;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIngreso.Location = new System.Drawing.Point(502, 128);
            this.lblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(103, 19);
            this.lblFechaIngreso.TabIndex = 80;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Location = new System.Drawing.Point(630, 178);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRetiro.TabIndex = 83;
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Depth = 0;
            this.lblFechaRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRetiro.Location = new System.Drawing.Point(502, 179);
            this.lblFechaRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(93, 19);
            this.lblFechaRetiro.TabIndex = 82;
            this.lblFechaRetiro.Text = "Fecha Retiro";
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(506, 249);
            this.txtDatosAdicionales.Multiline = true;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(324, 88);
            this.txtDatosAdicionales.TabIndex = 84;
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(8, 383);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(822, 152);
            this.dgEmpleados.TabIndex = 85;
            this.dgEmpleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEmpleados_CellMouseClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(8, 354);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(271, 23);
            this.txtBuscar.TabIndex = 86;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Depth = 0;
            this.txtIdEmpleado.Hint = "";
            this.txtIdEmpleado.Location = new System.Drawing.Point(13, 83);
            this.txtIdEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.PasswordChar = '\0';
            this.txtIdEmpleado.SelectedText = "";
            this.txtIdEmpleado.SelectionLength = 0;
            this.txtIdEmpleado.SelectionStart = 0;
            this.txtIdEmpleado.Size = new System.Drawing.Size(139, 23);
            this.txtIdEmpleado.TabIndex = 87;
            this.txtIdEmpleado.Text = "ID";
            this.txtIdEmpleado.UseSystemPasswordChar = false;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // btnCancelarEmpleado
            // 
            this.btnCancelarEmpleado.Depth = 0;
            this.btnCancelarEmpleado.Location = new System.Drawing.Point(855, 221);
            this.btnCancelarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarEmpleado.Name = "btnCancelarEmpleado";
            this.btnCancelarEmpleado.Primary = true;
            this.btnCancelarEmpleado.Size = new System.Drawing.Size(86, 24);
            this.btnCancelarEmpleado.TabIndex = 88;
            this.btnCancelarEmpleado.Text = "Cancelar";
            this.btnCancelarEmpleado.UseVisualStyleBackColor = true;
            this.btnCancelarEmpleado.Click += new System.EventHandler(this.btnCancelarEmpleado_Click);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.btnCancelarEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.txtDatosAdicionales);
            this.Controls.Add(this.dtpFechaRetiro);
            this.Controls.Add(this.lblFechaRetiro);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDatosAdicionales);
            this.Controls.Add(this.lblRolEmpleado);
            this.Controls.Add(this.cboRolEmpleado);
            this.Controls.Add(this.BtnSalirEmpleado);
            this.Controls.Add(this.BtnBuscarEmpleado);
            this.Controls.Add(this.BtnEliminarEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.BtnNuevoEmpleado);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel lblRolEmpleado;
        private System.Windows.Forms.ComboBox cboRolEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private MaterialSkin.Controls.MaterialLabel lblFechaRetiro;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdEmpleado;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelarEmpleado;
    }
}