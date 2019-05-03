using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPantallaDistanciador
    {
        [DataMember]
        public short? sintPinturaID { get; set; }

        [DataMember]
        public decimal? decAltura { get; set; }

        [DataMember]
        public int? intCantidad { get; set; }

        [DataMember]
        public decimal? decLargo { get; set; }

        [DataMember]
        public SeleccionDistanciador distanciador { get; set; }
    }
}
