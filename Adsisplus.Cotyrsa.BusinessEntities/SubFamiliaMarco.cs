using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SubFamiliaMarco
    {
        [DataMember]
        public Int32? intSubfamiliaMarcoID { get; set; }
        [DataMember]
        public Int32? sintFondoMarcoID { get; set; }
        [DataMember]
        public Decimal? decFondoMarco { get; set; }
        [DataMember]
        public Int32? sintTipoMarcoID { get; set; }
        [DataMember]
        public String vchTipoMarcoTyrsa { get; set; }
        [DataMember]
        public String vchParte { get; set; }
        [DataMember]
        public String vchDescripcion { get; set; }
        [DataMember]
        public Decimal? decConDesperdicio { get; set; }
        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
