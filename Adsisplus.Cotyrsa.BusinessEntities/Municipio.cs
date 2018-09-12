using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public  class Municipio
    {
        [DataMember]
        public int? intMunicipioID { get; set; }
        [DataMember]
        public int? intNumero_Mpio { get; set; }
        [DataMember]
        public int? intEstadoID { get; set; }
        [DataMember]
        public String vchEstado { get; set; }
        [DataMember]
        public String vchNombre { get; set; }
    }
}
