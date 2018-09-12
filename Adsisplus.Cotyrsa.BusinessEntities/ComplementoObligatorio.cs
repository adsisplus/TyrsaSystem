using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class ComplementoObligatorio
    {
        [DataMember]
        public Int32? intComplementObligatorioID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public DateTime? datFechaAlta { get; set; }

        [DataMember]
        public DateTime? datFechaActualizacion { get; set; }

        [DataMember]
        public Int32? intVigencia { get; set; }

        [DataMember]
        public String vchDescripcionComplemento { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }

        [DataMember]
        public Decimal? decPrecioUnitario { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
