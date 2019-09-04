using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DriveIn
    {
        [DataMember]
        public int? intCapacidadVigaID { get; set; }
        [DataMember]
        public string vchTipoViga { get; set; }
        [DataMember]
        public string vchLongitud { get; set; }
        [DataMember]
        public string vchCalibre { get; set; }
        [DataMember]
        public int? intLargo { get; set; }
        [DataMember]
        public decimal? decCargaKg { get; set; }
        [DataMember]
        public decimal? decCargaLbs { get; set; }
        [DataMember]
        public decimal? decCoeficienteSeguridad { get; set; }
        [DataMember]
        public DateTime? datFechaAlta { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
