using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosCrossBar
    {
        [DataMember]
        public Int32? intDatosCrossBarID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public Int32? intDatoMarcoID { get; set; }

        [DataMember]
        public Int16? sintCantidadDatoMarco { get; set; }

        [DataMember]
        public Decimal? decAnchoCrossBar { get; set; }
        [DataMember]
        public Boolean? bitConectorVigaCrossbar { get; set; }
        [DataMember]
        public Int32? intCantidadNivelCrossbar { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
