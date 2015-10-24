using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BookTitleStatusBLL
    {
        private int bookTitleStatusId;
        private string name;

        public int BookTitleStatusId
        {
            get { return bookTitleStatusId; }
            set { bookTitleStatusId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public BookTitleStatusBLL(int _bookTitleStatusId, string _name)
        {
            this.bookTitleStatusId = _bookTitleStatusId;
            this.name = _name;
        }

        public BookTitleStatusBLL() { }

        public List<BookTitleStatusBLL> LoadTypeOfBookList()
        {
            List<BookTitleStatusBLL> bookTitleStatusArr = new List<BookTitleStatusBLL>();
            BookTitleStatusDAL bookTitleStatusDAL = new BookTitleStatusDAL();
            DataTable dtBookTitleStatus = new DataTable();
            dtBookTitleStatus = bookTitleStatusDAL.LoadBookTitleStatusList();
            foreach (DataRow row in dtBookTitleStatus.Rows)
            {
                BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL();
                bookTitleStatusBLL.BookTitleStatusId = Int32.Parse(row["matinhtrang"].ToString());
                bookTitleStatusBLL.Name = row["tentinhtrang"].ToString();
                bookTitleStatusArr.Add(bookTitleStatusBLL);
            }
            return bookTitleStatusArr;
        }

        public List<BookTitleStatusBLL> Search(string catalog, string key)
        {
            List<BookTitleStatusBLL> bookTitleStatusArr = new List<BookTitleStatusBLL>();
            BookTitleStatusDAL bookTitleStatusDAL = new BookTitleStatusDAL();
            DataTable dtBookTitleStatus = new DataTable();
            dtBookTitleStatus = bookTitleStatusDAL.Search(catalog, key);
            foreach (DataRow row in dtBookTitleStatus.Rows)
            {
                BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL();
                bookTitleStatusBLL.BookTitleStatusId = Int32.Parse(row["matinhtrang"].ToString());
                bookTitleStatusBLL.Name = row["tentinhtrang"].ToString();
                bookTitleStatusArr.Add(bookTitleStatusBLL);
            }
            return bookTitleStatusArr;
        }

        public bool AddBookTitleStatus(BookTitleStatusBLL bookTitleStatusBLL)
        {
            BookTitleStatusDAL bookTitleStatusDAL = new BookTitleStatusDAL();
            return bookTitleStatusDAL.AddBookTitleStatus(bookTitleStatusBLL);
        }

        public bool DeleteBookTitleStatus(int id)
        {
            BookTitleStatusDAL bookTitleStatusDAL = new BookTitleStatusDAL();
            return bookTitleStatusDAL.DeleteBookTitleStatus(id);
        }

        public bool UpdateBookTitleStatus(BookTitleStatusBLL bookTitleStatusBLL)
        {
            BookTitleStatusDAL bookTitleStatusDAL = new BookTitleStatusDAL();
            return bookTitleStatusDAL.UpdateBookTitleStatus(bookTitleStatusBLL);
        }
    }
}
