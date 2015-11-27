namespace WinForm
{
    partial class BookTitleGUI
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
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBookTitle = new System.Windows.Forms.DataGridView();
            this.clmnBookTitleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookTitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTypeOfBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTypeOfBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPublisherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookTitleStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.cboTypeOfBook = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.clmnAuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWorkPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTypeOfBookManage = new System.Windows.Forms.Button();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPublisherManage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBookTitleStatus = new System.Windows.Forms.ComboBox();
            this.btnBookTitleStatusManage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnViewInStore = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookTotal = new System.Windows.Forms.TextBox();
            this.btnTypeOfBookRefresh = new System.Windows.Forms.Button();
            this.btnPublisherRefresh = new System.Windows.Forms.Button();
            this.btnBookTitleStatusRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(12, 22);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(179, 21);
            this.cboSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(197, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(480, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBookTitle
            // 
            this.dgvBookTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnBookTitleId,
            this.clmnBookTitleName,
            this.clmnTypeOfBookId,
            this.clmnTypeOfBookName,
            this.clmnPublisherId,
            this.clmnBookTitleStatusId,
            this.clmnSummary});
            this.dgvBookTitle.Location = new System.Drawing.Point(13, 55);
            this.dgvBookTitle.Name = "dgvBookTitle";
            this.dgvBookTitle.Size = new System.Drawing.Size(542, 398);
            this.dgvBookTitle.TabIndex = 3;
            // 
            // clmnBookTitleId
            // 
            this.clmnBookTitleId.HeaderText = "Book Title Id";
            this.clmnBookTitleId.Name = "clmnBookTitleId";
            this.clmnBookTitleId.Visible = false;
            // 
            // clmnBookTitleName
            // 
            this.clmnBookTitleName.HeaderText = "Book Name";
            this.clmnBookTitleName.Name = "clmnBookTitleName";
            // 
            // clmnTypeOfBookId
            // 
            this.clmnTypeOfBookId.HeaderText = "Type Of Book";
            this.clmnTypeOfBookId.Name = "clmnTypeOfBookId";
            this.clmnTypeOfBookId.Visible = false;
            // 
            // clmnTypeOfBookName
            // 
            this.clmnTypeOfBookName.HeaderText = "Type Of Book";
            this.clmnTypeOfBookName.Name = "clmnTypeOfBookName";
            // 
            // clmnPublisherId
            // 
            this.clmnPublisherId.HeaderText = "Publisher";
            this.clmnPublisherId.Name = "clmnPublisherId";
            // 
            // clmnBookTitleStatusId
            // 
            this.clmnBookTitleStatusId.HeaderText = "Book Title Status";
            this.clmnBookTitleStatusId.Name = "clmnBookTitleStatusId";
            // 
            // clmnSummary
            // 
            this.clmnSummary.HeaderText = "Summary";
            this.clmnSummary.Name = "clmnSummary";
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.Location = new System.Drawing.Point(577, 24);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(55, 13);
            this.lblInfor.TabIndex = 4;
            this.lblInfor.Text = "Id / Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Name:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(580, 78);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(296, 20);
            this.txtBookName.TabIndex = 6;
            // 
            // cboTypeOfBook
            // 
            this.cboTypeOfBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeOfBook.FormattingEnabled = true;
            this.cboTypeOfBook.Location = new System.Drawing.Point(580, 130);
            this.cboTypeOfBook.Name = "cboTypeOfBook";
            this.cboTypeOfBook.Size = new System.Drawing.Size(197, 21);
            this.cboTypeOfBook.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type Of Book:";
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnAuthorId,
            this.clmnAuthorName,
            this.clmnWorkPlace});
            this.dgvAuthor.Location = new System.Drawing.Point(897, 108);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.Size = new System.Drawing.Size(296, 297);
            this.dgvAuthor.TabIndex = 9;
            // 
            // clmnAuthorId
            // 
            this.clmnAuthorId.HeaderText = "Author Id";
            this.clmnAuthorId.Name = "clmnAuthorId";
            this.clmnAuthorId.Visible = false;
            // 
            // clmnAuthorName
            // 
            this.clmnAuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnAuthorName.HeaderText = "Author Name";
            this.clmnAuthorName.Name = "clmnAuthorName";
            // 
            // clmnWorkPlace
            // 
            this.clmnWorkPlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnWorkPlace.HeaderText = "Work Place";
            this.clmnWorkPlace.Name = "clmnWorkPlace";
            // 
            // btnTypeOfBookManage
            // 
            this.btnTypeOfBookManage.Location = new System.Drawing.Point(784, 128);
            this.btnTypeOfBookManage.Name = "btnTypeOfBookManage";
            this.btnTypeOfBookManage.Size = new System.Drawing.Size(42, 23);
            this.btnTypeOfBookManage.TabIndex = 10;
            this.btnTypeOfBookManage.Text = "...";
            this.btnTypeOfBookManage.UseVisualStyleBackColor = true;
            this.btnTypeOfBookManage.Click += new System.EventHandler(this.btnTypeOfBookManage_Click);
            // 
            // cboPublisher
            // 
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(580, 184);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(197, 21);
            this.cboPublisher.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Publisher";
            // 
            // btnPublisherManage
            // 
            this.btnPublisherManage.Location = new System.Drawing.Point(784, 184);
            this.btnPublisherManage.Name = "btnPublisherManage";
            this.btnPublisherManage.Size = new System.Drawing.Size(42, 23);
            this.btnPublisherManage.TabIndex = 13;
            this.btnPublisherManage.Text = "...";
            this.btnPublisherManage.UseVisualStyleBackColor = true;
            this.btnPublisherManage.Click += new System.EventHandler(this.btnPublisherManage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Book Title Status:";
            // 
            // cboBookTitleStatus
            // 
            this.cboBookTitleStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookTitleStatus.FormattingEnabled = true;
            this.cboBookTitleStatus.Location = new System.Drawing.Point(580, 244);
            this.cboBookTitleStatus.Name = "cboBookTitleStatus";
            this.cboBookTitleStatus.Size = new System.Drawing.Size(197, 21);
            this.cboBookTitleStatus.TabIndex = 15;
            // 
            // btnBookTitleStatusManage
            // 
            this.btnBookTitleStatusManage.Location = new System.Drawing.Point(783, 244);
            this.btnBookTitleStatusManage.Name = "btnBookTitleStatusManage";
            this.btnBookTitleStatusManage.Size = new System.Drawing.Size(43, 23);
            this.btnBookTitleStatusManage.TabIndex = 16;
            this.btnBookTitleStatusManage.Text = "...";
            this.btnBookTitleStatusManage.UseVisualStyleBackColor = true;
            this.btnBookTitleStatusManage.Click += new System.EventHandler(this.btnBookTitleStatusManage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Summary:";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(580, 300);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(296, 75);
            this.txtSummary.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Add";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(713, 389);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(64, 23);
            this.btnBookAdd.TabIndex = 24;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnViewInStore
            // 
            this.btnViewInStore.Location = new System.Drawing.Point(783, 389);
            this.btnViewInStore.Name = "btnViewInStore";
            this.btnViewInStore.Size = new System.Drawing.Size(86, 23);
            this.btnViewInStore.TabIndex = 25;
            this.btnViewInStore.Text = "View In Store";
            this.btnViewInStore.UseVisualStyleBackColor = true;
            this.btnViewInStore.Click += new System.EventHandler(this.btnViewInStore_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1119, 430);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 26;
            this.button8.Text = "Close";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1038, 430);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 27;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(957, 430);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 28;
            this.button10.Text = "Delete";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(876, 430);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 29;
            this.button11.Text = "Add";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(894, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Author:";
            // 
            // cboAuthor
            // 
            this.cboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(897, 44);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(197, 21);
            this.cboAuthor.TabIndex = 31;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1100, 44);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 23);
            this.button12.TabIndex = 32;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1036, 77);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(66, 23);
            this.button13.TabIndex = 33;
            this.button13.Text = "Add";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1126, 76);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 23);
            this.button14.TabIndex = 34;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(666, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Book";
            // 
            // txtBookTotal
            // 
            this.txtBookTotal.Location = new System.Drawing.Point(609, 391);
            this.txtBookTotal.Name = "txtBookTotal";
            this.txtBookTotal.Size = new System.Drawing.Size(45, 20);
            this.txtBookTotal.TabIndex = 35;
            // 
            // btnTypeOfBookRefresh
            // 
            this.btnTypeOfBookRefresh.Image = global::WinForm.Properties.Resources.refresh;
            this.btnTypeOfBookRefresh.Location = new System.Drawing.Point(832, 128);
            this.btnTypeOfBookRefresh.Name = "btnTypeOfBookRefresh";
            this.btnTypeOfBookRefresh.Size = new System.Drawing.Size(44, 23);
            this.btnTypeOfBookRefresh.TabIndex = 36;
            this.btnTypeOfBookRefresh.UseVisualStyleBackColor = true;
            this.btnTypeOfBookRefresh.Click += new System.EventHandler(this.btnTypeOfBookRefresh_Click);
            // 
            // btnPublisherRefresh
            // 
            this.btnPublisherRefresh.Image = global::WinForm.Properties.Resources.refresh;
            this.btnPublisherRefresh.Location = new System.Drawing.Point(832, 184);
            this.btnPublisherRefresh.Name = "btnPublisherRefresh";
            this.btnPublisherRefresh.Size = new System.Drawing.Size(44, 23);
            this.btnPublisherRefresh.TabIndex = 37;
            this.btnPublisherRefresh.UseVisualStyleBackColor = true;
            this.btnPublisherRefresh.Click += new System.EventHandler(this.btnPublisherRefresh_Click);
            // 
            // btnBookTitleStatusRefresh
            // 
            this.btnBookTitleStatusRefresh.Image = global::WinForm.Properties.Resources.refresh;
            this.btnBookTitleStatusRefresh.Location = new System.Drawing.Point(832, 244);
            this.btnBookTitleStatusRefresh.Name = "btnBookTitleStatusRefresh";
            this.btnBookTitleStatusRefresh.Size = new System.Drawing.Size(44, 23);
            this.btnBookTitleStatusRefresh.TabIndex = 38;
            this.btnBookTitleStatusRefresh.UseVisualStyleBackColor = true;
            this.btnBookTitleStatusRefresh.Click += new System.EventHandler(this.btnBookTitleStatusRefresh_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WinForm.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(1149, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BookTitleGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBookTitleStatusRefresh);
            this.Controls.Add(this.btnPublisherRefresh);
            this.Controls.Add(this.btnTypeOfBookRefresh);
            this.Controls.Add(this.txtBookTotal);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.cboAuthor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnViewInStore);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBookTitleStatusManage);
            this.Controls.Add(this.cboBookTitleStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPublisherManage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPublisher);
            this.Controls.Add(this.btnTypeOfBookManage);
            this.Controls.Add(this.dgvAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTypeOfBook);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfor);
            this.Controls.Add(this.dgvBookTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Name = "BookTitleGUI";
            this.Text = "Book Title";
            this.Load += new System.EventHandler(this.BookTitleGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBookTitle;
        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ComboBox cboTypeOfBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.Button btnTypeOfBookManage;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPublisherManage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBookTitleStatus;
        private System.Windows.Forms.Button btnBookTitleStatusManage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnViewInStore;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookTitleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookTitleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTypeOfBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTypeOfBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPublisherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookTitleStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSummary;
        private System.Windows.Forms.Button btnTypeOfBookRefresh;
        private System.Windows.Forms.Button btnPublisherRefresh;
        private System.Windows.Forms.Button btnBookTitleStatusRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWorkPlace;
    }
}