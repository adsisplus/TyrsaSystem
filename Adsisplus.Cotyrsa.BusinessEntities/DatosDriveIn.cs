using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosDriveIn
    {
        [DataMember]
        public int? intDatosDriveInID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public short? sintPinturaID { get; set; }
        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public bool? bitEsEstructural { get; set; }
        [DataMember]
        public bool? bitDobleMonten { get; set; }
        [DataMember]
        public decimal? decFrente { get; set; }
        [DataMember]
        public decimal? decFondo { get; set; }
        [DataMember]
        public decimal? decAltura { get; set; }
        [DataMember]
        public decimal? decPeso { get; set; }
        [DataMember]
        public decimal? decAnchoMonta { get; set; }
        [DataMember]
        public decimal? decAlturaMaxima { get; set; }
        [DataMember]
        public decimal? decAlturaCanastilla { get; set; }
        [DataMember]
        public decimal? decCapacidadMaxima { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
