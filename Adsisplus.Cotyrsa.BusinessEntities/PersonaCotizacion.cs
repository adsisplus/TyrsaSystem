using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public  class PersonaCotizacion
    {
        [DataMember]
        public int? intPersonaCotizaID { get; set; }
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intPersonaID { get; set; }
        [DataMember]
        public int? intPersonalidadID { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
