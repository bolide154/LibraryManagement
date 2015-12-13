namespace WinForm
{
    partial class CertificateGUI
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
            this.dgvCertificateStt = new System.Windows.Forms.DataGridView();
            this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDayStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDayEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReaderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetailCertificate = new System.Windows.Forms.DataGridView();
            this.clmnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtReaderCode = new System.Windows.Forms.TextBox();
            this.txtDayStart = new System.Windows.Forms.TextBox();
            this.txtOutOfDay = new System.Windows.Forms.TextBox();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.txtDayEnd = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnExportEx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificateStt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCertificateStt
            // 
            this.dgvCertificateStt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificateStt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnStt,
            this.clmnDayStart,
            this.clmnDayEnd,
            this.clmnReaderName,
            this.clmnObject,
            this.clmnReaderCode});
            this.dgvCertificateStt.Location = new System.Drawing.Point(9, 30);
            this.dgvCertificateStt.Name = "dgvCertificateStt";
            this.dgvCertificateStt.ReadOnly = true;
            this.dgvCertificateStt.RowHeadersVisible = false;
            this.dgvCertificateStt.Size = new System.Drawing.Size(279, 423);
            this.dgvCertificateStt.TabIndex = 53;
            this.dgvCertificateStt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCertificateStt_CellContentClick);
            // 
            // clmnId
            // 
            this.clmnId.HeaderText = "Certificate";
            this.clmnId.Name = "clmnId";
            this.clmnId.ReadOnly = true;
            this.clmnId.Width = 140;
            // 
            // clmnStt
            // 
            this.clmnStt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnStt.HeaderText = "Certificate Status";
            this.clmnStt.Name = "clmnStt";
            this.clmnStt.ReadOnly = true;
            // 
            // clmnDayStart
            // 
            this.clmnDayStart.HeaderText = "Day Start";
            this.clmnDayStart.Name = "clmnDayStart";
            this.clmnDayStart.ReadOnly = true;
            this.clmnDayStart.Visible = false;
            // 
            // clmnDayEnd
            // 
            this.clmnDayEnd.HeaderText = "Day End";
            this.clmnDayEnd.Name = "clmnDayEnd";
            this.clmnDayEnd.ReadOnly = true;
            this.clmnDayEnd.Visible = false;
            // 
            // clmnReaderName
            // 
            this.clmnReaderName.HeaderText = "Name";
            this.clmnReaderName.Name = "clmnReaderName";
            this.clmnReaderName.ReadOnly = true;
            this.clmnReaderName.Visible = false;
            // 
            // clmnObject
            // 
            this.clmnObject.HeaderText = "Object";
            this.clmnObject.Name = "clmnObject";
            this.clmnObject.ReadOnly = true;
            this.clmnObject.Visible = false;
            // 
            // clmnReaderCode
            // 
            this.clmnReaderCode.HeaderText = "Code";
            this.clmnReaderCode.Name = "clmnReaderCode";
            this.clmnReaderCode.ReadOnly = true;
            this.clmnReaderCode.Visible = false;
            // 
            // dgvDetailCertificate
            // 
            this.dgvDetailCertificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailCertificate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCode,
            this.clmnBookName});
            this.dgvDetailCertificate.Location = new System.Drawing.Point(341, 267);
            this.dgvDetailCertificate.Name = "dgvDetailCertificate";
            this.dgvDetailCertificate.ReadOnly = true;
            this.dgvDetailCertificate.RowHeadersVisible = false;
            this.dgvDetailCertificate.Size = new System.Drawing.Size(518, 186);
            this.dgvDetailCertificate.TabIndex = 56;
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
            this.clmnBookName.Width = 415;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(437, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 20);
            this.txtSearch.TabIndex = 57;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(772, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 26);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.Location = new System.Drawing.Point(338, 55);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(79, 13);
            this.lblReaderName.TabIndex = 59;
            this.lblReaderName.Text = "Reader Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Reader Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Day Start :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Day End :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Out Of Day :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Object :";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(418, 50);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(186, 20);
            this.txtReaderName.TabIndex = 65;
            // 
            // txtReaderCode
            // 
            this.txtReaderCode.Location = new System.Drawing.Point(418, 88);
            this.txtReaderCode.Name = "txtReaderCode";
            this.txtReaderCode.Size = new System.Drawing.Size(186, 20);
            this.txtReaderCode.TabIndex = 66;
            // 
            // txtDayStart
            // 
            this.txtDayStart.Location = new System.Drawing.Point(418, 128);
            this.txtDayStart.Name = "txtDayStart";
            this.txtDayStart.Size = new System.Drawing.Size(186, 20);
            this.txtDayStart.TabIndex = 67;
            // 
            // txtOutOfDay
            // 
            this.txtOutOfDay.Location = new System.Drawing.Point(418, 165);
            this.txtOutOfDay.Name = "txtOutOfDay";
            this.txtOutOfDay.Size = new System.Drawing.Size(186, 20);
            this.txtOutOfDay.TabIndex = 68;
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(661, 50);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(186, 20);
            this.txtObject.TabIndex = 69;
            // 
            // txtDayEnd
            // 
            this.txtDayEnd.Location = new System.Drawing.Point(661, 128);
            this.txtDayEnd.Name = "txtDayEnd";
            this.txtDayEnd.Size = new System.Drawing.Size(186, 20);
            this.txtDayEnd.TabIndex = 70;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(296, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 6);
            this.lblId.TabIndex = 71;
            this.lblId.Visible = false;
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(341, 5);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(90, 21);
            this.cboSearch.TabIndex = 72;
            // 
            // btnExportEx
            // 
            this.btnExportEx.Location = new System.Drawing.Point(760, 235);
            this.btnExportEx.Name = "btnExportEx";
            this.btnExportEx.Size = new System.Drawing.Size(93, 26);
            this.btnExportEx.TabIndex = 73;
            this.btnExportEx.Text = "Export Excel";
            this.btnExportEx.UseVisualStyleBackColor = true;
            this.btnExportEx.Click += new System.EventHandler(this.btnExportEx_Click);
            // 
            // CertificateGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 459);
            this.Controls.Add(this.btnExportEx);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtDayEnd);
            this.Controls.Add(this.txtObject);
            this.Controls.Add(this.txtOutOfDay);
            this.Controls.Add(this.txtDayStart);
            this.Controls.Add(this.txtReaderCode);
            this.Controls.Add(this.txtReaderName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReaderName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDetailCertificate);
            this.Controls.Add(this.dgvCertificateStt);
            this.Name = "CertificateGUI";
            this.Text = "ManageCertificateGUI";
            this.Load += new System.EventHandler(this.ManageCertificateGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificateStt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCertificate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCertificateStt;
        private System.Windows.Forms.DataGridView dgvDetailCertificate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.TextBox txtReaderCode;
        private System.Windows.Forms.TextBox txtDayStart;
        private System.Windows.Forms.TextBox txtOutOfDay;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.TextBox txtDayEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDayStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDayEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReaderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBookName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Button btnExportEx;
    }
}