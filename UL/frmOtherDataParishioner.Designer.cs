namespace UL
{
    partial class frmOtherDataParishioner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtherDataParishioner));
            this.lbData = new System.Windows.Forms.ListBox();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.btnModifyData = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.lblDataType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.BackColor = System.Drawing.Color.White;
            this.lbData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbData.DisplayMember = "name";
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbData.ForeColor = System.Drawing.Color.Black;
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 16;
            this.lbData.Location = new System.Drawing.Point(10, 23);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(210, 354);
            this.lbData.TabIndex = 4;
            this.lbData.ValueMember = "Id";
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteData.BackgroundImage")));
            this.btnDeleteData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteData.FlatAppearance.BorderSize = 0;
            this.btnDeleteData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnDeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteData.Location = new System.Drawing.Point(226, 136);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(35, 35);
            this.btnDeleteData.TabIndex = 7;
            this.btnDeleteData.UseVisualStyleBackColor = false;
            // 
            // btnModifyData
            // 
            this.btnModifyData.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModifyData.BackgroundImage")));
            this.btnModifyData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifyData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyData.FlatAppearance.BorderSize = 0;
            this.btnModifyData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnModifyData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyData.Location = new System.Drawing.Point(225, 80);
            this.btnModifyData.Name = "btnModifyData";
            this.btnModifyData.Size = new System.Drawing.Size(35, 35);
            this.btnModifyData.TabIndex = 6;
            this.btnModifyData.UseVisualStyleBackColor = false;
            // 
            // btnAddData
            // 
            this.btnAddData.BackColor = System.Drawing.Color.Transparent;
            this.btnAddData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddData.BackgroundImage")));
            this.btnAddData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddData.FlatAppearance.BorderSize = 0;
            this.btnAddData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.btnAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddData.Location = new System.Drawing.Point(226, 23);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(35, 35);
            this.btnAddData.TabIndex = 5;
            this.btnAddData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddData.UseVisualStyleBackColor = false;
            this.btnAddData.Click += new System.EventHandler(this.BtnAddData_Click);
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(248, 278);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(10, 13);
            this.lblDataType.TabIndex = 37;
            this.lblDataType.Text = ".";
            this.lblDataType.Visible = false;
            // 
            // frmOtherDataParishioner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 401);
            this.Controls.Add(this.lblDataType);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnModifyData);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.lbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOtherDataParishioner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmOtherDataParishioner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Button btnModifyData;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Label lblDataType;
    }
}