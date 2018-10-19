using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class FactorViga
    {
        /// <summary>
        /// ID del factor de la viga
        /// </summary>
        [DataMember]
        public short? sintFactorVigaID { get; set; }
        /// <summary>
        /// Id del calibre
        /// </summary>
        [DataMember]
        public int? intCalibreID { get; set; }
        /// <summary>
        /// Calibre
        /// </summary>
        [DataMember]
        public string vchCalibre { get; set; }
        /// <summary>
        /// ID de la familia de la viga
        /// </summary>
        [DataMember]
        public short? sintFamiliaVigaID { get; set; }
        /// <summary>
        /// Nombre de la familia de la viga
        /// </summary>
        [DataMember]
        public string vchFamiliaViga { get; set; }
        /// <summary>
        /// Nombre del acero
        /// </summary>
        [DataMember]
        public string vchAcero { get; set; }
        /// <summary>
        /// Medidas del acero
        /// </summary>
        [DataMember]
        public decimal? decAcero { get; set; }
        /// <summary>
        /// Nombre del remache
        /// </summary>
        [DataMember]
        public string vchRemache { get; set; }
        /// <summary>
        /// Tamaño del remache
        /// </summary>
        [DataMember]
        public decimal? decRemache { get; set; }
        /// <summary>
        /// Peso por metro cuadrado
        /// </summary>
        [DataMember]
        public string vchKgMetroCuadrado { get; set; }
        /// <summary>
        /// peso por metro cuadrado
        /// </summary>
        [DataMember]
        public decimal? decKgMetroCuadrado { get; set; }
        /// <summary>
        /// Factor de venta
        /// </summary>
        [DataMember]
        public string vchFactorVenta { get; set; }
        /// <summary>
        /// Factor de venta
        /// </summary>
        [DataMember]
        public decimal? decFactorVenta { get; set; }
        /// <summary>
        /// Factor de despiste
        /// </summary>
        [DataMember]
        public string vchFactorDespiste { get; set; }
        /// <summary>
        /// Factor de despiste
        /// </summary>
        [DataMember]
        public decimal? decFactorDespiste { get; set; }
        /// <summary>
        /// Factor de descuento
        /// </summary>
        [DataMember]
        public string vchFactorDescuento { get; set; }
        /// <summary>
        /// Factor de descuento
        /// </summary>
        [DataMember]
        public decimal? decFactorDescuento { get; set; }
        /// <summary>
        /// Estatus del factor
        /// </summary>
        [DataMember]
        public bool bitActivo { get; set; }
    }
}
