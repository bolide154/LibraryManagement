using Core;
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
                this.dgvBookTitle.Rows.Add(row.BookTitleId, row.Name, row.TypeOfBookId, typeOfBookBLL.Name, row.PublisherId, row.BookTitleStatusId, row.Summary, row.Reprint);
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
                this.btnBookTitleDelete.Enabled = true;
                this.btnBookTitleSave.Enabled = true;
                this.btnBookAdd.Enabled = true;
                this.btnViewInStore.Enabled = true;
                DataGridViewRow selectedRow = this.dgvBookTitle.Rows[this.dgvBookTitle.CurrentRow.Index];

                int id = Convert.ToInt32(selectedRow.Cells["clmnBookTitleId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnBookTitleName"].Value);
                int bookTitleStatusId = Convert.ToInt32(selectedRow.Cells["clmnBookTitleStatusId"].Value.ToString());
                int publisherId = Convert.ToInt32(selectedRow.Cells["clmnPublisherId"].Value);
                int typeOfBookId = Convert.ToInt32(selectedRow.Cells["clmnTypeOfBookId"].Value);
                int reprint = Convert.ToInt32(selectedRow.Cells["clmnReprint"].Value);
                string summary = Convert.ToString(selectedRow.Cells["clmnSummary"].Value);

                this.lblInfor.Text = id.ToString() + " / " + name;
                this.txtBookName.Text = name;
                this.txtSummary.Text = summary;
                this.lblReprint.Text = reprint.ToString();


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

                BookTitleBLL bookTitleBLL = new BookTitleBLL(id, bookTitleStatusId, publisherId, typeOfBookId, name, summary, reprint);
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
                this.btnBookAdd.Enabled = false;
                this.btnViewInStore.Enabled = false;
                this.dgvAuthor.Rows.Clear();
                this.lblReprint.Text = "0";
                this.btnBookTitleDelete.Enabled = false;
                this.btnBookTitleSave.Enabled = false;
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
                for (int i = 0; i < quantity; i++)
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
                int reprint = Convert.ToInt32(selectedRow.Cells["clmnReprint"].Value);
                BookTitleBLL bookTitleBLL = new BookTitleBLL(id, bookTitleStatusId, publisherId, typeOfBookId, name, summary, reprint);

                BookGUI bookGUI;
                if (IsFormAlreadyOpen(typeof(BookGUI)) == null)
                {
                    bookGUI = new BookGUI(bookTitleBLL);
                    bookGUI.Show();
                }
            }
        }

        private void btnAuthorRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDataToComboboxAuthor();
        }

        private void btnAuthorManage_Click(object sender, EventArgs e)
        {
            AuthorGUI authorGUI = new AuthorGUI();
            if (IsFormAlreadyOpen(typeof(AuthorGUI)) == null)
            {
                authorGUI = new AuthorGUI();
                authorGUI.Show();
            }
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            AuthorBLL authorBLL = new AuthorBLL();
            authorBLL = AuthorDAL.getAuthorItem(this.cboAuthor.SelectedValue.ToString());
            foreach (DataGridViewRow row in this.dgvAuthor.Rows)
            {
                if (row.Index < this.dgvAuthor.Rows.Count - 1)
                {
                    if (Int32.Parse(row.Cells["clmnAuthorId"].Value.ToString()) == authorBLL.AuthorId)
                    {
                        MessageBox.Show("Author has already!");
                        return;
                    }
                }

            }
            this.dgvAuthor.Rows.Add(authorBLL.AuthorId, authorBLL.Name, authorBLL.WorkPlace);
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvAuthor.SelectedCells.Count > 0 && this.dgvAuthor.CurrentRow.Index < this.dgvAuthor.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = this.dgvAuthor.Rows[this.dgvAuthor.CurrentRow.Index];
                dgvAuthor.Rows.RemoveAt(selectedRow.Index);
            }
        }

        private void btnBookTitleAdd_Click(object sender, EventArgs e)
        {
            ComboboxItem item = new ComboboxItem();
            string bookTitleName = this.txtBookName.Text;
            item = (ComboboxItem)this.cboTypeOfBook.SelectedItem;
            int typeOfBookId = Int32.Parse(item.Value.ToString());
            item = (ComboboxItem)this.cboPublisher.SelectedItem;
            int publisherId = Int32.Parse(item.Value.ToString());
            item = (ComboboxItem)this.cboBookTitleStatus.SelectedItem;
            int bookTitleStatusId = Int32.Parse(item.Value.ToString());
            string summary = this.txtSummary.Text;
            int quantity = Int32.Parse(this.txtBookTotal.Text);
            List<AuthorBLL> authorList = new List<AuthorBLL>();
            foreach (DataGridViewRow row in this.dgvAuthor.Rows)
            {
                if (row.Index < this.dgvAuthor.Rows.Count - 1)
                {
                    authorList.Add(new AuthorBLL(Int32.Parse(row.Cells["clmnAuthorId"].Value.ToString()), row.Cells["clmnAuthorName"].Value.ToString(), row.Cells["clmnWorkPlace"].Value.ToString()));
                }
            }
            if (this.txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter book name!");
                return;
            }
            if (this.txtSummary.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter book summary!");
                return;
            }
            if (authorList == null)
            {
                MessageBox.Show("Please choose author!");
                return;
            }
            if (quantity < 1)
            {
                MessageBox.Show("Quantity mustn't less than 1!");
                return;
            }
            BookTitleBLL bookTitleBLL = new BookTitleBLL();
            bookTitleBLL.Name = bookTitleName;
            bookTitleBLL.TypeOfBookId = typeOfBookId;
            bookTitleBLL.PublisherId = publisherId;
            bookTitleBLL.BookTitleStatusId = bookTitleStatusId;
            bookTitleBLL.Name = bookTitleName;
            bookTitleBLL.Summary = summary;
            int result = bookTitleBLL.checkCopyright(publisherId, bookTitleName);
            if (result == 1)
            {
                bookTitleBLL.Reprint = 0;
                int id = BookTitleDAL.addBookTitle(bookTitleBLL);
                foreach (AuthorBLL authorBLL in authorList)
                {
                    AuthorBookTitleDAL.assignAuthorToBookTitle(id, authorBLL);
                }
                for (int i = 0; i < quantity; i++)
                {
                    BookBLL bookBLL = new BookBLL();
                    bookBLL.BookTitleId = id;
                    bookBLL.BookStatusId = 1;
                    BookDAL.addBook(bookBLL);
                }
                MessageBox.Show("Add success!");
                this.dgvBookTitle.Rows.Clear();
                this.LoadDataToDataGridViewBookTitle();
            }
            else if (result == -1)
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                bookTitleList = BookTitleDAL.getBookTitleItem(bookTitleBLL.Name);
                bookTitleBLL.Reprint += bookTitleList[bookTitleList.Count - 1].Reprint + 1;
                int id = BookTitleDAL.addBookTitle(bookTitleBLL);
                foreach (AuthorBLL authorBLL in authorList)
                {
                    AuthorBookTitleDAL.delete(id);
                    AuthorBookTitleDAL.assignAuthorToBookTitle(id, authorBLL);
                }
                for (int i = 0; i < quantity; i++)
                {
                    BookBLL bookBLL = new BookBLL();
                    bookBLL.BookTitleId = id;
                    bookBLL.BookStatusId = 1;
                    BookDAL.addBook(bookBLL);
                }
                MessageBox.Show("Add success!");
                this.dgvBookTitle.Rows.Clear();
                this.LoadDataToDataGridViewBookTitle();
            }
            else
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                bookTitleList = BookTitleDAL.getBookTitleItem(bookTitleBLL.Name);
                PublisherBLL publisherBLL = new PublisherBLL();
                publisherBLL = PublisherDAL.getPublisherItem(bookTitleList[0].PublisherId);
                MessageBox.Show("Can't add this title, because it's published by \"" + publisherBLL.Name + "\" publisher!");
            }
        }

        private void btnBookTitleDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvBookTitle.SelectedCells.Count > 0 && this.dgvBookTitle.CurrentRow.Index < this.dgvBookTitle.Rows.Count - 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure delete this book title!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = this.dgvBookTitle.Rows[this.dgvBookTitle.CurrentRow.Index];

                    int id = Convert.ToInt32(selectedRow.Cells["clmnBookTitleId"].Value);
                    string name = Convert.ToString(selectedRow.Cells["clmnBookTitleName"].Value);
                    int bookTitleStatusId = Convert.ToInt32(selectedRow.Cells["clmnBookTitleStatusId"].Value.ToString());
                    int publisherId = Convert.ToInt32(selectedRow.Cells["clmnPublisherId"].Value);
                    int typeOfBookId = Convert.ToInt32(selectedRow.Cells["clmnTypeOfBookId"].Value);
                    string summary = Convert.ToString(selectedRow.Cells["clmnSummary"].Value);
                    int reprint = Convert.ToInt32(selectedRow.Cells["clmnReprint"].Value);
                    BookTitleBLL bookTitleBLL = new BookTitleBLL(id, bookTitleStatusId, publisherId, typeOfBookId, name, summary, reprint);

                    // Không thể xóa đầu sách, chỉ có thể thay đổi tình trạng thành không tồn tại
                    BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL();
                    bookTitleStatusBLL = BookTitleStatusDAL.getBookTitleStatusByName("Không Tồn Tại");
                    BookStatusBLL bookStatusBLL = new BookStatusBLL();
                    bookStatusBLL = BookStatusDAL.getBookStatusByName("Không Tồn Tại");
                    if (bookTitleStatusBLL != null)
                    {
                        bookTitleBLL.BookTitleStatusId = bookTitleStatusBLL.BookTitleStatusId;
                        BookTitleDAL.updateBookTitleStatus(bookTitleBLL);
                        BookDAL.updateBookStatus(bookTitleBLL, bookStatusBLL.BookStatusId);
                        MessageBox.Show("Change status success!", "Warning");
                        this.LoadDataToDataGridViewBookTitle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose book title you want delete!", "Notice");
            }
        }

        private void btnBookTitleSave_Click(object sender, EventArgs e)
        {
            ComboboxItem item = new ComboboxItem();
            string bookTitleName = this.txtBookName.Text;
            item = (ComboboxItem)this.cboTypeOfBook.SelectedItem;
            int typeOfBookId = Int32.Parse(item.Value.ToString());
            item = (ComboboxItem)this.cboPublisher.SelectedItem;
            int publisherId = Int32.Parse(item.Value.ToString());
            item = (ComboboxItem)this.cboBookTitleStatus.SelectedItem;
            int bookTitleStatusId = Int32.Parse(item.Value.ToString());
            string summary = this.txtSummary.Text;
            int quantity = Int32.Parse(this.txtBookTotal.Text);
            List<AuthorBLL> authorList = new List<AuthorBLL>();
            foreach (DataGridViewRow row in this.dgvAuthor.Rows)
            {
                if (row.Index < this.dgvAuthor.Rows.Count - 1)
                {
                    authorList.Add(new AuthorBLL(Int32.Parse(row.Cells["clmnAuthorId"].Value.ToString()), row.Cells["clmnAuthorName"].Value.ToString(), row.Cells["clmnWorkPlace"].Value.ToString()));
                }
            }
            if (this.txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter book name!");
                return;
            }
            if (this.txtSummary.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter book summary!");
                return;
            }
            if (authorList == null)
            {
                MessageBox.Show("Please choose author!");
                return;
            }
            if (quantity < 1)
            {
                MessageBox.Show("Quantity mustn't less than 1!");
                return;
            }
            BookTitleBLL bookTitleBLL = new BookTitleBLL();
            bookTitleBLL.Name = bookTitleName;
            bookTitleBLL.TypeOfBookId = typeOfBookId;
            bookTitleBLL.PublisherId = publisherId;
            bookTitleBLL.BookTitleStatusId = bookTitleStatusId;
            bookTitleBLL.Name = bookTitleName;
            bookTitleBLL.Summary = summary;
            int result = bookTitleBLL.checkCopyright(publisherId, bookTitleName);
            if (result == 1)
            {
                //Chưa có nhà xuất bản nào phát hành cuốn sách này
                bookTitleBLL.Reprint = 0;
                int id = BookTitleDAL.addBookTitle(bookTitleBLL);
                foreach (AuthorBLL authorBLL in authorList)
                {
                    AuthorBookTitleDAL.assignAuthorToBookTitle(id, authorBLL);
                }
                for (int i = 0; i < quantity; i++)
                {
                    BookBLL bookBLL = new BookBLL();
                    bookBLL.BookTitleId = id;
                    bookBLL.BookStatusId = 1;
                    BookDAL.addBook(bookBLL);
                }
                MessageBox.Show("Add success!");
                this.dgvBookTitle.Rows.Clear();
                this.LoadDataToDataGridViewBookTitle();
            }
            else if (result == -1)
            {
                //Nhà xuất bản này đã phát hành cuốn sách này rồi. Tăng lần tái bản lên 1
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                bookTitleList = BookTitleDAL.getBookTitleItem(bookTitleBLL.Name);
                bookTitleBLL.Reprint += bookTitleList[bookTitleList.Count - 1].Reprint + 1;
                int id = BookTitleDAL.addBookTitle(bookTitleBLL);
                foreach (AuthorBLL authorBLL in authorList)
                {
                    AuthorBookTitleDAL.delete(id);
                    AuthorBookTitleDAL.assignAuthorToBookTitle(id, authorBLL);
                }
                for (int i = 0; i < quantity; i++)
                {
                    BookBLL bookBLL = new BookBLL();
                    bookBLL.BookTitleId = id;
                    bookBLL.BookStatusId = 1;
                    BookDAL.addBook(bookBLL);
                }
                MessageBox.Show("Add success!");
                this.dgvBookTitle.Rows.Clear();
                this.LoadDataToDataGridViewBookTitle();
            }
            else
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                bookTitleList = BookTitleDAL.getBookTitleItem(bookTitleBLL.Name);
                PublisherBLL publisherBLL = new PublisherBLL();
                publisherBLL = PublisherDAL.getPublisherItem(bookTitleList[0].PublisherId);
                MessageBox.Show("Can't add this title, because it's published by \"" + publisherBLL.Name + "\" publisher!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
