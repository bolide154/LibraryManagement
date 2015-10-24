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
    class BookStatusDAL
    {
        public DataTable LoadBookStatusList()
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
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable Search(string catalog, string key)
        {
            string sql = "";
            if (key != "")
            {
                if (catalog == "" || catalog == "Serch by...")
                {
                    sql = "SELECT * FROM [tinhtrangsach] WHERE tentinhtrangsach LIKE '%" + key + "%'";
                }
                else if (catalog == "Name")
                {
                    sql = "SELECT * FROM [tinhtrangsach] WHERE tentinhtrangsach LIKE '%" + key + "%'";
                }
            }
            SqlConnection conn = Connection.ConnectionData();
            System.Console.Write(sql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public bool AddBookStatus(BookStatusBLL bookStatusBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "INSERT INTO [tinhtrangsachs] (tentinhtrangsach) VALUES ( N'" + bookStatusBLL.Name + "')";
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

        public bool DeleteBookStatus(int id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "DELETE FROM [tinhtrangsachs] WHERE matinhtrangsach=" + id;
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

        public bool UpdateBookStatus(BookStatusBLL bookStatusBLL)
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

        public DataTable CheckDelete(int id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "SELECT * FROM [sach] WHERE matinhtrangsach=" + id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
