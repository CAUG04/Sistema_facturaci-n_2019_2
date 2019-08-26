namespace Sistema_facturación_2019_2
{
    partial class FrmAyuda
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
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblDetalles = new MaterialSkin.Controls.MaterialLabel();
            this.lblAyuda = new MaterialSkin.Controls.MaterialLabel();
            this.BtnSalirAyuda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(16, 125);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(541, 289);
            this.txtDetalles.TabIndex = 87;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Depth = 0;
            this.lblDetalles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalles.Location = new System.Drawing.Point(12, 91);
            this.lblDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(64, 19);
            this.lblDetalles.TabIndex = 86;
            this.lblDetalles.Text = "Detalles";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Depth = 0;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAyuda.Location = new System.Drawing.Point(387, 23);
            this.lblAyuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(57, 18);
            this.lblAyuda.TabIndex = 85;
            this.lblAyuda.Text = "AYUDA";
            // 
            // BtnSalirAyuda
            // 
            this.BtnSalirAyuda.Depth = 0;
            this.BtnSalirAyuda.Location = new System.Drawing.Point(793, 390);
            this.BtnSalirAyuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirAyuda.Name = "BtnSalirAyuda";
            this.BtnSalirAyuda.Primary = true;
            this.BtnSalirAyuda.Size = new System.Drawing.Size(86, 24);
            this.BtnSalirAyuda.TabIndex = 88;
            this.BtnSalirAyuda.Text = "Salir";
            this.BtnSalirAyuda.UseVisualStyleBackColor = true;
            this.BtnSalirAyuda.Click += new System.EventHandler(this.BtnSalirEmpleado_Click);
            // 
            // FrmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.BtnSalirAyuda);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAyuda";
            this.Text = "FrmAyuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalles;
        private MaterialSkin.Controls.MaterialLabel lblDetalles;
        private MaterialSkin.Controls.MaterialLabel lblAyuda;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirAyuda;
    }
}