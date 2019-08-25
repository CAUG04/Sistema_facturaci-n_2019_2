namespace Sistema_facturación_2019_2
{
    partial class FrmInformes
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
            this.lblSeleccionarInforme = new MaterialSkin.Controls.MaterialLabel();
            this.cboSeleccionarInforme = new System.Windows.Forms.ComboBox();
            this.BtnSalirFacturas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblFacturas = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaInicial = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.mncFechaInicial = new System.Windows.Forms.MonthCalendar();
            this.mncFechaFinal = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lblSeleccionarInforme
            // 
            this.lblSeleccionarInforme.AutoSize = true;
            this.lblSeleccionarInforme.Depth = 0;
            this.lblSeleccionarInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSeleccionarInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeleccionarInforme.Location = new System.Drawing.Point(457, 84);
            this.lblSeleccionarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccionarInforme.Name = "lblSeleccionarInforme";
            this.lblSeleccionarInforme.Size = new System.Drawing.Size(144, 19);
            this.lblSeleccionarInforme.TabIndex = 67;
            this.lblSeleccionarInforme.Text = "Seleccionar Informe";
            // 
            // cboSeleccionarInforme
            // 
            this.cboSeleccionarInforme.FormattingEnabled = true;
            this.cboSeleccionarInforme.Location = new System.Drawing.Point(607, 85);
            this.cboSeleccionarInforme.Name = "cboSeleccionarInforme";
            this.cboSeleccionarInforme.Size = new System.Drawing.Size(144, 21);
            this.cboSeleccionarInforme.TabIndex = 66;
            // 
            // BtnSalirFacturas
            // 
            this.BtnSalirFacturas.Depth = 0;
            this.BtnSalirFacturas.Location = new System.Drawing.Point(855, 408);
            this.BtnSalirFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalirFacturas.Name = "BtnSalirFacturas";
            this.BtnSalirFacturas.Primary = true;
            this.BtnSalirFacturas.Size = new System.Drawing.Size(86, 24);
            this.BtnSalirFacturas.TabIndex = 64;
            this.BtnSalirFacturas.Text = "Salir";
            this.BtnSalirFacturas.UseVisualStyleBackColor = true;
            this.BtnSalirFacturas.Click += new System.EventHandler(this.BtnSalirFacturas_Click);
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Depth = 0;
            this.lblFacturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFacturas.Location = new System.Drawing.Point(387, 22);
            this.lblFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(84, 19);
            this.lblFacturas.TabIndex = 54;
            this.lblFacturas.Text = "FACTURAS";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Depth = 0;
            this.lblFechaInicial.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaInicial.Location = new System.Drawing.Point(4, 84);
            this.lblFechaInicial.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(93, 19);
            this.lblFechaInicial.TabIndex = 72;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaFinal.Location = new System.Drawing.Point(4, 335);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(85, 19);
            this.lblFechaFinal.TabIndex = 73;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // mncFechaInicial
            // 
            this.mncFechaInicial.Location = new System.Drawing.Point(123, 84);
            this.mncFechaInicial.Name = "mncFechaInicial";
            this.mncFechaInicial.TabIndex = 74;
            // 
            // mncFechaFinal
            // 
            this.mncFechaFinal.Location = new System.Drawing.Point(123, 335);
            this.mncFechaFinal.Name = "mncFechaFinal";
            this.mncFechaFinal.TabIndex = 75;
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.mncFechaFinal);
            this.Controls.Add(this.mncFechaInicial);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.lblSeleccionarInforme);
            this.Controls.Add(this.cboSeleccionarInforme);
            this.Controls.Add(this.BtnSalirFacturas);
            this.Controls.Add(this.lblFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformes";
            this.Text = "FrmInformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblSeleccionarInforme;
        private System.Windows.Forms.ComboBox cboSeleccionarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalirFacturas;
        private MaterialSkin.Controls.MaterialLabel lblFacturas;
        private MaterialSkin.Controls.MaterialLabel lblFechaInicial;
        private MaterialSkin.Controls.MaterialLabel lblFechaFinal;
        private System.Windows.Forms.MonthCalendar mncFechaInicial;
        private System.Windows.Forms.MonthCalendar mncFechaFinal;
    }
}