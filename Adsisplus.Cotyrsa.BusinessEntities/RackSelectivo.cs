using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class RackSelectivo
    {
        /// <summary>
        /// ID de la tabla tbl_Rack_Selectivo
        /// </summary>
        [DataMember]
        public int? intRackID { get; set; }
        /// <summary>
        /// ID de la tabla tbl_SeleccionViga
        /// </summary>
        [DataMember]
        public int? intSeleccionVigaID { get; set; }
        /// <summary>
        /// ID de la tabla tbl_SeleccionMarco
        /// </summary>
        [DataMember]
        public int? intSeleccionMarcoID { get; set; }
        /// <summary>
        /// ID de la tabla tbl_DET_Cotizacion
        /// </summary>
        [DataMember]
        public int? intCotizacionID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }
        /// <summary>
        /// ID de la relación de la tabla de producto cotización
        /// </summary>
        [DataMember]
        public int? intRelCotizaProductoID { get; set; }
        /// <summary>
        /// Id del producto a cotizar
        /// </summary>
        [DataMember]
        public int? intProductoGralID { get; set; }
        /// <summary>
        /// Id del subproducto a cotizar
        /// </summary>
        [DataMember]
        public int? intSubProductoID { get; set; }

        /// <summary>
        /// Número de tarimas por nivel
        /// </summary>
        [DataMember]
        public int? intNumTarimaNivel { get; set; }
        /// <summary>
        /// Valor de la longitud del frente de la tarima con producto
        /// </summary>
        [DataMember]
        public decimal? decFrente { get; set; }
        /// <summary>
        /// Valor de la longitud del fondo de la tarima con producto
        /// </summary>
        [DataMember]
        public decimal? decFondo { get; set; }
        /// <summary>
        /// Valor de la longitud de la altura de la tarima con producto
        /// </summary>
        [DataMember]
        public decimal? decAltura { get; set; }
        /// <summary>
        /// Valor del peso de la tarima con producto
        /// </summary>
        [DataMember]
        public decimal? decPeso { get; set; }

        [DataMember]
        public bool? bitMontacarga { get; set; }

        [DataMember]
        public string vchDimensionMontacarga { get; set; }

        [DataMember]
        public int? intPosicion { get; set; }

        [DataMember]
        public short? sintVisitas { get; set; }


        #region Datos para la Viga

        /// <summary>
        /// Longitud de la viga
        /// </summary>
        [DataMember]
        public decimal? decLongitudViga { get; set; }
        /// <summary>
        /// Capacidad de carga requerida por viga
        /// </summary>
        [DataMember]
        public decimal? decCapCargaReqViga { get; set; }
        /// <summary>
        /// Indica si es (= 1) o no (= 0) una tarima estructural 
        /// </summary>
        [DataMember]
        public bool? bitEstructural { get; set; }
        /// <summary>
        /// Indica si sobresale (=1) o no (=0) la viga
        /// </summary>
        [DataMember]
        public bool? bitSobresale { get; set; }
        /// <summary>
        /// Valor de la distancia que sobresale  el producto sobre la viga
        /// </summary>
        [DataMember]
        public decimal? decDistanciaLargoProducto { get; set; }
        /// <summary>
        /// Indica el tipo de opción seleccionada por el cliente
        /// </summary>
        [DataMember]
        public short? tinOpcionViga { get; set; }

        [DataMember]
        public int? intNumeroTarimaPorNivel { get; set; }

        [DataMember]
        public int? intCantidadVigas { get; set; }

        [DataMember]
        public short? sintPinturaID { get; set; }
        #endregion

        #region Datos para el Marco
        /// <summary>
        /// Fondo del Marco
        /// </summary>
        [DataMember]
        public decimal? decFondoMarco { get; set; }
        /// <summary>
        /// Altura del marco
        /// </summary>
        [DataMember]
        public decimal? decAlturaMarco { get; set; }
        /// <summary>
        /// Indica la opción seleccionada por el cliente
        /// </summary>
        [DataMember]
        public short? tinOpcionMarco { get; set; }

        [DataMember]
        public decimal? decNNSV { get; set; }

        [DataMember]
        public decimal? decMargenExcedente { get; set; }

        [DataMember]
        public decimal? decAlturaPiso { get; set; }

        [DataMember]
        public decimal? decNPVS { get; set; }

        [DataMember]
        public decimal? decNNSVS { get; set; }

        [DataMember]
        public decimal? decNNPVS { get; set; }

        /// <summary>
        /// Numeros de Niveles sobre vigas
        /// </summary>
        [DataMember]
        public int? intNumeroNivelSobreViga { get; set; }
        /// <summary>
        /// Dimension del Claro
        /// </summary>
        [DataMember]
        public decimal? decDimensionClaro { get; set; }
        /// <summary>
        /// Número total de tarimas almacenadas sobre vigas en un
        /// Modulo por el Peso de cada tarima llena
        /// </summary>
        [DataMember]
        public decimal? decCargaModulo { get; set; }
        /// <summary>
        /// Es la altura desde el piso hasta la parte superior de la viga
        /// más cercana al piso(primer nivel de vigas). En metros
        /// </summary>
        [DataMember]
        public decimal? decAlturaPandeo { get; set; }
        #endregion


        [DataMember]
        public bool? bitActivo { get; set; }

    }
}
