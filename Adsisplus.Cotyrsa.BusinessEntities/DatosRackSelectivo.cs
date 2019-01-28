using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosRackSelectivo
    {
        // DATOS DEL RACK
        /// <summary>
        /// ID de la tabla tbl_Rack_Selectivo
        /// </summary>
        [DataMember]
        public int? intRackID { get; set; }
        /// <summary>
        /// ID de la tabla tbl_DET_Cotizacion
        /// </summary>
        [DataMember]
        public int? intDetCotizaID { get; set; }
        /// <summary>
        /// ID de la tabla tbl_SeleccionViga
        /// </summary>
        [DataMember]
        public int? intSeleccionVigaID { get; set; }
        /// <summary>
        /// Número de tarimas por nivel
        /// </summary>
        [DataMember]
        public int? intNumTarimaNivel { get; set; }
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
        /// Indica si la viga es estructural
        /// </summary>
        [DataMember]
        public bool? bitEstructural { get; set; }
        /// <summary>
        /// Indica la distancia que sobre sale el producto de la tarima
        /// </summary>
        [DataMember]
        public decimal? decDistanciaLargoProducto { get; set; }
        /// <summary>
        /// Indica si el producto sobresale de la viga
        /// </summary>
        [DataMember]
        public bool? bitSobresale { get; set; }

        // DATOS DE TARIMA
        /// <summary>
        /// Dimensión del frente de la tarima vacia en metros
        /// </summary>
        [DataMember]
        public decimal? decFrente { get; set; }
        /// <summary>
        /// Dimensión del fondo de la tarima vacía en metros
        /// </summary>
        [DataMember]
        public decimal? decFondo { get; set; }
        /// <summary>
        /// Dimensión de la altura de la tarima  vacía en metros
        /// </summary>
        [DataMember]
        public decimal? decAltura { get; set; }
        /// <summary>
        /// Peso de la tarima vacía en Kg
        /// </summary>
        [DataMember]
        public decimal? decPeso { get; set; }

        // DATOS SELECCIÓN VIGA
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
        /// ID correspondiente al tipo
        /// </summary>
        [DataMember]
        public int? intTipoID { get; set; }
        /// <summary>
        /// Tipo de VIga
        /// </summary>
        [DataMember]
        public string vchTipo { get; set; }
        /// <summary>
        /// ID correspondiente al Material
        /// </summary>
        [DataMember]
        public int? intMaterialID { get; set; }
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
        /// Estatus
        /// </summary>
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
