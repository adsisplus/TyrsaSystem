using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class RelTipoElementoAlmacenFactorCotizacion
    {
        /// <summary>
        /// ID de la relación Elemento Almacen vs Factor de Cotización
        /// </summary>
        [DataMember]
        public int intTipoElementoAlmacen_FactorID { get; set; }
        /// <summary>
        /// ID del tipo Elemento Almacen
        /// </summary>
        [DataMember]
        public int intTipoElementoAlmacenID { get; set; }
        /// <summary>
        /// ID del factor
        /// </summary>
        [DataMember]
        public short sintFactorID { get; set; }
        /// <summary>
        /// Nombre del Factor
        /// </summary>
        [DataMember]
        public string vchFactor { get; set; }
        /// <summary>
        /// Valor del factor
        /// </summary>
        [DataMember]
        public decimal decFactor { get; set; }
        /// <summary>
        /// Fecha de alta de la relación
        /// </summary>
        [DataMember]
        public DateTime datFechaAlta { get; set; }
        /// <summary>
        /// Estatus de la relación
        /// </summary>
        [DataMember]
        public bool bitActivo { get; set; }
    }
}
