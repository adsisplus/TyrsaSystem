using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class TipoMarco
    {
        [DataMember]
        public int? sintTipoMarcoID { get; set; }
        [DataMember]
        public String vchSeccionPoste { get; set; }
        [DataMember]
        public String vchTipoMarcoTyrsa { get; set; }
        [DataMember]
        public String vchTipoMarcoMercadoA { get; set; }
        [DataMember]
        public String vchTipoMarcoMercadoB { get; set; }
        [DataMember]
        public Decimal? decPosteDesarrollo { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }

    }
}
