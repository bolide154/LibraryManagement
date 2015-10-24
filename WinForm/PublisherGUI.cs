using Core.BLL;
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
    public partial class PublisherGUI : Form
    {
        public PublisherGUI()
        {
            InitializeComponent();
        }

        private void PublisherGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToCombobox();
            this.LoadDataToGridView();
            this.GetSelectedValue();
            this.dgvPublisher.CellClick += new DataGridViewCellEventHandler(dgvPublisher_Click);
        }

        private void dgvPublisher_Click(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
        }

        private void GetSelectedValue()
        {
            if (this.dgvPublisher.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvPublisher.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvPublisher.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["clmnId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnName"].Value);
                string phone = Convert.ToString(selectedRow.Cells["clmnPhone"].Value);
                string address = Convert.ToString(selectedRow.Cells["clmnAddress"].Value);
                this.lblInfor.Text = id + " / " + name;
                this.txtPublisherName.Text = name;
                this.txtPhone.Text = phone;
                this.txtAddress.Text = address;
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
                this.txtPublisherName.Text = "";
                this.txtPhone.Text = "";
                this.txtAddress.Text = "";
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;
            }
        }

        private void LoadDataToCombobox()
        {
            List<string> keyArr = new List<string>();
            keyArr.Add("Name");
            keyArr.Add("Phone Number");
            keyArr.Add("Address");
            this.cboSearch.DataSource = keyArr;
            this.cboSearch.Text = "Serch by...";
        }
        private void LoadDataToGridView()
        {
            this.dgvPublisher.Rows.Clear();
            PublisherBLL publiserBLL = new PublisherBLL();
            List<PublisherBLL> publisherArr = new List<PublisherBLL>();
            publisherArr = publiserBLL.LoadPublisherList();
            foreach (PublisherBLL row in publisherArr)
            {
                this.dgvPublisher.Rows.Add(row.PublisherId, row.Name, row.Phone, row.Address);
            }
            this.dgvPublisher.CellClick += new DataGridViewCellEventHandler(dgvPublisher_CellClick);
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }


    }
}
