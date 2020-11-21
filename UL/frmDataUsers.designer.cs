namespace UL
{
    partial class frmDataUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataUsers));
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Apellido = new System.Windows.Forms.Label();
            this.Lbl_Perfil = new System.Windows.Forms.Label();
            this.Txt_Nick = new System.Windows.Forms.TextBox();
            this.Txt_Surname = new System.Windows.Forms.TextBox();
            this.cbprofile = new System.Windows.Forms.ComboBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUserId = new System.Windows.Forms.Label();
            this.Btn_NewP = new System.Windows.Forms.Button();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_CancelUser = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_CancelAdm = new System.Windows.Forms.Button();
            this.Btn_CancelFirst = new System.Windows.Forms.Button();
            this.Btn_UserPass = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Lbl_NUser = new System.Windows.Forms.Label();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_RPass = new System.Windows.Forms.TextBox();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Repetir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Usuario.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(62, 16);
            this.Lbl_Usuario.TabIndex = 23;
            this.Lbl_Usuario.Text = "Usuario";
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Apellido.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Apellido.Location = new System.Drawing.Point(15, 191);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(66, 16);
            this.Lbl_Apellido.TabIndex = 27;
            this.Lbl_Apellido.Text = "Apellido";
            // 
            // Lbl_Perfil
            // 
            this.Lbl_Perfil.AutoSize = true;
            this.Lbl_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Perfil.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Perfil.Location = new System.Drawing.Point(15, 237);
            this.Lbl_Perfil.Name = "Lbl_Perfil";
            this.Lbl_Perfil.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Perfil.TabIndex = 28;
            this.Lbl_Perfil.Text = "Perfil";
            this.Lbl_Perfil.Click += new System.EventHandler(this.Lbl_Perfil_Click);
            // 
            // Txt_Nick
            // 
            this.Txt_Nick.BackColor = System.Drawing.Color.White;
            this.Txt_Nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Txt_Nick.ForeColor = System.Drawing.Color.Black;
            this.Txt_Nick.Location = new System.Drawing.Point(18, 28);
            this.Txt_Nick.MaxLength = 16;
            this.Txt_Nick.Name = "Txt_Nick";
            this.Txt_Nick.ShortcutsEnabled = false;
            this.Txt_Nick.Size = new System.Drawing.Size(191, 22);
            this.Txt_Nick.TabIndex = 0;
            this.Txt_Nick.Enter += new System.EventHandler(this.Txt_Nick_Enter);
            // 
            // Txt_Surname
            // 
            this.Txt_Surname.BackColor = System.Drawing.Color.White;
            this.Txt_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Txt_Surname.ForeColor = System.Drawing.Color.Black;
            this.Txt_Surname.Location = new System.Drawing.Point(18, 210);
            this.Txt_Surname.MaxLength = 36;
            this.Txt_Surname.Name = "Txt_Surname";
            this.Txt_Surname.ShortcutsEnabled = false;
            this.Txt_Surname.Size = new System.Drawing.Size(191, 22);
            this.Txt_Surname.TabIndex = 33;
            this.Txt_Surname.Enter += new System.EventHandler(this.Txt_Surname_Enter);
            this.Txt_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Surname_KeyPress);
            // 
            // cbprofile
            // 
            this.cbprofile.BackColor = System.Drawing.Color.White;
            this.cbprofile.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbprofile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbprofile.ForeColor = System.Drawing.Color.Black;
            this.cbprofile.Location = new System.Drawing.Point(18, 258);
            this.cbprofile.MaxDropDownItems = 2;
            this.cbprofile.Name = "cbprofile";
            this.cbprofile.Size = new System.Drawing.Size(191, 24);
            this.cbprofile.TabIndex = 37;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 373);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(10, 13);
            this.lblUserId.TabIndex = 40;
            this.lblUserId.Text = ".";
            this.lblUserId.Visible = false;
            // 
            // Btn_NewP
            // 
            this.Btn_NewP.BackColor = System.Drawing.Color.Transparent;
            this.Btn_NewP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_NewP.BackgroundImage")));
            this.Btn_NewP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_NewP.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_NewP.FlatAppearance.BorderSize = 0;
            this.Btn_NewP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_NewP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NewP.Location = new System.Drawing.Point(214, 68);
            this.Btn_NewP.Name = "Btn_NewP";
            this.Btn_NewP.Size = new System.Drawing.Size(29, 25);
            this.Btn_NewP.TabIndex = 45;
            this.Tip.SetToolTip(this.Btn_NewP, "Blanquear contraseña");
            this.Btn_NewP.UseVisualStyleBackColor = false;
            this.Btn_NewP.Click += new System.EventHandler(this.Btn_NewP_Click);
            // 
            // Tip
            // 
            this.Tip.ForeColor = System.Drawing.Color.Black;
            // 
            // Btn_CancelUser
            // 
            this.Btn_CancelUser.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CancelUser.BackgroundImage")));
            this.Btn_CancelUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_CancelUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_CancelUser.FlatAppearance.BorderSize = 0;
            this.Btn_CancelUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_CancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelUser.Location = new System.Drawing.Point(189, 288);
            this.Btn_CancelUser.Name = "Btn_CancelUser";
            this.Btn_CancelUser.Size = new System.Drawing.Size(20, 23);
            this.Btn_CancelUser.TabIndex = 41;
            this.Tip.SetToolTip(this.Btn_CancelUser, "Cancelar");
            this.Btn_CancelUser.UseVisualStyleBackColor = false;
            this.Btn_CancelUser.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.BackColor = System.Drawing.Color.Transparent;
            this.Btn_New.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_New.BackgroundImage")));
            this.Btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_New.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_New.FlatAppearance.BorderSize = 0;
            this.Btn_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_New.Location = new System.Drawing.Point(154, 288);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(20, 23);
            this.Btn_New.TabIndex = 42;
            this.Tip.SetToolTip(this.Btn_New, "Aceptar");
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_CancelAdm
            // 
            this.Btn_CancelAdm.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelAdm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CancelAdm.BackgroundImage")));
            this.Btn_CancelAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_CancelAdm.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_CancelAdm.FlatAppearance.BorderSize = 0;
            this.Btn_CancelAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_CancelAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelAdm.Location = new System.Drawing.Point(189, 288);
            this.Btn_CancelAdm.Name = "Btn_CancelAdm";
            this.Btn_CancelAdm.Size = new System.Drawing.Size(20, 23);
            this.Btn_CancelAdm.TabIndex = 46;
            this.Tip.SetToolTip(this.Btn_CancelAdm, "Cancelar");
            this.Btn_CancelAdm.UseVisualStyleBackColor = false;
            this.Btn_CancelAdm.Click += new System.EventHandler(this.Btn_CancelAdm_Click);
            // 
            // Btn_CancelFirst
            // 
            this.Btn_CancelFirst.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CancelFirst.BackgroundImage")));
            this.Btn_CancelFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_CancelFirst.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_CancelFirst.FlatAppearance.BorderSize = 0;
            this.Btn_CancelFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_CancelFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelFirst.Location = new System.Drawing.Point(189, 288);
            this.Btn_CancelFirst.Name = "Btn_CancelFirst";
            this.Btn_CancelFirst.Size = new System.Drawing.Size(20, 23);
            this.Btn_CancelFirst.TabIndex = 47;
            this.Tip.SetToolTip(this.Btn_CancelFirst, "Cancelar");
            this.Btn_CancelFirst.UseVisualStyleBackColor = false;
            this.Btn_CancelFirst.Click += new System.EventHandler(this.Btn_CancelFirst_Click);
            // 
            // Btn_UserPass
            // 
            this.Btn_UserPass.BackColor = System.Drawing.Color.Transparent;
            this.Btn_UserPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_UserPass.BackgroundImage")));
            this.Btn_UserPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_UserPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_UserPass.FlatAppearance.BorderSize = 0;
            this.Btn_UserPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_UserPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UserPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_UserPass.Location = new System.Drawing.Point(154, 288);
            this.Btn_UserPass.Name = "Btn_UserPass";
            this.Btn_UserPass.Size = new System.Drawing.Size(20, 23);
            this.Btn_UserPass.TabIndex = 48;
            this.Tip.SetToolTip(this.Btn_UserPass, "Aceptar");
            this.Btn_UserPass.UseVisualStyleBackColor = false;
            this.Btn_UserPass.Click += new System.EventHandler(this.Btn_UserPass_Click_1);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Refresh.BackgroundImage")));
            this.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Refresh.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Refresh.Location = new System.Drawing.Point(154, 288);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(20, 23);
            this.Btn_Refresh.TabIndex = 49;
            this.Tip.SetToolTip(this.Btn_Refresh, "Aceptar");
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click_1);
            // 
            // Lbl_NUser
            // 
            this.Lbl_NUser.AutoSize = true;
            this.Lbl_NUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_NUser.ForeColor = System.Drawing.Color.Black;
            this.Lbl_NUser.Location = new System.Drawing.Point(37, 53);
            this.Lbl_NUser.Name = "Lbl_NUser";
            this.Lbl_NUser.Size = new System.Drawing.Size(62, 16);
            this.Lbl_NUser.TabIndex = 44;
            this.Lbl_NUser.Text = "Usuario";
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Contraseña.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Contraseña.Location = new System.Drawing.Point(12, 53);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(87, 16);
            this.Lbl_Contraseña.TabIndex = 24;
            this.Lbl_Contraseña.Text = "Contraseña";
            // 
            // Txt_Name
            // 
            this.Txt_Name.BackColor = System.Drawing.Color.White;
            this.Txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Txt_Name.ForeColor = System.Drawing.Color.Black;
            this.Txt_Name.Location = new System.Drawing.Point(18, 163);
            this.Txt_Name.MaxLength = 41;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.ShortcutsEnabled = false;
            this.Txt_Name.Size = new System.Drawing.Size(191, 22);
            this.Txt_Name.TabIndex = 32;
            this.Txt_Name.Enter += new System.EventHandler(this.Txt_Name_Enter);
            this.Txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // Txt_RPass
            // 
            this.Txt_RPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Txt_RPass.ForeColor = System.Drawing.Color.Black;
            this.Txt_RPass.Location = new System.Drawing.Point(12, 117);
            this.Txt_RPass.MaxLength = 15;
            this.Txt_RPass.Name = "Txt_RPass";
            this.Txt_RPass.PasswordChar = '*';
            this.Txt_RPass.Size = new System.Drawing.Size(194, 22);
            this.Txt_RPass.TabIndex = 31;
            this.Txt_RPass.Enter += new System.EventHandler(this.Txt_RPass_Enter);
            this.Txt_RPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_RPass_KeyPress);
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Txt_Pass.ForeColor = System.Drawing.Color.Black;
            this.Txt_Pass.Location = new System.Drawing.Point(15, 70);
            this.Txt_Pass.MaxLength = 15;
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.PasswordChar = '*';
            this.Txt_Pass.Size = new System.Drawing.Size(194, 22);
            this.Txt_Pass.TabIndex = 30;
            this.Txt_Pass.Enter += new System.EventHandler(this.Txt_Pass_Enter);
            this.Txt_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pass_KeyPress);
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Nombre.Location = new System.Drawing.Point(15, 142);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(63, 16);
            this.Lbl_Nombre.TabIndex = 26;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Lbl_Repetir
            // 
            this.Lbl_Repetir.AutoSize = true;
            this.Lbl_Repetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Repetir.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Repetir.Location = new System.Drawing.Point(12, 97);
            this.Lbl_Repetir.Name = "Lbl_Repetir";
            this.Lbl_Repetir.Size = new System.Drawing.Size(140, 16);
            this.Lbl_Repetir.TabIndex = 25;
            this.Lbl_Repetir.Text = "Repetir contraseña";
            // 
            // frmDataUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(245, 313);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_UserPass);
            this.Controls.Add(this.Btn_NewP);
            this.Controls.Add(this.Btn_CancelFirst);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Btn_CancelAdm);
            this.Controls.Add(this.Lbl_Contraseña);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Lbl_NUser);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.Lbl_Repetir);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_Apellido);
            this.Controls.Add(this.Btn_CancelUser);
            this.Controls.Add(this.Lbl_Perfil);
            this.Controls.Add(this.Txt_Nick);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_Surname);
            this.Controls.Add(this.cbprofile);
            this.Controls.Add(this.Txt_RPass);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDataUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDataUsers_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Label lblUserId;
        public System.Windows.Forms.TextBox Txt_Nick;
        public System.Windows.Forms.TextBox Txt_Surname;
        public System.Windows.Forms.ComboBox cbprofile;
        public System.Windows.Forms.Label Lbl_Usuario;
        public System.Windows.Forms.Label Lbl_Apellido;
        public System.Windows.Forms.Label Lbl_Perfil;
        public System.Windows.Forms.Button Btn_NewP;
        private System.Windows.Forms.ToolTip Tip;
        public System.Windows.Forms.Button Btn_CancelFirst;
        public System.Windows.Forms.Button Btn_CancelAdm;
        public System.Windows.Forms.Button Btn_New;
        public System.Windows.Forms.Button Btn_CancelUser;
        public System.Windows.Forms.Label Lbl_Contraseña;
        public System.Windows.Forms.Label Lbl_NUser;
        public System.Windows.Forms.Label Lbl_Repetir;
        public System.Windows.Forms.Label Lbl_Nombre;
        public System.Windows.Forms.TextBox Txt_Pass;
        public System.Windows.Forms.TextBox Txt_RPass;
        public System.Windows.Forms.TextBox Txt_Name;
        public System.Windows.Forms.Button Btn_UserPass;
        public System.Windows.Forms.Button Btn_Refresh;
    }
}