using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Elemento
    {
        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public Int32? intSubProductoID { get; set; }
        [DataMember]
        public String vchDescripcionSub { get; set; }
        [DataMember]
        public String vchElemento { get; set; }
        [DataMember]
        public Int32? intDetElementoID { get; set; }
        [DataMember]
        public int? intTipoElementoID { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
