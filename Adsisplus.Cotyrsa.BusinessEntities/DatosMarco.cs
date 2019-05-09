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
        public int? intDatoMarcoID { get; set; }

        [DataMember]
        public int? intCotizacionID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }

        //[DataMember]
        //public string vchFolio { get; set; }

        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public string vchElemento { get; set; }

        [DataMember]
        public short? sintPinturaID { get; set; }
        [DataMember]
        public string vchPintura { get; set; }

        //[DataMember]
        //public Decimal? decMedidaFondo { get; set; }

        //[DataMember]
        //public Decimal? decMedidaAlto { get; set; }

        //[DataMember]
        //public Boolean? bitDobleMonten { get; set; }

        //[DataMember]
        //public Int32? intNumeroNivelSobreViga { get; set; }

        //[DataMember]
        //public Decimal? decCapacidadxNivel { get; set; }

        [DataMember]
        public short? sintCantidad { get; set; }

        [DataMember]
        public decimal? decAlturaPandeo { get; set; }

        [DataMember]
        public decimal? decAltura { get; set; }

        [DataMember]
        public decimal? decFondo { get; set; }

        [DataMember]
        public bool? bitActivo { get; set; }

        //[DataMember]
        //public int? intConfiguraMarcoID { get; set; }

    }
}
