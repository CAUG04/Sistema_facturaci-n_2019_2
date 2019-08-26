namespace Sistema_facturación_2019_2
{
    partial class FrmRoles
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
            this.BtnSalirRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevoRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtDetalleRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescripcionRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblRoles = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // BtnSalirRol
            // 
            this.BtnSalirRol.Depth = 0;
            this.BtnSalirRol.Location = new System.Drawing.Point(855, 409);
            this.BtnSalirRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirRol.Name = "BtnSalirRol";
            this.BtnSalirRol.Primary = true;
            this.BtnSalirRol.Size = new System.Drawing.Size(86, 24);
            this.BtnSalirRol.TabIndex = 60;
            this.BtnSalirRol.Text = "Salir";
            this.BtnSalirRol.UseVisualStyleBackColor = true;
            this.BtnSalirRol.Click += new System.EventHandler(this.BtnSalirRol_Click);
            // 
            // BtnEliminarRol
            // 
            this.BtnEliminarRol.Depth = 0;
            this.BtnEliminarRol.Location = new System.Drawing.Point(855, 172);
            this.BtnEliminarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminarRol.Name = "BtnEliminarRol";
            this.BtnEliminarRol.Primary = true;
            this.BtnEliminarRol.Size = new System.Drawing.Size(86, 23);
            this.BtnEliminarRol.TabIndex = 59;
            this.BtnEliminarRol.Text = "Eliminar";
            this.BtnEliminarRol.UseVisualStyleBackColor = true;
            // 
            // btnActualizarRol
            // 
            this.btnActualizarRol.Depth = 0;
            this.btnActualizarRol.Location = new System.Drawing.Point(855, 124);
            this.btnActualizarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarRol.Name = "btnActualizarRol";
            this.btnActualizarRol.Primary = true;
            this.btnActualizarRol.Size = new System.Drawing.Size(86, 23);
            this.btnActualizarRol.TabIndex = 58;
            this.btnActualizarRol.Text = "Actualizar";
            this.btnActualizarRol.UseVisualStyleBackColor = true;
            // 
            // BtnNuevoRol
            // 
            this.BtnNuevoRol.Depth = 0;
            this.BtnNuevoRol.Location = new System.Drawing.Point(855, 83);
            this.BtnNuevoRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevoRol.Name = "BtnNuevoRol";
            this.BtnNuevoRol.Primary = true;
            this.BtnNuevoRol.Size = new System.Drawing.Size(86, 24);
            this.BtnNuevoRol.TabIndex = 57;
            this.BtnNuevoRol.Text = "Nuevo";
            this.BtnNuevoRol.UseVisualStyleBackColor = true;
            // 
            // TxtDetalleRol
            // 
            this.TxtDetalleRol.Depth = 0;
            this.TxtDetalleRol.Hint = "";
            this.TxtDetalleRol.Location = new System.Drawing.Point(8, 124);
            this.TxtDetalleRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDetalleRol.Name = "TxtDetalleRol";
            this.TxtDetalleRol.PasswordChar = '\0';
            this.TxtDetalleRol.SelectedText = "";
            this.TxtDetalleRol.SelectionLength = 0;
            this.TxtDetalleRol.SelectionStart = 0;
            this.TxtDetalleRol.Size = new System.Drawing.Size(432, 23);
            this.TxtDetalleRol.TabIndex = 56;
            this.TxtDetalleRol.Text = "Detalle Rol";
            this.TxtDetalleRol.UseSystemPasswordChar = false;
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Depth = 0;
            this.txtDescripcionRol.Hint = "";
            this.txtDescripcionRol.Location = new System.Drawing.Point(8, 84);
            this.txtDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.PasswordChar = '\0';
            this.txtDescripcionRol.SelectedText = "";
            this.txtDescripcionRol.SelectionLength = 0;
            this.txtDescripcionRol.SelectionStart = 0;
            this.txtDescripcionRol.Size = new System.Drawing.Size(432, 23);
            this.txtDescripcionRol.TabIndex = 55;
            this.txtDescripcionRol.Text = "Descripción Rol";
            this.txtDescripcionRol.UseSystemPasswordChar = false;
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Depth = 0;
            this.lblRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRoles.Location = new System.Drawing.Point(387, 23);
            this.lblRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(54, 19);
            this.lblRoles.TabIndex = 54;
            this.lblRoles.Text = "ROLES";
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.BtnSalirRol);
            this.Controls.Add(this.BtnEliminarRol);
            this.Controls.Add(this.btnActualizarRol);
            this.Controls.Add(this.BtnNuevoRol);
            this.Controls.Add(this.TxtDetalleRol);
            this.Controls.Add(this.txtDescripcionRol);
            this.Controls.Add(this.lblRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoles";
            this.Text = "FrmRoles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirRol;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminarRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarRol;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevoRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDetalleRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcionRol;
        private MaterialSkin.Controls.MaterialLabel lblRoles;
    }
}