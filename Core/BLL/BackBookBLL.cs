using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BackBookBLL
    {
        int _code;
        string _bookname;
        int _bookid;
        int _bookstt;
        Int64 _readerId;
        string _name;
        DateTime _datestart;
        DateTime _dateend;

        public int Code
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

        public DateTime Datestart
        {
            get
            {
                return _datestart;
            }

            set
            {
                _datestart = value;
            }
        }

        public DateTime Dateend
        {
            get
            {
                return _dateend;
            }

            set
            {
                _dateend = value;
            }
        }

        public long ReaderId
        {
            get
            {
                return _readerId;
            }

            set
            {
                _readerId = value;
            }
        }

        public string Bookname
        {
            get
            {
                return _bookname;
            }

            set
            {
                _bookname = value;
            }
        }

        public int Bookid
        {
            get
            {
                return _bookid;
            }

            set
            {
                _bookid = value;
            }
        }

        public int Bookstt
        {
            get
            {
                return _bookstt;
            }

            set
            {
                _bookstt = value;
            }
        }

        public BackBookBLL(int Code, string BookName,int BookId, int BookStt, Int64 ReaderId,string Name, DateTime DateStart, DateTime DateEnd)
        {
            this._code = Code;
            this._bookname = BookName;
            this._bookid = BookId;
            this._bookstt = BookStt;
            this._readerId = ReaderId;
            this._name = Name;
            this._datestart = DateStart;
            this._dateend = DateEnd;
        }
        public BackBookBLL() { }
    }
}
