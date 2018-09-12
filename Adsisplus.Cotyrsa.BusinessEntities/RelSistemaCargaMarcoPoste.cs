using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class RelSistemaCargaMarcoPoste
    {
        [DataMember]
        public Int16? sintSistemaCargaMarcoID { get; set; }
        [DataMember]
        public Int32? intSubProductoID { get; set; }
        [DataMember]
        public String vchDescripcionSub { get; set; }
        [DataMember]
        public Int32? intCargaPosteID { get; set; }
        [DataMember]
        public String vchFondoTyrsaPoste { get; set; }
        [DataMember]
        public Int32? intCargaMarcoID { get; set; }
        [DataMember]
        public String vchFondoTyrsaMarco { get; set; }
        [DataMember]
        public Boolean? bitActivo { get; set; }

    }
}
