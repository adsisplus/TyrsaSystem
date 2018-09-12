using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Modelo
    {
        [DataMember]
        public Int32? intModeloID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public String vchModelo { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }

    }
}
