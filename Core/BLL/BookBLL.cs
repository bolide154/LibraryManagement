using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BookBLL
    {
        private int _bookId;
        private int _bookTitleId;
        private int _bookStatusId;

        public int BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        public int BookTitleId
        {
            get { return _bookTitleId; }
            set { _bookTitleId = value; }
        }

        public int BookStatusId
        {
            get { return _bookStatusId; }
            set { _bookStatusId = value; }
        }

        public BookBLL(int bookId, int bookTitleId, int bookStatusId)
        {

        }

        public BookBLL() { }

    }
}
