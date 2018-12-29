using System;
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
        /// Valor del SKU
        /// </summary>
        [DataMember]
        public string vchSKU { get; set; }
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
        /// Tipo del marco
        /// </summary>
        [DataMember]
        public string vchTipo { get; set; }
        /// <summary>
        /// Material del marco
        /// </summary>
        [DataMember]
        public string vchMaterial { get; set; }
        /// <summary>
        /// Fondo del marco en metros
        /// </summary>
        [DataMember]
        public decimal? decFondo { get; set; }
        /// <summary>
        /// Altura del marco
        /// </summary>
        [DataMember]
        public decimal? decAltura { get; set; }
        /// <summary>
        /// Altura de la altura del pandeo en metros
        /// </summary>
        [DataMember]
        public decimal? decAlturaPandeo { get; set; }
        /// <summary>
        /// Capacidad por marco en kilogramos
        /// </summary>
        [DataMember]
        public decimal? decCapacidadMarco { get; set; }
    }
}
