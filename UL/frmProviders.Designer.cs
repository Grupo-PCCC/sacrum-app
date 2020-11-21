namespace UL
{
    partial class frmProviders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProviders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_Filas = new System.Windows.Forms.Label();
            this.dgvProvider = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Pri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Otro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProviderPhone1Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProviderPhone2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmViewDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Tip
            // 
            this.Tip.ForeColor = System.Drawing.Color.Black;
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
            this.btn_cerrar.TabIndex = 55;
            this.btn_cerrar.TabStop = false;
            this.Tip.SetToolTip(this.btn_cerrar, "Cerrar");
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click_1);
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
            this.Tip.SetToolTip(this.BtnNew, "Nuevo proveedor");
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
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
            this.Tip.SetToolTip(this.BtnDelete, "Eliminar proveedor");
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.Tip.SetToolTip(this.BtnModify, "Modificar proveedor");
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(389, 87);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(251, 22);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Buscar.Location = new System.Drawing.Point(327, 90);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Buscar.TabIndex = 22;
            this.Lbl_Buscar.Text = "Buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 31);
            this.label5.TabIndex = 56;
            this.label5.Text = "Proveedores";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnModify);
            this.groupBox2.Controls.Add(this.BtnNew);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 89);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // Lbl_Filas
            // 
            this.Lbl_Filas.AutoSize = true;
            this.Lbl_Filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Filas.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Filas.Location = new System.Drawing.Point(6, 658);
            this.Lbl_Filas.Name = "Lbl_Filas";
            this.Lbl_Filas.Size = new System.Drawing.Size(75, 16);
            this.Lbl_Filas.TabIndex = 58;
            this.Lbl_Filas.Text = "Registros";
            this.Lbl_Filas.Visible = false;
            // 
            // dgvProvider
            // 
            this.dgvProvider.AllowUserToAddRows = false;
            this.dgvProvider.AllowUserToDeleteRows = false;
            this.dgvProvider.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProvider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProvider.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProvider.BackgroundColor = System.Drawing.Color.White;
            this.dgvProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProvider.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProvider.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProvider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.Nombre,
            this.Tel_Pri,
            this.Tel_Otro,
            this.clmObservation,
            this.clmProviderPhone1Id,
            this.clmProviderPhone2Id,
            this.clmViewDetail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProvider.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProvider.EnableHeadersVisualStyles = false;
            this.dgvProvider.Location = new System.Drawing.Point(6, 173);
            this.dgvProvider.MultiSelect = false;
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.ReadOnly = true;
            this.dgvProvider.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProvider.RowHeadersVisible = false;
            this.dgvProvider.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvider.Size = new System.Drawing.Size(1149, 446);
            this.dgvProvider.TabIndex = 63;
            this.dgvProvider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProvider_CellContentClick);
            this.dgvProvider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProvider_CellDoubleClick);
            this.dgvProvider.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvProvider_RowsAdded);
            this.dgvProvider.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvProvider_RowsRemoved);
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
            this.Nombre.FillWeight = 65F;
            this.Nombre.HeaderText = "Nombre / Razón social";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tel_Pri
            // 
            this.Tel_Pri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tel_Pri.HeaderText = "Teléfono principal";
            this.Tel_Pri.Name = "Tel_Pri";
            this.Tel_Pri.ReadOnly = true;
            // 
            // Tel_Otro
            // 
            this.Tel_Otro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tel_Otro.HeaderText = "Teléfono alternativo";
            this.Tel_Otro.Name = "Tel_Otro";
            this.Tel_Otro.ReadOnly = true;
            // 
            // clmObservation
            // 
            this.clmObservation.HeaderText = "Observation";
            this.clmObservation.Name = "clmObservation";
            this.clmObservation.ReadOnly = true;
            this.clmObservation.Visible = false;
            this.clmObservation.Width = 129;
            // 
            // clmProviderPhone1Id
            // 
            this.clmProviderPhone1Id.HeaderText = "PHP1Id";
            this.clmProviderPhone1Id.Name = "clmProviderPhone1Id";
            this.clmProviderPhone1Id.ReadOnly = true;
            this.clmProviderPhone1Id.Visible = false;
            this.clmProviderPhone1Id.Width = 94;
            // 
            // clmProviderPhone2Id
            // 
            this.clmProviderPhone2Id.HeaderText = "PHP2Id";
            this.clmProviderPhone2Id.Name = "clmProviderPhone2Id";
            this.clmProviderPhone2Id.ReadOnly = true;
            this.clmProviderPhone2Id.Visible = false;
            this.clmProviderPhone2Id.Width = 94;
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
            // frmProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 766);
            this.Controls.Add(this.dgvProvider);
            this.Controls.Add(this.Lbl_Filas);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btn_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProviders";
            this.Text = "frmProviders";
            this.Load += new System.EventHandler(this.FrmProviders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip Tip;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label Lbl_Filas;
        public System.Windows.Forms.DataGridView dgvProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Pri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Otro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProviderPhone1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProviderPhone2Id;
        private System.Windows.Forms.DataGridViewButtonColumn clmViewDetail;
    }
}