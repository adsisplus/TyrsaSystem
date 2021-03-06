﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionMarco
    {
        /// <summary>
        /// ID de la tabla tbl_SeleccionMarco
        /// </summary>
        [DataMember]
        public int? intSeleccionMarcoID { get; set; }
        /// <summary>
        /// ID de la tabla tbl_RackSeleccion
        /// </summary>
        [DataMember]
        public int? intRackID { get; set; }
        /// <summary>
        /// ID de la cotización
        /// </summary>
        [DataMember]
        public int? intDetCotizaID { get; set; }

        [DataMember]
        public int? intDatoMarcoID { get; set; }
        /// <summary>
        /// Valor del SKU
        /// </summary>
        [DataMember]
        public string vchSKU { get; set; }
        /// <summary>
        /// ID de la configuración del Marco
        /// </summary>
        [DataMember]
        public int? intConfiguraMarcoID { get; set; }
        /// <summary>
        /// Peso del MArco en Kg
        /// </summary>
        [DataMember]
        public decimal? decPesoMarco { get; set; }
        /// <summary>
        /// Precio unitario del marco sin IVA
        /// </summary>
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        /// <summary>
        /// ID del tipo de Marco
        /// </summary>
        [DataMember]
        public int? intTipoID { get; set; }
        /// <summary>
        /// Tipo del marco
        /// </summary>
        [DataMember]
        public string vchTipo { get; set; }
        /// <summary>
        /// ID del Calibre
        /// </summary>
        [DataMember]
        public int? intMaterialID { get; set; }

        [DataMember]
        public decimal? decFondo { get; set; }

        [DataMember]
        public decimal? decAltura { get; set; }

        [DataMember]
        public decimal? decAlturaPandeo { get; set; }
        /// <summary>
        /// Material del marco
        /// </summary>
        [DataMember]
        public string vchMaterial { get; set; }
        /// <summary>
        /// Fondo del marco en metros
        /// </summary>
        [DataMember]
        public decimal? decFondoMarco { get; set; }
        /// <summary>
        /// Altura del marco
        /// </summary>
        [DataMember]
        public decimal? decAlturaMarco { get; set; }
        /// <summary>
        /// Altura de la altura del pandeo en metros
        /// </summary>
        [DataMember]
        public decimal? decAlturaPandeoRack { get; set; }
        /// <summary>
        /// Capacidad por marco en kilogramos
        /// </summary>
        [DataMember]
        public decimal? decCapacidadMarco { get; set; }
        ///// <summary>
        ///// Indica si viene o nó con doble montel
        ///// </summary>
        //public bool? bitDobleMontel { get; set; }

        [DataMember]
        public int? intNumeroNiveles { get; set; }

        [DataMember]
        public decimal? decCapacidadCargaTotal { get; set; }

        [DataMember]
        public bool? bitRolado { get; set; }

        [DataMember]
        public bool? bitEstructural { get; set; }

        [DataMember]
        public int? intCantidad { get; set; }

        [DataMember]
        public decimal? decSubtotal { get; set; }

        /// <summary>
        /// Estatus de la selección de Marco
        /// </summary>
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
