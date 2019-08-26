using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosRielTarima
    {
        [DataMember]
        public Int32? intRielTarimaID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public Int16? sintRielTarimaID { get; set; }

        [DataMember]
        public Int16? sintPinturaID { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public short? sintTipoRielTarimaID { get; set; }
        [DataMember]
        public decimal? decCarga { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
    }
}
