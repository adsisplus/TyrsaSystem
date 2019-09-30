using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosBarandal
    {
        [DataMember]
        public int? intDatosBarandalID { get; set; }
        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public short? sintPinturaID { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public decimal? decCantidad { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioTotal { get; set; }
        [DataMember]
        public decimal? decPesoTotal { get; set; }
        [DataMember]
        public SeleccionBarandal seleccion { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
