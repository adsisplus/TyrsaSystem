﻿using System;
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
        /// ID del registro de la tabla
        /// </summary>
        [DataMember]
        public int? intTarimaID { get; set; }
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
    }
}
