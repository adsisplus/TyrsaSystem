using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosViaticos
    {
        [DataMember]
        public int? intDatoViaticoID { get; set; }
        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public short? sintViaticoID { get; set; }
        [DataMember]
        public int? intCantidad { get; set; }
        [DataMember]
        public DateTime? datFecha { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
