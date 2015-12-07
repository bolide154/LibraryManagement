using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class AspectCertificateBLL
    {
        int _certificateId;
        string _nameAspect;
        public int CertificateId
        {
            get { return _certificateId; }
            set { _certificateId = value; }
        }
        public string Name
        {
            get { return _nameAspect; }
            set { _nameAspect = value; }
        }
        public AspectCertificateBLL(int certificateId, string nameAspect)
        {
            this._certificateId = certificateId;
            this._nameAspect = nameAspect;
        }
        public AspectCertificateBLL() { }
    }
}
