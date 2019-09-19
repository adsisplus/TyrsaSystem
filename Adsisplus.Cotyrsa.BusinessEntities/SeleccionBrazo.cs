using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionBrazo
    {
        [DataMember]
        public int? intSeleccionBrazoID { get; set; }
        [DataMember]
        public int? intBrazo { get; set; }
        [DataMember]
        public short? sintDriveInID { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public decimal? decLongitud { get; set; }
        [DataMember]
        public decimal? decAncho { get; set; }
        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioFinal { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
