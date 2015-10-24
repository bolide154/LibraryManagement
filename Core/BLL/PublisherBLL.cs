using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class PublisherBLL
    {
        private int publisherId;
        private string name;
        private string phone;
        private string address;

        public int PublisherId
        {
            get { return publisherId; }
            set { publisherId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public PublisherBLL(int _publisherId, string _name, string _phone, string _address)
        {
            this.publisherId = _publisherId;
            this.name = _name;
            this.phone = _phone;
            this.address = _address;
        }

        public PublisherBLL() { }

        public List<PublisherBLL> LoadPublisherList()
        {
            List<PublisherBLL> publisherArr = new List<PublisherBLL>();
            PublisherDAL publisherDAL = new PublisherDAL();
            DataTable dtPublisher = new DataTable();
            dtPublisher = publisherDAL.LoadPublisherList();
            foreach (DataRow row in dtPublisher.Rows)
            {
                PublisherBLL publisherBLL = new PublisherBLL();
                publisherBLL.PublisherId = Int32.Parse(row["manxb"].ToString());
                publisherBLL.Name = row["tennxb"].ToString();
                publisherBLL.Phone = row["sdtnxb"].ToString();
                publisherBLL.Address = row["diachinxb"].ToString();
                publisherArr.Add(publisherBLL);
            }
            return publisherArr;
        }



    }
}
