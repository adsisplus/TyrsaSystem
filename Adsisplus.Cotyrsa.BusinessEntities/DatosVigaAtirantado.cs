using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosVigaAtirantado
    {
        [DataMember]
        public Int32? intVigaAtirantadoID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public string vchElemento { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public Int16? sintPinturaID { get; set; }
        [DataMember]
        public string vchPintura { get; set; }

        [DataMember]
        public Decimal? decLargo { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public decimal? decPrecioVentaUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioVentaTotal { get; set; }
        [DataMember]
        public decimal? decPesoUnitario { get; set; }
        [DataMember]
        public decimal? decPesoTotal { get; set; }
        [DataMember]
        public decimal? decLongitud { get; set; }
        [DataMember]
        public short? sintLongitudID { get; set; }
        [DataMember]
        public int? intCalibreID { get; set; }
        [DataMember]
        public string vchCalibre { get; set; }
        [DataMember]
        public decimal? decPeso { get; set; }
        [DataMember]
        public bool? bitVigaTipoCaja { get; set; }

        //[DataMember]
        //public SeleccionVigaTipoCaja seleccion { get; set; }
    }
}
