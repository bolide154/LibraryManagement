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
    public partial class BackBookGUI : Form
    {
        public BackBookGUI()
        {
            InitializeComponent();
        }

        private void BackBookGUI_Load(object sender, EventArgs e)
        {
            this.btnAddVoucher.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.search();
        }
        private void search()
        {
            string key = this.txtSearch.Text;
            if (key == "".Trim())
            {
                MessageBox.Show("Please enter keyword!", "Notice");
                return;
            }
            string catalog = "";
            //MessageBox.Show(this.cboSearch.SelectedItem.ToString());
            /*if (this.cboSearch.SelectedItem.ToString() == "Certificate")
            {
                catalog += "phieumuon.maphieumuon";
                //MessageBox.Show(catalog);
            }
            else if (this.cboSearch.SelectedItem.ToString() == "Certificate Stt")
            {
                catalog += "tinhtrangphieumuon.tentinhtrang";
                //MessageBox.Show(catalog);
            }*/
            BackBookBLL bookStatusBLL = new BackBookBLL();
            List<BackBookBLL> backbookArr = new List<BackBookBLL>();
            backbookArr = BackBookDAL.search(key);
            this.dgvBook.Rows.Clear();
            if (backbookArr != null)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "";
                checkBoxColumn.Width = 30;
                checkBoxColumn.Name = "chkBook";
                //MessageBox.Show("ok");
                int dem = 0;
                if (this.dgvBook.ColumnCount == 3)
                {
                    this.dgvBook.Columns.RemoveAt(0);
                }
                foreach (BackBookBLL row in backbookArr)
                {
                    dem++;
                    if (row.Bookstt != 1)
                    {
                        this.dgvBook.Rows.Add(row.Bookid, row.Bookname);
                        this.dgvBook.Columns.Insert(0, checkBoxColumn);
                    }
                    if (backbookArr.Count == dem)
                    {
                        this.txtCertificate.Text = row.Code.ToString();
                        this.txtReaderName.Text = row.Name;
                        this.txtReaderId.Text = row.ReaderId.ToString();
                        this.txtDayStart.Text = row.Datestart.ToShortDateString();
                        this.txtDayEnd.Text = row.Dateend.ToShortDateString();
                        if(this.dgvBook.RowCount < 1)
                        {
                            this.btnAddVoucher.Enabled = false;
                        }
                        else
                        {
                            this.btnAddVoucher.Enabled = true;
                        }
                    }

                }
            }
            else
            {
                this.txtCertificate.Text = "";
                this.txtReaderName.Text = "";
                this.txtReaderId.Text = "";
                this.txtDayStart.Text = "";
                this.txtDayEnd.Text = "";
                if (this.dgvBook.ColumnCount == 3)
                {
                    this.dgvBook.Columns.RemoveAt(0);
                }

                this.btnAddVoucher.Enabled = false;
                MessageBox.Show("Sorry! Can't find this certificate");
            }
        }
        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            //string message = "";
            //List<string> maso;
            Int32 voucher = BackBookDAL.addVoucher(Convert.ToInt64(this.txtReaderId.Text));
            for (int i = 0; i < this.dgvBook.RowCount; i++)
            {
                //maso = new List<string>();
                bool check = Convert.ToBoolean(this.dgvBook.Rows[i].Cells["chkBook"].Value);
                if(check)
                {
                    BackBookDAL.editbookstt(Int32.Parse(this.dgvBook.Rows[i].Cells["clmnCode"].Value.ToString()));
                    BackBookDAL.addBackBook(voucher, Int32.Parse(this.dgvBook.Rows[i].Cells["clmnCode"].Value.ToString()),Int32.Parse(this.txtCertificate.Text));
                    /*message += Environment.NewLine;
                    message += this.dgvBook.Rows[i].Cells["clmnCode"].Value.ToString();*/
                }
            }
            BackBookDAL.checkCertificateStt(Int32.Parse(this.txtCertificate.Text));
            MessageBox.Show("To create voucher is complete!");
            this.search();
        }
    }
}
