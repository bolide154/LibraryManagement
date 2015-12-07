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
    public partial class VoucherGUI : Form
    {
        public VoucherGUI()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            this.dgvVoucherStt.Rows.Clear();
            VoucherBLL manageVoucherBLL = new VoucherBLL();
            List<VoucherBLL> manageVoucherArr = new List<VoucherBLL>();
            manageVoucherArr = VoucherDAL.getManageVoucherList();
            //MessageBox.Show("ok");
            foreach (VoucherBLL row in manageVoucherArr)
            {
                this.dgvVoucherStt.Rows.Add(row.Phieutra, row.Phieumuon, row.Ngaytra, row.Docgia, row.Doituong);
            }
            this.GetSelectedValue();
            this.dgvVoucherStt.SelectionChanged += new EventHandler(dgvCertificateStt_SelectionChanged);
        }

        private void dgvCertificateStt_SelectionChanged(object sender, EventArgs e)
        {
            this.GetSelectedValue();
        }

        private void GetSelectedValue()
        {
            if (this.dgvVoucherStt.SelectedCells.Count > 0 && this.dgvVoucherStt.CurrentRow.Index < this.dgvVoucherStt.Rows.Count - 1)
            {
                int selectedrowindex = this.dgvVoucherStt.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvVoucherStt.Rows[selectedrowindex];
                string name = Convert.ToString(selectedRow.Cells["clmnReader"].Value);
                bool ob = Convert.ToBoolean(selectedRow.Cells["clmnObject"].Value);
                string id = Convert.ToString(selectedRow.Cells["clmnCertificateId"].Value);
                DateTime payday = Convert.ToDateTime(selectedRow.Cells["clmnPayDay"].Value);
                this.txtReaderName.Text = name;
                if (ob)
                {
                    this.txtObject.Text = "Cán Bộ Công Nhân Viên";
                }
                else
                {
                    this.txtObject.Text = "Sinh Viên";
                }
                this.txtPayDay.Text = payday.ToShortDateString();
                this.txtCertificate.Text = id;
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
                if (this.dgvVoucherStt.SelectedCells.Count > 0 && this.dgvVoucherStt.CurrentRow.Index < this.dgvVoucherStt.Rows.Count - 1)
                {
                    this.dgvDetailVoucher.Rows.Clear();
                    DetailVoucherBLL manageVoucherBLL = new DetailVoucherBLL();
                    List<DetailVoucherBLL> manageVoucherArr = new List<DetailVoucherBLL>();
                    manageVoucherArr = VoucherDAL.getDetailVoucherList(Convert.ToInt32(selectedRow.Cells["clmnVoucherId"].Value));
                    //MessageBox.Show("ok");
                    foreach (DetailVoucherBLL row in manageVoucherArr)
                    {
                        this.dgvDetailVoucher.Rows.Add(row.Masachtra,row.Tensachtra);
                    }
                }
            }
            else
            {
                this.txtReaderName.Text = "";
                this.txtPayDay.Text = "";
                this.txtObject.Text = "";
                this.txtCertificate.Text = "";
                this.dgvDetailVoucher.Rows.Clear();
            }
        }
        private void loadDataToComboBoxVoucher()
        {
            List<string> keyname = new List<string>();
            keyname.Add("Voucher");
            keyname.Add("Certificate");
            this.cboSearch.DataSource = keyname;
        }
        private void VoucherGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToGridView();
            this.loadDataToComboBoxVoucher();
            this.GetSelectedValue();
            this.dgvVoucherStt.SelectionChanged += new EventHandler(dgvCertificateStt_SelectionChanged);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = this.txtSearch.Text;
            if (key == "".Trim())
            {
                MessageBox.Show("Please enter keyword!", "Notice");
                return;
            }
            string catalog = "";
            //MessageBox.Show(this.cboSearch.SelectedItem.ToString());
            if (this.cboSearch.SelectedItem.ToString() == "Voucher")
            {
                catalog += "phieutra.maphieutra";
                //MessageBox.Show(catalog);
            }
            else if (this.cboSearch.SelectedItem.ToString() == "Certificate")
            {
                catalog += "sachmuon.maphieumuon";
                //MessageBox.Show(catalog);
            }
            VoucherBLL bookStatusBLL = new VoucherBLL();
            List<VoucherBLL> voucherStatusArr = new List<VoucherBLL>();
            voucherStatusArr = VoucherDAL.search(key, catalog);
            this.dgvVoucherStt.Rows.Clear();
            if (voucherStatusArr != null)
            {
                //MessageBox.Show("ok");
                foreach (VoucherBLL row in voucherStatusArr)
                {
                    this.dgvVoucherStt.Rows.Add(row.Phieutra, row.Phieumuon, row.Ngaytra, row.Docgia, row.Doituong);
                }
            }
            else
            {
                MessageBox.Show("Sorry! Can't find this voucher/certificate");
                return;
            }
            this.GetSelectedValue();
            this.dgvVoucherStt.SelectionChanged += new EventHandler(dgvCertificateStt_SelectionChanged);
        }
    }
}
