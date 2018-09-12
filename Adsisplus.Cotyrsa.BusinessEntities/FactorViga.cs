using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class FactorViga
    {
        [DataMember]
        public Int32? intFactorVigaID { get; set; }

        [DataMember]
        public String vchFactorViga { get; set; }

        [DataMember]
        public Decimal? decFactorViga { get; set; }

        [DataMember]
        public DateTime? datFechaAlta { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
