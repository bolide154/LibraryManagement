using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class ReaderBLL
    {
        private string _name;
        private string _code;
        private string _address;
        private string _phone;
        private string _email;
        private DateTime _allocateddate;
        private DateTime _enddate;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Code
        {
            get
            {
                return _code;
            }

            set
            {
                _code = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public DateTime Allocateddate
        {
            get
            {
                return _allocateddate;
            }

            set
            {
                _allocateddate = value;
            }
        }

        public DateTime Enddate
        {
            get
            {
                return _enddate;
            }

            set
            {
                _enddate = value;
            }
        }

        public ReaderBLL(string name, string code, string address, string phone, string email, DateTime allocateddate, DateTime enddate)
        {
            this._name = name;
            this._code = code;
            this._address = address;
            this._phone = phone;
            this._email = email;
            this._allocateddate = allocateddate;
            this._enddate = enddate;
        }
        public ReaderBLL() { }
    }
}
