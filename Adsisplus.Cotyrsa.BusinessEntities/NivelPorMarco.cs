using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class NivelPorMarco
    {
        [DataMember]
        public int? intNivelID { get; set; }

        [DataMember]
        public int? intSeleccionMarcoID { get; set; }

        [DataMember]
        public int? intNumeroTarima { get; set; }

        [DataMember]
        public decimal? decPeso { get; set; }

        [DataMember]
        public decimal? decTotal { get; set; }

        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
