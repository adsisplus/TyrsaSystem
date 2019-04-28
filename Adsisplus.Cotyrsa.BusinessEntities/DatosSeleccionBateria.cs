using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosSeleccionBateria
    {
        [DataMember]
        public long? SKU { get; set; }

        [DataMember]
        public int? intNumBotas { get; set; }

        [DataMember]
        public int? intNumBarras { get; set; }

        [DataMember]
        public string vchMaterial { get; set; }

        [DataMember]
        public decimal? TOTAL { get; set; }

        [DataMember]
        public int? intAltura { get; set; }
    }
}
