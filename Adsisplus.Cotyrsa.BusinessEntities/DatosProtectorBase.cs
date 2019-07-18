using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosProtectorBase
    {
        [DataMember]
        public Int32? intProtectorPosteID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }

        [DataMember]
        public String vchFolio { get; set; }

        [DataMember]
        public Int16? sintPinturaID { get; set; }
        [DataMember]
        public String vchPintura { get; set; }

        [DataMember]
        public decimal? decPrecioUnitario { get; set; }

        [DataMember]
        public Int32? intCantidadProtectorPoste { get; set; }
       
        [DataMember]
        public Boolean? bitActivo { get; set; }

        [DataMember]
        public decimal? decAltura { get; set; }

        [DataMember]
        public short? sintLongitudID { get; set; }

        [DataMember]
        public string vchLongitud { get; set; }

        [DataMember]
        public decimal? decPrecioVentaTotal { get; set; }

        [DataMember]
        public decimal? decPrecioVentaUnitario { get; set; }

        [DataMember]
        public decimal? decPesoUnitario { get; set; }

        [DataMember]
        public decimal? decPesoTotal { get; set; }

        [DataMember]
        public decimal? decPesoxPieza { get; set; }
    }
}
