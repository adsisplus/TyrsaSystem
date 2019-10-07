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
        public decimal? decPesoPartida { get; set; }
        [DataMember]
        public decimal? decPrecioFinal { get; set; }
    }
}
