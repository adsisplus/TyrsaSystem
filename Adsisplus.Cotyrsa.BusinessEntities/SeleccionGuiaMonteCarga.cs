using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionGuiaMonteCarga
    {
        [DataMember]
        public int? intSeleccionGuiaMontaCargaID { get; set; }
        [DataMember]
        public int? intGuiaEntradaID { get; set; }
        [DataMember]
        public decimal? decTotal { get; set; }
        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }
        [DataMember]
        public string vchMedida { get; set; }
        [DataMember]
        public decimal? decPrecioFinal { get; set; }
        [DataMember]
        public decimal? decPrecioMasLargoTotal { get; set; }
        [DataMember]
        public int? intCantidad { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
