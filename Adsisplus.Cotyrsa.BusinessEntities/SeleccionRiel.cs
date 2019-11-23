using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionRiel
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
        public int? intTotalRieles { get; set; }
        [DataMember]
        public int? intTotalRuedas { get; set; }
        [DataMember]
        public decimal? decCostoTotalRuedas { get; set; }
        [DataMember]
        public decimal? decClip { get; set; }
        [DataMember]
        public short? sintPesoPieza { get; set; }
        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public string vchLeyenda { get; set; }
        [DataMember]
        public decimal? decTotalInternacion { get; set; }
    }
}
