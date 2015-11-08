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

        
    }
}

