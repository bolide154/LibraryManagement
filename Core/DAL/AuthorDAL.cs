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
    class AuthorDAL
    {
        public DataTable LoadAuthorList()
        {
            SqlConnection conn = Connection.ConnectionData();
            String sql = "SELECT * FROM tacgia";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public bool AddAuthor(AuthorBLL authorBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "INSERT INTO [tacgia] (tentacgia, noicongtac)"
                    + " VALUES ( N'" + authorBLL.Name + "', N'" + authorBLL.WorkPlace + "')";
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
        public bool DeleteAuthor(int id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "DELETE FROM TABLE [tacgia] WHERE matacgia="+id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch{
                return false;
            }
        }
        public bool UpdateAuthor(AuthorBLL authorBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "UPDATE [tacgia] SET tentacgia=N'" + authorBLL.Name + "', noicongtac=N'" + authorBLL.WorkPlace + "' WHERE matacgia=" + authorBLL.AuthorId;
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

        public DataTable Search(string catalog, string key)
        {
            string sql = "";
            if (key != "")
            {
                if (catalog == "" || catalog == "Serch by...")
                {
                        sql = "SELECT * FROM [tacgia] WHERE tentacgia LIKE '%" + key + "%'";
                }
                else if (catalog == "Name")
                {
                    sql = "SELECT * FROM [tacgia] WHERE tentacgia LIKE '%" + key + "%'";
                }
                else if (catalog == "Work Place")
                {
                    sql = "SELECT * FROM [tacgia] WHERE noicongtac LIKE '%" + key + "%'";
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
    }
}
