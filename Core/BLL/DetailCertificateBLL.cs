using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class DetailCertificateBLL
    {
        private int _masach;
        private string _tensach;

        public int Masach
        {
            get
            {
                return _masach;
            }

            set
            {
                _masach = value;
            }
        }

        public string Tensach
        {
            get
            {
                return _tensach;
            }

            set
            {
                _tensach = value;
            }
        }
        public DetailCertificateBLL(int maSach, string tenSach)
        {
            this._masach = maSach;
            this._tensach = tenSach;
        }
        public DetailCertificateBLL() { }
    }
}
