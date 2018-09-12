using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class FactorMarco
    {
        [DataMember]
        public int? sintFactorMarcoID { get; set; }
        [DataMember]
        public String vchDescCorta { get; set; }
        [DataMember]
        public String vchContanteMarco { get; set; }
        [DataMember]
        public Decimal? decCosto { get; set; }
        [DataMember]
        public DateTime? datFechaAlta { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
