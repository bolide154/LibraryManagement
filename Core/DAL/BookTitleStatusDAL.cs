using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class BookTitleStatusDAL
    {
        public static Connection _condb = new Connection();
        public static List<BookTitleStatusBLL> getBookTitleStatusList()
        {
            String sql = "SELECT * FROM [tinhtrangdausach]";
            DataTable dt = new DataTable();
            dt = BookTitleStatusDAL._condb.getDataTable(sql);
            List<BookTitleStatusBLL> bookTitleStatusBLLList = new List<BookTitleStatusBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL(Int32.Parse(row["matinhtrang"].ToString()), row["tentinhtrang"].ToString());
                    bookTitleStatusBLLList.Add(bookTitleStatusBLL);
                }
                return bookTitleStatusBLLList;
            }
            return null;
        }

        public static List<BookTitleStatusBLL> search(string catalog, string key)
        {
            string sql = "SELECT * FROM [tinhtrangdausach] WHERE " + catalog + " LIKE '%" + key + "%'";
            DataTable dt = new DataTable();
            dt = BookTitleStatusDAL._condb.getDataTable(sql);
            List<BookTitleStatusBLL> bookTitleStatusBLLList = new List<BookTitleStatusBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    BookTitleStatusBLL bookTitleStatusBLL = new BookTitleStatusBLL(Int32.Parse(row["matinhtrang"].ToString()), row["tentinhtrang"].ToString());
                    bookTitleStatusBLLList.Add(bookTitleStatusBLL);
                }
                return bookTitleStatusBLLList;
            }
            return null;
        }

        public static void addBookTitleStatus(BookTitleStatusBLL bookTitleStatus)
        {
            String sql = "INSERT INTO [tinhtrangdausach] (tentinhtrang) VALUES ( N'" + bookTitleStatus.Name + "')";
            BookTitleStatusDAL._condb.ExecuteNonQuery(sql);
        }

        public static void deleteBookTitleStatus(BookTitleStatusBLL bookTitleStatus)
        {
            String sql = "DELETE FROM [tinhtrangdausach] WHERE matinhtrang=" + bookTitleStatus.BookTitleStatusId;
            BookTitleStatusDAL._condb.ExecuteNonQuery(sql);
        }
        public static void updateBookTitleStatus(BookTitleStatusBLL bookTitleStatusBLL)
        {
            String sql = "UPDATE [tinhtrangdausach] SET tentinhtrang=N'" + bookTitleStatusBLL.Name + "' WHERE matinhtrang=" + bookTitleStatusBLL.BookTitleStatusId;
            BookTitleStatusDAL._condb.ExecuteNonQuery(sql);
        }
        public static BookTitleStatusBLL getBookTitleStatusItem(BookTitleStatusBLL bookTitleStatusBLL)
        {
            String sql = "SELECT * FROM [dausach] WHERE matinhtrang=" + bookTitleStatusBLL.BookTitleStatusId;
            DataTable dt = BookTitleStatusDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new BookTitleStatusBLL(Int32.Parse(row["matinhtrang"].ToString()), row["tentinhtrang"].ToString());
            }
            return null;
        }
        public static List<BookTitleStatusBLL> getBookTitleStatusItem(string bookTitleStatusName)
        {
            String sql = "SELECT * FROM [tinhtrangdausach] WHERE tentinhtrang LIKE N'%" + bookTitleStatusName + "%'";
            DataTable dt = BookTitleStatusDAL._condb.getDataTable(sql);
            List<BookTitleStatusBLL> bookTitleStatusList = new List<BookTitleStatusBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    bookTitleStatusList.Add(new BookTitleStatusBLL(Int32.Parse(row["matinhtrang"].ToString()), row["tentinhtrang"].ToString()));
                }
                return bookTitleStatusList;
            }
            return null;
        }
        public static BookTitleStatusBLL getBookTitleStatusByName(string bookTitleStatusName)
        {
            String sql = "SELECT * FROM [tinhtrangdausach] WHERE tentinhtrang = N'"+bookTitleStatusName+"'";
            DataTable dt = BookTitleStatusDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new BookTitleStatusBLL(Int32.Parse(row["matinhtrang"].ToString()), row["tentinhtrang"].ToString());
            }
            return null;
        }
    }
}
