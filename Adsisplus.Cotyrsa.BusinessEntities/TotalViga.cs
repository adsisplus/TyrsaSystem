using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class TotalViga
    {
        [DataMember]
        public Int32? intTotalViga { get; set; }
        [DataMember]
        public Int32? intConfiguraVigaID { get; set; }
        [DataMember]
        public Decimal? decTotalConfViga { get; set; }
        [DataMember]
        public Int16? sintInsumoViga { get; set; }
        [DataMember]
        public String vchInsumoViga { get; set; }
        [DataMember]
        public String vchDescripcion { get; set; }
        [DataMember]
        public Decimal? decTotalViga { get; set; }
        [DataMember]
        public Boolean? bitActivo { get; set; }
        
    }
}
