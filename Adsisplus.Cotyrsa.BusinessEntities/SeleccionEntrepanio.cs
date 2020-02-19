using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionEntrepanio
    {
        [DataMember]
        public int? intSeleccionEntrepanioID { get; set; }
        [DataMember]
        public int? intEntrepanioID { get; set; }
        [DataMember]
        public string vchCalibreAcero { get; set; }
        [DataMember]
        public decimal? decFondo { get; set; }
        [DataMember]
        public decimal? decFrente { get; set; }
        [DataMember]
        public short? sintNumRefuerzo { get; set; }
        [DataMember]
        public int? intCapCargaXEntrepanio { get; set; }
        [DataMember]
        public decimal? decDesarrollo { get; set; }
        [DataMember]
        public decimal? decLongitud { get; set; }
        [DataMember]
        public string vchMaterial { get; set; }
        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioFinal { get; set; }

        [DataMember]
        public decimal? decPesoTotal { get; set; }
        [DataMember]
        public decimal? decPrecioTotal { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
