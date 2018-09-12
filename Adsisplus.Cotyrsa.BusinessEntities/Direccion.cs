using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Direccion
    {
        [DataMember]
        public int? intDireccionID { get; set; }
        [DataMember]
        public int? intMunicipioID { get; set; }
        [DataMember]
        public String vchMunicipio { get; set; }
        [DataMember]
        public int? intEstadoID { get; set; }
        [DataMember]
        public String vchEstado { get; set; }
        [DataMember]
        public int? intLocalidadID { get; set; }
        [DataMember]
        public String vchLocalidad { get; set; }
        [DataMember]
        public String vchDomicilio { get; set; }
        [DataMember]
        public int? intTipoDomicilioID { get; set; }
        [DataMember]
        public String vchTipoDomicilio { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string vchCalle { get; set; }
        [DataMember]
        public string vchNumExterior { get; set; }
        [DataMember]
        public string vchNumInterior { get; set; }
        [DataMember]
        public string vchColonia { get; set; }
        [DataMember]
        public string vchCP { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
       

    }
}

