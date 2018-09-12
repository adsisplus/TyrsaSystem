using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Protector
    {
        [DataMember]
        public int? intTipoProtector { get; set; }
        [DataMember]
        public int? intSubProductoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }
        [DataMember]
        public int? intDetElementoID { get; set; }
        [DataMember]
        public int? intTipoElementoID { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }


    }
}
