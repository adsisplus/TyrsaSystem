using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPrecioPoste
    {
        [DataMember]
        public int? intConfiguraMarcoID { get; set; }
        [DataMember]
        public int? intSKUID { get; set; }
        [DataMember]
        public decimal? decCalibre { get; set; }
        [DataMember]
        public decimal? decSolera { get; set; }
        [DataMember]
        public decimal? decTotalKilo { get; set; }
        [DataMember]
        public decimal? decPrecioTyrsa { get; set; }
        [DataMember]
        public decimal? decRelacionPrecios { get; set; }
        [DataMember]
        public decimal? decPrecioTyrsaMetro { get; set; }
        [DataMember]
        public decimal? decPrecioTyrsaKg { get; set; }
        [DataMember]
        public short? sintNumPosteReq { get; set; }
        [DataMember]
        public short? sintNumTravesanio { get; set; }
    }
}
