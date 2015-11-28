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
            keywd.Add("Reader's Name");
            keywd.Add("Reader's Code");
            keywd.Add("Phone Number");
            keywd.Add("E-mail");
            this.cboTimtheo.DataSource = keywd;
        }

        private void LoadDataToDataGridView()
        {
            //this.dgvDocgia.Rows.Clear();
            List<ReaderBLL> readerList = new List<ReaderBLL>();
            readerList = ReaderDAL.getReaderList();
            foreach (ReaderBLL row in readerList)
            {
                this.dgvReader.Rows.Add(row.Code, row.Name, row.Address, row.Phone, row.Email, row.Allocateddate, row.Enddate);
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
                string id = Convert.ToString(selectedRow.Cells["clmnReaderId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnReaderName"].Value);
                string phone = Convert.ToString(selectedRow.Cells["clmnPhone"].Value);
                string email = Convert.ToString(selectedRow.Cells["clmnEmail"].Value);
                string address = Convert.ToString(selectedRow.Cells["clmnAddress"].Value);
                string date_allo = Convert.ToString(selectedRow.Cells["clmnDateAllocated"].Value);
                string date_end = Convert.ToString(selectedRow.Cells["clmnDateEnd"].Value);
                current = DateTime.Now;
                endtime = Convert.ToDateTime(selectedRow.Cells["clmnDateEnd"].Value);
                tg = current - endtime;
                this.txtMadocgia.Text = id;
                this.txtDocgia.Text = name;
                this.txtPhone.Text = phone;
                this.txtEmail.Text = email;
                this.txtDc.Text = address;
                this.txtNgaycap.Text = date_allo;
                this.txtNgahet.Text = date_end;
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
                /*this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;*/
            }
        }
    }
}
