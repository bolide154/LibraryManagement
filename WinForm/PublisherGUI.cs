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
            }
        }
    }
}
