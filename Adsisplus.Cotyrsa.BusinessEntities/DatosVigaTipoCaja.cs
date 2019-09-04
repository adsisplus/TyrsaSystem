using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosVigaTipoCaja
    {
        [DataMember]
        public int? SKU { get; set; }
        [DataMember]
        public decimal? decPesoPieza { get; set; }
        [DataMember]
        public decimal? TOTAL { get; set; }
        [DataMember]
        public decimal? decTotal { get; set; }
    }
}
