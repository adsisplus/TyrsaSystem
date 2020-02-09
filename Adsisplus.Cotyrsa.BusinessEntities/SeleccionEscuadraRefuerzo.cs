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
        public decimal? decPrecioUnitario { get; set; }
    }
}
