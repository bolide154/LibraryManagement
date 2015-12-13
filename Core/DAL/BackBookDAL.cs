using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class BackBookDAL
    {
        public static Connection _condb = new Connection();
        public static List<BackBookBLL> search(string value)
        {
            string sql = "SELECT * FROM [phieumuon] INNER JOIN [sachmuon] ON phieumuon.maphieumuon = sachmuon.maphieumuon INNER JOIN [docgia] ON phieumuon.madocgia = docgia.madocgia INNER JOIN [sach] ON sachmuon.masach = sach.masach INNER JOIN [dausach] ON dausach.madausach = sach.madausach where phieumuon.maphieumuon = " + value;
            DataTable dt = BackBookDAL._condb.getDataTable(sql);
            List<BackBookBLL> backbookBLLList = new List<BackBookBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    BackBookBLL backbookBLL = new BackBookBLL(Int32.Parse(row["maphieumuon"].ToString()), row["tensach"].ToString(),Int32.Parse(row["masach"].ToString()),Int32.Parse(row["matinhtrangsach"].ToString()),Int64.Parse(row["madocgia"].ToString()), row["tendocgia"].ToString(), DateTime.Parse(row["ngaymuon"].ToString()), DateTime.Parse(row["hantra"].ToString()));
                    backbookBLLList.Add(backbookBLL);
                }
                return backbookBLLList;
            }
            else
            {
                return null;
            }
        }
        public static void editbookstt(Int32 maso)
        {
                String sql_01 = "UPDATE [sach] SET matinhtrangsach=1 where sach.masach="+maso;
                ReaderDAL._condb.ExecuteNonQuery(sql_01);
                /*for(int i=0;i<6;i++)
                {
                    String sql_01 = "UPDATE [sach] SET matinhtrangsach=2 where sach.masach=" + (i+1);
                    ReaderDAL._condb.ExecuteNonQuery(sql_01);
                }*/
        }
        public static Int32 addVoucher(Int64 madocgia)
        {
            DateTime current = DateTime.Now;
            String sql = "INSERT INTO [phieutra] (madocgia,ngaytra) VALUES (" + madocgia + ",'" + current.ToShortDateString()+"')";
            ReaderDAL._condb.ExecuteNonQuery(sql);
            String sql_01 = "SELECT * FROM [phieutra]";
            DataTable dt = TypeOfBookDAL._condb.getDataTable(sql_01);
            int dem = 0;
            foreach (DataRow row in dt.Rows)
            {
                dem++;
                if (dem == dt.Rows.Count)
                {
                    return Int32.Parse(row["maphieutra"].ToString());
                }
            }
            return 0;
        }
        public static void addBackBook(Int32 maphieutra, Int32 masach, Int32 maphieumuon)
        {
            String sql = "INSERT INTO [sachtra] (maphieutra,masach) VALUES (" + maphieutra + "," + masach + ")";
            ReaderDAL._condb.ExecuteNonQuery(sql);
            String sql_01 = "UPDATE [sachmuon] SET sachmuon.maphieutra="+maphieutra+" where sachmuon.maphieumuon="+maphieumuon+" AND sachmuon.masach="+masach+"";
            ReaderDAL._condb.ExecuteNonQuery(sql_01);
        }
        public static void checkCertificateStt(Int32 maphieumuon)
        {
            String sql = "SELECT * FROM [sachmuon] INNER JOIN [sach] ON sachmuon.masach = sach.masach where sachmuon.maphieumuon="+maphieumuon;
            DataTable dt = TypeOfBookDAL._condb.getDataTable(sql);
            int dem = 0;
            foreach (DataRow row in dt.Rows)
            {
                dem++;
                if(Int32.Parse(row["matinhtrangsach"].ToString())==2)
                {
                    return;
                }
                if (dem == dt.Rows.Count)
                {
                    String sql_01 = "UPDATE [phieumuon] SET phieumuon.idtinhtrang=4 where phieumuon.maphieumuon=" + maphieumuon;
                    ReaderDAL._condb.ExecuteNonQuery(sql_01);
                }
            }
        }
    }
}
