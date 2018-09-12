using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class CotizaProducto
    {
        [DataMember]
        public int? intRelCotizaProductoID { get; set; }
        [DataMember]
        public int? intProductoGralID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public DateTime? datFechaArmado { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
