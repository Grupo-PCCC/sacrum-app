namespace UL
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.Logo_Principal = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUser.Location = new System.Drawing.Point(62, 191);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(220, 27);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.Txt_usuario_Enter);
            this.txtUser.Leave += new System.EventHandler(this.Txt_usuario_Leave);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_password.Location = new System.Drawing.Point(62, 232);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(220, 27);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "PASSWORD";
            this.txt_password.TextChanged += new System.EventHandler(this.Txt_password_TextChanged);
            this.txt_password.Enter += new System.EventHandler(this.Txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.Txt_password_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(31, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(31, 192);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ingresar.BackgroundImage")));
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ingresar.ForeColor = System.Drawing.Color.Black;
            this.btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ingresar.Location = new System.Drawing.Point(97, 279);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(135, 43);
            this.btn_ingresar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_ingresar, "Iniciar sesión");
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Logo_Principal
            // 
            this.Logo_Principal.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Principal.Image = ((System.Drawing.Image)(resources.GetObject("Logo_Principal.Image")));
            this.Logo_Principal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logo_Principal.Location = new System.Drawing.Point(1, 11);
            this.Logo_Principal.Margin = new System.Windows.Forms.Padding(2);
            this.Logo_Principal.Name = "Logo_Principal";
            this.Logo_Principal.Size = new System.Drawing.Size(339, 176);
            this.Logo_Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_Principal.TabIndex = 11;
            this.Logo_Principal.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 343);
            this.Controls.Add(this.Logo_Principal);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txt_password);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Logo_Principal;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}