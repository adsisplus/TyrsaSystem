using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionEscuadraRefuerzo
    {
        [DataMember]
        public int? intSeleccionEscuadraID { get; set; }
        [DataMember]
        public int? intEscuadraRefID { get; set; }
        [DataMember]
        public short? sintEscuadraRefuerzoID { get; set; }
        [DataMember]
        public decimal? decDesarrollo { get; set; }
        [DataMember]
        public decimal? decLongitud { get; set; }
        [DataMember]
        public decimal? decAncho { get; set; }
        [DataMember]
        public string vchMaterial { get; set; }
        [DataMember]
        public decimal? decPesoUnitario { get; set; }
        [DataMember]
        public decimal? decPesoTotal { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioTotal { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
