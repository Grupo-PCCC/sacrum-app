namespace UL
{
    partial class frmDataParishioners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataParishioners));
            this.dtBornDate = new System.Windows.Forms.DateTimePicker();
            this.txtObservation = new System.Windows.Forms.RichTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.Lbl_TelP = new System.Windows.Forms.Label();
            this.Lbl_Dni = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Lbl_Apellido = new System.Windows.Forms.Label();
            this.Lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.Lbl_Obs = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtExit = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.btnOtherTelephone = new System.Windows.Forms.Button();
            this.btnOtherMail = new System.Windows.Forms.Button();
            this.btnOtherAddress = new System.Windows.Forms.Button();
            this.chbDateTime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBornDate
            // 
            this.dtBornDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtBornDate.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtBornDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(202)))));
            this.dtBornDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(202)))));
            this.dtBornDate.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtBornDate.CustomFormat = "dd/MM/yyyy";
            this.dtBornDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBornDate.Location = new System.Drawing.Point(15, 162);
            this.dtBornDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBornDate.Name = "dtBornDate";
            this.dtBornDate.Size = new System.Drawing.Size(253, 22);
            this.dtBornDate.TabIndex = 4;
            this.dtBornDate.Value = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            this.dtBornDate.ValueChanged += new System.EventHandler(this.DtBornDate_ValueChanged);
            // 
            // txtObservation
            // 
            this.txtObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtObservation.Location = new System.Drawing.Point(14, 338);
            this.txtObservation.MaxLength = 120;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(255, 92);
            this.txtObservation.TabIndex = 8;
            this.txtObservation.Text = "";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMail.ForeColor = System.Drawing.Color.Black;
            this.txtMail.Location = new System.Drawing.Point(15, 294);
            this.txtMail.MaxLength = 15;
            this.txtMail.Name = "txtMail";
            this.txtMail.ShortcutsEnabled = false;
            this.txtMail.Size = new System.Drawing.Size(253, 22);
            this.txtMail.TabIndex = 7;
            this.txtMail.Enter += new System.EventHandler(this.TxtTelephone2_Enter);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelephone2_KeyPress);
            this.txtMail.Leave += new System.EventHandler(this.TxtTelephone2_Leave);
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.White;
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTelephone.ForeColor = System.Drawing.Color.Black;
            this.txtTelephone.Location = new System.Drawing.Point(15, 206);
            this.txtTelephone.MaxLength = 15;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ShortcutsEnabled = false;
            this.txtTelephone.Size = new System.Drawing.Size(253, 22);
            this.txtTelephone.TabIndex = 5;
            this.txtTelephone.Enter += new System.EventHandler(this.TxtTelephone1_Enter);
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelephone1_KeyPress);
            this.txtTelephone.Leave += new System.EventHandler(this.TxtTelephone1_Leave);
            // 
            // Lbl_TelP
            // 
            this.Lbl_TelP.AutoSize = true;
            this.Lbl_TelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_TelP.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TelP.Location = new System.Drawing.Point(10, 187);
            this.Lbl_TelP.Name = "Lbl_TelP";
            this.Lbl_TelP.Size = new System.Drawing.Size(70, 16);
            this.Lbl_TelP.TabIndex = 20;
            this.Lbl_TelP.Text = "Teléfono";
            // 
            // Lbl_Dni
            // 
            this.Lbl_Dni.AutoSize = true;
            this.Lbl_Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Dni.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Dni.Location = new System.Drawing.Point(10, 7);
            this.Lbl_Dni.Name = "Lbl_Dni";
            this.Lbl_Dni.Size = new System.Drawing.Size(73, 16);
            this.Lbl_Dni.TabIndex = 0;
            this.Lbl_Dni.Text = "Nombre *";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(14, 30);
            this.txtName.MaxLength = 41;
            this.txtName.Name = "txtName";
            this.txtName.ShortcutsEnabled = false;
            this.txtName.Size = new System.Drawing.Size(253, 22);
            this.txtName.TabIndex = 0;
            this.txtName.Enter += new System.EventHandler(this.TxtName_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.TxtName_Leave);
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Apellido.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Apellido.Location = new System.Drawing.Point(11, 55);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(76, 16);
            this.Lbl_Apellido.TabIndex = 1;
            this.Lbl_Apellido.Text = "Apellido *";
            // 
            // Lbl_FechaNacimiento
            // 
            this.Lbl_FechaNacimiento.AutoSize = true;
            this.Lbl_FechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_FechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.Lbl_FechaNacimiento.Location = new System.Drawing.Point(12, 143);
            this.Lbl_FechaNacimiento.Name = "Lbl_FechaNacimiento";
            this.Lbl_FechaNacimiento.Size = new System.Drawing.Size(152, 16);
            this.Lbl_FechaNacimiento.TabIndex = 3;
            this.Lbl_FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // Lbl_Obs
            // 
            this.Lbl_Obs.AutoSize = true;
            this.Lbl_Obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Obs.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Obs.Location = new System.Drawing.Point(12, 319);
            this.Lbl_Obs.Name = "Lbl_Obs";
            this.Lbl_Obs.Size = new System.Drawing.Size(96, 16);
            this.Lbl_Obs.TabIndex = 5;
            this.Lbl_Obs.Text = "Observación";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.White;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(14, 74);
            this.txtSurname.MaxLength = 36;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ShortcutsEnabled = false;
            this.txtSurname.Size = new System.Drawing.Size(254, 22);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Enter += new System.EventHandler(this.TxtSurname_Enter_1);
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSurname_KeyPress);
            this.txtSurname.Leave += new System.EventHandler(this.TxtSurname_Leave);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // txtExit
            // 
            this.txtExit.BackColor = System.Drawing.Color.Transparent;
            this.txtExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtExit.BackgroundImage")));
            this.txtExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtExit.FlatAppearance.BorderSize = 0;
            this.txtExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.txtExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtExit.ForeColor = System.Drawing.Color.Black;
            this.txtExit.Location = new System.Drawing.Point(193, 436);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 23);
            this.txtExit.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtExit, "Cancelar");
            this.txtExit.UseVisualStyleBackColor = false;
            this.txtExit.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(112, 436);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnAccept, "Aceptar");
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(16, 250);
            this.txtAddress.MaxLength = 15;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ShortcutsEnabled = false;
            this.txtAddress.Size = new System.Drawing.Size(253, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mail";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDocumento.ForeColor = System.Drawing.Color.Black;
            this.txtDocumento.Location = new System.Drawing.Point(15, 118);
            this.txtDocumento.MaxLength = 36;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ShortcutsEnabled = false;
            this.txtDocumento.Size = new System.Drawing.Size(254, 22);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDocumento.ForeColor = System.Drawing.Color.Black;
            this.lblDocumento.Location = new System.Drawing.Point(12, 99);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(96, 16);
            this.lblDocumento.TabIndex = 27;
            this.lblDocumento.Text = "Documento *";
            // 
            // btnOtherTelephone
            // 
            this.btnOtherTelephone.BackColor = System.Drawing.Color.Transparent;
            this.btnOtherTelephone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOtherTelephone.BackgroundImage")));
            this.btnOtherTelephone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOtherTelephone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtherTelephone.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnOtherTelephone.FlatAppearance.BorderSize = 0;
            this.btnOtherTelephone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnOtherTelephone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherTelephone.Location = new System.Drawing.Point(274, 206);
            this.btnOtherTelephone.Name = "btnOtherTelephone";
            this.btnOtherTelephone.Size = new System.Drawing.Size(21, 24);
            this.btnOtherTelephone.TabIndex = 11;
            this.btnOtherTelephone.UseVisualStyleBackColor = false;
//            this.btnOtherTelephone.Click += new System.EventHandler(this.BtnOtherTelephone_Click);
            // 
            // btnOtherMail
            // 
            this.btnOtherMail.BackColor = System.Drawing.Color.Transparent;
            this.btnOtherMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOtherMail.BackgroundImage")));
            this.btnOtherMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOtherMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtherMail.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnOtherMail.FlatAppearance.BorderSize = 0;
            this.btnOtherMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnOtherMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherMail.Location = new System.Drawing.Point(275, 294);
            this.btnOtherMail.Name = "btnOtherMail";
            this.btnOtherMail.Size = new System.Drawing.Size(21, 24);
            this.btnOtherMail.TabIndex = 13;
            this.btnOtherMail.UseVisualStyleBackColor = false;
            // 
            // btnOtherAddress
            // 
            this.btnOtherAddress.BackColor = System.Drawing.Color.Transparent;
            this.btnOtherAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOtherAddress.BackgroundImage")));
            this.btnOtherAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOtherAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtherAddress.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnOtherAddress.FlatAppearance.BorderSize = 0;
            this.btnOtherAddress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnOtherAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherAddress.Location = new System.Drawing.Point(276, 250);
            this.btnOtherAddress.Name = "btnOtherAddress";
            this.btnOtherAddress.Size = new System.Drawing.Size(21, 24);
            this.btnOtherAddress.TabIndex = 12;
            this.btnOtherAddress.UseVisualStyleBackColor = false;
            // 
            // chbDateTime
            // 
            this.chbDateTime.AutoSize = true;
            this.chbDateTime.Location = new System.Drawing.Point(280, 166);
            this.chbDateTime.Name = "chbDateTime";
            this.chbDateTime.Size = new System.Drawing.Size(15, 14);
            this.chbDateTime.TabIndex = 3;
            this.chbDateTime.UseVisualStyleBackColor = true;
            this.chbDateTime.CheckedChanged += new System.EventHandler(this.ChbDateTime_CheckedChanged);
            // 
            // frmDataParishioners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 465);
            this.Controls.Add(this.chbDateTime);
            this.Controls.Add(this.btnOtherAddress);
            this.Controls.Add(this.btnOtherMail);
            this.Controls.Add(this.btnOtherTelephone);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dtBornDate);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.Lbl_Dni);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.Lbl_TelP);
            this.Controls.Add(this.Lbl_Obs);
            this.Controls.Add(this.Lbl_FechaNacimiento);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Lbl_Apellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDataParishioners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feligrés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDataParishioners_FormClosing);
            this.Load += new System.EventHandler(this.FrmDataParishioners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.TextBox txtTelephone;
        public System.Windows.Forms.Label Lbl_TelP;
        public System.Windows.Forms.Label Lbl_Dni;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label Lbl_Apellido;
        public System.Windows.Forms.Label Lbl_FechaNacimiento;
        public System.Windows.Forms.Label Lbl_Obs;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.DateTimePicker dtBornDate;
        public System.Windows.Forms.RichTextBox txtObservation;
        public System.Windows.Forms.ErrorProvider Error;
        public System.Windows.Forms.Button txtExit;
        public System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txtDocumento;
        public System.Windows.Forms.Label lblDocumento;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtherAddress;
        private System.Windows.Forms.Button btnOtherMail;
        private System.Windows.Forms.Button btnOtherTelephone;
        public System.Windows.Forms.CheckBox chbDateTime;
    }
}