using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionViga
    {
        /// <summary>
        /// Id de la viga seleccionada
        /// </summary>
        public int? intSeleccionVigaID { get; set; }
        /// <summary>
        /// Id del tipo de Viga
        /// </summary>
        public short? sintTipoVigaID { get; set; }
        /// <summary>
        /// Valor de SKU
        /// </summary>
        [DataMember]
        public int? SKU { get; set; }
        /// <summary>
        /// Valor del peso de la viga en Kg
        /// </summary>
        [DataMember]
        public decimal? decPesoViga { get; set; }
        /// <summary>
        /// Precio unitario de la viga sin IVA
        /// </summary>
        [DataMember]
        public decimal? decPrecioUnitarioSinIVA { get; set; }
        /// <summary>
        /// Tipo de VIga
        /// </summary>
        [DataMember]
        public string vchTipo { get; set; }
        /// <summary>
        /// Material de la viga
        /// </summary>
        [DataMember]
        public string vchMaterial { get; set; }
        /// <summary>
        /// Patín en pulgadas
        /// </summary>
        [DataMember]
        public decimal? decPatin { get; set; }
        /// <summary>
        /// Peralte en pulgadas
        /// </summary>
        [DataMember]
        public decimal? decPeralte { get; set; }
        /// <summary>
        /// Longitud en metros
        /// </summary>
        [DataMember]
        public decimal? decLongitud { get; set; }
        /// <summary>
        /// Capacidad par vigas requerida en kilogramos
        /// </summary>
        [DataMember]
        public decimal? decCapacidadParVigasRequerida { get; set; }
        /// <summary>
        /// Capacidad par vigas maxima en kilogramos
        /// </summary>
        [DataMember]
        public decimal? decCapacidadParVigasMaxima { get; set; }
        /// <summary>
        /// Indica el resultado de la consulta
        /// </summary>
        [DataMember]
        public string vchResultado { get; set; }
        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        public decimal? decTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int? intLargo { get; set; }
        /// <summary>
        /// ID de la longitud
        /// </summary>
        [DataMember]
        public short? sintLongitudID { get; set; }
    }
}
