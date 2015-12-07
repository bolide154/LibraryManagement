using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.BLL;
using Core.DAL;

namespace WinForm
{
    public partial class AspectCertificateGUI : Form
    {
        public AspectCertificateGUI()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            this.dgvCertificateStt.Rows.Clear();
            AspectCertificateBLL aspectCertificateBLL = new AspectCertificateBLL();
            List<AspectCertificateBLL> aspectCertificateList = new List<AspectCertificateBLL>();
            aspectCertificateList = AspectCertificateDAL.getCertifivateId();
            foreach (AspectCertificateBLL row in aspectCertificateList)
            {
                this.dgvCertificateStt.Rows.Add(row.CertificateId, row.Name);
            }
            this.GetSelectedValue();
            this.dgvCertificateStt.CellClick += new DataGridViewCellEventHandler(dgvCertificateStt_CellClick);

        }

        private void dgvCertificateStt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
        }
        private void GetSelectedValue()
        {
            if (this.dgvCertificateStt.SelectedCells.Count > 0 && this.dgvCertificateStt.CurrentRow.Index < this.dgvCertificateStt.Rows.Count - 1)
            {
                int selectedrowindex = this.dgvCertificateStt.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvCertificateStt.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["clmnId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnName"].Value);
                this.lblInfor.Text = id + " / " + name;
                this.txtCertificateStt.Text = name;
                if (id == "")
                {
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = false;
                }
                else
                {
                    this.btnDelete.Enabled = true;
                    this.btnSave.Enabled = true;
                }
            }
            else
            {
                this.lblInfor.Text = "Id / Name";
                this.txtCertificateStt.Text = "";
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;
            }
        }

        private void AspectCertificateGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToGridView();
            this.loadDataToComboBoxCertificate();
        }

        private void dgvCertificateStt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
        }
        private void loadDataToComboBoxCertificate()
        {
            List<string> keyname = new List<string>();
            keyname.Add("Name");
            this.cboSearchCertificate.DataSource = keyname;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvCertificateStt.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvCertificateStt.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvCertificateStt.Rows[selectedrowindex];
                AspectCertificateBLL certificateStatusBLL = new AspectCertificateBLL(Convert.ToInt32(selectedRow.Cells["clmnId"].Value), selectedRow.Cells["clmnName"].Value.ToString());
                DialogResult result = MessageBox.Show("Do you want to delete certificate status: " + selectedRow.Cells["clmnName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:

                        if (AspectCertificateDAL.getCertificateStatusItem(certificateStatusBLL.CertificateId) != null)
                        {
                            MessageBox.Show("Can't delete! Please delete all book has status " + selectedRow.Cells["clmnName"].Value + " before delete this status!", "Error");
                            break;
                        }
                        else
                        {
                            AspectCertificateDAL.deleteCertificateStatus(certificateStatusBLL);
                            MessageBox.Show("Delete complete!", "Success");
                            this.LoadDataToGridView();
                            break;
                        }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AspectCertificateBLL certificateStatusBLL = new AspectCertificateBLL();
            certificateStatusBLL.Name = this.txtCertificateStt.Text;
            if (certificateStatusBLL.Name == "")
            {
                MessageBox.Show("Certificate status name is not null!", "Notice");
                return;
            }
            AspectCertificateDAL.addCertificateStatus(certificateStatusBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvCertificateStt.SelectedCells.Count > 0)
            {

                int selectedrowindex = this.dgvCertificateStt.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvCertificateStt.Rows[selectedrowindex];

                AspectCertificateBLL certificateStatusBLL = new AspectCertificateBLL(Convert.ToInt32(selectedRow.Cells["clmnId"].Value), this.txtCertificateStt.Text);

                if (certificateStatusBLL.Name == "")
                {
                    MessageBox.Show("Certificate status name is not null!", "Notice");
                    return;
                }
                AspectCertificateDAL.updateCertificateStatus(certificateStatusBLL);
                MessageBox.Show("Update success!", "Success");
                this.LoadDataToGridView();
            }
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
            if (this.cboSearchCertificate.SelectedItem.ToString() == "Name")
            {
                catalog = "tentinhtrang";
            }
            AspectCertificateBLL certificateStatusBLL = new AspectCertificateBLL();
            List<AspectCertificateBLL> certificateStatusArr = new List<AspectCertificateBLL>();
            certificateStatusArr = AspectCertificateDAL.searchCertificate(catalog, key);
            this.dgvCertificateStt.Rows.Clear();
            if (certificateStatusArr.Count != null)
            {
                foreach (AspectCertificateBLL row in certificateStatusArr)
                {
                    this.dgvCertificateStt.Rows.Add(row.CertificateId, row.Name);
                }
            }
            this.GetSelectedValue();

            this.dgvCertificateStt.CellClick += new DataGridViewCellEventHandler(this.dgvCertificateStt_CellClick);
        }
    }
}
