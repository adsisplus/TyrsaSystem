using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class RelPersonaDomicilioEmpresa
    {
        /// <summary>
        /// ID de la tabla principal
        /// </summary>
        [DataMember]
        public int intPersonaDomEmpreID { get; set; }
        /// <summary>
        /// ID de la persona
        /// </summary>
        [DataMember]
        public int intPersonaID { get; set; }
        /// <summary>
        /// ID del domicilio
        /// </summary>
        [DataMember]
        public int intDireccionID { get; set; }
        /// <summary>
        /// ID de la Empresa
        /// </summary>
        [DataMember]
        public int intEmpresaID { get; set; }
        /// <summary>
        /// Estatus de la relación persona, dirección y empresa
        /// </summary>
        [DataMember]
        public bool bitActivo { get; set; }
    }
}
