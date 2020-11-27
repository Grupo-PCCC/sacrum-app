namespace UL
{
    partial class frmActivities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivities));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.Lbl_Filas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Activities = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParishionerPhoneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParishionerAddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParishionerMailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmViewDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Activities)).BeginInit();
            this.SuspendLayout();
            // 
            // cbActivity
            // 
            this.cbActivity.BackColor = System.Drawing.Color.White;
            this.cbActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbActivity.ForeColor = System.Drawing.Color.Black;
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Location = new System.Drawing.Point(6, 40);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(352, 24);
            this.cbActivity.TabIndex = 38;
            this.cbActivity.SelectedIndexChanged += new System.EventHandler(this.CbActivity_SelectedIndexChanged);
            // 
            // Lbl_Filas
            // 
            this.Lbl_Filas.AutoSize = true;
            this.Lbl_Filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Filas.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Filas.Location = new System.Drawing.Point(6, 658);
            this.Lbl_Filas.Name = "Lbl_Filas";
            this.Lbl_Filas.Size = new System.Drawing.Size(75, 16);
            this.Lbl_Filas.TabIndex = 44;
            this.Lbl_Filas.Text = "Registros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbActivity);
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 89);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actividad";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnModify);
            this.groupBox2.Controls.Add(this.BtnNew);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(385, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 89);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.Transparent;
            this.BtnModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModify.BackgroundImage")));
            this.BtnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModify.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnModify.FlatAppearance.BorderSize = 0;
            this.BtnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModify.Location = new System.Drawing.Point(114, 35);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(89, 30);
            this.BtnModify.TabIndex = 41;
            this.toolTip1.SetToolTip(this.BtnModify, "Modificar actividad");
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.Transparent;
            this.BtnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNew.BackgroundImage")));
            this.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnNew.FlatAppearance.BorderSize = 0;
            this.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNew.Location = new System.Drawing.Point(22, 35);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(86, 30);
            this.BtnNew.TabIndex = 39;
            this.toolTip1.SetToolTip(this.BtnNew, "Nueva actividad");
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnActivities_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(209, 35);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(90, 30);
            this.BtnDelete.TabIndex = 40;
            this.toolTip1.SetToolTip(this.BtnDelete, "Eliminar actividad");
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Buscar.Location = new System.Drawing.Point(711, 100);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Buscar.TabIndex = 43;
            this.Lbl_Buscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(769, 98);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(251, 22);
            this.txtBuscar.TabIndex = 42;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged_1);
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
            this.btn_cerrar.TabIndex = 60;
            this.btn_cerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_cerrar, "Cerrar");
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(1128, 142);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 25);
            this.btnRefresh.TabIndex = 72;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refrescar");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 31);
            this.label5.TabIndex = 45;
            this.label5.Text = "Actividades";
            // 
            // dgv_Activities
            // 
            this.dgv_Activities.AllowUserToAddRows = false;
            this.dgv_Activities.AllowUserToDeleteRows = false;
            this.dgv_Activities.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Activities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Activities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Activities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Activities.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Activities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Activities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Activities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Activities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Activities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Activities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.Nombre,
            this.Apellido,
            this.clmDocumento,
            this.FechaNac,
            this.Telephone,
            this.Address,
            this.Mail,
            this.clmObservation,
            this.clmParishionerPhoneId,
            this.clmParishionerAddressId,
            this.clmParishionerMailId,
            this.clmViewDetail});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Activities.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Activities.EnableHeadersVisualStyles = false;
            this.dgv_Activities.Location = new System.Drawing.Point(6, 173);
            this.dgv_Activities.MultiSelect = false;
            this.dgv_Activities.Name = "dgv_Activities";
            this.dgv_Activities.ReadOnly = true;
            this.dgv_Activities.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Activities.RowHeadersVisible = false;
            this.dgv_Activities.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Activities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Activities.Size = new System.Drawing.Size(1149, 446);
            this.dgv_Activities.TabIndex = 73;
            this.dgv_Activities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Activities_CellContentClick);
            this.dgv_Activities.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Activities_CellDoubleClick);
            this.dgv_Activities.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Dgv_Activities_RowsAdded);
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
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmDocumento
            // 
            this.clmDocumento.HeaderText = "Documento";
            this.clmDocumento.Name = "clmDocumento";
            this.clmDocumento.ReadOnly = true;
            this.clmDocumento.Width = 125;
            // 
            // FechaNac
            // 
            this.FechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaNac.HeaderText = "Fecha de nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telephone.HeaderText = "Teléfono";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Dirección";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // clmObservation
            // 
            this.clmObservation.HeaderText = "Observation";
            this.clmObservation.Name = "clmObservation";
            this.clmObservation.ReadOnly = true;
            this.clmObservation.Visible = false;
            this.clmObservation.Width = 129;
            // 
            // clmParishionerPhoneId
            // 
            this.clmParishionerPhoneId.HeaderText = "telId";
            this.clmParishionerPhoneId.Name = "clmParishionerPhoneId";
            this.clmParishionerPhoneId.ReadOnly = true;
            this.clmParishionerPhoneId.Visible = false;
            this.clmParishionerPhoneId.Width = 69;
            // 
            // clmParishionerAddressId
            // 
            this.clmParishionerAddressId.HeaderText = "addressId";
            this.clmParishionerAddressId.Name = "clmParishionerAddressId";
            this.clmParishionerAddressId.ReadOnly = true;
            this.clmParishionerAddressId.Visible = false;
            this.clmParishionerAddressId.Width = 113;
            // 
            // clmParishionerMailId
            // 
            this.clmParishionerMailId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmParishionerMailId.HeaderText = "mailid";
            this.clmParishionerMailId.Name = "clmParishionerMailId";
            this.clmParishionerMailId.ReadOnly = true;
            this.clmParishionerMailId.Visible = false;
            // 
            // clmViewDetail
            // 
            this.clmViewDetail.HeaderText = "Detalle";
            this.clmViewDetail.Name = "clmViewDetail";
            this.clmViewDetail.ReadOnly = true;
            this.clmViewDetail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmViewDetail.Text = "Ver detalle";
            this.clmViewDetail.ToolTipText = "Ver detalle";
            this.clmViewDetail.UseColumnTextForButtonValue = true;
            this.clmViewDetail.Width = 71;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(1026, 94);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(66, 30);
            this.btnExcel.TabIndex = 74;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // frmActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 788);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgv_Activities);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl_Filas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActivities";
            this.Activated += new System.EventHandler(this.FrmActivities_Activated);
            this.Load += new System.EventHandler(this.FrmActivities_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Activities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Filas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ComboBox cbActivity;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.DataGridView dgv_Activities;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParishionerPhoneId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParishionerAddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParishionerMailId;
        private System.Windows.Forms.DataGridViewButtonColumn clmViewDetail;
        private System.Windows.Forms.Button btnExcel;
    }
}