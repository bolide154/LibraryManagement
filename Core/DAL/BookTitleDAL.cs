using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class BookTitleDAL
    {
        public static Connection _condb = new Connection();
        public static List<BookTitleBLL> getBookTitleList()
        {
            string sql = "SELECT * FROM [dausach]";
            DataTable dt = BookTitleDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    BookTitleBLL bookTitleBLL = new BookTitleBLL(Int32.Parse(row["madausach"].ToString()), Int32.Parse(row["matinhtrang"].ToString()), Int32.Parse(row["manxb"].ToString()), Int32.Parse(row["matheloai"].ToString()), row["tensach"].ToString(), row["tomtat"].ToString());
                    bookTitleList.Add(bookTitleBLL);
                }
                return bookTitleList;
            }
            return null;
        }
        public static void addBookTitle(BookTitleBLL bookTitleBLL)
        {
            String sql = "INSERT INTO [dausach] (matinhtrang, manxb, matheloai, tensach, tomtat) VALUES ( " + bookTitleBLL.BookTitleStatusId + ", " + bookTitleBLL.PublisherId + ", " + bookTitleBLL.TypeOfBookId + ", N'" + bookTitleBLL.Name + "', N'" + bookTitleBLL.Summary + "')";
            BookTitleDAL._condb.ExecuteNonQuery(sql);
        }
        public static void deleteBookTitle(BookTitleBLL bookTitleBLL)
        {
            String sql = "DELETE FROM [dausach] WHERE matacgia=" + bookTitleBLL.BookTitleId;
            BookTitleDAL._condb.ExecuteNonQuery(sql);
        }
        public static void updateBookTitle(BookTitleBLL bookTitleBLL)
        {
            String sql = "UPDATE [dausach] SET matinhtrang=" + bookTitleBLL.BookTitleStatusId + ", manxb=" + bookTitleBLL.PublisherId + ", matheloai=" + bookTitleBLL.TypeOfBookId + ", tensach=N'" + bookTitleBLL.Name + "', tomtat=N'" + bookTitleBLL.Summary + "' WHERE madausach=" + bookTitleBLL.BookTitleId;
            BookTitleDAL._condb.ExecuteNonQuery(sql);
        }
        public static List<BookTitleBLL> search(string catalog, string key)
        {
            string sql = "SELECT * FROM [dausach] WHERE " + catalog + " LIKE '%" + key + "%'";
            DataTable dt = BookTitleDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    bookTitleList.Add(new BookTitleBLL(Int32.Parse(row["madausach"].ToString()), Int32.Parse(row["matinhtrang"].ToString()), Int32.Parse(row["manxb"].ToString()), Int32.Parse(row["matheloai"].ToString()), row["tensach"].ToString(), row["tomtat"].ToString()));
                }
                return bookTitleList;
            }
            return null;
        }

        public static BookTitleBLL getBookTitleItem(BookTitleBLL bookTitleBLL)
        {
            String sql = "SELECT * FROM [dausach] WHERE madausach=" + bookTitleBLL.BookTitleId;
            DataTable dt = BookTitleDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new BookTitleBLL(Int32.Parse(row["madausach"].ToString()), Int32.Parse(row["matinhtrang"].ToString()), Int32.Parse(row["manxb"].ToString()), Int32.Parse(row["matheloai"].ToString()), row["tensach"].ToString(), row["tomtat"].ToString());
            }
            return null;
        }

        public static List<BookTitleBLL> getBookTitleList(string catalog, int key)
        {
            String sql = "SELECT * FROM [dausach] WHERE " + catalog + "=" + key;
            DataTable dt = BookTitleDAL._condb.getDataTable(sql);
            List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    bookTitleList.Add(new BookTitleBLL(Int32.Parse(row["madausach"].ToString()), Int32.Parse(row["matinhtrang"].ToString()), Int32.Parse(row["manxb"].ToString()), Int32.Parse(row["matheloai"].ToString()), row["tensach"].ToString(), row["tomtat"].ToString()));
                }
                return bookTitleList;
            }
            return null;
        }
    }
}