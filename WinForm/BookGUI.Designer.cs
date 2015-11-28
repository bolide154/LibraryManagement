namespace WinForm
{
    partial class BookGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.clmnBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookTitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookTitleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search by:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnBookId,
            this.clmnBookTitleName,
            this.clmnBookTitleId,
            this.clmnBookStatusName,
            this.clmnBookStatusId});
            this.dgvBook.Location = new System.Drawing.Point(14, 65);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(397, 210);
            this.dgvBook.TabIndex = 17;
            // 
            // clmnBookId
            // 
            this.clmnBookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnBookId.HeaderText = "Book Id";
            this.clmnBookId.Name = "clmnBookId";
            // 
            // clmnBookTitleName
            // 
            this.clmnBookTitleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnBookTitleName.HeaderText = "Book Title";
            this.clmnBookTitleName.Name = "clmnBookTitleName";
            this.clmnBookTitleName.ReadOnly = true;
            // 
            // clmnBookTitleId
            // 
            this.clmnBookTitleId.HeaderText = "Book Title Id";
            this.clmnBookTitleId.Name = "clmnBookTitleId";
            this.clmnBookTitleId.Visible = false;
            // 
            // clmnBookStatusName
            // 
            this.clmnBookStatusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnBookStatusName.HeaderText = "Book Status";
            this.clmnBookStatusName.Name = "clmnBookStatusName";
            this.clmnBookStatusName.ReadOnly = true;
            // 
            // clmnBookStatusId
            // 
            this.clmnBookStatusId.HeaderText = "Book Status Id";
            this.clmnBookStatusId.Name = "clmnBookStatusId";
            this.clmnBookStatusId.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(173, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 20);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(345, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboSearch
            // 
            this.cboSearch.DisplayMember = "a";
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Tên tác giả",
            "Nơi công tác"});
            this.cboSearch.Location = new System.Drawing.Point(76, 27);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(91, 21);
            this.cboSearch.TabIndex = 14;
            // 
            // BookGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Name = "BookGUI";
            this.Text = "BookGUI";
            this.Load += new System.EventHandler(this.BookGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookTitleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookTitleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookStatusId;
    }
}