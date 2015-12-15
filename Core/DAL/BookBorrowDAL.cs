using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class BookBorrowDAL
    {
        public static Connection _conndb = new Connection();

        public static void Insert(Int32 bookId, Int32 certificateId)
        {
            string sql = "INSERT INTO [sachmuon] (maphieumuon, masach) VALUES (" + certificateId + ", " + bookId + ")";
            BookBorrowDAL._conndb.ExecuteNonQuery(sql);
        }
    }
}
