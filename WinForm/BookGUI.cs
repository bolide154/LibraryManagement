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
    public partial class BookGUI : Form
    {
        private BookTitleBLL _bookTitleBLL;
        public BookGUI(BookTitleBLL bookTitleBLL)
        {
            this._bookTitleBLL = bookTitleBLL;
            InitializeComponent();
        }

        private void BookGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToComBoBox();
            this.LoadDataToDataGridView();
        }

        private void LoadDataToComBoBox()
        {
            List<string> keyArr = new List<string>();
            keyArr.Add("Book Id");
            keyArr.Add("Book Title");
            keyArr.Add("Book Status");
            this.cboSearch.DataSource = keyArr;
        }

        private void LoadDataToDataGridView()
        {
            this.dgvBook.Rows.Clear();
            List<BookBLL> bookList = new List<BookBLL>();
            bookList = BookDAL.getBookList(this._bookTitleBLL);
            foreach (BookBLL row in bookList)
            {
                BookTitleBLL bookTitleBLL = new BookTitleBLL();
                bookTitleBLL = BookTitleDAL.getBookTitleItem(row.BookTitleId);
                BookStatusBLL bookStatusBLL = new BookStatusBLL();
                bookStatusBLL = BookStatusDAL.getBookStatusItem(row.BookStatusId);
                this.dgvBook.Rows.Add(row.BookId, bookTitleBLL.Name, bookTitleBLL.BookTitleId, bookStatusBLL.Name, bookStatusBLL.BookStatusId);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
