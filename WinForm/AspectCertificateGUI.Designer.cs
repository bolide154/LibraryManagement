namespace WinForm
{
    partial class AspectCertificateGUI
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
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchCertificate = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCertificateStt = new System.Windows.Forms.TextBox();
            this.lblBookStatusName = new System.Windows.Forms.Label();
            this.lblInfor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificateStt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCertificateStt
            // 
            this.dgvCertificateStt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificateStt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnName});
            this.dgvCertificateStt.Location = new System.Drawing.Point(23, 60);
            this.dgvCertificateStt.Name = "dgvCertificateStt";
            this.dgvCertificateStt.Size = new System.Drawing.Size(397, 210);
            this.dgvCertificateStt.TabIndex = 52;
            this.dgvCertificateStt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCertificateStt_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Search by:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(185, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 20);
            this.txtSearch.TabIndex = 62;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(354, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearchCertificate
            // 
            this.cboSearchCertificate.DisplayMember = "a";
            this.cboSearchCertificate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchCertificate.FormattingEnabled = true;
            this.cboSearchCertificate.Items.AddRange(new object[] {
            "Tên tác giả",
            "Nơi công tác"});
            this.cboSearchCertificate.Location = new System.Drawing.Point(88, 19);
            this.cboSearchCertificate.Name = "cboSearchCertificate";
            this.cboSearchCertificate.Size = new System.Drawing.Size(91, 21);
            this.cboSearchCertificate.TabIndex = 60;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(332, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(228, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(125, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCertificateStt
            // 
            this.txtCertificateStt.Location = new System.Drawing.Point(23, 344);
            this.txtCertificateStt.Name = "txtCertificateStt";
            this.txtCertificateStt.Size = new System.Drawing.Size(221, 20);
            this.txtCertificateStt.TabIndex = 55;
            // 
            // lblBookStatusName
            // 
            this.lblBookStatusName.AutoSize = true;
            this.lblBookStatusName.Location = new System.Drawing.Point(20, 317);
            this.lblBookStatusName.Name = "lblBookStatusName";
            this.lblBookStatusName.Size = new System.Drawing.Size(99, 13);
            this.lblBookStatusName.TabIndex = 54;
            this.lblBookStatusName.Text = "Book Status Name:";
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.Location = new System.Drawing.Point(20, 289);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(55, 13);
            this.lblInfor.TabIndex = 53;
            this.lblInfor.Text = "Id / Name";
            // 
            // AspectCertificateGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 420);
            this.Controls.Add(this.dgvCertificateStt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearchCertificate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCertificateStt);
            this.Controls.Add(this.lblBookStatusName);
            this.Controls.Add(this.lblInfor);
            this.Name = "AspectCertificateGUI";
            this.Text = "AspectCertificateGUI";
            this.Load += new System.EventHandler(this.AspectCertificateGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificateStt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCertificateStt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchCertificate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCertificateStt;
        private System.Windows.Forms.Label lblBookStatusName;
        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
    }
}