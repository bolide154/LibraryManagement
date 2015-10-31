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
    public static class AuthorDAL
    {
        public static List<AuthorBLL> LoadAuthorList()
        {
            SqlConnection conn = Connection.ConnectionData();
            String sql = "SELECT * FROM [tacgia]";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            //return dt;

            List<AuthorBLL> authorList = new List<AuthorBLL>();
            foreach (DataRow row in dt.Rows)
            {
                AuthorBLL authorBLL = new AuthorBLL(Int32.Parse(row["matacgia"].ToString()), row["tentacgia"].ToString(), row["noicongtac"].ToString());
                authorList.Add(authorBLL);
            }
            return authorList;
        }

        public static bool AddAuthor(AuthorBLL authorBLL)
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
        public static bool DeleteAuthor(AuthorBLL authorBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "DELETE FROM [tacgia] WHERE matacgia="+authorBLL.AuthorId;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch{
                return false;
            }
        }
        public static bool UpdateAuthor(AuthorBLL authorBLL)
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

        public static List<AuthorBLL> Search(string key, string value)
        {
            try
            {
                string sql = "SELECT * FROM [tacgia] WHERE " + key + " LIKE '%" + value + "%'";
                SqlConnection conn = Connection.ConnectionData();
                System.Console.Write(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                List<AuthorBLL> authorList = new List<AuthorBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    AuthorBLL authorBLL = new AuthorBLL(Int32.Parse(row["matacgia"].ToString()), row["tentacgia"].ToString(), row["noicongtac"].ToString());
                    authorList.Add(authorBLL);
                }
                return authorList;
            }
            catch
            {
                return null;
            }
        }

        public static bool CheckDelete(AuthorBLL authorBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "SELECT * FROM [tacgia_dausach] WHERE matacgia="+authorBLL.AuthorId;
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
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
