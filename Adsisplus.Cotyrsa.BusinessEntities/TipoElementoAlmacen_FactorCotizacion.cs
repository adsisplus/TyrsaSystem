using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class TipoElementoAlmacen_FactorCotizacion
    {
        [DataMember]
        public Int32? intTipoElementoAlmacen_FactorID { get; set; }

        [DataMember]
        public Int32? intTipoElementoAlmacenID { get; set; }

        [DataMember]
        public Int16? sintFactorID { get; set; }

        [DataMember]
        public DateTime? datFechaAlta { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
