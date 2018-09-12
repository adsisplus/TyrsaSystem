using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Catalogo
    {
        [DataMember]
        public Int32? intCatalogoID { get; set; }

        [DataMember]
        public string vchDescripcion { get; set; }

        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
