namespace UL
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.Btn_Proveedor = new System.Windows.Forms.Button();
            this.Btn_LogOff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUserAndLogout = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.Pic_User = new System.Windows.Forms.PictureBox();
            this.PnlSubMenuSys = new System.Windows.Forms.Panel();
            this.BtnLogAudit = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.Btn_System = new System.Windows.Forms.Button();
            this.Btn_Datos = new System.Windows.Forms.Button();
            this.Btn_Prov = new System.Windows.Forms.Button();
            this.Btn_Cash = new System.Windows.Forms.Button();
            this.Btn_Activities = new System.Windows.Forms.Button();
            this.Btn_Parish = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelContenedor.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUserAndLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_User)).BeginInit();
            this.PnlSubMenuSys.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelformularios);
            this.panelContenedor.Controls.Add(this.PnlButtons);
            resources.ApplyResources(this.panelContenedor, "panelContenedor");
            this.panelContenedor.Name = "panelContenedor";
            // 
            // panelformularios
            // 
            this.panelformularios.BackColor = System.Drawing.Color.LightGray;
            this.panelformularios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.panelformularios, "panelformularios");
            this.panelformularios.Name = "panelformularios";
            // 
            // PnlButtons
            // 
            this.PnlButtons.BackColor = System.Drawing.Color.White;
            this.PnlButtons.Controls.Add(this.Btn_Proveedor);
            this.PnlButtons.Controls.Add(this.Btn_LogOff);
            this.PnlButtons.Controls.Add(this.pictureBox1);
            this.PnlButtons.Controls.Add(this.pnlUserAndLogout);
            this.PnlButtons.Controls.Add(this.PnlSubMenuSys);
            this.PnlButtons.Controls.Add(this.Btn_System);
            this.PnlButtons.Controls.Add(this.Btn_Datos);
            this.PnlButtons.Controls.Add(this.Btn_Prov);
            this.PnlButtons.Controls.Add(this.Btn_Cash);
            this.PnlButtons.Controls.Add(this.Btn_Activities);
            this.PnlButtons.Controls.Add(this.Btn_Parish);
            resources.ApplyResources(this.PnlButtons, "PnlButtons");
            this.PnlButtons.Name = "PnlButtons";
            // 
            // Btn_Proveedor
            // 
            this.Btn_Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Proveedor.FlatAppearance.BorderSize = 0;
            this.Btn_Proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Btn_Proveedor, "Btn_Proveedor");
            this.Btn_Proveedor.ForeColor = System.Drawing.Color.Black;
            this.Btn_Proveedor.Name = "Btn_Proveedor";
            this.toolTip1.SetToolTip(this.Btn_Proveedor, resources.GetString("Btn_Proveedor.ToolTip"));
            this.Btn_Proveedor.UseVisualStyleBackColor = false;
            this.Btn_Proveedor.Click += new System.EventHandler(this.Btn_Proveedor_Click);
            // 
            // Btn_LogOff
            // 
            this.Btn_LogOff.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_LogOff, "Btn_LogOff");
            this.Btn_LogOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_LogOff.FlatAppearance.BorderSize = 0;
            this.Btn_LogOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_LogOff.ForeColor = System.Drawing.Color.Black;
            this.Btn_LogOff.Name = "Btn_LogOff";
            this.toolTip1.SetToolTip(this.Btn_LogOff, resources.GetString("Btn_LogOff.ToolTip"));
            this.Btn_LogOff.UseVisualStyleBackColor = false;
            this.Btn_LogOff.Click += new System.EventHandler(this.Btn_LogOff_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pnlUserAndLogout
            // 
            this.pnlUserAndLogout.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserAndLogout.Controls.Add(this.lblUser);
            this.pnlUserAndLogout.Controls.Add(this.Pic_User);
            resources.ApplyResources(this.pnlUserAndLogout, "pnlUserAndLogout");
            this.pnlUserAndLogout.Name = "pnlUserAndLogout";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Name = "lblUser";
            this.toolTip1.SetToolTip(this.lblUser, resources.GetString("lblUser.ToolTip"));
            // 
            // Pic_User
            // 
            this.Pic_User.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.Pic_User, "Pic_User");
            this.Pic_User.Name = "Pic_User";
            this.Pic_User.TabStop = false;
            this.toolTip1.SetToolTip(this.Pic_User, resources.GetString("Pic_User.ToolTip"));
            // 
            // PnlSubMenuSys
            // 
            this.PnlSubMenuSys.BackColor = System.Drawing.Color.Transparent;
            this.PnlSubMenuSys.Controls.Add(this.BtnLogAudit);
            this.PnlSubMenuSys.Controls.Add(this.BtnUsers);
            resources.ApplyResources(this.PnlSubMenuSys, "PnlSubMenuSys");
            this.PnlSubMenuSys.Name = "PnlSubMenuSys";
            // 
            // BtnLogAudit
            // 
            this.BtnLogAudit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogAudit.FlatAppearance.BorderSize = 0;
            this.BtnLogAudit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.BtnLogAudit, "BtnLogAudit");
            this.BtnLogAudit.ForeColor = System.Drawing.Color.Black;
            this.BtnLogAudit.Name = "BtnLogAudit";
            this.toolTip1.SetToolTip(this.BtnLogAudit, resources.GetString("BtnLogAudit.ToolTip"));
            this.BtnLogAudit.UseVisualStyleBackColor = true;
            this.BtnLogAudit.Click += new System.EventHandler(this.BtnLogAudit_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.BtnUsers, "BtnUsers");
            this.BtnUsers.ForeColor = System.Drawing.Color.Black;
            this.BtnUsers.Name = "BtnUsers";
            this.toolTip1.SetToolTip(this.BtnUsers, resources.GetString("BtnUsers.ToolTip"));
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // Btn_System
            // 
            this.Btn_System.BackColor = System.Drawing.Color.Transparent;
            this.Btn_System.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_System.FlatAppearance.BorderSize = 0;
            this.Btn_System.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Btn_System, "Btn_System");
            this.Btn_System.ForeColor = System.Drawing.Color.Black;
            this.Btn_System.Name = "Btn_System";
            this.toolTip1.SetToolTip(this.Btn_System, resources.GetString("Btn_System.ToolTip"));
            this.Btn_System.UseVisualStyleBackColor = false;
            this.Btn_System.Click += new System.EventHandler(this.Btn_System_Click);
            // 
            // Btn_Datos
            // 
            this.Btn_Datos.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Datos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Datos.FlatAppearance.BorderSize = 0;
            this.Btn_Datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Btn_Datos, "Btn_Datos");
            this.Btn_Datos.ForeColor = System.Drawing.Color.Black;
            this.Btn_Datos.Name = "Btn_Datos";
            this.toolTip1.SetToolTip(this.Btn_Datos, resources.GetString("Btn_Datos.ToolTip"));
            this.Btn_Datos.UseVisualStyleBackColor = false;
            this.Btn_Datos.Click += new System.EventHandler(this.Btn_Datos_Click);
            // 
            // Btn_Prov
            // 
            this.Btn_Prov.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Prov.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Btn_Prov, "Btn_Prov");
            this.Btn_Prov.FlatAppearance.BorderSize = 0;
            this.Btn_Prov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_Prov.ForeColor = System.Drawing.Color.Black;
            this.Btn_Prov.Name = "Btn_Prov";
            this.toolTip1.SetToolTip(this.Btn_Prov, resources.GetString("Btn_Prov.ToolTip"));
            this.Btn_Prov.UseVisualStyleBackColor = false;
            this.Btn_Prov.Click += new System.EventHandler(this.Btn_Prov_Click);
            // 
            // Btn_Cash
            // 
            this.Btn_Cash.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cash.FlatAppearance.BorderSize = 0;
            this.Btn_Cash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Btn_Cash, "Btn_Cash");
            this.Btn_Cash.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cash.Name = "Btn_Cash";
            this.toolTip1.SetToolTip(this.Btn_Cash, resources.GetString("Btn_Cash.ToolTip"));
            this.Btn_Cash.UseVisualStyleBackColor = false;
            this.Btn_Cash.Click += new System.EventHandler(this.Btn_Cash_Click);
            // 
            // Btn_Activities
            // 
            this.Btn_Activities.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Activities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Activities.FlatAppearance.BorderSize = 0;
            this.Btn_Activities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Btn_Activities, "Btn_Activities");
            this.Btn_Activities.ForeColor = System.Drawing.Color.Black;
            this.Btn_Activities.Name = "Btn_Activities";
            this.toolTip1.SetToolTip(this.Btn_Activities, resources.GetString("Btn_Activities.ToolTip"));
            this.Btn_Activities.UseVisualStyleBackColor = false;
            this.Btn_Activities.Click += new System.EventHandler(this.Btn_Activities_Click);
            // 
            // Btn_Parish
            // 
            this.Btn_Parish.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Parish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Parish.FlatAppearance.BorderSize = 0;
            this.Btn_Parish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Btn_Parish, "Btn_Parish");
            this.Btn_Parish.ForeColor = System.Drawing.Color.Black;
            this.Btn_Parish.Name = "Btn_Parish";
            this.toolTip1.SetToolTip(this.Btn_Parish, resources.GetString("Btn_Parish.ToolTip"));
            this.Btn_Parish.UseVisualStyleBackColor = false;
            this.Btn_Parish.Click += new System.EventHandler(this.Btn_Parish_Click);
            // 
            // frmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMenu_KeyUp);
            this.panelContenedor.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUserAndLogout.ResumeLayout(false);
            this.pnlUserAndLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_User)).EndInit();
            this.PnlSubMenuSys.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox Pic_User;
        public System.Windows.Forms.Button Btn_Parish;
        public System.Windows.Forms.Button Btn_Cash;
        public System.Windows.Forms.Button Btn_Activities;
        public System.Windows.Forms.Button Btn_Prov;
        public System.Windows.Forms.Button Btn_Datos;
        public System.Windows.Forms.Button Btn_System;
        public System.Windows.Forms.Button BtnLogAudit;
        public System.Windows.Forms.Button BtnUsers;
        public System.Windows.Forms.Panel PnlSubMenuSys;
        private System.Windows.Forms.Panel pnlUserAndLogout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Btn_LogOff;
        public System.Windows.Forms.Button Btn_Proveedor;
    }
}

