using Core;
using Core.BLL;
using Core.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class BookTitleGUI : Form
    {
        public BookTitleGUI()
        {
            InitializeComponent();
        }

        private void BookTitleGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToComboboxSearch();
            this.LoadDataToComboboxTypeOfBook();
            this.LoadDataToComboboxPublisher();
            this.LoadDataToComboboxBookTitleStatus();
            this.LoadDataToComboboxAuthor();
            this.LoadDataToDataGridViewBookTitle();
        }

        private void LoadDataToComboboxSearch()
        {
            List<string> keyArr = new List<string>();
            keyArr.Add("Book Title Status");
            keyArr.Add("Publisher");
            keyArr.Add("Type Of Book");
            keyArr.Add("Name");
            keyArr.Add("Summary");
            this.cboSearch.DataSource = keyArr;
        }

        private void LoadDataToComboboxTypeOfBook()
        {
            BookTitleBLL bookTitleBLL = new BookTitleBLL();
            this.cboTypeOfBook.DataSource = bookTitleBLL.getComboboxItemTypeOfBook();
            //MessageBox.Show((cboTypeOfBook.SelectedItem as ComboboxItem).Value.ToString());
            this.cboPublisher.DisplayMember = "Text";
            this.cboPublisher.ValueMember = "Value";
        }

        private void LoadDataToComboboxPublisher()
        {
            BookTitleBLL bookTitleBLL = new BookTitleBLL();
            this.cboPublisher.DataSource = bookTitleBLL.getComboboxItemPublisher();
            this.cboPublisher.DisplayMember = "Text";
            this.cboPublisher.ValueMember = "Value";
        }

        private void LoadDataToComboboxBookTitleStatus()
        {
            BookTitleBLL bookTitleBLL = new BookTitleBLL();
            this.cboBookTitleStatus.DataSource = bookTitleBLL.getComboboxItemBookTitleStatus();
            this.cboBookTitleStatus.DisplayMember = "Text";
            this.cboBookTitleStatus.ValueMember = "Value";
        }

        private void LoadDataToComboboxAuthor()
        {
            BookTitleBLL bookTitleBLL = new BookTitleBLL();
            this.cboAuthor.DataSource = bookTitleBLL.getComboboxItemAuthor();
            this.cboAuthor.DisplayMember = "Text";
            this.cboAuthor.ValueMember = "Value";
        }



        private void LoadDataToDataGridViewBookTitle()
        {
            this.dgvBookTitle.Rows.Clear();
            List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
            bookTitleList = BookTitleDAL.getBookTitleList();
            TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL();
            foreach (BookTitleBLL row in bookTitleList)
            {
                typeOfBookBLL = TypeOfBookDAL.getTypeOfBookItem(row.TypeOfBookId);
                PublisherBLL publisherBLL = new PublisherBLL();
                publisherBLL = PublisherDAL.getPublisherItem(row.PublisherId);
                BookTitleStatusBLL status = new BookTitleStatusBLL();
                status = BookTitleStatusDAL.getBookTitleStatusItem(row.BookTitleStatusId);
                this.dgvBookTitle.Rows.Add(row.BookTitleId, row.Name, row.TypeOfBookId, typeOfBookBLL.Name, row.PublisherId, publisherBLL.Name, row.BookTitleStatusId, status.Name, row.Summary);
            }
            GetSelectedValueDataGridViewBookTitle();
            this.dgvBookTitle.SelectionChanged += new EventHandler(dgvBookTitle_SelectionChanged);
        }

        private void dgvBookTitle_SelectionChanged(object sender, EventArgs e)
        {
            this.GetSelectedValueDataGridViewBookTitle();
        }

        private void GetSelectedValueDataGridViewBookTitle()
        {
            if (this.dgvBookTitle.SelectedCells.Count > 0 && this.dgvBookTitle.CurrentRow.Index < this.dgvBookTitle.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = this.dgvBookTitle.Rows[this.dgvBookTitle.CurrentRow.Index];

                int id = Convert.ToInt32(selectedRow.Cells["clmnBookTitleId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnBookTitleName"].Value);
                int bookTitleStatusId = Convert.ToInt32(selectedRow.Cells["clmnBookTitleStatusId"].Value.ToString());
                int publisherId = Convert.ToInt32(selectedRow.Cells["clmnPublisherId"].Value);
                int typeOfBookId = Convert.ToInt32(selectedRow.Cells["clmnTypeOfBookId"].Value);
                string summary = Convert.ToString(selectedRow.Cells["clmnSummary"].Value);

                this.lblInfor.Text = id.ToString() + " / " + name;
                this.txtBookName.Text = name;
                this.txtSummary.Text = summary;


                foreach (ComboboxItem item in this.cboBookTitleStatus.Items)
                {
                    if (Convert.ToInt32(item.Value) == bookTitleStatusId)
                        cboBookTitleStatus.SelectedItem = item;
                }
                foreach (ComboboxItem item in this.cboPublisher.Items)
                {
                    if (Convert.ToInt32(item.Value) == publisherId)
                        this.cboPublisher.SelectedItem = item;
                }
                foreach (ComboboxItem item in this.cboTypeOfBook.Items)
                {
                    if (Convert.ToInt32(item.Value) == typeOfBookId)
                        this.cboTypeOfBook.SelectedItem = item;
                }

                BookTitleBLL bookTitleBLL = new BookTitleBLL(id, bookTitleStatusId, publisherId, typeOfBookId, name, summary);
                List<AuthorBLL> authorList = bookTitleBLL.getAuthor();
                this.loadDataToDataGridViewAuthor(authorList);
                this.setSelectedValueComboboxAuthor(authorList[0]);
                this.setAmountOfBook(bookTitleBLL);

            }
            else
            {
                this.lblInfor.Text = "Id / Name";
                this.txtBookName.Text = "";
                this.cboBookTitleStatus.Text = this.cboBookTitleStatus.Items[0].ToString();
                this.cboPublisher.Text = this.cboPublisher.Items[0].ToString();
                this.cboTypeOfBook.Text = this.cboTypeOfBook.Items[0].ToString();
                this.cboAuthor.Text = this.cboAuthor.Items[0].ToString();
                this.txtBookTotal.Text = "";
                this.txtSummary.Text = "";
                this.dgvAuthor.Rows.Clear();
            }
        }
        private void loadDataToDataGridViewAuthor(List<AuthorBLL> authorList)
        {
            this.dgvAuthor.Rows.Clear();
            foreach (AuthorBLL authorBLL in authorList)
            {
                this.dgvAuthor.Rows.Add(authorBLL.AuthorId, authorBLL.Name, authorBLL.WorkPlace);
            }
        }
        private void setSelectedValueComboboxAuthor(AuthorBLL authorBLL)
        {
            foreach (ComboboxItem item in this.cboAuthor.Items)
            {
                if (Convert.ToInt32(item.Value) == authorBLL.AuthorId)
                    this.cboAuthor.SelectedItem = item;
            }
        }
        private void setAmountOfBook(BookTitleBLL bookTitleBLL)
        {
            this.txtBookTotal.Text = bookTitleBLL.getAmountOfBook().ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = this.txtSearch.Text;
            string catalog = "";
            if (key == "".Trim())
            {
                MessageBox.Show("Please enter keyword!", "Notice");
                return;
            }
            if (this.cboSearch.Text == "Book Title Status")
            {
                catalog = "matinhtrang";
            }
            else if (this.cboSearch.Text == "Publisher")
            {
                catalog = "manxb";
            }
            else if (this.cboSearch.Text == "Type Of Book")
            {
                catalog = "matheloai";
            }
            else if (this.cboSearch.Text == "Name")
            {
                catalog = "tensach";
            }
            else if (this.cboSearch.Text == "Summary")
            {
                catalog = "tomtat";
            }
            BookTitleBLL bookTitleBLL = new BookTitleBLL();
            List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
            bookTitleList = bookTitleBLL.search(catalog, key);
            this.dgvBookTitle.Rows.Clear();
            if (bookTitleList != null)
            {
                foreach (BookTitleBLL row in bookTitleList)
                {
                    this.dgvBookTitle.Rows.Add(row.BookTitleId, row.BookTitleStatusId, row.PublisherId, row.TypeOfBookId, row.Name, row.Summary);
                }
            }
            this.GetSelectedValueDataGridViewBookTitle();
            this.dgvBookTitle.SelectionChanged += new EventHandler(dgvBookTitle_SelectionChanged);

        }

        private void btnTypeOfBookManage_Click(object sender, EventArgs e)
        {
            TypeOfBookGUI typeOfBookGUI = new TypeOfBookGUI();
            if (IsFormAlreadyOpen(typeof(TypeOfBookGUI)) == null)
            {
                typeOfBookGUI = new TypeOfBookGUI();
                typeOfBookGUI.Show();
            }
        }

        private void btnPublisherManage_Click(object sender, EventArgs e)
        {
            PublisherGUI publisherGUI = new PublisherGUI();
            if (IsFormAlreadyOpen(typeof(PublisherGUI)) == null)
            {
                publisherGUI = new PublisherGUI();
                publisherGUI.Show();
            }
        }

        private void btnBookTitleStatusManage_Click(object sender, EventArgs e)
        {
            BookTitleStatusGUI bookTitleStatusGUI = new BookTitleStatusGUI();
            if (IsFormAlreadyOpen(typeof(BookTitleStatusGUI)) == null)
            {
                bookTitleStatusGUI = new BookTitleStatusGUI();
                bookTitleStatusGUI.Show();
            }
        }

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }

        private void btnTypeOfBookRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDataToComboboxTypeOfBook();
        }

        private void btnPublisherRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDataToComboboxPublisher();
        }

        private void btnBookTitleStatusRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDataToComboboxBookTitleStatus();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            if (this.dgvBookTitle.SelectedCells.Count > 0 && this.dgvBookTitle.CurrentRow.Index < this.dgvBookTitle.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = this.dgvBookTitle.Rows[this.dgvBookTitle.CurrentRow.Index];

                int bookTitleId = Convert.ToInt32(selectedRow.Cells["clmnBookTitleId"].Value);
                int quantity = Convert.ToInt32(this.txtBookTotal.Text);
                if (quantity < 1)
                {
                    MessageBox.Show("The quantity can't less than 1");
                    return;
                }
                BookBLL bookBLL = new BookBLL();
                bookBLL.BookTitleId = bookTitleId;
                bookBLL.BookStatusId = 1; //Điều này có thể thay đổi
                for (int i = 0; i < quantity; i++ )
                    BookDAL.addBook(bookBLL);
                MessageBox.Show("Add success!");
            }
        }

        private void btnViewInStore_Click(object sender, EventArgs e)
        {
            if (this.dgvBookTitle.SelectedCells.Count > 0 && this.dgvBookTitle.CurrentRow.Index < this.dgvBookTitle.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = this.dgvBookTitle.Rows[this.dgvBookTitle.CurrentRow.Index];

                int id = Convert.ToInt32(selectedRow.Cells["clmnBookTitleId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnBookTitleName"].Value);
                int bookTitleStatusId = Convert.ToInt32(selectedRow.Cells["clmnBookTitleStatusId"].Value.ToString());
                int publisherId = Convert.ToInt32(selectedRow.Cells["clmnPublisherId"].Value);
                int typeOfBookId = Convert.ToInt32(selectedRow.Cells["clmnTypeOfBookId"].Value);
                string summary = Convert.ToString(selectedRow.Cells["clmnSummary"].Value);
                BookTitleBLL bookTitleBLL = new BookTitleBLL(id, bookTitleStatusId, publisherId, typeOfBookId, name, summary);

                BookGUI bookGUI;
                if (IsFormAlreadyOpen(typeof(BookGUI)) == null)
                {
                    bookGUI = new BookGUI(bookTitleBLL);
                    bookGUI.Show();
                }
            }
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";


            for (int j = 0; j < dGV.Columns.Count; j++)
                if (dGV.Columns[j].Visible != false)
                {
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                }
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    {

                        if (dGV.Rows[i].Cells[j].ColumnIndex != 0 && dGV.Rows[i].Cells[j].ColumnIndex != 2 && dGV.Rows[i].Cells[j].ColumnIndex != 4 && dGV.Rows[i].Cells[j].ColumnIndex != 6)
                        {
                            if (dGV.Rows[i].Cells[j].ColumnIndex == 8)
                            {
                                stLine = stLine.ToString() + "'" +dGV.Rows[i].Cells[j].Value.ToString() +"'" + "\t";
                            }
                            stLine = stLine.ToString() + dGV.Rows[i].Cells[j].Value.ToString() + "\t";
                        }
                    }
                    stOutput += stLine + "\r\n";
                
            }
            FileStream fs = new FileStream(filename, FileMode.Create);
            StreamWriter bw = new StreamWriter(fs, Encoding.Unicode);
            bw.Write(stOutput); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "BookTitle.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(this.dgvBookTitle, sfd.FileName);
                //ToCsV(nHANVIEN_DTODataGridView, sfd.FileName); // Here dataGridview1 is your grid view name 
            }
        }
    }
}
