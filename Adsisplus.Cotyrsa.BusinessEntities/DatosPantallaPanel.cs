using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPantallaPanel
    {
        [DataMember]
        public int? intRackID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public short? sintPinturaID { get; set; }
        [DataMember]
        public decimal? decAnchoBus { get; set; }

        [DataMember]
        public decimal? decCapacidadCarga { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public short? sintCantidadPanelNivel { get; set; }
        [DataMember]
        public int? intCantidadPanel { get; set; }
        [DataMember]
        public string vchCalibre { get; set; }

        [DataMember]
        public SeleccionPanel panel { get; set; }
        [DataMember]
        public bool? bitGalvanizado { get; set; }
        [DataMember]
        public bool? bitPintado { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
