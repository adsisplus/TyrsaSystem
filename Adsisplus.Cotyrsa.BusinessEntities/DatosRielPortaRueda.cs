using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosRielPortaRueda
    {
        [DataMember]
        public Int32? intRielPortaRuedaID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? intCalibreAceroID { get; set; }
        [DataMember]
        public int? intUnidadMedicionID { get; set; }
        [DataMember]
        public short? sintMonedaID { get; set; }
        [DataMember]
        public short? sintTipoCartonFlowID { get; set; }

        [DataMember]
        public Decimal? decLargo { get; set; }
        [DataMember]
        public int? intNumNivel { get; set; }
        [DataMember]
        public int? intClip { get; set; }

        [DataMember]
        public Decimal? decPaso { get; set; }

        [DataMember]
        public Int32? intCantidadRuedaRiel { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }

        [DataMember]
        public Decimal? decCostoPorRuedaUSD { get; set; }

        [DataMember]
        public Decimal? decTipoCambio { get; set; }
        [DataMember]
        public decimal? decTotalRielPartida { get; set; }
        [DataMember]
        public bool? bitPlastica { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioTotal { get; set; }
        [DataMember]
        public int? intInternacion { get; set; }
        [DataMember]
        public decimal? decCostoInternacion { get; set; }
        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
