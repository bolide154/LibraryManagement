using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BookTitleBLL
    {
        private int _bookTitleId;
        private int _bookTitleStatusId;
        private int _publisherId;
        private int _typeOfBookId;
        private string _name;
        private string _summary;
        private int _reprint;

        public int Reprint
        {
            get { return _reprint; }
            set { _reprint = value; }
        }

        public int BookTitleId
        {
            get { return _bookTitleId; }
            set { _bookTitleId = value; }
        }

        public int BookTitleStatusId
        {
            get { return _bookTitleStatusId; }
            set { _bookTitleStatusId = value; }
        }

        public int PublisherId
        {
            get { return _publisherId; }
            set { _publisherId = value; }
        }

        public int TypeOfBookId
        {
            get { return _typeOfBookId; }
            set { _typeOfBookId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

        public BookTitleBLL (int bookTitleId, int bookTitleStatusId, int publisherId, int typeOfBookId, string name, string summary, int reprint){
            this._bookTitleId = bookTitleId;
            this._bookTitleStatusId = bookTitleStatusId;
            this._publisherId = publisherId;
            this._typeOfBookId = typeOfBookId;
            this._name = name;
            this._summary = summary;
            this._reprint = reprint;
        }
        public BookTitleBLL() { }

        public List<ComboboxItem> getComboboxItemTypeOfBook()
        {
            List<TypeOfBookBLL> typeOfBookList = new List<TypeOfBookBLL>();
            typeOfBookList = TypeOfBookDAL.getTypeOfBookList();
            List<ComboboxItem> comboboxItemList = new List<ComboboxItem>();
            
            for (int i = 0; i < typeOfBookList.Count; i++ )
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = typeOfBookList[i].TypeOfBookId;
                item.Text = typeOfBookList[i].Name;
                comboboxItemList.Add(item);
            }
            return comboboxItemList;
        }
        public List<ComboboxItem> getComboboxItemPublisher()
        {
            List<PublisherBLL> publisherList = new List<PublisherBLL>();
            publisherList = PublisherDAL.getPublisherList();
            List<ComboboxItem> comboboxItemList = new List<ComboboxItem>();

            for (int i = 0; i < publisherList.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = publisherList[i].PublisherId;
                item.Text = publisherList[i].Name;
                comboboxItemList.Add(item);
            }
            return comboboxItemList;
        }
        public List<ComboboxItem> getComboboxItemBookTitleStatus()
        {
            List<BookTitleStatusBLL> bookTitleStatusList = new List<BookTitleStatusBLL>();
            bookTitleStatusList = BookTitleStatusDAL.getBookTitleStatusList();
            List<ComboboxItem> comboboxItemList = new List<ComboboxItem>();

            for (int i = 0; i < bookTitleStatusList.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = bookTitleStatusList[i].BookTitleStatusId;
                item.Text = bookTitleStatusList[i].Name;
                comboboxItemList.Add(item);
            }
            return comboboxItemList;
        }

        public List<ComboboxItem> getComboboxItemAuthor()
        {
            List<AuthorBLL> authorList = new List<AuthorBLL>();
            authorList = AuthorDAL.getAuthorList();
            List<ComboboxItem> comboboxItemList = new List<ComboboxItem>();

            for (int i = 0; i < authorList.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = authorList[i].AuthorId;
                item.Text = authorList[i].Name;
                comboboxItemList.Add(item);
            }
            return comboboxItemList;
        }

        public List<ComboboxItem> getComboboxItemBookStatus()
        {
            List<BookStatusBLL> bookStatusList = new List<BookStatusBLL>();
            bookStatusList = BookStatusDAL.getBookStatusList();
            List<ComboboxItem> comboboxItemList = new List<ComboboxItem>();

            for (int i = 0; i < bookStatusList.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = bookStatusList[i].BookStatusId;
                item.Text = bookStatusList[i].Name;
                comboboxItemList.Add(item);
            }
            return comboboxItemList;
        }

        public List<AuthorBLL> getAuthor()
        {
            List<String> authorIdList = new List<string>();
            authorIdList = AuthorBookTitleDAL.getAuthorId(this);
            List<AuthorBLL> authorList = new List<AuthorBLL>();
            foreach (string authorId in authorIdList)
            {
                authorList.Add(AuthorDAL.getAuthorItem(authorId));
            }
            return authorList;
        }

        public int getAmountOfBook()
        {
            
            int totalOfBook = 0;
            List<BookBLL> bookList = new List<BookBLL>();
            
            bookList = BookDAL.getBookList(this.BookTitleId);
            
            foreach (BookBLL book in bookList)
            {
                totalOfBook++;
            }
            return totalOfBook;
        }

        public List<BookTitleBLL> search(string catalog, string key)
        {
            if (catalog == "matinhtrang")
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                List<BookTitleStatusBLL> bookTitleStatusList = new List<BookTitleStatusBLL>();
                bookTitleStatusList = BookTitleStatusDAL.getBookTitleStatusItem(key);
                if (bookTitleStatusList != null)
                {
                    foreach (BookTitleStatusBLL bookTitleStatusBLL in bookTitleStatusList)
                    {
                        List<BookTitleBLL> results = new List<BookTitleBLL>();
                        results = BookTitleDAL.getBookTitleList(catalog, bookTitleStatusBLL.BookTitleStatusId);
                        if (results != null)
                        {
                            foreach (BookTitleBLL bookTitleBLL in results)
                            {
                                bookTitleList.Add(bookTitleBLL);
                            }
                        }
                    }

                    return bookTitleList;
                }
                return null;
            }
            else if (catalog == "manxb")
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                List<PublisherBLL> publisherList = new List<PublisherBLL>();
                publisherList = PublisherDAL.getPublisherItem(key);
                if (publisherList != null)
                {
                    foreach (PublisherBLL publisherBLL in publisherList)
                    {
                        List<BookTitleBLL> results = new List<BookTitleBLL>();
                        results = BookTitleDAL.getBookTitleList(catalog, publisherBLL.PublisherId);
                        if (results != null)
                        {
                            foreach (BookTitleBLL bookTitleBLL in results)
                            {
                                bookTitleList.Add(bookTitleBLL);
                            }
                        }
                        return bookTitleList;
                    }
                }
                return null;
            }
            else if (catalog == "matheloai")
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                List<TypeOfBookBLL> typeOfBookList = new List<TypeOfBookBLL>();
                typeOfBookList = TypeOfBookDAL.getTypeOfBookItem(key);
                if (typeOfBookList != null)
                {
                    foreach (TypeOfBookBLL typeOfBookBLL in typeOfBookList)
                    {
                        List<BookTitleBLL> results = new List<BookTitleBLL>();
                        results = BookTitleDAL.getBookTitleList(catalog, typeOfBookBLL.TypeOfBookId);
                        if (results != null)
                        {
                            foreach (BookTitleBLL bookTitleBLL in results)
                            {
                                bookTitleList.Add(bookTitleBLL);
                            }
                        }
                        return bookTitleList;
                    }
                }
                return null;

            }
            else if (catalog == "tensach" || catalog == "tomtat")
            {
                List<BookTitleBLL> bookTitleList = new List<BookTitleBLL>();
                bookTitleList = BookTitleDAL.search(catalog, key);
                return bookTitleList;
            }
            return null;
        }
        public int checkCopyright(int publisherId, string bookTitleName)
        {
            List<BookTitleBLL> bookTitleList= BookTitleDAL.getBookTitleItem(bookTitleName);
            if (bookTitleList != null)
            {
                if (bookTitleList[bookTitleList.Count - 1].PublisherId == publisherId)
                {
                    //Trùng nhà xuất bản
                    return -1;
                }
                //Khác nhà xuất bản
                return 0;
            }
            //Không tìm thấy
            return 1;
        }
    }
}
