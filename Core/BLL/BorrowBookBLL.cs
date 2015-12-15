using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BorrowBookBLL
    {
        public bool checkBookBorrowMax(ReaderBLL readerBLL)
        {
            if (CertificateDAL.getCertificateByReaderId(readerBLL.Code) !=null && CertificateDAL.getCertificateByReaderId(readerBLL.Code).Count >= 3)
            {
                return false;
            }
            return true;
        }
        public int getBookQuantityCanBorrow(ReaderBLL readerBLL)
        {
            if (CertificateDAL.getCertificateByReaderId(readerBLL.Code) != null)
            {
                    return (3 - CertificateDAL.getCertificateByReaderId(readerBLL.Code).Count);
            }
            return 3;
            
        }
        public BookTitleBLL getBookTile(int bookId)
        {
            BookBLL bookBLL = new BookBLL();
            bookBLL = BookDAL.getBookByBookId(bookId);
            if (bookBLL != null)
            {
                BookTitleBLL bookTitleBLL = new BookTitleBLL();
                return BookTitleDAL.getBookTitleItem(bookBLL.BookTitleId);
            }
            return null;
        }
        public void Add(CertificateBLL certificate, List<Int32> listBook)
        {
            CertificateDAL.insert(certificate);
            List<CertificateBLL> certificateList = CertificateDAL.getLastCertificateByReaderId(certificate.Iddocgia);
            if (certificateList != null)
            {
                foreach (Int32 bookId in listBook)
                {
                    BookBorrowDAL.Insert(bookId, certificateList[certificateList.Count-1].Idphieumuon);
                    BookDAL.changeStatus(bookId);
                }
            }
        }
    }
}
