using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosTornilleria
    {
        [DataMember]
        public int? intDatoTornilleriaID { get; set; }

        [DataMember]
        public short? sintTornilleriaID { get; set; }

        [DataMember]
        public int? intElementoID { get; set; }

        [DataMember]
        public int? intCotizacionID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }

        [DataMember]
        public string vchSubMenu { get; set; }

        [DataMember]
        public string vchDescripcion { get; set; }

        [DataMember]
        public int? intCantidad { get; set; }

        [DataMember]
        public decimal? decPrecioUnitario { get; set; }

        [DataMember]
        public decimal? decTotal { get; set; }

        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
