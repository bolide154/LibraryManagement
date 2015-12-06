using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class AuthorBookTitleDAL
    {
        public static Connection _condb = new Connection();
        public static List<string> getAuthorId(BookTitleBLL bookTitleBLL)
        {
            string sql = "SELECT * FROM [tacgia_dausach] WHERE madausach="+bookTitleBLL.BookTitleId;
            DataTable dt = new DataTable();
            dt = _condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<string> authorIdList = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    authorIdList.Add(row["matacgia"].ToString());
                }
                return authorIdList;
            }
            return null;
        }
        public static void assignAuthorToBookTitle(int bookTitleId, AuthorBLL authorBLL)
        {
            string sql = "INSERT INTO [tacgia_dausach] (matacgia, madausach) VALUES (" + authorBLL.AuthorId + ", " + bookTitleId + ")";
            AuthorBookTitleDAL._condb.ExecuteNonQuery(sql);
        }
        public static void delete(int bookTitleId)
        {
            string sql = "DELETE FROM [tacgia_dausach] WHERE madausach=" + bookTitleId;
            AuthorBookTitleDAL._condb.ExecuteNonQuery(sql);
        }

    }
}
