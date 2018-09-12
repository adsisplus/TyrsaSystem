using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class FactorCotizacion
    {
        [DataMember]
        public Int16? sintFactorID { get; set; }

        [DataMember]
        public String vchFactor { get; set; }

        [DataMember]
        public Decimal? decFactor { get; set; }

        [DataMember]
        public DateTime? datFechaAlta { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
