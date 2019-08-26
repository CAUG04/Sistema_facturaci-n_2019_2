namespace Sistema_facturación_2019_2
{
    partial class FrmAcercaDe
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
            this.txtDetallesAcercaDe = new System.Windows.Forms.TextBox();
            this.lblDetallesAcercaDe = new MaterialSkin.Controls.MaterialLabel();
            this.lblAceraDe = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtDetallesAcercaDe
            // 
            this.txtDetallesAcercaDe.Location = new System.Drawing.Point(16, 125);
            this.txtDetallesAcercaDe.Multiline = true;
            this.txtDetallesAcercaDe.Name = "txtDetallesAcercaDe";
            this.txtDetallesAcercaDe.Size = new System.Drawing.Size(541, 289);
            this.txtDetallesAcercaDe.TabIndex = 90;
            // 
            // lblDetallesAcercaDe
            // 
            this.lblDetallesAcercaDe.AutoSize = true;
            this.lblDetallesAcercaDe.Depth = 0;
            this.lblDetallesAcercaDe.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetallesAcercaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetallesAcercaDe.Location = new System.Drawing.Point(12, 91);
            this.lblDetallesAcercaDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetallesAcercaDe.Name = "lblDetallesAcercaDe";
            this.lblDetallesAcercaDe.Size = new System.Drawing.Size(64, 19);
            this.lblDetallesAcercaDe.TabIndex = 89;
            this.lblDetallesAcercaDe.Text = "Detalles";
            // 
            // lblAceraDe
            // 
            this.lblAceraDe.AutoSize = true;
            this.lblAceraDe.Depth = 0;
            this.lblAceraDe.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAceraDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAceraDe.Location = new System.Drawing.Point(387, 23);
            this.lblAceraDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAceraDe.Name = "lblAceraDe";
            this.lblAceraDe.Size = new System.Drawing.Size(90, 19);
            this.lblAceraDe.TabIndex = 88;
            this.lblAceraDe.Text = "ACERCA DE";
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.txtDetallesAcercaDe);
            this.Controls.Add(this.lblDetallesAcercaDe);
            this.Controls.Add(this.lblAceraDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAcercaDe";
            this.Text = "FrmAcercaDe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetallesAcercaDe;
        private MaterialSkin.Controls.MaterialLabel lblDetallesAcercaDe;
        private MaterialSkin.Controls.MaterialLabel lblAceraDe;
    }
}