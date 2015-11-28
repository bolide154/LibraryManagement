using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class ReaderDAL
    {
        public static Connection _condb = new Connection();
        public static List<ReaderBLL> getReaderList()
        {
            string sql = "SELECT * FROM [docgia]";
            DataTable dt = ReaderDAL._condb.getDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                List<ReaderBLL> readerList = new List<ReaderBLL>();
                foreach(DataRow row in dt.Rows)
                {
                    ReaderBLL readerBLL = new ReaderBLL(row["tendocgia"].ToString(), row["madocgia"].ToString(),row["diachidocgia"].ToString(), row["sdtdocgia"].ToString(), row["emaildocgia"].ToString(), DateTime.Parse(row["ngaycap"].ToString()), DateTime.Parse(row["ngayhethan"].ToString()));
                    readerList.Add(readerBLL);
                }
                return readerList;
            }
            return null;
        }
    }
}
