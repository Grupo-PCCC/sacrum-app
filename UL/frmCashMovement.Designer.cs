namespace UL
{
    partial class frmCashMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashMovement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtPicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.chbCategory = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbEgress = new System.Windows.Forms.CheckBox();
            this.chbIngress = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Lbl_Filas1 = new System.Windows.Forms.Label();
            this.dgvCashMovement = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCTId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmViewDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnNewIngress = new System.Windows.Forms.Button();
            this.BtnNewEgress = new System.Windows.Forms.Button();
            this.Lbl_Filas = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(149, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
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
            this.dtPicker1.TabIndex = 0;
            this.dtPicker1.Value = new System.DateTime(2000, 9, 19, 0, 0, 0, 0);
            this.dtPicker1.ValueChanged += new System.EventHandler(this.DtPicker1_ValueChanged);
            this.dtPicker1.MouseEnter += new System.EventHandler(this.DtPicker1_MouseEnter);
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
            this.dtPicker2.Location = new System.Drawing.Point(181, 7);
            this.dtPicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtPicker2.Name = "dtPicker2";
            this.dtPicker2.Size = new System.Drawing.Size(134, 22);
            this.dtPicker2.TabIndex = 1;
            this.dtPicker2.Value = new System.DateTime(2019, 9, 19, 0, 0, 0, 0);
            this.dtPicker2.ValueChanged += new System.EventHandler(this.DtPicker2_ValueChanged);
            this.dtPicker2.MouseEnter += new System.EventHandler(this.DtPicker2_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNewCategory);
            this.panel3.Controls.Add(this.cbCategories);
            this.panel3.Controls.Add(this.chbCategory);
            this.panel3.Location = new System.Drawing.Point(579, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 57);
            this.panel3.TabIndex = 43;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnNewCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewCategory.BackgroundImage")));
            this.btnNewCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCategory.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnNewCategory.FlatAppearance.BorderSize = 0;
            this.btnNewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCategory.Location = new System.Drawing.Point(183, 4);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(23, 23);
            this.btnNewCategory.TabIndex = 2;
            this.Tip.SetToolTip(this.btnNewCategory, "Nueva categoría");
            this.btnNewCategory.UseVisualStyleBackColor = false;
            this.btnNewCategory.Click += new System.EventHandler(this.BtnNewCategory_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.BackColor = System.Drawing.Color.White;
            this.cbCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbCategories.ForeColor = System.Drawing.Color.Black;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(3, 4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(175, 24);
            this.cbCategories.TabIndex = 0;
            this.cbCategories.Click += new System.EventHandler(this.CbCategories_Click);
            // 
            // chbCategory
            // 
            this.chbCategory.AutoSize = true;
            this.chbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbCategory.ForeColor = System.Drawing.Color.Black;
            this.chbCategory.Location = new System.Drawing.Point(3, 31);
            this.chbCategory.Name = "chbCategory";
            this.chbCategory.Size = new System.Drawing.Size(94, 20);
            this.chbCategory.TabIndex = 1;
            this.chbCategory.Text = "Ver todas";
            this.chbCategory.UseVisualStyleBackColor = true;
            this.chbCategory.CheckedChanged += new System.EventHandler(this.ChbCategory_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbEgress);
            this.panel2.Controls.Add(this.chbIngress);
            this.panel2.Location = new System.Drawing.Point(362, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 33);
            this.panel2.TabIndex = 42;
            // 
            // chbEgress
            // 
            this.chbEgress.AutoSize = true;
            this.chbEgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbEgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbEgress.ForeColor = System.Drawing.Color.Black;
            this.chbEgress.Location = new System.Drawing.Point(88, 5);
            this.chbEgress.Name = "chbEgress";
            this.chbEgress.Size = new System.Drawing.Size(85, 20);
            this.chbEgress.TabIndex = 1;
            this.chbEgress.Text = "Egresos";
            this.chbEgress.UseVisualStyleBackColor = true;
            this.chbEgress.CheckedChanged += new System.EventHandler(this.ChbEgress_CheckedChanged);
            // 
            // chbIngress
            // 
            this.chbIngress.AutoSize = true;
            this.chbIngress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbIngress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbIngress.ForeColor = System.Drawing.Color.Black;
            this.chbIngress.Location = new System.Drawing.Point(3, 4);
            this.chbIngress.Name = "chbIngress";
            this.chbIngress.Size = new System.Drawing.Size(87, 20);
            this.chbIngress.TabIndex = 0;
            this.chbIngress.Text = "Ingresos";
            this.chbIngress.UseVisualStyleBackColor = true;
            this.chbIngress.CheckedChanged += new System.EventHandler(this.ChbIngress_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtPicker1);
            this.panel1.Controls.Add(this.dtPicker2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 42);
            this.panel1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(370, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tipo de movimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(576, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Categoría";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(1008, 658);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(1055, 655);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 24;
            // 
            // Lbl_Filas1
            // 
            this.Lbl_Filas1.AutoSize = true;
            this.Lbl_Filas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Filas1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Filas1.Location = new System.Drawing.Point(-27, 495);
            this.Lbl_Filas1.Name = "Lbl_Filas1";
            this.Lbl_Filas1.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Filas1.TabIndex = 37;
            // 
            // dgvCashMovement
            // 
            this.dgvCashMovement.AllowUserToAddRows = false;
            this.dgvCashMovement.AllowUserToDeleteRows = false;
            this.dgvCashMovement.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCashMovement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCashMovement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCashMovement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCashMovement.BackgroundColor = System.Drawing.Color.White;
            this.dgvCashMovement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCashMovement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvCashMovement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashMovement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCashMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashMovement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmDate,
            this.clmCategory,
            this.clmValue,
            this.clmCategoryType,
            this.clmUser,
            this.clmCId,
            this.clmCTId,
            this.clmObservation,
            this.clmUId,
            this.clmViewDetail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCashMovement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCashMovement.EnableHeadersVisualStyles = false;
            this.dgvCashMovement.Location = new System.Drawing.Point(6, 173);
            this.dgvCashMovement.MultiSelect = false;
            this.dgvCashMovement.Name = "dgvCashMovement";
            this.dgvCashMovement.ReadOnly = true;
            this.dgvCashMovement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCashMovement.RowHeadersVisible = false;
            this.dgvCashMovement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCashMovement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashMovement.Size = new System.Drawing.Size(1149, 446);
            this.dgvCashMovement.TabIndex = 41;
            this.dgvCashMovement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCashMovement_CellContentClick);
            this.dgvCashMovement.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCashMovement_CellDoubleClick);
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
            // clmDate
            // 
            this.clmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDate.FillWeight = 50F;
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmCategory
            // 
            this.clmCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCategory.HeaderText = "Categoría";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmValue
            // 
            this.clmValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmValue.HeaderText = "Valor";
            this.clmValue.Name = "clmValue";
            this.clmValue.ReadOnly = true;
            // 
            // clmCategoryType
            // 
            this.clmCategoryType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCategoryType.HeaderText = "Tipo de movimiento";
            this.clmCategoryType.Name = "clmCategoryType";
            this.clmCategoryType.ReadOnly = true;
            // 
            // clmUser
            // 
            this.clmUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmUser.HeaderText = "Usuario";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            // 
            // clmCId
            // 
            this.clmCId.HeaderText = "cId";
            this.clmCId.Name = "clmCId";
            this.clmCId.ReadOnly = true;
            this.clmCId.Visible = false;
            this.clmCId.Width = 58;
            // 
            // clmCTId
            // 
            this.clmCTId.HeaderText = "ctId";
            this.clmCTId.Name = "clmCTId";
            this.clmCTId.ReadOnly = true;
            this.clmCTId.Visible = false;
            this.clmCTId.Width = 64;
            // 
            // clmObservation
            // 
            this.clmObservation.HeaderText = "Observacion";
            this.clmObservation.Name = "clmObservation";
            this.clmObservation.ReadOnly = true;
            this.clmObservation.Visible = false;
            this.clmObservation.Width = 132;
            // 
            // clmUId
            // 
            this.clmUId.HeaderText = "uId";
            this.clmUId.Name = "clmUId";
            this.clmUId.ReadOnly = true;
            this.clmUId.Visible = false;
            this.clmUId.Width = 59;
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
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(804, 36);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(67, 32);
            this.BtnSearch.TabIndex = 0;
            this.Tip.SetToolTip(this.BtnSearch, "Buscar");
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnNewIngress
            // 
            this.BtnNewIngress.BackColor = System.Drawing.Color.Transparent;
            this.BtnNewIngress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewIngress.BackgroundImage")));
            this.BtnNewIngress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewIngress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewIngress.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnNewIngress.FlatAppearance.BorderSize = 0;
            this.BtnNewIngress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnNewIngress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewIngress.Location = new System.Drawing.Point(15, 40);
            this.BtnNewIngress.Name = "BtnNewIngress";
            this.BtnNewIngress.Size = new System.Drawing.Size(89, 30);
            this.BtnNewIngress.TabIndex = 0;
            this.Tip.SetToolTip(this.BtnNewIngress, "Nuevo ingreso");
            this.BtnNewIngress.UseVisualStyleBackColor = false;
            this.BtnNewIngress.Click += new System.EventHandler(this.BtnNewIngress_Click);
            // 
            // BtnNewEgress
            // 
            this.BtnNewEgress.BackColor = System.Drawing.Color.Transparent;
            this.BtnNewEgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewEgress.BackgroundImage")));
            this.BtnNewEgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewEgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewEgress.FlatAppearance.BorderSize = 0;
            this.BtnNewEgress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.BtnNewEgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewEgress.Location = new System.Drawing.Point(144, 40);
            this.BtnNewEgress.Name = "BtnNewEgress";
            this.BtnNewEgress.Size = new System.Drawing.Size(90, 30);
            this.BtnNewEgress.TabIndex = 1;
            this.Tip.SetToolTip(this.BtnNewEgress, "Nuevo egreso");
            this.BtnNewEgress.UseVisualStyleBackColor = false;
            this.BtnNewEgress.Click += new System.EventHandler(this.BtnNewEgress_Click);
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
            this.Lbl_Filas.TabIndex = 44;
            this.Lbl_Filas.Text = "Registros";
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
            this.btn_cerrar.TabIndex = 19;
            this.btn_cerrar.TabStop = false;
            this.Tip.SetToolTip(this.btn_cerrar, "Cerrar");
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Tip
            // 
            this.Tip.ForeColor = System.Drawing.Color.Black;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(260, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 89);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnNewIngress);
            this.groupBox2.Controls.Add(this.BtnNewEgress);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 89);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimientos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 31);
            this.label5.TabIndex = 44;
            this.label5.Text = "Caja";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // frmCashMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 749);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Lbl_Filas);
            this.Controls.Add(this.dgvCashMovement);
            this.Controls.Add(this.Lbl_Filas1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCashMovement";
            this.Load += new System.EventHandler(this.FrmCashMovement_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Filas1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnNewIngress;
        private System.Windows.Forms.Button BtnNewEgress;
        private System.Windows.Forms.Label Lbl_Filas;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.ToolTip Tip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvCashMovement;
        public System.Windows.Forms.DateTimePicker dtPicker1;
        public System.Windows.Forms.DateTimePicker dtPicker2;
        public System.Windows.Forms.CheckBox chbEgress;
        public System.Windows.Forms.CheckBox chbIngress;
        public System.Windows.Forms.CheckBox chbCategory;
        public System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCTId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUId;
        private System.Windows.Forms.DataGridViewButtonColumn clmViewDetail;
    }
}