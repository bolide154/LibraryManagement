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
        public static List<BookStatusBLL> LoadBookStatusList()
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "SELECT * FROM [tinhtrangsach]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    List<BookStatusBLL> bookStatusList = new List<BookStatusBLL>();
                    foreach (DataRow row in dt.Rows)
                    {
                        BookStatusBLL authorBLL = new BookStatusBLL(Int32.Parse(row["matinhtrangsach"].ToString()), row["tentinhtrangsach"].ToString());
                        bookStatusList.Add(authorBLL);
                    }
                    return bookStatusList;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public static List<BookStatusBLL> Search(string key, string value)
        {
            try
            {
                string sql = "SELECT * FROM [tinhtrangsach] WHERE " + key + " LIKE '%" + value + "%'";
                SqlConnection conn = Connection.ConnectionData();
                System.Console.Write(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    List<BookStatusBLL> bookStatusList = new List<BookStatusBLL>();
                    foreach (DataRow row in dt.Rows)
                    {
                        BookStatusBLL bookStatusBLL = new BookStatusBLL(Int32.Parse(row["matinhtrangsach"].ToString()), row["tentinhtrangsach"].ToString());
                        bookStatusList.Add(bookStatusBLL);
                    }
                    return bookStatusList;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public static bool AddBookStatus(BookStatusBLL bookStatusBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "INSERT INTO [tinhtrangsach] (tentinhtrangsach) VALUES ( N'" + bookStatusBLL.Name + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteBookStatus(BookStatusBLL bookStatusBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "DELETE FROM [tinhtrangsach] WHERE matinhtrangsach=" + bookStatusBLL.BookStatusId;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateBookStatus(BookStatusBLL bookStatusBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "UPDATE [tinhtrangsach] SET tentinhtrangsach=N'" + bookStatusBLL.Name + "' WHERE matinhtrangsach=" + bookStatusBLL.BookStatusId;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckDelete(BookStatusBLL bookStatusBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "SELECT * FROM [sach] WHERE matinhtrangsach=" + bookStatusBLL.BookStatusId;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return false;
                }
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
