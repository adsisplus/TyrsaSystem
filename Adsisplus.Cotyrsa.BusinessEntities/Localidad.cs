using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Localidad
    {
        [DataMember]
        public int? intLocalidadID { get; set; }
        [DataMember]
        public int? int_MunicipioID { get; set; }
        [DataMember]
        public String vchNombre { get; set; }
        [DataMember]
        public int? intCP { get; set; }
        [DataMember]
        public String vchZona { get; set; }
    }
}
