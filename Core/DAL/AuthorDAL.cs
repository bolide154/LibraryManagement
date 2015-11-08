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
        public static Connection _condb = new Connection();
        public static List<AuthorBLL> getAuthorList()
        {
            string sql = "SELECT * FROM [tacgia]";
            DataTable dt = AuthorDAL._condb.getDataTable(sql);
            List<AuthorBLL> authorList = new List<AuthorBLL>();
            foreach (DataRow row in dt.Rows)
            {
                AuthorBLL authorBLL = new AuthorBLL(Int32.Parse(row["matacgia"].ToString()), row["tentacgia"].ToString(), row["noicongtac"].ToString());
                authorList.Add(authorBLL);
            }
            return authorList;
        }

        public static void addAuthor(AuthorBLL authorBLL)
        {
            String sql = "INSERT INTO [tacgia] (tentacgia, noicongtac) VALUES ( N'" + authorBLL.Name + "', N'" + authorBLL.WorkPlace + "')";
            AuthorDAL._condb.ExecuteNonQuery(sql);
        }
        public static void deleteAuthor(AuthorBLL authorBLL)
        {
            String sql = "DELETE FROM [tacgia] WHERE matacgia=" + authorBLL.AuthorId;
            AuthorDAL._condb.ExecuteNonQuery(sql);
        }
        public static void updateAuthor(AuthorBLL authorBLL)
        {
                String sql = "UPDATE [tacgia] SET tentacgia=N'" + authorBLL.Name + "', noicongtac=N'" + authorBLL.WorkPlace + "' WHERE matacgia=" + authorBLL.AuthorId;
                AuthorDAL._condb.ExecuteNonQuery(sql);
        }

        public static List<AuthorBLL> search(string catalog, string key)
        {
            string sql = "SELECT * FROM [tacgia] WHERE " + catalog + " LIKE '%" + key + "%'";
            DataTable dt = AuthorDAL._condb.getDataTable(sql);
            List<AuthorBLL> authorList = new List<AuthorBLL>();
            foreach (DataRow row in dt.Rows)
            {
                AuthorBLL authorBLL = new AuthorBLL(Int32.Parse(row["matacgia"].ToString()), row["tentacgia"].ToString(), row["noicongtac"].ToString());
                authorList.Add(authorBLL);
            }
            return authorList;
        }

        public static AuthorBLL getAuthorItem(AuthorBLL authorBLL)
        {
                String sql = "SELECT * FROM [tacgia_dausach] WHERE matacgia=" + authorBLL.AuthorId;
            DataTable dt = TypeOfBookDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new AuthorBLL(Int32.Parse(row["matacgia"].ToString()), row["tentacgia"].ToString(), row["noicongtac"].ToString());
            }
            return null;
        }
    }
}
