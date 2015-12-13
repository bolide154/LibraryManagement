namespace WinForm
{
    partial class BackBookGUI
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
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.clmnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtCertificate = new System.Windows.Forms.TextBox();
            this.lblCertificate = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDayEnd = new System.Windows.Forms.TextBox();
            this.txtDayStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddVoucher = new System.Windows.Forms.Button();
            this.txtReaderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCode,
            this.clmnBookName});
            this.dgvBook.Location = new System.Drawing.Point(7, 237);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.Size = new System.Drawing.Size(618, 186);
            this.dgvBook.TabIndex = 73;
            // 
            // clmnCode
            // 
            this.clmnCode.HeaderText = "Book Id";
            this.clmnCode.Name = "clmnCode";
            this.clmnCode.ReadOnly = true;
            // 
            // clmnBookName
            // 
            this.clmnBookName.HeaderText = "Book Name";
            this.clmnBookName.Name = "clmnBookName";
            this.clmnBookName.ReadOnly = true;
            this.clmnBookName.Width = 515;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(350, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 26);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 20);
            this.txtSearch.TabIndex = 75;
            // 
            // txtCertificate
            // 
            this.txtCertificate.Location = new System.Drawing.Point(93, 55);
            this.txtCertificate.Name = "txtCertificate";
            this.txtCertificate.ReadOnly = true;
            this.txtCertificate.Size = new System.Drawing.Size(186, 20);
            this.txtCertificate.TabIndex = 83;
            // 
            // lblCertificate
            // 
            this.lblCertificate.AutoSize = true;
            this.lblCertificate.Location = new System.Drawing.Point(8, 58);
            this.lblCertificate.Name = "lblCertificate";
            this.lblCertificate.Size = new System.Drawing.Size(60, 13);
            this.lblCertificate.TabIndex = 82;
            this.lblCertificate.Text = "Certificate :";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(93, 96);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.ReadOnly = true;
            this.txtReaderName.Size = new System.Drawing.Size(186, 20);
            this.txtReaderName.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Reader Name :";
            // 
            // txtDayEnd
            // 
            this.txtDayEnd.Location = new System.Drawing.Point(429, 138);
            this.txtDayEnd.Name = "txtDayEnd";
            this.txtDayEnd.ReadOnly = true;
            this.txtDayEnd.Size = new System.Drawing.Size(186, 20);
            this.txtDayEnd.TabIndex = 89;
            // 
            // txtDayStart
            // 
            this.txtDayStart.Location = new System.Drawing.Point(93, 138);
            this.txtDayStart.Name = "txtDayStart";
            this.txtDayStart.ReadOnly = true;
            this.txtDayStart.Size = new System.Drawing.Size(186, 20);
            this.txtDayStart.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Day End :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Day Start :";
            // 
            // btnAddVoucher
            // 
            this.btnAddVoucher.Location = new System.Drawing.Point(518, 208);
            this.btnAddVoucher.Name = "btnAddVoucher";
            this.btnAddVoucher.Size = new System.Drawing.Size(97, 23);
            this.btnAddVoucher.TabIndex = 90;
            this.btnAddVoucher.Text = "Add Voucher";
            this.btnAddVoucher.UseVisualStyleBackColor = true;
            this.btnAddVoucher.Click += new System.EventHandler(this.btnAddVoucher_Click);
            // 
            // txtReaderId
            // 
            this.txtReaderId.Location = new System.Drawing.Point(429, 96);
            this.txtReaderId.Name = "txtReaderId";
            this.txtReaderId.ReadOnly = true;
            this.txtReaderId.Size = new System.Drawing.Size(186, 20);
            this.txtReaderId.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Reader Id :";
            // 
            // BackBookGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 428);
            this.Controls.Add(this.txtReaderId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddVoucher);
            this.Controls.Add(this.txtDayEnd);
            this.Controls.Add(this.txtDayStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReaderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCertificate);
            this.Controls.Add(this.lblCertificate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvBook);
            this.Name = "BackBookGUI";
            this.Text = "BackBook";
            this.Load += new System.EventHandler(this.BackBookGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtCertificate;
        private System.Windows.Forms.Label lblCertificate;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDayEnd;
        private System.Windows.Forms.TextBox txtDayStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddVoucher;
        private System.Windows.Forms.TextBox txtReaderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookName;
    }
}