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
    public partial class AuthorGUI : Form
    {
        public AuthorGUI()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = this.txtSearch.Text;
            if (value == "".Trim())
            {
                MessageBox.Show("Please enter keyword!", "Notice");
                return;
            }
            string key = "";
            if (this.cboSearch.SelectedItem.ToString()=="Work Place")
            {
                key = "noicongtac";
            }
            else
            {
                key = "tentacgia";
            }
            AuthorBLL authorBLL = new AuthorBLL();
            List<AuthorBLL> authorArr = new List<AuthorBLL>();
            authorArr = AuthorDAL.Search(key, value);
            this.dgvAuthor.Rows.Clear(); 
            foreach (AuthorBLL row in authorArr)
            {
                this.dgvAuthor.Rows.Add(row.AuthorId, row.Name, row.WorkPlace);
            }
            this.GetSelectedValue();

            this.dgvAuthor.CellClick += new DataGridViewCellEventHandler(dgvAuthor_CellClick);
        }

        private void GetSelectedValue()
        {
            if (dgvAuthor.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAuthor.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvAuthor.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["clmnId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnName"].Value);
                string workPlace = Convert.ToString(selectedRow.Cells["clmnWorkPlace"].Value);
                this.lblInfor.Text = id + " / " + name;
                this.txtAuthorName.Text = name;
                this.txtWorkPlace.Text = workPlace;
                if (id == "")
                {
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = false;
                }
                else {
                    this.btnDelete.Enabled = true;
                    this.btnSave.Enabled = true;
                }
            }
            else
            {
                this.lblInfor.Text = "Id / Name";
                this.txtAuthorName.Text = "";
                this.txtWorkPlace.Text = "";
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;
            }
        }

        private void AuthorGUI_Load(object sender, EventArgs e)
        {
            LoadDataToComBoBox();
            LoadDataToGridView();
            this.GetSelectedValue();
        }

        private void LoadDataToGridView()
        {
            this.dgvAuthor.Rows.Clear();
            AuthorBLL authorBLL = new AuthorBLL();
            List<AuthorBLL> authorArr = new List<AuthorBLL>();
            authorArr = authorBLL.LoadAuthorList();
            foreach(AuthorBLL row in authorArr){
                this.dgvAuthor.Rows.Add(row.AuthorId, row.Name, row.WorkPlace);
            }
            this.GetSelectedValue();
            this.dgvAuthor.CellClick += new DataGridViewCellEventHandler(dgvAuthor_CellClick);
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
        }

        private void LoadDataToComBoBox(){
            List<string> keyArr = new List<string>();
            keyArr.Add("Name");
            keyArr.Add("Work Place");
            this.cboSearch.DataSource = keyArr;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AuthorBLL authorBLL = new AuthorBLL();
            authorBLL.Name = this.txtAuthorName.Text;
            authorBLL.WorkPlace = this.txtWorkPlace.Text;
            if (authorBLL.Name == "")
            {
                MessageBox.Show("Author name is not null!", "Notice");
                return;
            }
            if (authorBLL.AddAuthor(authorBLL))
            {
                MessageBox.Show("Add success!", "Success");
            }
            else{
                MessageBox.Show("Fail!", "Error");
            }
            this.LoadDataToGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvAuthor.SelectedCells.Count > 0)
            {
				int selectedrowindex = dgvAuthor.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRow = dgvAuthor.Rows[selectedrowindex];
				int id = Convert.ToInt32(selectedRow.Cells["clmnId"].Value);
                DialogResult result = MessageBox.Show("Do you want to delete author: " + selectedRow.Cells["clmnName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        AuthorBLL authorBLL = new AuthorBLL(Convert.ToInt32(selectedRow.Cells["clmnId"].Value), selectedRow.Cells["clmnName"].Value.ToString(), selectedRow.Cells["clmnWorkPlace"].Value.ToString());
                        if (!authorBLL.CheckDelete(authorBLL))
                        {
                            MessageBox.Show("Can't delete! Please delete all book of " + selectedRow.Cells["clmnName"].Value + " before delete this author!", "Error");
                            break;
                        }
                        else
                        {
                            if (authorBLL.DeleteAuthor(authorBLL))
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
            if (dgvAuthor.SelectedCells.Count > 0)
            {

                int selectedrowindex = dgvAuthor.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvAuthor.Rows[selectedrowindex];

                AuthorBLL authorBLL = new AuthorBLL();
                authorBLL.AuthorId = Convert.ToInt32(selectedRow.Cells["clmnId"].Value);
                authorBLL.Name = txtAuthorName.Text;
                authorBLL.WorkPlace = txtWorkPlace.Text;
                if (authorBLL.Name == "")
                {
                    MessageBox.Show("Author name is not null!", "Notice");
                    return;
                }
                if (authorBLL.UpdateAuthor(authorBLL))
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
        private void RemoveDataGridView()
        {
            for (int i = 0; i < this.dgvAuthor.Rows.Count; i++)
            {
                this.dgvAuthor.Rows.Clear();
            }
        }
    }
}
