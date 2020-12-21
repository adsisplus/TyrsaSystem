using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities.Catalogos
{
    /// <summary>
    /// Clase que describe las unidades de medida
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
