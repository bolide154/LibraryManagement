using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class CertificateDAL
    {
        public static Connection _condb = new Connection();
        public static List<CertificateBLL> getManageCertificateList()
        {
            String sql = "SELECT * FROM [phieumuon] INNER JOIN [tinhtrangphieumuon] ON phieumuon.idtinhtrang = tinhtrangphieumuon.idtinhtrang INNER JOIN [docgia] ON phieumuon.madocgia = docgia.madocgia";
            DataTable dt = CertificateDAL._condb.getDataTable(sql);
            List<CertificateBLL> manageCertificateBLLList = new List<CertificateBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    CertificateBLL manageCertificateBLL = new CertificateBLL(Int32.Parse(row["maphieumuon"].ToString()), Int32.Parse(row["idtinhtrang"].ToString()), row["tendocgia"].ToString(), Int64.Parse(row["madocgia"].ToString()),row["tentinhtrang"].ToString(), Boolean.Parse(row["lacbcnv"].ToString()), DateTime.Parse(row["ngaymuon"].ToString()), DateTime.Parse(row["hantra"].ToString()));
                    manageCertificateBLLList.Add(manageCertificateBLL);
                    
                }
                return manageCertificateBLLList;
            }
            else
            {
                return null;
            }
        }
        public static List<DetailCertificateBLL> getDetailCertificateList(Int32 maphieumuon)
        {
            String sql = "SELECT * FROM [sachmuon] INNER JOIN [sach] ON sach.masach = sachmuon.masach INNER JOIN [dausach] ON sach.madausach = dausach.madausach where sachmuon.maphieumuon = "+ maphieumuon;
            DataTable dt = CertificateDAL._condb.getDataTable(sql);
            List<DetailCertificateBLL> manageCertificateBLLList = new List<DetailCertificateBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DetailCertificateBLL manageCertificateBLL = new DetailCertificateBLL(Int32.Parse(row["masach"].ToString()), row["tensach"].ToString());
                    manageCertificateBLLList.Add(manageCertificateBLL);

                }
                return manageCertificateBLLList;
            }
            else
            {
                return null;
            }
        }
        public static List<CertificateBLL> search(string value, string catalog)
        {
            string sql = "SELECT * FROM [phieumuon] INNER JOIN [tinhtrangphieumuon] ON phieumuon.idtinhtrang = tinhtrangphieumuon.idtinhtrang INNER JOIN [docgia] ON phieumuon.madocgia = docgia.madocgia where "+catalog+" LIKE N'%" +value+"%'";
            DataTable dt = CertificateDAL._condb.getDataTable(sql);
            List<CertificateBLL> certificateStatusBLLList = new List<CertificateBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    CertificateBLL certificateStatusBLL = new CertificateBLL(Int32.Parse(row["maphieumuon"].ToString()), Int32.Parse(row["idtinhtrang"].ToString()), row["tendocgia"].ToString(), Int64.Parse(row["madocgia"].ToString()), row["tentinhtrang"].ToString(), Boolean.Parse(row["lacbcnv"].ToString()), DateTime.Parse(row["ngaymuon"].ToString()), DateTime.Parse(row["hantra"].ToString()));
                    certificateStatusBLLList.Add(certificateStatusBLL);

                }
                return certificateStatusBLLList;
            }
            else
            {
                return null;
            }
        }
    }
}
