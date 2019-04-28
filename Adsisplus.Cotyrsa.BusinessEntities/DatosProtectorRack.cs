using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosProtectorRack
    {
        [DataMember]
        public string vchTipoProtector { get; set; }

        [DataMember]
        public decimal? decPrecioFinal { get; set; }

    }
}
