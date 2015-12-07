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
    public partial class CertificateGUI : Form
    {
        public CertificateGUI()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            this.dgvCertificateStt.Rows.Clear();
            CertificateBLL manageCertificateBLL = new CertificateBLL();
            List<CertificateBLL> manageCertificateArr = new List<CertificateBLL>();
            manageCertificateArr = CertificateDAL.getManageCertificateList();
            //MessageBox.Show("ok");
            foreach (CertificateBLL row in manageCertificateArr)
            {
                this.dgvCertificateStt.Rows.Add(row.Idphieumuon, row.Tentinhtrang,row.Ngaymuon, row.Hantra, row.Tendocgia, row.Lacnvc, row.Iddocgia);
            }
            this.GetSelectedValue();
            this.dgvCertificateStt.SelectionChanged += new EventHandler(dgvCertificateStt_SelectionChanged);
        }

        private void dgvCertificateStt_SelectionChanged(object sender, EventArgs e)
        {
            this.GetSelectedValue();
        }

        private void GetSelectedValue()
        {
            if (this.dgvCertificateStt.SelectedCells.Count > 0 && this.dgvCertificateStt.CurrentRow.Index < this.dgvCertificateStt.Rows.Count - 1)
            {
                int selectedrowindex = this.dgvCertificateStt.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvCertificateStt.Rows[selectedrowindex];
                DateTime current = new DateTime();
                DateTime endtime = new DateTime();
                TimeSpan tg;
                string name = Convert.ToString(selectedRow.Cells["clmnReaderName"].Value);
                bool ob = Convert.ToBoolean(selectedRow.Cells["clmnObject"].Value);
                string id = Convert.ToString(selectedRow.Cells["clmnReaderCode"].Value);
                DateTime daystart = Convert.ToDateTime(selectedRow.Cells["clmnDayStart"].Value);
                DateTime dayend = Convert.ToDateTime(selectedRow.Cells["clmnDayEnd"].Value);
                current = DateTime.Now;
                endtime = Convert.ToDateTime(selectedRow.Cells["clmnDayEnd"].Value);
                tg = endtime - current;
                this.txtReaderName.Text = name;
                this.txtReaderCode.Text = id;
                this.txtDayStart.Text = daystart.ToShortDateString();
                this.txtDayEnd.Text = dayend.ToShortDateString();
                if(ob)
                {
                    this.txtObject.Text = "Cán Bộ Công Nhân Viên";
                }
                else
                {
                    this.txtObject.Text = "Sinh Viên";
                }
                int songay = Convert.ToInt16(tg.Days);
                if (songay < 0)
                {
                    if (selectedRow.Cells["clmnStt"].Value.ToString() != "mới tạo")
                    {
                        this.txtOutOfDay.Text = "";
                    }
                    else
                    {
                        this.txtOutOfDay.Text = "trễ " + Math.Abs(songay) + " ngày";
                    }
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
                if (this.dgvCertificateStt.SelectedCells.Count > 0 && this.dgvCertificateStt.CurrentRow.Index < this.dgvCertificateStt.Rows.Count - 1)
                {
                    this.dgvDetailCertificate.Rows.Clear();
                    DetailCertificateBLL manageCertificateBLL = new DetailCertificateBLL();
                    List<DetailCertificateBLL> manageCertificateArr = new List<DetailCertificateBLL>();
                    manageCertificateArr = CertificateDAL.getDetailCertificateList(Convert.ToInt32(selectedRow.Cells["clmnId"].Value));
                    //MessageBox.Show("ok");
                    foreach (DetailCertificateBLL row in manageCertificateArr)
                    {
                        this.dgvDetailCertificate.Rows.Add(row.Masach, row.Tensach);
                    }
                }
            }
            else
            {
                this.txtReaderName.Text = "";
                this.txtReaderCode.Text = "";
                this.txtDayStart.Text = "";
                this.txtDayEnd.Text = "";
                this.txtObject.Text = "";
                this.txtOutOfDay.Text = "";
                this.dgvDetailCertificate.Rows.Clear();
            }
        }
        private void ManageCertificateGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToGridView();
            this.loadDataToComboBoxCertificate();
            this.GetSelectedValue();
            this.dgvCertificateStt.CellClick += new DataGridViewCellEventHandler(dgvCertificateStt_SelectionChanged);
        }

        private void loadDataToComboBoxCertificate()
        {
            List<string> keyname = new List<string>();
            keyname.Add("Certificate");
            keyname.Add("Certificate Stt");
            this.cboSearch.DataSource = keyname;
        }
        private void dgvCertificateStt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
            //MessageBox.Show(dgvCertificateStt.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //this.getDetailCertificate(dgvCertificateStt_SelectionChanged);
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
            if (this.cboSearch.SelectedItem.ToString() == "Certificate")
            {
                catalog+= "phieumuon.maphieumuon";
                //MessageBox.Show(catalog);
            }
            else if (this.cboSearch.SelectedItem.ToString() == "Certificate Stt")
            {
                catalog+= "tinhtrangphieumuon.tentinhtrang";
                //MessageBox.Show(catalog);
            }
            CertificateBLL bookStatusBLL = new CertificateBLL();
            List<CertificateBLL> certificateStatusArr = new List<CertificateBLL>();
            certificateStatusArr = CertificateDAL.search(key,catalog);
            this.dgvCertificateStt.Rows.Clear();
            if (certificateStatusArr != null)
            {
                //MessageBox.Show("ok");
                foreach (CertificateBLL row in certificateStatusArr)
                {
                    this.dgvCertificateStt.Rows.Add(row.Idphieumuon, row.Tentinhtrang, row.Ngaymuon, row.Hantra, row.Tendocgia, row.Lacnvc, row.Iddocgia);
                }
            }
            else
            {
                MessageBox.Show("Sorry! Can't find this certificate");
                return;
            }
            this.GetSelectedValue();
            this.dgvCertificateStt.SelectionChanged += new EventHandler(dgvCertificateStt_SelectionChanged);
        }
    }
}
