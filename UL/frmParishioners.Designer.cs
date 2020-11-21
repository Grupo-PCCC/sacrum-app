namespace UL
{
    partial class frmParishioners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParishioners));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFilas = new System.Windows.Forms.Label();
            this.dgv_Parish = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parish)).BeginInit();
            this.SuspendLayout();
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
            this.btn_cerrar.TabIndex = 56;
            this.btn_cerrar.TabStop = false;
            this.Tip.SetToolTip(this.btn_cerrar, "Cerrar");
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click_1);
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
            this.Tip.SetToolTip(this.BtnModify, "Modificar feligrés");
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
            this.Tip.SetToolTip(this.BtnNew, "Agregar feligrés");
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
            this.Tip.SetToolTip(this.BtnDelete, "Eliminar feligrés");
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Buscar.Location = new System.Drawing.Point(331, 89);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Buscar.TabIndex = 37;
            this.Lbl_Buscar.Text = "Buscar";
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
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 57;
            this.label5.Text = "Feligreses";
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFilas.ForeColor = System.Drawing.Color.Black;
            this.lblFilas.Location = new System.Drawing.Point(6, 658);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(75, 16);
            this.lblFilas.TabIndex = 36;
            this.lblFilas.Text = "Registros";
            this.lblFilas.Visible = false;
            // 
            // dgv_Parish
            // 
            this.dgv_Parish.AllowUserToAddRows = false;
            this.dgv_Parish.AllowUserToDeleteRows = false;
            this.dgv_Parish.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Parish.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Parish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Parish.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Parish.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Parish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Parish.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Parish.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Parish.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Parish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Parish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Parish.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Parish.EnableHeadersVisualStyles = false;
            this.dgv_Parish.Location = new System.Drawing.Point(6, 173);
            this.dgv_Parish.MultiSelect = false;
            this.dgv_Parish.Name = "dgv_Parish";
            this.dgv_Parish.ReadOnly = true;
            this.dgv_Parish.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Parish.RowHeadersVisible = false;
            this.dgv_Parish.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Parish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Parish.Size = new System.Drawing.Size(1149, 446);
            this.dgv_Parish.TabIndex = 62;
            this.dgv_Parish.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Parish_CellContentClick);
            this.dgv_Parish.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Parish_CellDoubleClick);
            this.dgv_Parish.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Dgv_Parish_RowsAdded);
            this.dgv_Parish.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Dgv_Parish_RowsRemoved);
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
            // frmParishioners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 788);
            this.Controls.Add(this.dgv_Parish);
            this.Controls.Add(this.lblFilas);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cerrar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmParishioners";
            this.Load += new System.EventHandler(this.FrmParishioners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolTip Tip;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label lblFilas;
        public System.Windows.Forms.DataGridView dgv_Parish;
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
    }
}