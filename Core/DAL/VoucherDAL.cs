using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class VoucherDAL
    {
        public static Connection _condb = new Connection();

        public static List<VoucherBLL> getManageVoucherList()
        {
            String sql = "SELECT * FROM [phieutra] INNER JOIN [sachmuon] ON sachmuon.maphieutra = phieutra.maphieutra INNER JOIN [docgia] ON phieutra.madocgia = docgia.madocgia";
            DataTable dt = VoucherDAL._condb.getDataTable(sql);
            List<VoucherBLL> manageVoucherBLLList = new List<VoucherBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    VoucherBLL manageVoucherBLL = new VoucherBLL(Int32.Parse(row["maphieutra"].ToString()), Int32.Parse(row["maphieumuon"].ToString()), row["tendocgia"].ToString(), Boolean.Parse(row["lacbcnv"].ToString()),DateTime.Parse(row["ngaytra"].ToString()));
                    manageVoucherBLLList.Add(manageVoucherBLL);

                }
                return manageVoucherBLLList;
            }
            else
            {
                return null;
            }
        }
        public static List<DetailVoucherBLL> getDetailVoucherList(Int32 maphieutra)
        {
            String sql = "SELECT * FROM [sachtra] INNER JOIN [sach] ON sachtra.masach = sach.masach INNER JOIN [dausach] ON sach.madausach = dausach.madausach where sachtra.maphieutra = " + maphieutra;
            DataTable dt = VoucherDAL._condb.getDataTable(sql);
            List<DetailVoucherBLL> manageVoucherBLLList = new List<DetailVoucherBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DetailVoucherBLL manageVoucherBLL = new DetailVoucherBLL(Int32.Parse(row["masach"].ToString()), row["tensach"].ToString());
                    manageVoucherBLLList.Add(manageVoucherBLL);

                }
                return manageVoucherBLLList;
            }
            else
            {
                return null;
            }
        }
        public static List<VoucherBLL> search(string value, string catalog)
        {
            string sql = "SELECT * FROM [phieutra] INNER JOIN [sachmuon] ON sachmuon.maphieutra = phieutra.maphieutra INNER JOIN [docgia] ON phieutra.madocgia = docgia.madocgia where "+ catalog + "=" +value+"";
            DataTable dt = VoucherDAL._condb.getDataTable(sql);
            List<VoucherBLL> voucherStatusBLLList = new List<VoucherBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    VoucherBLL voucherStatusBLL = new VoucherBLL(Int32.Parse(row["maphieutra"].ToString()), Int32.Parse(row["maphieumuon"].ToString()), row["tendocgia"].ToString(), Boolean.Parse(row["lacbcnv"].ToString()), DateTime.Parse(row["ngaytra"].ToString()));
                    voucherStatusBLLList.Add(voucherStatusBLL);

                }
                return voucherStatusBLLList;
            }
            else
            {
                return null;
            }
        }
    }
}
