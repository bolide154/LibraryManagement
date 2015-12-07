using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BLL;

namespace Core.DAL
{
    public static class AspectCertificateDAL
    {
        public static Connection _condb = new Connection();
        public static List<AspectCertificateBLL> getCertifivateId()
        {
            String sql = "SELECT * FROM [tinhtrangphieumuon]";
            DataTable dt = AspectCertificateDAL._condb.getDataTable(sql);
            List<AspectCertificateBLL> aspectCertificateList = new List<AspectCertificateBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    AspectCertificateBLL aspectCertificateBLL = new AspectCertificateBLL(Int32.Parse(row["idtinhtrang"].ToString()), row["tentinhtrang"].ToString());
                    aspectCertificateList.Add(aspectCertificateBLL);

                }
                return aspectCertificateList;
            }
            else
            {
                return null;
            }
        }
        public static void deleteCertificateStatus(AspectCertificateBLL certificateStatusBLL)
        {
            String sql = "DELETE FROM [tinhtrangphieumuon] WHERE idtinhtrang=" + certificateStatusBLL.CertificateId;
            AspectCertificateDAL._condb.ExecuteNonQuery(sql);
        }
        public static CertificateBLL getCertificateStatusItem(int certificateStatusId)
        {
            String sql = "SELECT * FROM [phieumuon] WHERE idtinhtrang=" + certificateStatusId;
            DataTable dt = AspectCertificateDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new CertificateBLL(Int32.Parse(row["maphieumuon"].ToString()), Int32.Parse(row["idtinhtrang"].ToString()),null,Int64.Parse(row["madocgia"].ToString()),null,false, DateTime.Parse(row["ngaymuon"].ToString()), DateTime.Parse(row["hantra"].ToString()));
            }
            else
            {
                return null;
            }

        }

        /*public static AspectCertificateBLL getCertificateStatusItem(int certificateStatusId)
        {
            String sql = "SELECT * FROM [tinhtrangphieumuon] WHERE idtinhtrang=" + certificateStatusId;
            DataTable dt = AspectCertificateDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new AspectCertificateBLL(Int32.Parse(row["idtinhtrang"].ToString()), row["tentinhtrang"].ToString());
            }
            return null;
        }*/
        public static void addCertificateStatus(AspectCertificateBLL certificateStatusBLL)
        {
            String sql = "INSERT INTO [tinhtrangphieumuon] (tentinhtrang) VALUES ( N'" + certificateStatusBLL.Name + "')";
            AspectCertificateDAL._condb.ExecuteNonQuery(sql);
        }
        public static void updateCertificateStatus(AspectCertificateBLL certificateStatusBLL)
        {
            String sql = "UPDATE [tinhtrangphieumuon] SET tentinhtrang=N'" + certificateStatusBLL.Name + "' WHERE idtinhtrang=" + certificateStatusBLL.CertificateId;
            AspectCertificateDAL._condb.ExecuteNonQuery(sql);
        }
        public static List<AspectCertificateBLL> searchCertificate(string key, string value)
        {
            string sql = "SELECT * FROM [tinhtrangphieumuon] WHERE " + key + " LIKE N'%" + value + "%'";
            DataTable dt = AspectCertificateDAL._condb.getDataTable(sql);
            List<AspectCertificateBLL> certificateStatusBLLList = new List<AspectCertificateBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    AspectCertificateBLL bookStatusBLL = new AspectCertificateBLL(Int32.Parse(row["idtinhtrang"].ToString()), row["tentinhtrang"].ToString());
                    certificateStatusBLLList.Add(bookStatusBLL);

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
