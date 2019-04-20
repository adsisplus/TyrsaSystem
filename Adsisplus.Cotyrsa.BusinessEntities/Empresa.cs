using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Empresa
    {
        [DataMember]
        public int? intEmpresaID { get; set; }
        [DataMember]
        public short? sintTipoEmpresaID { get; set; }
        [DataMember]
        public String vchTipoEmpresa { get; set; }
        [DataMember]
        public String vchNombre { get; set; }
        [DataMember]
        public String vchCorreo { get; set; }
        [DataMember]
        public String vchCorreoFacturacion { get; set; }
        [DataMember]
        public String vchCondisionesGenerales { get; set; }
        [DataMember]
        public bool? bitEsCliente { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
        [DataMember]
        public bool? bitEsProveedor { get; set; }
        /// <summary>
        /// Parametro de telefono de la empresa
        /// </summary>
        [DataMember]
        public string vchTelefono { get; set; }
        /// <summary>
        /// Parametro de RFC de la empresa
        /// </summary>
        [DataMember]
        public string vchRFC { get; set; }

        [DataMember]
        public bool? bitCausaRetencion { get; set; }
    }
}
