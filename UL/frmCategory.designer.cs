namespace UL
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategoryTypeId = new System.Windows.Forms.Label();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnModifyCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbCategory
            // 
            this.lbCategory.BackColor = System.Drawing.Color.White;
            this.lbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCategory.DisplayMember = "name";
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCategory.ForeColor = System.Drawing.Color.Black;
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 16;
            this.lbCategory.Location = new System.Drawing.Point(12, 38);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(210, 354);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.ValueMember = "Id";
            this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.LbCategory_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(73, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(149, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(9, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 16);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Buscar";
            // 
            // lblCategoryTypeId
            // 
            this.lblCategoryTypeId.AutoSize = true;
            this.lblCategoryTypeId.Location = new System.Drawing.Point(231, 423);
            this.lblCategoryTypeId.Name = "lblCategoryTypeId";
            this.lblCategoryTypeId.Size = new System.Drawing.Size(10, 13);
            this.lblCategoryTypeId.TabIndex = 36;
            this.lblCategoryTypeId.Text = ".";
            this.lblCategoryTypeId.Visible = false;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveCategory.BackgroundImage")));
            this.btnRemoveCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCategory.FlatAppearance.BorderSize = 0;
            this.btnRemoveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategory.Location = new System.Drawing.Point(228, 151);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveCategory.TabIndex = 3;
            this.Tip.SetToolTip(this.btnRemoveCategory, "Eliminar");
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.BtnRemoveCategory_Click);
            // 
            // btnModifyCategory
            // 
            this.btnModifyCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModifyCategory.BackgroundImage")));
            this.btnModifyCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifyCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyCategory.FlatAppearance.BorderSize = 0;
            this.btnModifyCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnModifyCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCategory.Location = new System.Drawing.Point(227, 95);
            this.btnModifyCategory.Name = "btnModifyCategory";
            this.btnModifyCategory.Size = new System.Drawing.Size(35, 35);
            this.btnModifyCategory.TabIndex = 2;
            this.Tip.SetToolTip(this.btnModifyCategory, "Modificar");
            this.btnModifyCategory.UseVisualStyleBackColor = false;
            this.btnModifyCategory.Click += new System.EventHandler(this.BtnModifyCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Location = new System.Drawing.Point(228, 38);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(35, 35);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tip.SetToolTip(this.btnAddCategory, "Agregar");
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // Tip
            // 
            this.Tip.ForeColor = System.Drawing.Color.Black;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 401);
            this.Controls.Add(this.lblCategoryTypeId);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnModifyCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lbCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCategory_FormClosing);
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnModifyCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategoryTypeId;
        private System.Windows.Forms.ToolTip Tip;
    }
}