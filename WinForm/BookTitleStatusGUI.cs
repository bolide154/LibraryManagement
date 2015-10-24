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
            bookTitleStatusArr = bookTitleStatusBLL.LoadBookTitleStatusList();
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
            bookTitleStatusArr = bookTitleStatusBLL.Search(catalog, key);
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
                if (bookTitleStatusBLL.AddBookTitleStatus(bookTitleStatusBLL))
                {
                    MessageBox.Show("Add success!", "Success");
                }
                else
                {
                    MessageBox.Show("Fail!", "Error");
                }
                this.LoadDataToGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvBookTitleStatus.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvBookTitleStatus.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvBookTitleStatus.Rows[selectedrowindex];
                int id = Convert.ToInt32(selectedRow.Cells["clmnId"].Value);
                DialogResult result = MessageBox.Show("Do you want to delete book title status: " + selectedRow.Cells["clmnName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        BookTitleStatusBLL bookTitleStatusDLL = new BookTitleStatusBLL();
                        if (!bookTitleStatusDLL.CheckDelete(id))
                        {
                            MessageBox.Show("Can't delete! Please delete all book title has status: '" + selectedRow.Cells["clmnName"].Value + "' before delete this status!", "Error");
                            break;
                        }
                        else
                        {
                            if (bookTitleStatusDLL.DeleteBookTitleStatus(id))
                            {
                                MessageBox.Show("Delete complete!", "Success");
                            }
                            else
                            {
                                MessageBox.Show("Fail!", "Error");
                            }
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

                BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL();
                bookTitleStatusBLL.BookTitleStatusId = Convert.ToInt32(selectedRow.Cells["clmnId"].Value);
                bookTitleStatusBLL.Name = this.txtBookTitleStatusName.Text;
                if (bookTitleStatusBLL.Name == "")
                {
                    MessageBox.Show("Author name is not null!", "Notice");
                    return;
                }
                if (bookTitleStatusBLL.UpdateBookTitleStatus(bookTitleStatusBLL))
                {
                    MessageBox.Show("Update success!", "Success");
                }
                else
                {
                    MessageBox.Show("Fail", "Error");
                }
                this.LoadDataToGridView();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
