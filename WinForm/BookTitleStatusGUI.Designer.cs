namespace WinForm
{
    partial class BookTitleStatusGUI
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
            this.dgvBookTitleStatus = new System.Windows.Forms.DataGridView();
            this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBookTitleStatusName = new System.Windows.Forms.TextBox();
            this.lblBookTitleStatusName = new System.Windows.Forms.Label();
            this.lblInfor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTitleStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookTitleStatus
            // 
            this.dgvBookTitleStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookTitleStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnName});
            this.dgvBookTitleStatus.Location = new System.Drawing.Point(17, 63);
            this.dgvBookTitleStatus.Name = "dgvBookTitleStatus";
            this.dgvBookTitleStatus.Size = new System.Drawing.Size(397, 210);
            this.dgvBookTitleStatus.TabIndex = 29;
            // 
            // clmnId
            // 
            this.clmnId.HeaderText = "Id";
            this.clmnId.Name = "clmnId";
            this.clmnId.Visible = false;
            // 
            // clmnName
            // 
            this.clmnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(159, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 20);
            this.txtSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(339, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.DisplayMember = "a";
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(17, 25);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 21);
            this.cboSearch.TabIndex = 26;
            this.cboSearch.Text = "Search by....";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(326, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBookTitleStatusName
            // 
            this.txtBookTitleStatusName.Location = new System.Drawing.Point(17, 347);
            this.txtBookTitleStatusName.Name = "txtBookTitleStatusName";
            this.txtBookTitleStatusName.Size = new System.Drawing.Size(221, 20);
            this.txtBookTitleStatusName.TabIndex = 32;
            // 
            // lblBookTitleStatusName
            // 
            this.lblBookTitleStatusName.AutoSize = true;
            this.lblBookTitleStatusName.Location = new System.Drawing.Point(14, 320);
            this.lblBookTitleStatusName.Name = "lblBookTitleStatusName";
            this.lblBookTitleStatusName.Size = new System.Drawing.Size(107, 13);
            this.lblBookTitleStatusName.TabIndex = 31;
            this.lblBookTitleStatusName.Text = "Type Of Book Name:";
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.Location = new System.Drawing.Point(14, 292);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(55, 13);
            this.lblInfor.TabIndex = 30;
            this.lblInfor.Text = "Id / Name";
            // 
            // BookTitleStatusGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 430);
            this.Controls.Add(this.dgvBookTitleStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBookTitleStatusName);
            this.Controls.Add(this.lblBookTitleStatusName);
            this.Controls.Add(this.lblInfor);
            this.Name = "BookTitleStatusGUI";
            this.Text = "Book Title Status";
            this.Load += new System.EventHandler(this.BookTitleStatusGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTitleStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookTitleStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBookTitleStatusName;
        private System.Windows.Forms.Label lblBookTitleStatusName;
        private System.Windows.Forms.Label lblInfor;
    }
}