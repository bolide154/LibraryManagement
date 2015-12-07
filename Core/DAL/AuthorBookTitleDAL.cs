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
            List<string> authorIdList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                authorIdList.Add(row["matacgia"].ToString());
            }
            return authorIdList;
        }
    }
}
