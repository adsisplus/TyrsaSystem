using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class CapacidadViga
    {
        [DataMember]
        public Int32? intCapacidadVigaID { get; set; }

        [DataMember]
        public Int16? sintTipoVigaID { get; set; }

        [DataMember]
        public String vchTipoViga { get; set; }
        
        [DataMember]
        public Int16? sintLongitudID { get; set; }
        [DataMember]
        public String vchLongitud { get; set; }

        [DataMember]
        public Int32? intCalibreID { get; set; }

        [DataMember]
        public String vchCalibre { get; set; }

        [DataMember]
        public Int16? sintLargoID { get; set; }

        [DataMember]
        public Int32? intLargo { get; set; }

        [DataMember]
        public Decimal? decCargaKg { get; set; }

        [DataMember]
        public Decimal? decCargaLbs { get; set; }

        [DataMember]
        public Decimal? decCoeficienteSeguridad { get; set; }

        [DataMember]
        public DateTime? datFechaAlta { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
