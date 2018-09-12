using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosFreno
    {
        [DataMember]
        public Int32? intFrenoID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public Int16? sintPinturaID { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }

        [DataMember]
        public Decimal? decLargo { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
