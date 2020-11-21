namespace UL
{
    partial class frmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.chbUsers = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtPicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtPicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.Lbl_Filas = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.clmDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Auditoría";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Lbl_Buscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 89);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Buscar.Location = new System.Drawing.Point(526, 45);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Buscar.TabIndex = 45;
            this.Lbl_Buscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(584, 43);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(251, 22);
            this.txtBuscar.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entre";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(836, 36);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(67, 32);
            this.BtnSearch.TabIndex = 38;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbUsers);
            this.panel3.Controls.Add(this.chbUsers);
            this.panel3.Location = new System.Drawing.Point(337, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 57);
            this.panel3.TabIndex = 43;
            // 
            // cbUsers
            // 
            this.cbUsers.BackColor = System.Drawing.Color.White;
            this.cbUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbUsers.ForeColor = System.Drawing.Color.Black;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(3, 4);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(175, 24);
            this.cbUsers.TabIndex = 36;
            // 
            // chbUsers
            // 
            this.chbUsers.AutoSize = true;
            this.chbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbUsers.ForeColor = System.Drawing.Color.Black;
            this.chbUsers.Location = new System.Drawing.Point(3, 31);
            this.chbUsers.Name = "chbUsers";
            this.chbUsers.Size = new System.Drawing.Size(94, 20);
            this.chbUsers.TabIndex = 37;
            this.chbUsers.Text = "Ver todos";
            this.chbUsers.UseVisualStyleBackColor = true;
            this.chbUsers.CheckedChanged += new System.EventHandler(this.ChbUsers_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtPicker1);
            this.panel1.Controls.Add(this.dtPicker2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 42);
            this.panel1.TabIndex = 41;
            // 
            // dtPicker1
            // 
            this.dtPicker1.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtPicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(202)))));
            this.dtPicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(202)))));
            this.dtPicker1.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtPicker1.CustomFormat = "dd-MM-yyyy";
            this.dtPicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker1.Location = new System.Drawing.Point(5, 7);
            this.dtPicker1.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtPicker1.Name = "dtPicker1";
            this.dtPicker1.Size = new System.Drawing.Size(127, 22);
            this.dtPicker1.TabIndex = 20;
            this.dtPicker1.Value = new System.DateTime(2000, 9, 19, 0, 0, 0, 0);
            // 
            // dtPicker2
            // 
            this.dtPicker2.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtPicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(202)))));
            this.dtPicker2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(202)))));
            this.dtPicker2.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtPicker2.CustomFormat = "dd-MM-yyyy";
            this.dtPicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker2.Location = new System.Drawing.Point(184, 7);
            this.dtPicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtPicker2.Name = "dtPicker2";
            this.dtPicker2.Size = new System.Drawing.Size(134, 22);
            this.dtPicker2.TabIndex = 21;
            this.dtPicker2.Value = new System.DateTime(2019, 9, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(156, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(334, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Usuarios";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1134, 6);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(21, 27);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 46;
            this.btn_cerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_cerrar, "Cerrar");
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_Filas
            // 
            this.Lbl_Filas.AutoSize = true;
            this.Lbl_Filas.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Filas.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Filas.Location = new System.Drawing.Point(6, 658);
            this.Lbl_Filas.Name = "Lbl_Filas";
            this.Lbl_Filas.Size = new System.Drawing.Size(75, 16);
            this.Lbl_Filas.TabIndex = 49;
            this.Lbl_Filas.Text = "Registros";
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDateTime,
            this.clmAction,
            this.clmUser});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLog.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLog.EnableHeadersVisualStyles = false;
            this.dgvLog.Location = new System.Drawing.Point(6, 173);
            this.dgvLog.MultiSelect = false;
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(1149, 446);
            this.dgvLog.TabIndex = 47;
            // 
            // clmDateTime
            // 
            this.clmDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDateTime.FillWeight = 50F;
            this.clmDateTime.HeaderText = "Fecha y hora";
            this.clmDateTime.Name = "clmDateTime";
            this.clmDateTime.ReadOnly = true;
            // 
            // clmAction
            // 
            this.clmAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAction.FillWeight = 150F;
            this.clmAction.HeaderText = "Acción";
            this.clmAction.Name = "clmAction";
            this.clmAction.ReadOnly = true;
            this.clmAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmUser
            // 
            this.clmUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmUser.FillWeight = 50F;
            this.clmUser.HeaderText = "Usuario";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 766);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Lbl_Filas);
            this.Controls.Add(this.dgvLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLog";
            this.Text = "frmLog";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox cbUsers;
        public System.Windows.Forms.CheckBox chbUsers;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtPicker1;
        public System.Windows.Forms.DateTimePicker dtPicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Label Lbl_Filas;
        public System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}