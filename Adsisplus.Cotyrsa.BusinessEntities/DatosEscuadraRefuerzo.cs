using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosEscuadraRefuerzo
    {
        [DataMember]
        public int? intEscuadraRefID { get; set; }
        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? intCantidad { get; set; }
        [DataMember]
        public decimal? decPesoUnitario { get; set; }
        [DataMember]
        public decimal? decPesoTotal { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioTotal { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
        [DataMember]
        public List<SeleccionEscuadraRefuerzo> seleccion { get; set; } 
    }
}
