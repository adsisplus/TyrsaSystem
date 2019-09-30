using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionBarandal
    {
        [DataMember]
        public int? intSeleccionBarandalID { get; set; }
        [DataMember]
        public short? sintTipoVigaBarandalID { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public decimal? decPesoUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
    }
}
