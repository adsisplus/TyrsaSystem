using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPerfilCartonFlow
    {
        [DataMember]
        public short? sintTipoCartonFlowID { get; set; }
        [DataMember]
        public short? sintCalibre { get; set; }
        [DataMember]
        public string vchTipoCartonFlow { get; set; }
        [DataMember]
        public decimal? decAncho { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public short? sintPesoPieza { get; set; }
        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public string vchLeyenda { get; set; }
    }
}
