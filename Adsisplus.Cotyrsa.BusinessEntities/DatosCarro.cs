using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosCarro
    {
        [DataMember]
        public Int32? intCarroID { get; set; }

        [DataMember]
        public Int16? sintNumeroCarroID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public Boolean? bitUltimoCarro { get; set; }

        [DataMember]
        public Decimal? decFrenteTarima { get; set; }

        [DataMember]
        public Decimal? decFondoTarima { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }

        [DataMember]
        public Decimal? decPeso { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
