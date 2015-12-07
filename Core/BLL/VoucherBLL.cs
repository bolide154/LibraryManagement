using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class VoucherBLL
    {
        private int _phieutra;
        private int _phieumuon;
        private string _docgia;
        private bool _doituong;
        private DateTime _ngaytra;

        public int Phieutra
        {
            get
            {
                return _phieutra;
            }

            set
            {
                _phieutra = value;
            }
        }

        public int Phieumuon
        {
            get
            {
                return _phieumuon;
            }

            set
            {
                _phieumuon = value;
            }
        }

        public string Docgia
        {
            get
            {
                return _docgia;
            }

            set
            {
                _docgia = value;
            }
        }

        public bool Doituong
        {
            get
            {
                return _doituong;
            }

            set
            {
                _doituong = value;
            }
        }

        public DateTime Ngaytra
        {
            get
            {
                return _ngaytra;
            }

            set
            {
                _ngaytra = value;
            }
        }
        public VoucherBLL(int phieuTra, int phieuMuon, string docGia, bool doiTuong, DateTime ngayTra)
        {
            this._phieutra = phieuTra;
            this._phieumuon = phieuMuon;
            this._docgia = docGia;
            this._doituong = doiTuong;
            this._ngaytra = ngayTra;
        }
        public VoucherBLL() { }
    }
}
