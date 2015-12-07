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
    public partial class BookTitleStatusGUI : Form
    {
        public BookTitleStatusGUI()
        {
            InitializeComponent();
        }

        private void BookTitleStatusGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToComBoBox();
            this.LoadDataToGridView();
            this.GetSelectedValue();
        }

        private void LoadDataToComBoBox()
        {
            List<string> keyArr = new List<string>();
            keyArr.Add("Name");
            this.cboSearch.DataSource = keyArr;
            this.cboSearch.Text = "Serch by...";
        }

        private void LoadDataToGridView()
        {
            this.dgvBookTitleStatus.Rows.Clear();
            BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL();
            List<BookTitleStatusBLL> bookTitleStatusArr = new List<BookTitleStatusBLL>();
            bookTitleStatusArr = BookTitleStatusDAL.getBookTitleStatusList();
            foreach (BookTitleStatusBLL row in bookTitleStatusArr)
            {
                this.dgvBookTitleStatus.Rows.Add(row.BookTitleStatusId, row.Name);
            }
            this.GetSelectedValue();
            this.dgvBookTitleStatus.CellClick += new DataGridViewCellEventHandler(this.dgvBookTitleStatus_CellClick);

        }

        private void dgvBookTitleStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
        }

        private void GetSelectedValue()
        {
            if (this.dgvBookTitleStatus.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvBookTitleStatus.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvBookTitleStatus.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["clmnId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnName"].Value);
                this.lblInfor.Text = id + " / " + name;
                this.txtBookTitleStatusName.Text = name;
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
                this.txtBookTitleStatusName.Text = "";
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string catalog = this.cboSearch.Text;
            string key = this.txtSearch.Text;
            if (key == "")
            {
                MessageBox.Show("Please enter keyword!", "Notice");
                return;
            }
            BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL();
            List<BookTitleStatusBLL> bookTitleStatusArr = new List<BookTitleStatusBLL>();
            bookTitleStatusArr = BookTitleStatusDAL.search(catalog, key);
            this.dgvBookTitleStatus.Rows.Clear();
            foreach (BookTitleStatusBLL row in bookTitleStatusArr)
            {
                this.dgvBookTitleStatus.Rows.Add(row.BookTitleStatusId, row.Name);
            }

            this.GetSelectedValue();
            this.dgvBookTitleStatus.CellClick += new DataGridViewCellEventHandler(this.dgvBookTitleStatus_CellClick);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL();
            bookTitleStatusBLL.Name = this.txtBookTitleStatusName.Text;
            if (bookTitleStatusBLL.Name == "")
            {
                MessageBox.Show("Author name is not null!", "Notice");
                return;
            }
            BookTitleStatusDAL.addBookTitleStatus(bookTitleStatusBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvBookTitleStatus.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvBookTitleStatus.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvBookTitleStatus.Rows[selectedrowindex];
                BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL(Convert.ToInt32(selectedRow.Cells["clmnId"].Value), selectedRow.Cells["clmnName"].Value.ToString());
                DialogResult result = MessageBox.Show("Do you want to delete book title status: " + selectedRow.Cells["clmnName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        BookTitleStatusBLL bookTitleStatusDLL = new BookTitleStatusBLL();
                        if (BookTitleStatusDAL.getBookTitleStatusItem(bookTitleStatusBLL) != null)
                        {
                            MessageBox.Show("Can't delete! Please delete all book title has status: '" + selectedRow.Cells["clmnName"].Value + "' before delete this status!", "Error");
                            break;
                        }
                        else
                        {
                            BookTitleStatusDAL.deleteBookTitleStatus(bookTitleStatusBLL);
                            this.LoadDataToGridView();
                            break;
                        }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvBookTitleStatus.SelectedCells.Count > 0)
            {

                int selectedrowindex = this.dgvBookTitleStatus.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvBookTitleStatus.Rows[selectedrowindex];

                BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL(Convert.ToInt32(selectedRow.Cells["clmnId"].Value), this.txtBookTitleStatusName.Text);
                
                if (bookTitleStatusBLL.Name == "")
                {
                    MessageBox.Show("Author name is not null!", "Notice");
                    return;
                } 
                BookTitleStatusDAL.updateBookTitleStatus(bookTitleStatusBLL);
                MessageBox.Show("Update success!", "Success");
                this.LoadDataToGridView();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvBookTitleStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void lblInfor_Click(object sender, EventArgs e)
        {

        }

        private void lblBookTitleStatusName_Click(object sender, EventArgs e)
        {

        }

        private void txtBookTitleStatusName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
