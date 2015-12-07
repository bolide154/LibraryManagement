using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class DetailVoucherBLL
    {
        private int _masachtra;
        private string _tensachtra;

        public int Masachtra
        {
            get
            {
                return _masachtra;
            }

            set
            {
                _masachtra = value;
            }
        }

        public string Tensachtra
        {
            get
            {
                return _tensachtra;
            }

            set
            {
                _tensachtra = value;
            }
        }
        public DetailVoucherBLL(int masachTra, string tensachTra)
        {
            this._masachtra = masachTra;
            this._tensachtra = tensachTra;
        }
        public DetailVoucherBLL() { }
    }
}
