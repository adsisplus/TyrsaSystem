using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosFlete
    {
        [DataMember]
        public int? intDatoFleteID { get; set; }
        [DataMember]
        public short? sintFleteID { get; set; }
        [DataMember]
        public int? sintTipoUnidadFleteID { get; set; }
        [DataMember]
        public short? sintDestinoFleteID { get; set; }
        [DataMember]
        public string vchDestinoFlete { get; set; }
        [DataMember]
        public string vchTipoUnidad { get; set; }
        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? intCantidad { get; set; }
        [DataMember]
        public DateTime? datFechaCarga { get; set; }
        [DataMember]
        public DateTime? datFechaDescarga { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
