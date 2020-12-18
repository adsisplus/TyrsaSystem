using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities.Catalogos
{
    /// <summary>
    /// Clase que proporciona información sobre el viatico
    /// </summary>
    [DataContract]
    public class Viatico
    {
        /// <summary>
        /// Identificador del viatico
        /// </summary>
        [DataMember]
        public short ViaticoId { get; set; }


        #region Unidad de medición
        /// <summary>
        /// Identificador de la unidad de medición que es utilizada para el viatico
        /// </summary>
        [DataMember]
        public int UnidadMedicionId { get; set; }
        /// <summary>
        /// Instancia de la unidad de medición del viatico
        /// </summary>
        [DataMember]
        public UnidadMedicion UnidadMedicion { get; set; }
        #endregion

        /// <summary>
        /// Cantidades del viatico a utilizar
        /// </summary>
        [DataMember]
        public short Cantidad { get; set; }

        /// <summary>
        /// Descripción del viatico
        /// </summary>
        [DataMember]
        public string Descripcion { get; set; }

        /// <summary>
        /// Cantidad de instalaciones
        /// </summary>
        [DataMember]
        public int Instlacion { get; set; }

        /// <summary>
        /// Factor del costo del viatico
        /// </summary>
        [DataMember]
        public double Factor { get; set; }

        /// <summary>
        /// Verdadero si tiene costo
        /// </summary>
        [DataMember]
        public bool TieneCosto { get; set; }

        /// <summary>
        /// Verdadero si está activo
        /// </summary>
        [DataMember]
        public bool Activo { get; set; }

    }
}
