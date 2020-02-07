using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosEntrepanio
    {
        [DataMember]
        public int? intEntrepanioID { get; set; }

        [DataMember]
        public short? sintTipoEntrepanioID { get; set; }

        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        
        [DataMember]
        public int? intElementoID { get; set; }

        [DataMember]
        public short? sintPinturaID { get; set; }

        [DataMember]
        public int? intCalibreAceroID { get; set; }

        [DataMember]
        public int? intCantidad { get; set; }

        [DataMember]
        public bool? bitGalvanizado { get; set; }

        [DataMember]
        public bool? bitPintura { get; set; }

        [DataMember]
        public short? sintRefuerzo { get; set; }

        [DataMember]
        public decimal? decFrente { get; set; }

        [DataMember]
        public decimal? decFondo { get; set; }

        [DataMember]
        public decimal? decPesoPartida { get; set; }

        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }

        [DataMember]
        public decimal? decPrecioVenta { get; set; }

        [DataMember]
        public decimal? decPrecioFinal { get; set; }

        [DataMember]
        public decimal? decPesoTotal { get; set; }

        [DataMember]
        public decimal? decPrecioTotal { get; set; }
        
        [DataMember]
        public bool? bitActivo { get; set; }
        
        [DataMember]
        public List<SeleccionEntrepanio> seleccion { get; set; }
    }
}
