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
    class TypeOfBookDAL
    {
        public DataTable LoadTypeOfBookList()
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "SELECT * FROM [theloai]";
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
                    sql = "SELECT * FROM [theloai] WHERE tentheloai LIKE '%" + key + "%'";
                }
                else if (catalog == "Name")
                {
                    sql = "SELECT * FROM [theloai] WHERE tentheloai LIKE '%" + key + "%'";
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

        public bool AddTypeOfBook(BLL.TypeOfBookBLL typeOfBookBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "INSERT INTO [theloai] (tentheloai) VALUES ( N'" + typeOfBookBLL.Name + "')";
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

        public bool DeleteTypeOfBook(int id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "DELETE FROM [theloai] WHERE matheloai=" + id;
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
        public bool UpdateTypeOfBook(TypeOfBookBLL typeOfBookBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "UPDATE [theloai] SET tentheloai=N'" + typeOfBookBLL.Name + "' WHERE matheloai="+typeOfBookBLL.TypeOfBookId;
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
    }
}
