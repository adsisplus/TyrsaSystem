using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Subproducto
    {
        [DataMember]
        public int? intSubProductoID { get; set; }
        [DataMember]
        public int? intProductoGralID { get; set; }
        [DataMember]
        public String vchProductoGral { get; set; }
        [DataMember]
        public String vchDescripcionSub { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }

    }
}
