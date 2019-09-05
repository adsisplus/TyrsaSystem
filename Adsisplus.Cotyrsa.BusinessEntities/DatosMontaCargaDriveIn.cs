using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosMontaCargaDriveIn
    {
        [DataMember]
        public short? sintDriveInID { get; set; }
        [DataMember]
        public decimal? decTotal { get; set; }
        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }
        [DataMember]
        public string vchMedida { get; set; }
        [DataMember]
        public decimal? decPrecioFinal { get; set; }
        [DataMember]
        public decimal? decPrecioMasLargoTotal { get; set; }
    }
}
