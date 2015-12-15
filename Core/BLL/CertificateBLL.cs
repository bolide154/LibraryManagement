using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class CertificateBLL
    {
        private int _idphieumuon, _idtinhtrang;
        private Int64 _iddocgia;
        private string _tendocgia;
        private string _tentinhtrang;
        private bool _lacnvc;
        private DateTime _ngaymuon, _hantra;

        public int Idphieumuon
        {
            get
            {
                return _idphieumuon;
            }

            set
            {
                _idphieumuon = value;
            }
        }

        public int Idtinhtrang
        {
            get
            {
                return _idtinhtrang;
            }

            set
            {
                _idtinhtrang = value;
            }
        }

        public Int64 Iddocgia
        {
            get
            {
                return _iddocgia;
            }

            set
            {
                _iddocgia = value;
            }
        }

        public DateTime Ngaymuon
        {
            get
            {
                return _ngaymuon;
            }

            set
            {
                _ngaymuon = value;
            }
        }

        public DateTime Hantra
        {
            get
            {
                return _hantra;
            }

            set
            {
                _hantra = value;
            }
        }

        public string Tendocgia
        {
            get
            {
                return _tendocgia;
            }

            set
            {
                _tendocgia = value;
            }
        }

        public string Tentinhtrang
        {
            get
            {
                return _tentinhtrang;
            }

            set
            {
                _tentinhtrang = value;
            }
        }

        public bool Lacnvc
        {
            get
            {
                return _lacnvc;
            }

            set
            {
                _lacnvc = value;
            }
        }

        public CertificateBLL(int idPhieumuon, int idTinhtrang,string tenDocGia, Int64 idDocgia,string tenTinhtrang,bool laCNVC, DateTime ngayMuon, DateTime hanTra)
        {
            this._idphieumuon = idPhieumuon;
            this._idtinhtrang = idTinhtrang;
            this._tendocgia = tenDocGia;
            this._iddocgia = idDocgia;
            this._tentinhtrang = tenTinhtrang;
            this._lacnvc = laCNVC;
            this._ngaymuon = ngayMuon;
            this._hantra = hanTra;
        }

        public CertificateBLL(int idPhieumuon, int idTinhtrang, Int64 idDocgia, DateTime ngayMuon, DateTime hanTra)
        {
            this._idphieumuon = idPhieumuon;
            this._idtinhtrang = idTinhtrang;
            this._iddocgia = idDocgia;
            this._ngaymuon = ngayMuon;
            this._hantra = hanTra;
        }
        public CertificateBLL(int idTinhtrang, Int64 idDocgia, DateTime ngayMuon, DateTime hanTra)
        {
            this._idtinhtrang = idTinhtrang;
            this._iddocgia = idDocgia;
            this._ngaymuon = ngayMuon;
            this._hantra = hanTra;
        }

        public CertificateBLL() { }

        
    }
}
