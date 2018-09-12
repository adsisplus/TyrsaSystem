using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosRielDinamico
    {
        [DataMember]
        public Int32? intRielDinamicoID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public Decimal? decCostoUSB { get; set; }

        [DataMember]
        public Decimal? decPesoyTarimaFondo { get; set; }

        [DataMember]
        public Decimal? decTipoCambio { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }
                
        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
