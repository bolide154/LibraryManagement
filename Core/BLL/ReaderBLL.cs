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
        private Int64 _code;
        private string _address;
        private string _phone;
        private string _email;
        private DateTime _birthday;
        private DateTime _allocateddate;
        private DateTime _enddate;
        private bool _isStaff;
        private int _granduation;
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

        public Int64 Code
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

        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }

            set
            {
                _birthday = value;
            }
        }

        public bool IsStaff
        {
            get
            {
                return _isStaff;
            }

            set
            {
                _isStaff = value;
            }
        }
        public int Granduation
        {
            get { return _granduation; }
            set { _granduation = value; }
        }

        public ReaderBLL(string name, Int64 code, string address, string phone, string email, DateTime allocateddate, DateTime enddate, DateTime birthday, bool staff, int granduation)
        {
            this._name = name;
            this._code = code;
            this._address = address;
            this._phone = phone;
            this._email = email;
            this._allocateddate = allocateddate;
            this._enddate = enddate;
            this._birthday = birthday;
            this._isStaff = staff;
            this._granduation = granduation;
        }
        public ReaderBLL() { }
    }
}
