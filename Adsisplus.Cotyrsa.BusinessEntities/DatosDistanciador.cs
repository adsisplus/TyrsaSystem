using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosDistanciador
    {
        [DataMember]
        public Int32? intDistanciadorID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public String vchFolio { get; set; }

        [DataMember]
        public Int32? intCantidadDistanciador { get; set; }
        [DataMember]
        public Decimal? decLargoDistanciador { get; set; }
        
        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
