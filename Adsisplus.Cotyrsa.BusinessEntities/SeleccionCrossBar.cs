using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionCrossBar
    {
        [DataMember]
        public int? intSeleccionCrossBarID { get; set; }

        [DataMember]
        public short? sintCrossBarID { get; set; }

        [DataMember]
        public string vchTipoCrossBar { get; set; }

        [DataMember]
        public decimal? decPrecioFinal { get; set; }

        [DataMember]
        public short? sintFactorCrossBarID { get; set; }

        [DataMember]
        public short? sintNumPieza { get; set; }

        [DataMember]
        public decimal? decDesarrollo { get; set; }

        [DataMember]
        public decimal? decLongitud { get; set; }

        [DataMember]
        public string vchMaterial { get; set; }

        [DataMember]
        public decimal? decAncho { get; set; }

        [DataMember]
        public decimal? decLargo { get; set; }

        [DataMember]
        public int? intPiezaLamina { get; set; }

        [DataMember]
        public int? intNumPiezas { get; set; }

        [DataMember]
        public short? sintPesoPieza { get; set; }

        [DataMember]
        public decimal? decPesoPartida { get; set; }

        [DataMember]
        public decimal? decPrecioAcero { get; set; }

        [DataMember]
        public decimal? decTotal { get; set; }

        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }

        [DataMember]
        public decimal? decAreaPintura { get; set; }

        [DataMember]
        public short? sintCara { get; set; }

        [DataMember]
        public int? intCantidad { get; set; }

        [DataMember]
        public decimal? decSubtotal { get; set; }

        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
