namespace Sistema_facturación_2019_2
{
    partial class FrmPrincipal
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
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.tablas = new System.Windows.Forms.TabPage();
            this.facturación = new System.Windows.Forms.TabPage();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.tabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlPrincipal.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.PnlMenu);
            this.PnlPrincipal.Location = new System.Drawing.Point(1, 63);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1199, 588);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.TbpMenu);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(200, 588);
            this.PnlMenu.TabIndex = 0;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Controls.Add(this.Principal);
            this.TbpMenu.Controls.Add(this.tablas);
            this.TbpMenu.Controls.Add(this.facturación);
            this.TbpMenu.Controls.Add(this.Seguridad);
            this.TbpMenu.Controls.Add(this.Acerca);
            this.TbpMenu.Depth = 0;
            this.TbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbpMenu.Location = new System.Drawing.Point(0, 0);
            this.TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.SelectedIndex = 0;
            this.TbpMenu.Size = new System.Drawing.Size(200, 588);
            this.TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 562);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // tablas
            // 
            this.tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tablas.Location = new System.Drawing.Point(4, 22);
            this.tablas.Name = "tablas";
            this.tablas.Padding = new System.Windows.Forms.Padding(3);
            this.tablas.Size = new System.Drawing.Size(192, 562);
            this.tablas.TabIndex = 1;
            this.tablas.Text = "Admin Tablas";
            // 
            // facturación
            // 
            this.facturación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.facturación.Location = new System.Drawing.Point(4, 22);
            this.facturación.Name = "facturación";
            this.facturación.Size = new System.Drawing.Size(192, 562);
            this.facturación.TabIndex = 2;
            this.facturación.Text = "facturación";
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 562);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // Acerca
            // 
            this.Acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Acerca.Location = new System.Drawing.Point(4, 22);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(192, 562);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "Acerca de...";
            // 
            // tabOpcionesMenu
            // 
            this.tabOpcionesMenu.BaseTabControl = this.TbpMenu;
            this.tabOpcionesMenu.Depth = 0;
            this.tabOpcionesMenu.Location = new System.Drawing.Point(313, 27);
            this.tabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionesMenu.Name = "tabOpcionesMenu";
            this.tabOpcionesMenu.Size = new System.Drawing.Size(771, 30);
            this.tabOpcionesMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Sistema_facturación_2019_2.Properties.Resources.descarga;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(6, 174);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(178, 37);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_facturación_2019_2.Properties.Resources.bar_code;
            this.pictureBox1.Location = new System.Drawing.Point(7, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabOpcionesMenu);
            this.Controls.Add(this.PnlPrincipal);
            this.Name = "FrmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.TbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PnlMenu;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage tablas;
        private System.Windows.Forms.TabPage facturación;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca;
        private MaterialSkin.Controls.MaterialTabSelector tabOpcionesMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}