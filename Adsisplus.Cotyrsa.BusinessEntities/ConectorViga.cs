using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class ConectorViga
    {
        /// <summary>
        /// ID del conector vs Viga
        /// </summary>
        [DataMember]
        public int intConectorVigaID { get; set; }
        /// <summary>
        /// Id del calibre
        /// </summary>
        [DataMember]
        public int intCalibreID { get; set; }
        /// <summary>
        /// Nombre del calibre
        /// </summary>
        [DataMember]
        public string vchCalibre { get; set; }
        /// <summary>
        /// Valor del insumo de la viga
        /// </summary>
        [DataMember]
        public short sintInsumoViga { get; set; }
        /// <summary>
        /// Valor del insumo de la viga
        /// </summary>
        [DataMember]
        public string vchInsumoViga { get; set; }
        /// <summary>
        /// Tipo de conector
        /// </summary>
        [DataMember]
        public string vchTipoConector { get; set; }
        /// <summary>
        /// Id de la familia de la viga
        /// </summary>
        [DataMember]
        public short sintFamiliaVigaID { get; set; }
        /// <summary>
        /// Nombre de la familia de la viga
        /// </summary>
        [DataMember]
        public string vchFamiliaViga { get; set; }
        /// <summary>
        /// Tamaño del factor de acero
        /// </summary>
        [DataMember]
        public decimal decFactorAcero { get; set; }
        /// <summary>
        /// Tamaño del factor del remache
        /// </summary>
        [DataMember]
        public decimal decFactorRemache { get; set; }
        /// <summary>
        /// Numero de conector
        /// </summary>
        [DataMember]
        public int intNumeroConector { get; set; }
        /// <summary>
        /// Numero de piezas
        /// </summary>
        [DataMember]
        public int intNumeroPza { get; set; }
        /// <summary>
        /// porcentaje de desarrollo
        /// </summary>
        [DataMember]
        public decimal decDesarrollo { get; set; }
        /// <summary>
        /// Longitud
        /// </summary>
        [DataMember]
        public int intLongitud { get; set; }
        /// <summary>
        /// Descripción
        /// </summary>
        [DataMember]
        public string vchDescripcion { get; set; }
        /// <summary>
        /// Tamaño del ancho
        /// </summary>
        [DataMember]
        public decimal decAncho { get; set; }
        /// <summary>
        /// Tamañol de largo
        /// </summary>
        [DataMember]
        public decimal decLargo { get; set; }
        /// <summary>
        /// Piezas por lámina
        /// </summary>
        [DataMember]
        public int intPiezaxLamina { get; set; }
        /// <summary>
        /// Número de Piezas promedio
        /// </summary>
        [DataMember]
        public int intNumPiezaProm { get; set; }
        /// <summary>
        /// Peso por pieza
        /// </summary>
        [DataMember]
        public decimal decPesoPieza { get; set; }
        /// <summary>
        /// Peso por partida
        /// </summary>
        [DataMember]
        public decimal decPesoPartida { get; set; }
        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        public decimal decTotal { get; set; }
        /// <summary>
        /// Área de pintura
        /// </summary>
        [DataMember]
        public decimal decAreaPintura { get; set; }
        /// <summary>
        /// Número de la cara
        /// </summary>
        [DataMember]
        public int intCara { get; set; }
        /// <summary>
        /// Estatus del conector viga
        /// </summary>
        [DataMember]
        public bool bitActivo { get; set; }
    }
}
