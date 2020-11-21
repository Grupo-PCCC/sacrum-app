namespace UL
{
    partial class frmNewCashMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCashMovement));
            this.lblAction = new System.Windows.Forms.Label();
            this.dtPicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblObservation = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.RichTextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtExit = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnNewCategory = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtValue = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAction.ForeColor = System.Drawing.Color.Black;
            this.lblAction.Location = new System.Drawing.Point(14, 11);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(12, 16);
            this.lblAction.TabIndex = 0;
            this.lblAction.Text = ".";
            // 
            // dtPicker1
            // 
            this.dtPicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtPicker1.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtPicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(202)))));
            this.dtPicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(202)))));
            this.dtPicker1.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtPicker1.CustomFormat = "dd-MM-yyyy";
            this.dtPicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker1.Location = new System.Drawing.Point(15, 36);
            this.dtPicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtPicker1.Name = "dtPicker1";
            this.dtPicker1.Size = new System.Drawing.Size(262, 22);
            this.dtPicker1.TabIndex = 0;
            this.dtPicker1.Value = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            this.dtPicker1.ValueChanged += new System.EventHandler(this.DtPicker1_ValueChanged);
            this.dtPicker1.Enter += new System.EventHandler(this.DtPicker1_Enter);
            this.dtPicker1.MouseEnter += new System.EventHandler(this.DtPicker1_MouseEnter);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(13, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 16);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "Categoría";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.White;
            this.cbCategory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(16, 92);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(234, 24);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            this.cbCategory.Click += new System.EventHandler(this.CbCategory_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblValue.ForeColor = System.Drawing.Color.Black;
            this.lblValue.Location = new System.Drawing.Point(16, 126);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 16);
            this.lblValue.TabIndex = 27;
            this.lblValue.Text = "Valor";
            // 
            // lblObservation
            // 
            this.lblObservation.AutoSize = true;
            this.lblObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblObservation.ForeColor = System.Drawing.Color.Black;
            this.lblObservation.Location = new System.Drawing.Point(16, 178);
            this.lblObservation.Name = "lblObservation";
            this.lblObservation.Size = new System.Drawing.Size(96, 16);
            this.lblObservation.TabIndex = 29;
            this.lblObservation.Text = "Observación";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 334);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(10, 13);
            this.lblUserId.TabIndex = 33;
            this.lblUserId.Text = ".";
            this.lblUserId.Visible = false;
            // 
            // txtObservation
            // 
            this.txtObservation.BackColor = System.Drawing.Color.White;
            this.txtObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtObservation.ForeColor = System.Drawing.Color.Black;
            this.txtObservation.Location = new System.Drawing.Point(19, 195);
            this.txtObservation.MaxLength = 240;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(255, 149);
            this.txtObservation.TabIndex = 4;
            this.txtObservation.Text = "";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMoney.ForeColor = System.Drawing.Color.Black;
            this.lblMoney.Location = new System.Drawing.Point(1, 148);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(16, 16);
            this.lblMoney.TabIndex = 35;
            this.lblMoney.Text = "$";
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
            this.txtExit.Location = new System.Drawing.Point(250, 354);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(24, 23);
            this.txtExit.TabIndex = 6;
            this.Tip.SetToolTip(this.txtExit, "Cancelar");
            this.txtExit.UseVisualStyleBackColor = false;
            this.txtExit.Click += new System.EventHandler(this.TxtExit_Click);
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
            this.btnAccept.Location = new System.Drawing.Point(195, 354);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(32, 23);
            this.btnAccept.TabIndex = 5;
            this.Tip.SetToolTip(this.btnAccept, "Aceptar");
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click_1);
            // 
            // Tip
            // 
            this.Tip.ForeColor = System.Drawing.Color.Black;
            // 
            // BtnNewCategory
            // 
            this.BtnNewCategory.BackColor = System.Drawing.Color.Transparent;
            this.BtnNewCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewCategory.BackgroundImage")));
            this.BtnNewCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewCategory.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnNewCategory.FlatAppearance.BorderSize = 0;
            this.BtnNewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewCategory.Location = new System.Drawing.Point(269, 91);
            this.BtnNewCategory.Name = "BtnNewCategory";
            this.BtnNewCategory.Size = new System.Drawing.Size(21, 24);
            this.BtnNewCategory.TabIndex = 2;
            this.Tip.SetToolTip(this.BtnNewCategory, "Nueva categoría");
            this.BtnNewCategory.UseVisualStyleBackColor = false;
            this.BtnNewCategory.Click += new System.EventHandler(this.BtnNewCategory_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.Black;
            this.txtValue.Increment = 1D;
            this.txtValue.Location = new System.Drawing.Point(19, 145);
            this.txtValue.MaxValue = 99999.99D;
            this.txtValue.MinValue = 0D;
            this.txtValue.Name = "txtValue";
            this.txtValue.ShowUpDown = true;
            this.txtValue.Size = new System.Drawing.Size(255, 22);
            this.txtValue.TabIndex = 3;
            this.txtValue.WatermarkColor = System.Drawing.SystemColors.Desktop;
            this.txtValue.TextChanged += new System.EventHandler(this.TxtValue_TextChanged_1);
            this.txtValue.Enter += new System.EventHandler(this.TxtValue_Enter_1);
            this.txtValue.Leave += new System.EventHandler(this.TxtValue_Leave_1);
            // 
            // frmNewCashMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 389);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.BtnNewCategory);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblObservation);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.dtPicker1);
            this.Controls.Add(this.lblAction);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewCashMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewCashMovement_FormClosing);
            this.Load += new System.EventHandler(this.FrmNewCashMovement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblObservation;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.RichTextBox txtObservation;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.ToolTip Tip;
        public System.Windows.Forms.DateTimePicker dtPicker1;
        public System.Windows.Forms.ComboBox cbCategory;
        public System.Windows.Forms.Button btnAccept;
        public System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button BtnNewCategory;
        private System.Windows.Forms.ErrorProvider Error;
        private DevComponents.Editors.DoubleInput txtValue;
        public System.Windows.Forms.Label lblAction;
    }
}