using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPantallaCrossBar
    {
        [DataMember]
        public int? intRackID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }

        [DataMember]
        public decimal? decAncho { get; set; }

        [DataMember]
        public decimal? decLargo { get; set; }

        [DataMember]
        public bool? bitConectorViga { get; set; }

        [DataMember]
        public int? intCantNivel { get; set; }

        [DataMember]
        public int? intCantidad { get; set; }

        [DataMember]
        public SeleccionCrossBar crossBar { get; set; }
    }
}
