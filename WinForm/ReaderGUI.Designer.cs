namespace WinForm
{
    partial class ReaderGUI
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
            this.lblNgayht = new System.Windows.Forms.Label();
            this.lblTdg = new System.Windows.Forms.Label();
            this.lblDc = new System.Windows.Forms.Label();
            this.lblNgaycap = new System.Windows.Forms.Label();
            this.lblMadocgia = new System.Windows.Forms.Label();
            this.txtDocgia = new System.Windows.Forms.TextBox();
            this.txtDc = new System.Windows.Forms.TextBox();
            this.txtNgaycap = new System.Windows.Forms.TextBox();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.txtNgahet = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.lblNgayhet = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboTimtheo = new System.Windows.Forms.ComboBox();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.clmnReaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDateAllocated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGraduation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtGranduationyear = new System.Windows.Forms.Label();
            this.cboGranduationyear = new System.Windows.Forms.ComboBox();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today :";
            // 
            // lblNgayht
            // 
            this.lblNgayht.AutoSize = true;
            this.lblNgayht.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayht.Location = new System.Drawing.Point(110, 9);
            this.lblNgayht.Name = "lblNgayht";
            this.lblNgayht.Size = new System.Drawing.Size(126, 25);
            this.lblNgayht.TabIndex = 1;
            this.lblNgayht.Text = "dd/mm/yyyy";
            // 
            // lblTdg
            // 
            this.lblTdg.AutoSize = true;
            this.lblTdg.Location = new System.Drawing.Point(17, 61);
            this.lblTdg.Name = "lblTdg";
            this.lblTdg.Size = new System.Drawing.Size(73, 13);
            this.lblTdg.TabIndex = 2;
            this.lblTdg.Text = "Reader Name";
            // 
            // lblDc
            // 
            this.lblDc.AutoSize = true;
            this.lblDc.Location = new System.Drawing.Point(17, 108);
            this.lblDc.Name = "lblDc";
            this.lblDc.Size = new System.Drawing.Size(45, 13);
            this.lblDc.TabIndex = 3;
            this.lblDc.Text = "Address";
            // 
            // lblNgaycap
            // 
            this.lblNgaycap.AutoSize = true;
            this.lblNgaycap.Location = new System.Drawing.Point(17, 202);
            this.lblNgaycap.Name = "lblNgaycap";
            this.lblNgaycap.Size = new System.Drawing.Size(80, 13);
            this.lblNgaycap.TabIndex = 4;
            this.lblNgaycap.Text = "Date Allocated ";
            // 
            // lblMadocgia
            // 
            this.lblMadocgia.AutoSize = true;
            this.lblMadocgia.Location = new System.Drawing.Point(17, 155);
            this.lblMadocgia.Name = "lblMadocgia";
            this.lblMadocgia.Size = new System.Drawing.Size(54, 13);
            this.lblMadocgia.TabIndex = 5;
            this.lblMadocgia.Text = "Reader Id";
            // 
            // txtDocgia
            // 
            this.txtDocgia.Location = new System.Drawing.Point(115, 54);
            this.txtDocgia.Name = "txtDocgia";
            this.txtDocgia.Size = new System.Drawing.Size(291, 20);
            this.txtDocgia.TabIndex = 6;
            // 
            // txtDc
            // 
            this.txtDc.Location = new System.Drawing.Point(115, 101);
            this.txtDc.Name = "txtDc";
            this.txtDc.Size = new System.Drawing.Size(291, 20);
            this.txtDc.TabIndex = 7;
            // 
            // txtNgaycap
            // 
            this.txtNgaycap.Location = new System.Drawing.Point(115, 195);
            this.txtNgaycap.Name = "txtNgaycap";
            this.txtNgaycap.Size = new System.Drawing.Size(291, 20);
            this.txtNgaycap.TabIndex = 8;
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.Location = new System.Drawing.Point(115, 148);
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(291, 20);
            this.txtMadocgia.TabIndex = 9;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(602, 244);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(303, 20);
            this.txtTrangthai.TabIndex = 17;
            // 
            // txtNgahet
            // 
            this.txtNgahet.Location = new System.Drawing.Point(602, 195);
            this.txtNgahet.Name = "txtNgahet";
            this.txtNgahet.Size = new System.Drawing.Size(303, 20);
            this.txtNgahet.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(602, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(602, 101);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(303, 20);
            this.txtPhone.TabIndex = 14;
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Location = new System.Drawing.Point(504, 251);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(37, 13);
            this.lblTrangthai.TabIndex = 13;
            this.lblTrangthai.Text = "Status";
            // 
            // lblNgayhet
            // 
            this.lblNgayhet.AutoSize = true;
            this.lblNgayhet.Location = new System.Drawing.Point(504, 202);
            this.lblNgayhet.Name = "lblNgayhet";
            this.lblNgayhet.Size = new System.Drawing.Size(55, 13);
            this.lblNgayhet.TabIndex = 12;
            this.lblNgayhet.Text = "Date End ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(504, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(504, 108);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(557, 326);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 21);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(830, 325);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboTimtheo
            // 
            this.cboTimtheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimtheo.FormattingEnabled = true;
            this.cboTimtheo.Location = new System.Drawing.Point(441, 326);
            this.cboTimtheo.Name = "cboTimtheo";
            this.cboTimtheo.Size = new System.Drawing.Size(110, 21);
            this.cboTimtheo.TabIndex = 21;
            // 
            // dgvReader
            // 
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnReaderId,
            this.clmnReaderName,
            this.clmnAddress,
            this.clmnPhone,
            this.clmnEmail,
            this.clmnDateAllocated,
            this.clmnDateEnd,
            this.clmnBirthday,
            this.clmnStaff,
            this.clmnGraduation});
            this.dgvReader.Location = new System.Drawing.Point(12, 362);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvReader.Size = new System.Drawing.Size(893, 225);
            this.dgvReader.TabIndex = 22;
            // 
            // clmnReaderId
            // 
            this.clmnReaderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnReaderId.HeaderText = "Reader Id";
            this.clmnReaderId.Name = "clmnReaderId";
            this.clmnReaderId.Visible = false;
            // 
            // clmnReaderName
            // 
            this.clmnReaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnReaderName.HeaderText = "Reader Name";
            this.clmnReaderName.Name = "clmnReaderName";
            // 
            // clmnAddress
            // 
            this.clmnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnAddress.HeaderText = "Address";
            this.clmnAddress.Name = "clmnAddress";
            // 
            // clmnPhone
            // 
            this.clmnPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnPhone.HeaderText = "Phone";
            this.clmnPhone.Name = "clmnPhone";
            // 
            // clmnEmail
            // 
            this.clmnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnEmail.HeaderText = "Email";
            this.clmnEmail.Name = "clmnEmail";
            // 
            // clmnDateAllocated
            // 
            this.clmnDateAllocated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDateAllocated.HeaderText = "Date Allocated";
            this.clmnDateAllocated.Name = "clmnDateAllocated";
            // 
            // clmnDateEnd
            // 
            this.clmnDateEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDateEnd.HeaderText = "Date End";
            this.clmnDateEnd.Name = "clmnDateEnd";
            // 
            // clmnBirthday
            // 
            this.clmnBirthday.HeaderText = "Birthday";
            this.clmnBirthday.Name = "clmnBirthday";
            // 
            // clmnStaff
            // 
            this.clmnStaff.HeaderText = "Staff";
            this.clmnStaff.Name = "clmnStaff";
            this.clmnStaff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnStaff.Visible = false;
            // 
            // clmnGraduation
            // 
            this.clmnGraduation.HeaderText = "Graduation year";
            this.clmnGraduation.Name = "clmnGraduation";
            this.clmnGraduation.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(90, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delate";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(252, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(602, 54);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(303, 20);
            this.txtBirthday.TabIndex = 28;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(504, 61);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 27;
            this.lblBirthday.Text = "Birthday";
            // 
            // txtGranduationyear
            // 
            this.txtGranduationyear.AutoSize = true;
            this.txtGranduationyear.Location = new System.Drawing.Point(212, 251);
            this.txtGranduationyear.Name = "txtGranduationyear";
            this.txtGranduationyear.Size = new System.Drawing.Size(82, 13);
            this.txtGranduationyear.TabIndex = 29;
            this.txtGranduationyear.Text = "Graduation year";
            // 
            // cboGranduationyear
            // 
            this.cboGranduationyear.AllowDrop = true;
            this.cboGranduationyear.FormattingEnabled = true;
            this.cboGranduationyear.Location = new System.Drawing.Point(310, 243);
            this.cboGranduationyear.Name = "cboGranduationyear";
            this.cboGranduationyear.Size = new System.Drawing.Size(96, 21);
            this.cboGranduationyear.TabIndex = 30;
            this.cboGranduationyear.SelectedIndexChanged += new System.EventHandler(this.cboGranduationyear_SelectedIndexChanged);
            // 
            // cboStaff
            // 
            this.cboStaff.AllowDrop = true;
            this.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Location = new System.Drawing.Point(115, 243);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(76, 21);
            this.cboStaff.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Staff";
            // 
            // ReaderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 595);
            this.Controls.Add(this.cboStaff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGranduationyear);
            this.Controls.Add(this.txtGranduationyear);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvReader);
            this.Controls.Add(this.cboTimtheo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.txtNgahet);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblTrangthai);
            this.Controls.Add(this.lblNgayhet);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtMadocgia);
            this.Controls.Add(this.txtNgaycap);
            this.Controls.Add(this.txtDc);
            this.Controls.Add(this.txtDocgia);
            this.Controls.Add(this.lblMadocgia);
            this.Controls.Add(this.lblNgaycap);
            this.Controls.Add(this.lblDc);
            this.Controls.Add(this.lblTdg);
            this.Controls.Add(this.lblNgayht);
            this.Controls.Add(this.label1);
            this.Name = "ReaderGUI";
            this.Text = "ReaderGUI";
            this.Load += new System.EventHandler(this.ReaderGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgayht;
        private System.Windows.Forms.Label lblTdg;
        private System.Windows.Forms.Label lblDc;
        private System.Windows.Forms.Label lblNgaycap;
        private System.Windows.Forms.Label lblMadocgia;
        private System.Windows.Forms.TextBox txtDocgia;
        private System.Windows.Forms.TextBox txtDc;
        private System.Windows.Forms.TextBox txtNgaycap;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.TextBox txtNgahet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.Label lblNgayhet;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboTimtheo;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label txtGranduationyear;
        private System.Windows.Forms.ComboBox cboGranduationyear;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDateAllocated;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGraduation;
    }
}