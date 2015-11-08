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
    public partial class BookStatusGUI : Form
    {
        public BookStatusGUI()
        {
            InitializeComponent();
        }

        private void BookStatusGUI_Load(object sender, EventArgs e)
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
        }

        private void LoadDataToGridView()
        {
            this.dgvBookStatus.Rows.Clear();
            BookStatusBLL bookStatusBLL = new BookStatusBLL();
            List<BookStatusBLL> bookStatusArr = new List<BookStatusBLL>();
            bookStatusArr = BookStatusDAL.getBookStatusList();
            foreach (BookStatusBLL row in bookStatusArr)
            {
                this.dgvBookStatus.Rows.Add(row.BookStatusId, row.Name);
            }
            this.GetSelectedValue();
            this.dgvBookStatus.CellClick += new DataGridViewCellEventHandler(dgvBookStatus_CellClick);
        }

        private void dgvBookStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
        }

        private void GetSelectedValue()
        {
            if (this.dgvBookStatus.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvBookStatus.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvBookStatus.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["clmnId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnName"].Value);
                this.lblInfor.Text = id + " / " + name;
                this.txtBookStatusName.Text = name;
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
                this.txtBookStatusName.Text = "";
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;
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
            if (this.cboSearch.SelectedItem.ToString() == "Name")
            {
                catalog = "tentinhtrangsach";
            }
            BookStatusBLL bookStatusBLL = new BookStatusBLL();
            List<BookStatusBLL> bookStatusArr = new List<BookStatusBLL>();
            bookStatusArr = BookStatusDAL.search(catalog, key);
            this.dgvBookStatus.Rows.Clear();
            foreach (BookStatusBLL row in bookStatusArr)
            {
                this.dgvBookStatus.Rows.Add(row.BookStatusId, row.Name);
            }
            this.GetSelectedValue();

            this.dgvBookStatus.CellClick += new DataGridViewCellEventHandler(this.dgvBookStatus_CellClick);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookStatusBLL bookStatusBLL = new BookStatusBLL();
            bookStatusBLL.Name = this.txtBookStatusName.Text;
            if (bookStatusBLL.Name == "")
            {
                MessageBox.Show("Book status name is not null!", "Notice");
                return;
            }
            BookStatusDAL.addBookStatus(bookStatusBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvBookStatus.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvBookStatus.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvBookStatus.Rows[selectedrowindex];
                BookStatusBLL bookStatusBLL = new BookStatusBLL(Convert.ToInt32(selectedRow.Cells["clmnId"].Value), selectedRow.Cells["clmnName"].Value.ToString());
                DialogResult result = MessageBox.Show("Do you want to delete book status: " + selectedRow.Cells["clmnName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:

                        if (BookStatusDAL.getBookStatusItem(bookStatusBLL) != null)
                        {
                            MessageBox.Show("Can't delete! Please delete all book has status " + selectedRow.Cells["clmnName"].Value + " before delete this status!", "Error");
                            break;
                        }
                        else
                        {
                            BookStatusDAL.deleteBookStatus(bookStatusBLL);
                            MessageBox.Show("Delete complete!", "Success");
                            this.LoadDataToGridView();
                            break;
                        }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvBookStatus.SelectedCells.Count > 0)
            {

                int selectedrowindex = this.dgvBookStatus.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvBookStatus.Rows[selectedrowindex];

                BookStatusBLL bookStatusBLL = new BookStatusBLL(Convert.ToInt32(selectedRow.Cells["clmnId"].Value), this.txtBookStatusName.Text);

                if (bookStatusBLL.Name == "")
                {
                    MessageBox.Show("Book status name is not null!", "Notice");
                    return;
                }
                BookStatusDAL.updateBookStatus(bookStatusBLL);
                MessageBox.Show("Update success!", "Success");
                this.LoadDataToGridView();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
