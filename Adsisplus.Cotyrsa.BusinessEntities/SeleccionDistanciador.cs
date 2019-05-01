using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionDistanciador
    {
        [DataMember]
        public int? intSeleccionDistanciadorID { get; set; }

        [DataMember]
        public int? intRackID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }

        [DataMember]
        public string vchSKU { get; set; }
        [DataMember]
        public decimal? decAltura { get; set; }
        [DataMember]
        public decimal? decPesoKg { get; set; }
        [DataMember]
        public decimal? decPrecioTyrsa { get; set; }
        [DataMember]
        public decimal? decPrecioReferencia { get; set; }
        [DataMember]
        public decimal? decRelacionPrecio { get; set; }
        [DataMember]
        public decimal? decPrecioMetroTyrsa { get; set; }
        [DataMember]
        public decimal? decPrecioMetroRef { get; set; }
        [DataMember]
        public decimal? decPrecioKgTyrsa { get; set; }
        [DataMember]
        public decimal? decPrecioKgRef { get; set; }
        [DataMember]
        public decimal? decPesoAnguloCobro { get; set; }
        [DataMember]
        public decimal? decPesoPlacaCobro { get; set; }
        [DataMember]
        public short? sintCantidadPzaAngulo { get; set; }
        [DataMember]
        public short? sintCantidadPzaPlaca { get; set; }
        [DataMember]
        public decimal? decPesoPorDistanciador { get; set; }
        [DataMember]
        public decimal? decAreaPinturaAngulo { get; set; }
        [DataMember]
        public decimal? decAreaPinturaPlaca { get; set; }
        [DataMember]
        public decimal? decPinturaTotal { get; set; }
        [DataMember]
        public decimal? decTotalKgTotal { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
