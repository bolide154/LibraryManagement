namespace WinForm
{
    partial class VoucherGUI
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
            this.txtObject = new System.Windows.Forms.TextBox();
            this.txtPayDay = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDetailVoucher = new System.Windows.Forms.DataGridView();
            this.clmnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVoucherStt = new System.Windows.Forms.DataGridView();
            this.clmnVoucherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCertificateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPayday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCertificate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherStt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(656, 53);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(186, 20);
            this.txtObject.TabIndex = 85;
            // 
            // txtPayDay
            // 
            this.txtPayDay.Location = new System.Drawing.Point(413, 91);
            this.txtPayDay.Name = "txtPayDay";
            this.txtPayDay.Size = new System.Drawing.Size(186, 20);
            this.txtPayDay.TabIndex = 82;
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(413, 53);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(186, 20);
            this.txtReaderName.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Object :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Pay Day :";
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.Location = new System.Drawing.Point(333, 58);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(79, 13);
            this.lblReaderName.TabIndex = 75;
            this.lblReaderName.Text = "Reader Name :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(767, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 26);
            this.btnSearch.TabIndex = 74;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(432, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 20);
            this.txtSearch.TabIndex = 73;
            // 
            // dgvDetailVoucher
            // 
            this.dgvDetailVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCode,
            this.clmnBookName});
            this.dgvDetailVoucher.Location = new System.Drawing.Point(336, 270);
            this.dgvDetailVoucher.Name = "dgvDetailVoucher";
            this.dgvDetailVoucher.RowHeadersVisible = false;
            this.dgvDetailVoucher.Size = new System.Drawing.Size(518, 186);
            this.dgvDetailVoucher.TabIndex = 72;
            // 
            // clmnCode
            // 
            this.clmnCode.HeaderText = "Book Id";
            this.clmnCode.Name = "clmnCode";
            // 
            // clmnBookName
            // 
            this.clmnBookName.HeaderText = "Book Name";
            this.clmnBookName.Name = "clmnBookName";
            this.clmnBookName.Width = 415;
            // 
            // dgvVoucherStt
            // 
            this.dgvVoucherStt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucherStt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnVoucherId,
            this.clmnCertificateId,
            this.clmnPayday,
            this.clmnReader,
            this.clmnObject});
            this.dgvVoucherStt.Location = new System.Drawing.Point(4, 33);
            this.dgvVoucherStt.Name = "dgvVoucherStt";
            this.dgvVoucherStt.RowHeadersVisible = false;
            this.dgvVoucherStt.Size = new System.Drawing.Size(279, 423);
            this.dgvVoucherStt.TabIndex = 71;
            // 
            // clmnVoucherId
            // 
            this.clmnVoucherId.HeaderText = "Voucher";
            this.clmnVoucherId.Name = "clmnVoucherId";
            this.clmnVoucherId.Width = 140;
            // 
            // clmnCertificateId
            // 
            this.clmnCertificateId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnCertificateId.HeaderText = "Certificate";
            this.clmnCertificateId.Name = "clmnCertificateId";
            this.clmnCertificateId.ReadOnly = true;
            // 
            // clmnPayday
            // 
            this.clmnPayday.HeaderText = "Pay Day";
            this.clmnPayday.Name = "clmnPayday";
            this.clmnPayday.Visible = false;
            // 
            // clmnReader
            // 
            this.clmnReader.HeaderText = "Reader";
            this.clmnReader.Name = "clmnReader";
            this.clmnReader.Visible = false;
            // 
            // clmnObject
            // 
            this.clmnObject.HeaderText = "Ob";
            this.clmnObject.Name = "clmnObject";
            this.clmnObject.Visible = false;
            // 
            // txtCertificate
            // 
            this.txtCertificate.Location = new System.Drawing.Point(656, 91);
            this.txtCertificate.Name = "txtCertificate";
            this.txtCertificate.Size = new System.Drawing.Size(186, 20);
            this.txtCertificate.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Certificate :";
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(336, 8);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(90, 21);
            this.cboSearch.TabIndex = 88;
            // 
            // VoucherGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 461);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtCertificate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObject);
            this.Controls.Add(this.txtPayDay);
            this.Controls.Add(this.txtReaderName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReaderName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDetailVoucher);
            this.Controls.Add(this.dgvVoucherStt);
            this.Name = "VoucherGUI";
            this.Text = "VoucherGUI";
            this.Load += new System.EventHandler(this.VoucherGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherStt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.TextBox txtPayDay;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDetailVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookName;
        private System.Windows.Forms.DataGridView dgvVoucherStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnVoucherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCertificateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPayday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnObject;
        private System.Windows.Forms.TextBox txtCertificate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSearch;
    }
}