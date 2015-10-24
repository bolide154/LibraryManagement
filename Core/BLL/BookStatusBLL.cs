using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BookStatusBLL
    {
        private int bookStatusId;
        private string name;

        public int BookStatusId
        {
            get { return bookStatusId; }
            set { bookStatusId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public BookStatusBLL(int _bookStatusId, string _name)
        {
            this.bookStatusId = _bookStatusId;
            this.name = _name;
        }

        public BookStatusBLL() { }

        public List<BookStatusBLL> LoadBookStatusList()
        {
            List<BookStatusBLL> bookStatusArr = new List<BookStatusBLL>();
            BookStatusDAL bookStatusDAL = new BookStatusDAL();
            DataTable dtBookStatus = new DataTable();
            dtBookStatus = bookStatusDAL.LoadBookStatusList();
            foreach (DataRow row in dtBookStatus.Rows)
            {
                BookStatusBLL bookStatusBLL = new BookStatusBLL();
                bookStatusBLL.BookStatusId = Int32.Parse(row["matinhtrangsach"].ToString());
                bookStatusBLL.Name = row["tentinhtrangsach"].ToString();
                bookStatusArr.Add(bookStatusBLL);
            }
            return bookStatusArr;
        }

        public bool AddBookStatus(BookStatusBLL bookStatusBLL)
        {
            BookStatusDAL bookStatusDAL = new BookStatusDAL();
            return bookStatusDAL.AddBookStatus(bookStatusBLL);
        }
        public bool DeleteBookStatus(int id)
        {
            BookStatusDAL bookStatusDAL = new BookStatusDAL();
            return bookStatusDAL.DeleteBookStatus(id);
        }
        public bool UpdateBookStatus(BookStatusBLL bookStatusBLL)
        {
            BookStatusDAL bookStatusDAL = new BookStatusDAL();
            return bookStatusDAL.UpdateBookStatus(bookStatusBLL);
        }

        public List<BookStatusBLL> Search(string catalog, string key)
        {
            List<BookStatusBLL> bookStatusArr = new List<BookStatusBLL>();
            BookStatusDAL bookStatusDAL = new BookStatusDAL();
            DataTable dtBookStatus = new DataTable();
            dtBookStatus = bookStatusDAL.Search(catalog, key);
            foreach (DataRow row in dtBookStatus.Rows)
            {
                BookStatusBLL bookStatusBLL = new BookStatusBLL();
                bookStatusBLL.BookStatusId = Int32.Parse(row["matinhtrangsach"].ToString());
                bookStatusBLL.Name = row["tentinhtrangsach"].ToString();
                bookStatusArr.Add(bookStatusBLL);
            }
            return bookStatusArr;
        }

        public bool CheckDelete(int id)
        {
            DataTable dt = new DataTable();
            BookStatusDAL bookStatusDAL = new BookStatusDAL();
            dt = bookStatusDAL.CheckDelete(id);
            if (dt.Rows.Count > 0)
            {
                //Tồn tại tình trạng sách này trong bảng sách. Không cho xóa
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
