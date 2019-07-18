using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosParrilla
    {
        [DataMember]
        public Int32? intParrillaID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }
        [DataMember]
        public Int16? sintPinturaID { get; set; }
        [DataMember]
        public String vchPintura { get; set; }
        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public String vchFolio { get; set; }

        [DataMember]
        public Decimal? decFrenteParrilla { get; set; }
        [DataMember]
        public Decimal? decFondoParrilla { get; set; }
        [DataMember]
        public Decimal? decCostoParrilla { get; set; }
        [DataMember]
        public string vchTamanioCuadroParrilla { get; set; }
        [DataMember]
        public Int32? intCantidadParrilla { get; set; }

        [DataMember]
        public decimal? decPesoParrilla { get; set; }
        [DataMember]
        public bool? bitGalvanizado { get; set; }
        [DataMember]
        public bool? bitPintura { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }

        [DataMember]
        public decimal? decPrecioVentaUnitario { get; set; }

        [DataMember]
        public decimal? decPrecioVentaTotal { get; set; }
        [DataMember]
        public decimal? decCapacidadCarga { get; set; }

        [DataMember]
        public decimal? decCargaTotal { get; set; }

    }
}
