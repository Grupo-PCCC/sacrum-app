namespace UL
{
    partial class frmModifyActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyActivity));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtExit = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dgvParishLeft = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvParishRight = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnParishToRight = new System.Windows.Forms.Button();
            this.btnParishToLeft = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnNewParishioner = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParishLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParishRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(6, 53);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 16);
            this.lblDescription.TabIndex = 48;
            this.lblDescription.Text = "Descripción";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(9, 72);
            this.txtDescription.MaxLength = 120;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(535, 79);
            this.txtDescription.TabIndex = 47;
            this.txtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(9, 28);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(535, 22);
            this.txtName.TabIndex = 45;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(6, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 16);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Nombre";
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
            this.txtExit.Location = new System.Drawing.Point(279, 426);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(53, 23);
            this.txtExit.TabIndex = 50;
            this.toolTip1.SetToolTip(this.txtExit, "Cancelar");
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
            this.btnAccept.Location = new System.Drawing.Point(221, 426);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(52, 23);
            this.btnAccept.TabIndex = 49;
            this.toolTip1.SetToolTip(this.btnAccept, "Aceptar");
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // dgvParishLeft
            // 
            this.dgvParishLeft.AllowUserToAddRows = false;
            this.dgvParishLeft.AllowUserToDeleteRows = false;
            this.dgvParishLeft.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvParishLeft.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvParishLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParishLeft.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvParishLeft.BackgroundColor = System.Drawing.Color.White;
            this.dgvParishLeft.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvParishLeft.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParishLeft.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParishLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParishLeft.ColumnHeadersVisible = false;
            this.dgvParishLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.Nombre});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParishLeft.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvParishLeft.EnableHeadersVisualStyles = false;
            this.dgvParishLeft.Location = new System.Drawing.Point(9, 176);
            this.dgvParishLeft.MultiSelect = false;
            this.dgvParishLeft.Name = "dgvParishLeft";
            this.dgvParishLeft.ReadOnly = true;
            this.dgvParishLeft.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvParishLeft.RowHeadersVisible = false;
            this.dgvParishLeft.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParishLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParishLeft.Size = new System.Drawing.Size(206, 244);
            this.dgvParishLeft.TabIndex = 64;
            this.dgvParishLeft.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParishLeft_CellClick);
            this.dgvParishLeft.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Activities_CellContentClick);
            this.dgvParishLeft.SelectionChanged += new System.EventHandler(this.DgvParishLeft_SelectionChanged);
            // 
            // clmId
            // 
            this.clmId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            this.clmId.Width = 41;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.FillWeight = 50F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // dgvParishRight
            // 
            this.dgvParishRight.AllowUserToAddRows = false;
            this.dgvParishRight.AllowUserToDeleteRows = false;
            this.dgvParishRight.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvParishRight.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvParishRight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParishRight.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvParishRight.BackgroundColor = System.Drawing.Color.White;
            this.dgvParishRight.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvParishRight.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParishRight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvParishRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParishRight.ColumnHeadersVisible = false;
            this.dgvParishRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParishRight.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvParishRight.EnableHeadersVisualStyles = false;
            this.dgvParishRight.Location = new System.Drawing.Point(338, 176);
            this.dgvParishRight.MultiSelect = false;
            this.dgvParishRight.Name = "dgvParishRight";
            this.dgvParishRight.ReadOnly = true;
            this.dgvParishRight.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvParishRight.RowHeadersVisible = false;
            this.dgvParishRight.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParishRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParishRight.Size = new System.Drawing.Size(206, 244);
            this.dgvParishRight.TabIndex = 65;
            this.dgvParishRight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParishRight_CellClick);
            this.dgvParishRight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParishRight_CellContentClick);
            this.dgvParishRight.SelectionChanged += new System.EventHandler(this.DgvParishRight_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnParishToRight
            // 
            this.btnParishToRight.BackColor = System.Drawing.Color.Transparent;
            this.btnParishToRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnParishToRight.BackgroundImage")));
            this.btnParishToRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParishToRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnParishToRight.FlatAppearance.BorderSize = 0;
            this.btnParishToRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnParishToRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParishToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnParishToRight.ForeColor = System.Drawing.Color.Black;
            this.btnParishToRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParishToRight.Location = new System.Drawing.Point(221, 257);
            this.btnParishToRight.Name = "btnParishToRight";
            this.btnParishToRight.Size = new System.Drawing.Size(111, 43);
            this.btnParishToRight.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btnParishToRight, "Agregar feligrés a la actividad");
            this.btnParishToRight.UseVisualStyleBackColor = false;
            this.btnParishToRight.Click += new System.EventHandler(this.BtnParishToRight_Click);
            // 
            // btnParishToLeft
            // 
            this.btnParishToLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnParishToLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnParishToLeft.BackgroundImage")));
            this.btnParishToLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParishToLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnParishToLeft.FlatAppearance.BorderSize = 0;
            this.btnParishToLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnParishToLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParishToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnParishToLeft.ForeColor = System.Drawing.Color.Black;
            this.btnParishToLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParishToLeft.Location = new System.Drawing.Point(221, 316);
            this.btnParishToLeft.Name = "btnParishToLeft";
            this.btnParishToLeft.Size = new System.Drawing.Size(111, 43);
            this.btnParishToLeft.TabIndex = 67;
            this.toolTip1.SetToolTip(this.btnParishToLeft, "Eliminar feligrés de la actividad");
            this.btnParishToLeft.UseVisualStyleBackColor = false;
            this.btnParishToLeft.Click += new System.EventHandler(this.BtnParishToLeft_Click);
            // 
            // BtnNewParishioner
            // 
            this.BtnNewParishioner.BackColor = System.Drawing.Color.Transparent;
            this.BtnNewParishioner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewParishioner.BackgroundImage")));
            this.BtnNewParishioner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewParishioner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewParishioner.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnNewParishioner.FlatAppearance.BorderSize = 0;
            this.BtnNewParishioner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnNewParishioner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewParishioner.Location = new System.Drawing.Point(221, 176);
            this.BtnNewParishioner.Name = "BtnNewParishioner";
            this.BtnNewParishioner.Size = new System.Drawing.Size(27, 25);
            this.BtnNewParishioner.TabIndex = 68;
            this.toolTip1.SetToolTip(this.BtnNewParishioner, "Nuevo feligrés");
            this.BtnNewParishioner.UseVisualStyleBackColor = false;
            this.BtnNewParishioner.Click += new System.EventHandler(this.BtnNewParishioner_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(221, 217);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 25);
            this.btnRefresh.TabIndex = 71;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refrescar");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(335, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = ".";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // frmModifyActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 472);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNewParishioner);
            this.Controls.Add(this.btnParishToLeft);
            this.Controls.Add(this.btnParishToRight);
            this.Controls.Add(this.dgvParishRight);
            this.Controls.Add(this.dgvParishLeft);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifyActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar actividad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModifyActivity_FormClosed);
            this.Load += new System.EventHandler(this.FrmModifyActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParishLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParishRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button txtExit;
        public System.Windows.Forms.Button btnAccept;
        public System.Windows.Forms.DataGridView dgvParishLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        public System.Windows.Forms.DataGridView dgvParishRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnParishToRight;
        private System.Windows.Forms.Button btnParishToLeft;
        public System.Windows.Forms.RichTextBox txtDescription;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnNewParishioner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ErrorProvider Error;
    }
}