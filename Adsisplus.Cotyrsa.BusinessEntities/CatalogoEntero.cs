using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class CatalogoEntero
    {
        [DataMember]
        public Int32? intCatalogoID { get; set; }

        [DataMember]
        public Int32? intValor { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
