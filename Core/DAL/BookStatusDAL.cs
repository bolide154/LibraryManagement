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
    public static class BookStatusDAL
    {
        public static Connection _condb = new Connection();
        public static List<BookStatusBLL> getBookStatusList()
        {
                String sql = "SELECT * FROM [tinhtrangsach]";
                DataTable dt = BookStatusDAL._condb.getDataTable(sql);
                List<BookStatusBLL> bookStatusBLLList = new List<BookStatusBLL>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BookStatusBLL bookStatusBLL = new BookStatusBLL(Int32.Parse(row["matinhtrangsach"].ToString()), row["tentinhtrangsach"].ToString());
                        bookStatusBLLList.Add(bookStatusBLL);

                    }
                    return bookStatusBLLList;
                }
                else
                {
                    return null;
                }
        }

        public static List<BookStatusBLL> search(string key, string value)
        {
                string sql = "SELECT * FROM [tinhtrangsach] WHERE " + key + " LIKE N'%" + value + "%'";
                DataTable dt = BookStatusDAL._condb.getDataTable(sql);
                List<BookStatusBLL> bookStatusBLLList = new List<BookStatusBLL>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BookStatusBLL bookStatusBLL = new BookStatusBLL(Int32.Parse(row["matinhtrangsach"].ToString()), row["tentinhtrangsach"].ToString());
                        bookStatusBLLList.Add(bookStatusBLL);

                    }
                    return bookStatusBLLList;
                }
                else
                {
                    return null;
                }
        }

        public static void addBookStatus(BookStatusBLL bookStatusBLL)
        {
                String sql = "INSERT INTO [tinhtrangsach] (tentinhtrangsach) VALUES ( N'" + bookStatusBLL.Name + "')";
                BookStatusDAL._condb.ExecuteNonQuery(sql);
        }

        public static void deleteBookStatus(BookStatusBLL bookStatusBLL)
        {
                String sql = "DELETE FROM [tinhtrangsach] WHERE matinhtrangsach=" + bookStatusBLL.BookStatusId;
                BookStatusDAL._condb.ExecuteNonQuery(sql);
        }

        public static void updateBookStatus(BookStatusBLL bookStatusBLL)
        {
                String sql = "UPDATE [tinhtrangsach] SET tentinhtrangsach=N'" + bookStatusBLL.Name + "' WHERE matinhtrangsach=" + bookStatusBLL.BookStatusId;
                BookStatusDAL._condb.ExecuteNonQuery(sql);
        }

        public static BookStatusBLL getBookStatusItem(BookStatusBLL bookStatusBLL)
        {
            String sql = "SELECT * FROM [tinhtrangsach] WHERE matinhtrangsach=" + bookStatusBLL.BookStatusId;
                DataTable dt = BookStatusDAL._condb.getDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new BookStatusBLL(Int32.Parse(row["matinhtrangsach"].ToString()), row["tentinhtrangsach"].ToString());
                }
                else
                {
                    return null;
                }
                
        }

        public static BookStatusBLL getBookStatusItem(int bookStatusId)
        {
            String sql = "SELECT * FROM [tinhtrangsach] WHERE matinhtrangsach=" + bookStatusId;
            DataTable dt = BookStatusDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new BookStatusBLL(Int32.Parse(row["matinhtrangsach"].ToString()), row["tentinhtrangsach"].ToString());
            }
                return null;
        }
    }
}
