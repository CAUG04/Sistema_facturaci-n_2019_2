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
            this.lblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.lblCargoDatos = new MaterialSkin.Controls.MaterialLabel();
            this.cboCargoDatos = new System.Windows.Forms.ComboBox();
            this.lblEscolaridad = new MaterialSkin.Controls.MaterialLabel();
            this.cboEscolaridad = new System.Windows.Forms.ComboBox();
            this.BtnSalirEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevoEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblSexo = new MaterialSkin.Controls.MaterialLabel();
            this.rdbSexoMasculino = new System.Windows.Forms.RadioButton();
            this.rdbSexoFemenino = new System.Windows.Forms.RadioButton();
            this.lblFechaNacimiento = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Depth = 0;
            this.lblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosAdicionales.Location = new System.Drawing.Point(544, 220);
            this.lblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(132, 19);
            this.lblDatosAdicionales.TabIndex = 71;
            this.lblDatosAdicionales.Text = "Datos Adicionales";
            // 
            // lblCargoDatos
            // 
            this.lblCargoDatos.AutoSize = true;
            this.lblCargoDatos.Depth = 0;
            this.lblCargoDatos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCargoDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCargoDatos.Location = new System.Drawing.Point(544, 147);
            this.lblCargoDatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCargoDatos.Name = "lblCargoDatos";
            this.lblCargoDatos.Size = new System.Drawing.Size(93, 19);
            this.lblCargoDatos.TabIndex = 69;
            this.lblCargoDatos.Text = "Cargo Datos";
            // 
            // cboCargoDatos
            // 
            this.cboCargoDatos.FormattingEnabled = true;
            this.cboCargoDatos.Location = new System.Drawing.Point(660, 148);
            this.cboCargoDatos.Name = "cboCargoDatos";
            this.cboCargoDatos.Size = new System.Drawing.Size(144, 21);
            this.cboCargoDatos.TabIndex = 68;
            // 
            // lblEscolaridad
            // 
            this.lblEscolaridad.AutoSize = true;
            this.lblEscolaridad.Depth = 0;
            this.lblEscolaridad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEscolaridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEscolaridad.Location = new System.Drawing.Point(544, 88);
            this.lblEscolaridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEscolaridad.Name = "lblEscolaridad";
            this.lblEscolaridad.Size = new System.Drawing.Size(88, 19);
            this.lblEscolaridad.TabIndex = 67;
            this.lblEscolaridad.Text = "Escolaridad";
            // 
            // cboEscolaridad
            // 
            this.cboEscolaridad.FormattingEnabled = true;
            this.cboEscolaridad.Location = new System.Drawing.Point(660, 89);
            this.cboEscolaridad.Name = "cboEscolaridad";
            this.cboEscolaridad.Size = new System.Drawing.Size(144, 21);
            this.cboEscolaridad.TabIndex = 66;
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
            this.BtnBuscarEmpleado.Location = new System.Drawing.Point(855, 221);
            this.BtnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            this.BtnBuscarEmpleado.Primary = true;
            this.BtnBuscarEmpleado.Size = new System.Drawing.Size(86, 24);
            this.BtnBuscarEmpleado.TabIndex = 63;
            this.BtnBuscarEmpleado.Text = "Buscar";
            this.BtnBuscarEmpleado.UseVisualStyleBackColor = true;
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
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "";
            this.TxtDocumento.Location = new System.Drawing.Point(8, 124);
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
            // txtEmpleado
            // 
            this.txtEmpleado.Depth = 0;
            this.txtEmpleado.Hint = "";
            this.txtEmpleado.Location = new System.Drawing.Point(8, 84);
            this.txtEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PasswordChar = '\0';
            this.txtEmpleado.SelectedText = "";
            this.txtEmpleado.SelectionLength = 0;
            this.txtEmpleado.SelectionStart = 0;
            this.txtEmpleado.Size = new System.Drawing.Size(432, 23);
            this.txtEmpleado.TabIndex = 55;
            this.txtEmpleado.Text = "Empleado";
            this.txtEmpleado.UseSystemPasswordChar = false;
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
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Depth = 0;
            this.lblSexo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSexo.Location = new System.Drawing.Point(4, 164);
            this.lblSexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 19);
            this.lblSexo.TabIndex = 72;
            this.lblSexo.Text = "Sexo";
            // 
            // rdbSexoMasculino
            // 
            this.rdbSexoMasculino.AutoSize = true;
            this.rdbSexoMasculino.Location = new System.Drawing.Point(74, 165);
            this.rdbSexoMasculino.Name = "rdbSexoMasculino";
            this.rdbSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbSexoMasculino.TabIndex = 73;
            this.rdbSexoMasculino.TabStop = true;
            this.rdbSexoMasculino.Text = "Masculino";
            this.rdbSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbSexoFemenino
            // 
            this.rdbSexoFemenino.AutoSize = true;
            this.rdbSexoFemenino.Location = new System.Drawing.Point(185, 166);
            this.rdbSexoFemenino.Name = "rdbSexoFemenino";
            this.rdbSexoFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbSexoFemenino.TabIndex = 74;
            this.rdbSexoFemenino.TabStop = true;
            this.rdbSexoFemenino.Text = "Femenino";
            this.rdbSexoFemenino.UseVisualStyleBackColor = true;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Depth = 0;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(4, 206);
            this.lblFechaNacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(151, 19);
            this.lblFechaNacimiento.TabIndex = 75;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(185, 206);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 76;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(8, 250);
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
            this.txtTelefono.Location = new System.Drawing.Point(8, 292);
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
            this.txtEmail.Location = new System.Drawing.Point(8, 341);
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
            this.dtpFechaIngreso.Location = new System.Drawing.Point(132, 397);
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
            this.lblFechaIngreso.Location = new System.Drawing.Point(4, 398);
            this.lblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(103, 19);
            this.lblFechaIngreso.TabIndex = 80;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Location = new System.Drawing.Point(132, 448);
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
            this.lblFechaRetiro.Location = new System.Drawing.Point(4, 449);
            this.lblFechaRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(93, 19);
            this.lblFechaRetiro.TabIndex = 82;
            this.lblFechaRetiro.Text = "Fecha Retiro";
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(548, 250);
            this.txtDatosAdicionales.Multiline = true;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(256, 123);
            this.txtDatosAdicionales.TabIndex = 84;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.txtDatosAdicionales);
            this.Controls.Add(this.dtpFechaRetiro);
            this.Controls.Add(this.lblFechaRetiro);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.rdbSexoFemenino);
            this.Controls.Add(this.rdbSexoMasculino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDatosAdicionales);
            this.Controls.Add(this.lblCargoDatos);
            this.Controls.Add(this.cboCargoDatos);
            this.Controls.Add(this.lblEscolaridad);
            this.Controls.Add(this.cboEscolaridad);
            this.Controls.Add(this.BtnSalirEmpleado);
            this.Controls.Add(this.BtnBuscarEmpleado);
            this.Controls.Add(this.BtnEliminarEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.BtnNuevoEmpleado);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel lblCargoDatos;
        private System.Windows.Forms.ComboBox cboCargoDatos;
        private MaterialSkin.Controls.MaterialLabel lblEscolaridad;
        private System.Windows.Forms.ComboBox cboEscolaridad;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblSexo;
        private System.Windows.Forms.RadioButton rdbSexoMasculino;
        private System.Windows.Forms.RadioButton rdbSexoFemenino;
        private MaterialSkin.Controls.MaterialLabel lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private MaterialSkin.Controls.MaterialLabel lblFechaRetiro;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
    }
}