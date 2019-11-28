using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPanel
    {
        [DataMember]
        public Int32? intDatosPanelID { get; set; }
        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }
        [DataMember]
        public Int32? intDatoMarcoID { get; set; }
        [DataMember]
        public Int16? sintCantidadDatoMarco { get; set; }
        [DataMember]
        public Int16? sintPinturaID { get; set; }
        [DataMember]
        public String vchPintura { get; set; }
        [DataMember]
        public Decimal? decAnchoPanel { get; set; }
        [DataMember]
        public Int32? intCantidadPanel { get; set; }
        [DataMember]
        public Decimal? decCapacidadCargaPanel { get; set; }

        [DataMember]
        public int? intPanelesTotales { get; set; }
        [DataMember]
        public int? intNiveles { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
