using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosCartonFlow
    {
        [DataMember]
        public int? intDatosCartonFlowID { get; set; }
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public short? sintPinturaID { get; set; }
        [DataMember]
        public short? sintTipoCartonFlowID { get; set; }
        [DataMember]
        public int? intCalibreAceroID { get; set; }
        [DataMember]
        public short? sintMonedaID { get; set; }
        [DataMember]
        public short? intUnidadMedicionID { get; set; }
        [DataMember]
        public decimal? decFrente { get; set; }
        [DataMember]
        public decimal? decFondo { get; set; }
        [DataMember]
        public decimal? decAltura { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        //[DataMember]
        //public short? sintCantidadRiel { get; set; }
        //[DataMember]
        //public decimal? decClip { get; set; }
        //[DataMember]
        //public int? intInternacion { get; set; }
        //[DataMember]
        //public decimal? decCostoInternacion { get; set; }
        //[DataMember]
        //public decimal? decTotalInternacion { get; set; }
        //[DataMember]
        //public int? intTotalRuedas { get; set; }
        //[DataMember]
        //public int? intTotalRieles { get; set; }
        //[DataMember]
        //public decimal decPrecioRuedas { get; set; }
        //[DataMember]
        //public decimal? decTipoCambio { get; set; }
        //[DataMember]
        //public decimal? decCostoTotalRuedas { get; set; }
        [DataMember]
        public decimal? decPeso { get; set; }
        [DataMember]
        public decimal? decPesoUnitario { get; set; }
        [DataMember]
        public decimal? decPesoTotal { get; set; }
        [DataMember]
        public int? intNumCajaNivel { get; set; }
        [DataMember]
        public decimal? decPesoNivel { get; set; }
        [DataMember]
        public int? intNumNivel { get; set; }
        [DataMember]
        public int? intCantRefuerzoNivel { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioTotal { get; set; }

        [DataMember]
        public int? intNumCajaFrente { get; set; }

        [DataMember]
        public int? intNumCajaFondo { get; set; }
        //[DataMember]
        //public string vchLeyenda { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
        //[DataMember]
        //public SeleccionRiel riel { get; set; }
    }
}
