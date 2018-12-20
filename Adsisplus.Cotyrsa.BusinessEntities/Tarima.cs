using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Tarima
    {
        /// <summary>
        /// Dimensión del frente de la tarima vacia en metros
        /// </summary>
        [DataMember]
        public decimal? decTarimaVaciaFrente { get; set; }
        /// <summary>
        /// Dimensión del fondo de la tarima vacía en metros
        /// </summary>
        [DataMember]
        public decimal? decTarimaVaciaFondo { get; set; }
        /// <summary>
        /// Dimensión de la altura de la tarima  vacía en metros
        /// </summary>
        [DataMember]
        public decimal? decTarimaVaciaAltura { get; set; }
        /// <summary>
        /// Peso de la tarima vacía en Kg
        /// </summary>
        [DataMember]
        public decimal? decTarimaVaciaPeso { get; set; }
        /// <summary>
        /// Dimensión del frente de la tarima con producto en metros
        /// </summary>
        [DataMember]
        public decimal? decTarimaProductoFrente { get; set; }
        /// <summary>
        /// Dimensión del fondo de la tarima con producto en metros
        /// </summary>
        [DataMember]
        public decimal? decTarimaProductoFondo { get; set; }
        /// <summary>
        /// Dimensión de la altura de la tarima con prodcuto en metros
        /// </summary>
        [DataMember]
        public decimal? decTarimaProductoAltura { get; set; }
        /// <summary>
        /// Peso de la tarima con producto en Kg
        /// </summary>
        [DataMember]
        public decimal? decTarimaProductoPeso { get; set; }
    }
}
