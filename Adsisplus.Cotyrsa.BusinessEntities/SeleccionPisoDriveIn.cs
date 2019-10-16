using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionPisoDriveIn
    {
        [DataMember]
        public short? sintPisoID { get; set; }
        [DataMember]
        public decimal? decLongitud { get; set; }
        [DataMember]
        public string vchMaterial { get; set; }
        [DataMember]
        public decimal? decPesoUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public decimal? decPesoBase { get; set; }
        [DataMember]
        public decimal? decPrecioBase { get; set; }
    }
}
