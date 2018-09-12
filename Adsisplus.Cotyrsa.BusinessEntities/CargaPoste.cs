using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class CargaPoste
    {
        [DataMember]
        public Int32? intCargaPosteID { get; set; }
        [DataMember]
        public Int16? sintTipoMarcoID { get; set; }
        [DataMember]
        public String vchTipoMarcoTyrsa { get; set; }
        [DataMember]
        public Int16? intCalibreAceroID { get; set; }
        [DataMember]
        public String vchCalibreAcero { get; set; }
        [DataMember]
        public String vchFrenteTyrsa { get; set; }
        [DataMember]
        public String vchFrenteMercadoA { get; set; }
        [DataMember]
        public String vchFrenteMercadoB { get; set; }
        [DataMember]
        public String vchFondoTyrsa { get; set; }
        [DataMember]
        public String vchFondoMercadoA { get; set; }
        [DataMember]
        public String vchFondoMercadoB { get; set; }
        [DataMember]
        public Decimal? decAlturaPandeoM { get; set; }
        [DataMember]
        public Int32? intAlturaPandeoIN { get; set; }
        [DataMember]
        public Int32? intCapacidadPeso { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
