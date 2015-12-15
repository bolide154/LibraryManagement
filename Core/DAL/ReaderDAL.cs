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
            if (dt.Rows.Count > 0)
            {
                List<ReaderBLL> readerList = new List<ReaderBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    ReaderBLL readerBLL = new ReaderBLL(row["tendocgia"].ToString(), Convert.ToInt64(row["madocgia"]), row["diachidocgia"].ToString(), row["sdtdocgia"].ToString(), row["emaildocgia"].ToString(), DateTime.Parse(row["ngaycap"].ToString()), DateTime.Parse(row["ngayhethan"].ToString()), DateTime.Parse(row["ngaysinhdocgia"].ToString()), bool.Parse(row["lacbcnv"].ToString()), Int32.Parse(row["namtotnghiep"].ToString()));
                    readerList.Add(readerBLL);
                }
                return readerList;
            }
            return null;
        }
        public static void addReader(ReaderBLL readerBLL)
        {
            String sql = "INSERT INTO [docgia] (tendocgia, madocgia, diachidocgia, sdtdocgia, emaildocgia, ngaycap, ngayhethan, ngaysinhdocgia, lacbcnv, namtotnghiep) VALUES ( N'" + readerBLL.Name + "', " + readerBLL.Code + ", N'" + readerBLL.Address + "', N'" + readerBLL.Phone + "', N'" + readerBLL.Email + "', '" + readerBLL.Allocateddate + "', '" + readerBLL.Enddate + "', '" + readerBLL.Birthday + "', " + ((readerBLL.IsStaff==true)?1:0) + ", '" + readerBLL.Granduation + "')";
            ReaderDAL._condb.ExecuteNonQuery(sql);
        }
        public static void deleteReader(ReaderBLL readerBLL)
        {
            String sql = "SELECT * FROM [docgia] INNER JOIN [phieumuon] ON docgia.madocgia = phieumuon.madocgia";
            DataTable dt = TypeOfBookDAL._condb.getDataTable(sql);
            int dem = 0;
            foreach (DataRow row in dt.Rows)
            {
                dem++;
                if (Int64.Parse(row["madocgia"].ToString()) == readerBLL.Code)
                {
                    /*String sql_01 = "DELETE FROM [docgia] INNER JOIN [phieumuon] ON docgia.madocgia = phieumuon.madocgia INNER JOIN [sachmuon] ON sachmuon.maphieumuon = phieumuon.maphieumuon INNER JOIN [phieutra] ON phieutra.maphieutra = sachmuon.maphieutra INNER JOIN [sachtra] ON sachtra.maphieutra = phieutra.maphieutra where docgia.madocgia = " + readerBLL.Code;
                    DataTable dt_01 = TypeOfBookDAL._condb.getDataTable(sql_01);*/
                    String sql_01 = "DELETE sachmuon FROM [sachmuon] INNER JOIN [phieumuon] ON phieumuon.maphieumuon = sachmuon.maphieumuon where phieumuon.madocgia =" + readerBLL.Code;
                    DataTable dt_01 = TypeOfBookDAL._condb.getDataTable(sql_01);
                    String sql_03 = "DELETE sachtra FROM [sachtra] INNER JOIN [phieutra] ON phieutra.maphieutra = sachtra.maphieutra where phieutra.madocgia =" + readerBLL.Code;
                    DataTable dt_03 = TypeOfBookDAL._condb.getDataTable(sql_03);
                    String sql_04 = "DELETE FROM [phieutra] where phieutra.madocgia =" + readerBLL.Code;
                    DataTable dt_04 = TypeOfBookDAL._condb.getDataTable(sql_04);
                    String sql_05 = "DELETE FROM [phieumuon] where phieumuon.madocgia =" + readerBLL.Code;
                    DataTable dt_05 = TypeOfBookDAL._condb.getDataTable(sql_05);
                    String sql_06 = "DELETE FROM [docgia] WHERE madocgia=" + readerBLL.Code;
                    DataTable dt_06 = TypeOfBookDAL._condb.getDataTable(sql_06);
                    //String sql_01 = "DELETE FROM [phieumuon] where phieumuon.madocgia =" + readerBLL.Code;
                    //DataTable dt_01 = TypeOfBookDAL._condb.getDataTable(sql_01);

                    //String sql_03 = "DELETE FROM [phieumuon] where phieumuon.madocgia =" + readerBLL.Code;
                    //DataTable dt_03 = TypeOfBookDAL._condb.getDataTable(sql_01);
                }
                else if (dem == dt.Rows.Count && Int64.Parse(row["madocgia"].ToString()) != readerBLL.Code)
                {
                    String sql_02 = "DELETE FROM [docgia] WHERE madocgia=" + readerBLL.Code;
                    DataTable dt_02 = TypeOfBookDAL._condb.getDataTable(sql_02);
                }
            }
        }
        public static void updateReader(ReaderBLL readerBLL)
        {
            String sql = "UPDATE [docgia] SET tendocgia=N'" + readerBLL.Name + "' ,  diachidocgia=N'" + readerBLL.Address + "',  sdtdocgia=N'" + readerBLL.Phone + "',  emaildocgia=N'" + readerBLL.Email + "',  ngaycap='" + readerBLL.Allocateddate + "',  ngayhethan='" + readerBLL.Enddate + "',  ngaysinhdocgia='" + readerBLL.Birthday + "', lacbcnv=" + ((readerBLL.IsStaff==true)?1:0) + ",  namtotnghiep='" + readerBLL.Granduation + "' WHERE madocgia=" + readerBLL.Code;
            ReaderDAL._condb.ExecuteNonQuery(sql);
        }
        public static ReaderBLL getReaderItem(ReaderBLL readerBLL)
        {
            String sql = "SELECT * FROM [docgia] INNER JOIN [phieumuon] ON docgia.madocgia = phieumuon.madocgia";
            DataTable dt = TypeOfBookDAL._condb.getDataTable(sql);
            int dem = 0;
            foreach (DataRow row in dt.Rows)
            {
                dem++;
                if(Int64.Parse(row["madocgia"].ToString())==readerBLL.Code)
                {
                    break;
                }
                else if(dem== dt.Rows.Count)
                {
                    String sql_01 = "SELECT * FROM [docgia] where docgia.madocgia =" + readerBLL.Code;
                    DataTable dt_01 = TypeOfBookDAL._condb.getDataTable(sql_01);
                    if (dt_01.Rows.Count > 0)
                    {
                        DataRow row_01 = dt_01.Rows[0];
                        return new ReaderBLL(row_01["tendocgia"].ToString(), Convert.ToInt64(row_01["madocgia"].ToString()), row_01["diachidocgia"].ToString(), row_01["sdtdocgia"].ToString(), row_01["emaildocgia"].ToString(), DateTime.Parse(row_01["ngaycap"].ToString()), DateTime.Parse(row_01["ngayhethan"].ToString()), DateTime.Parse(row_01["ngaysinhdocgia"].ToString()), bool.Parse(row_01["lacbcnv"].ToString()), Int32.Parse(row_01["namtotnghiep"].ToString()));
                    }
                    return null;
                }
            }
            dem = 0;
            String sql_02 = "SELECT * FROM [docgia] INNER JOIN [phieumuon] ON docgia.madocgia = phieumuon.madocgia where docgia.madocgia =" + readerBLL.Code;
            DataTable dt_02 = TypeOfBookDAL._condb.getDataTable(sql_02);
            foreach (DataRow row_02 in dt_02.Rows)
            {
                dem++;
                if (Int32.Parse(row_02["idtinhtrang"].ToString()) != 4)
                {
                    return null;
                }
                else if(Int32.Parse(row_02["idtinhtrang"].ToString()) == 4 && dem == dt_02.Rows.Count)
                {
                    return new ReaderBLL(row_02["tendocgia"].ToString(), Convert.ToInt64(row_02["madocgia"].ToString()), row_02["diachidocgia"].ToString(), row_02["sdtdocgia"].ToString(), row_02["emaildocgia"].ToString(), DateTime.Parse(row_02["ngaycap"].ToString()), DateTime.Parse(row_02["ngayhethan"].ToString()), DateTime.Parse(row_02["ngaysinhdocgia"].ToString()), bool.Parse(row_02["lacbcnv"].ToString()), Int32.Parse(row_02["namtotnghiep"].ToString()));
                }
            }
            return null;
        }
        public static ReaderBLL getReaderByReaderId(Int64 readerId)
        {
            string sql = "SELECT * FROM [docgia] WHERE madocgia=" + readerId;
            DataTable dt = new DataTable();
            dt = ReaderDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new ReaderBLL(row["tendocgia"].ToString(), Convert.ToInt64(row["madocgia"]), row["diachidocgia"].ToString(), row["sdtdocgia"].ToString(), row["emaildocgia"].ToString(), DateTime.Parse(row["ngaycap"].ToString()), DateTime.Parse(row["ngayhethan"].ToString()), DateTime.Parse(row["ngaysinhdocgia"].ToString()), bool.Parse(row["lacbcnv"].ToString()), Int32.Parse(row["namtotnghiep"].ToString()));
            }
            return null;

        }
        public static List<ReaderBLL> search(string value, string catalog)
        {
            string sql = "SELECT * FROM [docgia] where " + catalog + " LIKE '%" + value + "%'";
            DataTable dt = ReaderDAL._condb.getDataTable(sql);
            List<ReaderBLL> readerBLLList = new List<ReaderBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ReaderBLL readerBLL = new ReaderBLL(row["tendocgia"].ToString(), Convert.ToInt64(row["madocgia"]), row["diachidocgia"].ToString(), row["sdtdocgia"].ToString(), row["emaildocgia"].ToString(), DateTime.Parse(row["ngaycap"].ToString()), DateTime.Parse(row["ngayhethan"].ToString()), DateTime.Parse(row["ngaysinhdocgia"].ToString()), bool.Parse(row["lacbcnv"].ToString()), Int32.Parse(row["namtotnghiep"].ToString()));
                    readerBLLList.Add(readerBLL);

                }
                return readerBLLList;
            }
            else
            {
                return null;
            }
        }
    }
}
