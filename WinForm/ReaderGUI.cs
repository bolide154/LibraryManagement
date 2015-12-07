using Core.BLL;
using Core.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class ReaderGUI : Form
    {
        public ReaderGUI()
        {
            InitializeComponent();
        }

        private void ReaderGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataCombobox();
            this.LoadDataToDataGridView();
            this.lblNgayht.Text = DateTime.Now.ToShortDateString();
        }
        private void LoadDataCombobox()
        {
            List<string> keywd = new List<string>();
            keywd.Add("Reader Name");
            keywd.Add("Reader Id");
            keywd.Add("Phone Number");
            keywd.Add("E-mail");
            this.cboTimtheo.DataSource = keywd;

            List<string> staff = new List<string>();
            staff.Add("False");
            staff.Add("True");
            this.cboStaff.DataSource = staff;

            List<string> granduation = new List<string>();
            for (int i = 1850; i <= DateTime.Now.Year; i++)
            {
                granduation.Add(i.ToString());
            }
            this.cboGranduationyear.DataSource = granduation;
        }

        private void LoadDataToDataGridView()
        {
            this.dgvReader.Rows.Clear();
            List<ReaderBLL> readerList = new List<ReaderBLL>();
            readerList = ReaderDAL.getReaderList();
            foreach (ReaderBLL row in readerList)
            {
                
                //MessageBox.Show(row.IsStaff.ToString());
                this.dgvReader.Rows.Add(row.Code, row.Name, row.Address, row.Phone, row.Email, row.Allocateddate.ToShortDateString(), row.Enddate.ToShortDateString(),row.Birthday.ToShortDateString(),row.IsStaff, row.Granduation);
            }
            this.dgvReader.SelectionChanged += new EventHandler(dgvReader_SelectionChanged);
            GetSelectedValue();
        }

        private void dgvReader_SelectionChanged(object sender, EventArgs e)
        {
            GetSelectedValue();
        }
        private void GetSelectedValue()
        {
            if (this.dgvReader.SelectedCells.Count > 0 && this.dgvReader.CurrentRow.Index < this.dgvReader.Rows.Count - 1)
            {
                int selectedrowindex = dgvReader.SelectedCells[0].RowIndex;
                DateTime current = new DateTime();
                DateTime endtime = new DateTime();
                TimeSpan tg;
                DataGridViewRow selectedRow = dgvReader.Rows[selectedrowindex];
                Int64 id = Convert.ToInt64(selectedRow.Cells["clmnReaderId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnReaderName"].Value);
                string phone = Convert.ToString(selectedRow.Cells["clmnPhone"].Value);
                string email = Convert.ToString(selectedRow.Cells["clmnEmail"].Value);
                string address = Convert.ToString(selectedRow.Cells["clmnAddress"].Value);
                DateTime date_allo = Convert.ToDateTime(selectedRow.Cells["clmnDateAllocated"].Value);
                DateTime date_end = Convert.ToDateTime(selectedRow.Cells["clmnDateEnd"].Value);
                DateTime birthday = Convert.ToDateTime(selectedRow.Cells["clmnBirthday"].Value);
                string staff = Convert.ToString(selectedRow.Cells["clmnStaff"].Value);
                int graduation = Convert.ToInt32(selectedRow.Cells["clmnGraduation"].Value);
                current = DateTime.Now;
                endtime = Convert.ToDateTime(selectedRow.Cells["clmnDateEnd"].Value);
                tg = current - endtime;
                this.txtMadocgia.Text = id.ToString();
                this.txtDocgia.Text = name;
                this.txtPhone.Text = phone;
                this.txtEmail.Text = email;
                this.txtDc.Text = address;
                this.txtNgaycap.Text = date_allo.ToShortDateString();
                this.txtNgahet.Text = date_end.ToShortDateString();
                this.txtBirthday.Text = birthday.ToShortDateString();
                this.cboStaff.Text = staff.ToString();
                this.cboGranduationyear.Text = graduation.ToString();
                int songay = Convert.ToInt16(tg.Days);
                if (songay >= 0 )
                {
                    this.txtTrangthai.Text = "Hết Hạn " + songay + " ngày";
                }
                else
                {
                    this.txtTrangthai.Text = "Còn Hạn";
                }
                /*if (id == "")
                {
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = false;
                }
                else
                {
                    this.btnDelete.Enabled = true;
                    this.btnSave.Enabled = true;
                }*/
            }
            else
            {
                this.txtMadocgia.Text = "";
                this.txtDocgia.Text = "";
                this.txtPhone.Text = "";
                this.txtEmail.Text = "";
                this.txtDc.Text = "";
                this.txtNgaycap.Text = "";
                this.txtNgahet.Text = "";
                this.txtTrangthai.Text = "";
                this.txtBirthday.Text = "";
                this.cboStaff.Text = "";
                this.cboGranduationyear.Text = "";
                /*this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;*/
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReaderBLL readerBLL = new ReaderBLL();
            readerBLL.Name = this.txtDocgia.Text;
            readerBLL.Code = Convert.ToInt64(this.txtMadocgia.Text);
            readerBLL.Phone = this.txtPhone.Text;
            readerBLL.Email = this.txtEmail.Text;
            readerBLL.Address = this.txtDc.Text;
            readerBLL.Allocateddate = Convert.ToDateTime(this.txtNgaycap.Text);
            readerBLL.Enddate = Convert.ToDateTime(this.txtNgahet.Text);
            readerBLL.Birthday = Convert.ToDateTime(this.txtBirthday.Text);
            readerBLL.IsStaff = Convert.ToBoolean(this.cboStaff.Text);
            readerBLL.Granduation = Convert.ToInt32(this.cboGranduationyear.Text);
            if (readerBLL.Name == ""||readerBLL.Code==null || readerBLL.Phone == "" || readerBLL.Email == "" || readerBLL.Address == "" || readerBLL.Allocateddate == null || readerBLL.Enddate == null || readerBLL.Birthday == null)
            {
                MessageBox.Show("You mustn't empty any fields", "Notice");
                return;
            }
            if(!IsNumber(readerBLL.Code.ToString())|| !IsNumber(readerBLL.Granduation.ToString()))
            {
                MessageBox.Show("Both of \"Reader Code\" and \"Granduation year\" must be the number format!");
                return;
            }
            if (!IsAllAlphabetic(readerBLL.Name))
            {
                MessageBox.Show("The \"Reader Name\" must be the character format!");
                return;
            }
            if(!IsNumber(readerBLL.Phone))
            {
                MessageBox.Show("the \"Phone Number\" mustn't have the letters!");
                return;
            }
            /*if(ReaderDAL.getReaderItem(readerBLL) != null)
            {
                MessageBox.Show("The \"Reader Code\" Existed!");
                return;
            }*/
            List<ReaderBLL> readerList = new List<ReaderBLL>();
            readerList = ReaderDAL.getReaderList();
            foreach (ReaderBLL row in readerList)
            {

                //MessageBox.Show(row.IsStaff.ToString());
                if(readerBLL.Code == row.Code)
                {
                    MessageBox.Show("The \"Reader Code\" Existed!");
                    return;
                }
            }
            //isExist("123");
            ReaderDAL.addReader(readerBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToDataGridView();
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c) && c.ToString() != " ")
                    return false;
            }

            return true;
        }

        public static Connection _condb = new Connection();
        
        private void cboGranduationyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReader.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvReader.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvReader.Rows[selectedrowindex];
                string id = selectedRow.Cells["clmnReaderId"].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to delete reader: " + selectedRow.Cells["clmnReaderName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        ReaderBLL readerBLL = new ReaderBLL(selectedRow.Cells["clmnReaderName"].Value.ToString(), Convert.ToInt64(selectedRow.Cells["clmnReaderId"].Value.ToString()), selectedRow.Cells["clmnAddress"].Value.ToString(), selectedRow.Cells["clmnPhone"].Value.ToString(), selectedRow.Cells["clmnEmail"].Value.ToString(), Convert.ToDateTime(selectedRow.Cells["clmnDateallocated"].Value), Convert.ToDateTime(selectedRow.Cells["clmnDateend"].Value), Convert.ToDateTime(selectedRow.Cells["clmnDateallocated"].Value), Convert.ToBoolean(selectedRow.Cells["clmnStaff"].Value), Convert.ToInt32(selectedRow.Cells["clmnGraduation"].Value));
                        if (ReaderDAL.getReaderItem(readerBLL) == null)
                        {
                            MessageBox.Show("Can't delete! this Reader still not to give back of book");
                            break;
                        }
                        else
                        {
                            ReaderDAL.deleteReader(readerBLL);
                            MessageBox.Show("Delete complete!", "Success");
                            this.LoadDataToDataGridView();
                            break;
                        }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvReader.SelectedCells.Count > 0)
            {

                int selectedrowindex = dgvReader.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvReader.Rows[selectedrowindex];

                ReaderBLL readerBLL = new ReaderBLL(this.txtDocgia.Text, Convert.ToInt64(this.txtMadocgia.Text), this.txtDc.Text, this.txtPhone.Text, this.txtEmail.Text, Convert.ToDateTime(this.txtNgaycap.Text), Convert.ToDateTime(this.txtNgahet.Text), Convert.ToDateTime(this.txtBirthday.Text), Convert.ToBoolean(this.cboStaff.Text), Convert.ToInt32(this.cboGranduationyear.Text));
                //Int64 readerId = Int64.Parse(this.txtMadocgia.Text);
                if (this.txtDocgia.Text == "" || this.txtPhone.Text == "" || this.txtEmail.Text == "" || this.txtDc.Text == "" || this.txtNgaycap.Text == "" || this.txtNgahet.Text == "" || this.txtBirthday.Text == "")
                {
                    MessageBox.Show("You mustn't empty any fields", "Notice");
                    return;
                }
                if (!IsNumber(this.cboGranduationyear.Text))
                {
                    MessageBox.Show("Both of \"Reader Code\" and \"Granduation year\" must be the number format!");
                    return;
                }
                if (!IsAllAlphabetic(this.txtDocgia.Text))
                {
                    MessageBox.Show("The \"Reader Name\" must be the character format!");
                    return;
                }
                if (!IsNumber(this.txtPhone.Text))
                {
                    MessageBox.Show("the \"Phone Number\" mustn't have the letters!");
                    return;
                }
                ReaderDAL.updateReader(readerBLL); //MessageBox.Show(readerBLL.Code.ToString());
                MessageBox.Show("Update success!", "Success");
                this.LoadDataToDataGridView();
            }
        }
    }
}
