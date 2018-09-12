using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class TipoProtector
    {
        [DataMember]
        public int? intTipoProtector { get; set; }
        [DataMember]
        public String vchDescripcionTipoElemento { get; set; }
        [DataMember]
        public int? intTipoElementoID { get; set; }
        [DataMember]
        public int? intTipoElementoAlmacenID { get; set; }
        [DataMember]
        public int? intComplementObligatorioID { get; set; }
        [DataMember]
        public String vchProtector { get; set; }
        [DataMember]
        public int? intCantidad { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
