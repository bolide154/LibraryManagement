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
    class BookTitleStatusDAL
    {
        public DataTable LoadBookTitleStatusList()
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "SELECT * FROM [tinhtrangdausach]";
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
                    sql = "SELECT * FROM [tinhtrangdausach] WHERE tentinhtrang LIKE '%" + key + "%'";
                }
                else if (catalog == "Name")
                {
                    sql = "SELECT * FROM [tinhtrangdausach] WHERE tentinhtrang LIKE '%" + key + "%'";
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

        public bool AddBookTitleStatus(BookTitleStatusBLL bookTitleStatus)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "INSERT INTO [tinhtrangdausach] (tentinhtrang) VALUES ( N'" + bookTitleStatus.Name + "')";
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

        public bool DeleteBookTitleStatus(int id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "DELETE FROM [tinhtrangdausach] WHERE matinhtrang=" + id;
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
        public bool UpdateBookTitleStatus(BookTitleStatusBLL bookTitleStatusBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "UPDATE [tinhtrangdausach] SET tentinhtrang=N'" + bookTitleStatusBLL.Name + "' WHERE matinhtrang=" + bookTitleStatusBLL.BookTitleStatusId;
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
                String sql = "SELECT * FROM [dausach] WHERE matinhtrang=" + id;
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
