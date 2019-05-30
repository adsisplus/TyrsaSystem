using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class FondoMarco
    {
        [DataMember]
        public String vchFondoMarco { get; set; }

        [DataMember]
        public Decimal? decFondoMarco { get; set; }
    }
}
