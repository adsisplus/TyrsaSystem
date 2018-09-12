using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Persona
    {
        [DataMember]
        public int? intPersonaID { get; set; }
        [DataMember]
        public int? intTipoPersonaID { get; set; }
        [DataMember]
        public String vchTipoPersona { get; set; }
        [DataMember]
        public int? intPersonaDomEmpreID { get; set; }
        [DataMember]
        public String vchPersona { get; set; }
        [DataMember]
        public String vchDomicilio { get; set; }
        [DataMember]
        public String vchEmpresa { get; set; }
        [DataMember]
        public int? intEmpresaID { get; set; }
        [DataMember]
        public String vchNombreEmpresa { get; set; }
        [DataMember]
        public string vchNombreCompleto { get; set; }
        [DataMember]
        public string vchNombre { get; set; }
        [DataMember]
        public string vchApPaterno { get; set; }
        [DataMember]
        public string vchApMaterno { get; set; }
        [DataMember]
        public DateTime? datFechaNacimiento { get; set; }
        [DataMember]
        public string vchLugarNacimiento { get; set; }
        [DataMember]
        public string vchRFC { get; set; }
        [DataMember]
        public string vchCURP { get; set; }
        [DataMember]
        public short? sintEdad { get; set; }
        [DataMember]
        public string vchTelefono { get; set; }
        [DataMember]
        public string vchTelefonoMovil { get; set; }
        [DataMember]
        public string vchMail { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
        [DataMember]
        public bool? bitCausaRetencion { get; set; }
        

    }
}

