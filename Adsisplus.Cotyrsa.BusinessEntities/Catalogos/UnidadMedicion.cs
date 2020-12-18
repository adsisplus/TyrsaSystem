using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities.Catalogos
{
    /// <summary>
    /// Clase que describe la unidad de medición
    /// </summary>
    [DataContract]
    public class UnidadMedicion
    {
        /// <summary>
        /// Identificador de la unidad de medición
        /// </summary>
        [DataMember]
        public int UnidadMedicionId { get; set; }
        /// <summary>
        /// Nombre de la unidad de medición.
        /// Por ejemplo Kg, MM, Mts, etc
        /// </summary>
        [DataMember]
        public string Unidad { get; set; }
        /// <summary>
        /// Indica si la unidad de medición está activa
        /// </summary>
        [DataMember]
        public bool Activo { get; set; }

    }
}
