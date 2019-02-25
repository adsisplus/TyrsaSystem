using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosMarco
    {
        [DataMember]
        public Int32? intDatoMarcoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }

        [DataMember]
        public String vchFolio { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public Int16? sintPinturaID { get; set; }
        [DataMember]
        public String vchPintura { get; set; }

        [DataMember]
        public Decimal? decMedidaFondo { get; set; }

        [DataMember]
        public Decimal? decMedidaAlto { get; set; }

        [DataMember]
        public Boolean? bitDobleMonten { get; set; }

        [DataMember]
        public Int32? intNumeroNivelSobreViga { get; set; }

        [DataMember]
        public Decimal? decAlturaPandeo { get; set; }

        [DataMember]
        public Decimal? decCapacidadxNivel { get; set; }

        [DataMember]
        public Int16? sintCantidad { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }

        [DataMember]
        public int? intConfiguraMarcoID { get; set; }

    }
}
