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
        /// ID de la tabla tbl_Tarima
        /// </summary>
        [DataMember]
        public int? intTarimaID { get; set; }
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

    }
}
