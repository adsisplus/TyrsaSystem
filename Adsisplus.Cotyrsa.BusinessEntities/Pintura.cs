using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Pintura
    {
        [DataMember]
        public Int16? sintPinturaID { get; set; }

        [DataMember]
        public String vchPintura { get; set; }

        [DataMember]
        public Decimal? decCosto { get; set; }

        [DataMember]
        public DateTime? datFechaActual { get; set; }

        [DataMember]
        public DateTime? datFechaActualizacion { get; set; }

        [DataMember]
        public Int16? sintVigencia { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
