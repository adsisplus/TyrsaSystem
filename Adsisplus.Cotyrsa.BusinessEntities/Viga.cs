using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Viga
    {
        [DataMember]
        public Int32? intConfiguraVigaID { get; set; }
        [DataMember]
        public Int16? sintTipoVigaID { get; set; }
        [DataMember]
        public String vchTipoViga { get; set; }
        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }
        [DataMember]
        public Int32 intCalibreID { get; set; }
        [DataMember]
        public String vchCalibre { get; set; }
        [DataMember]
        public Int32? intCapacidadVigaID { get; set; }
        [DataMember]
        public Decimal? decCapacidadViga { get; set; }
        [DataMember]
        public Int32? intFactorVigaID { get; set; }
        [DataMember]
        public String vchFactorViga { get; set; }
        [DataMember]
        public Decimal? decFactorViga { get; set; }
        [DataMember]
        public DateTime? datFechaAlta { get; set; }
        [DataMember]
        public Int16? sintInsumoViga { get; set; }
        [DataMember]
        public String vchInsumoViga { get; set; }
        [DataMember]
        public Decimal? decDesarrollo { get; set; }
        [DataMember]
        public Int32? intLongitud { get; set; }
        [DataMember]
        public String vchDescripcion { get; set; }
        [DataMember]
        public Decimal? decAncho { get; set; }
        [DataMember]
        public Decimal? decLargo { get; set; }
        [DataMember]
        public Int32? intPiezaxLamina { get; set; }
        [DataMember]
        public Decimal? decPesoPieza { get; set; }
        [DataMember]
        public Decimal? decPesoPartida { get; set; }
        [DataMember]
        public Decimal? decTotal { get; set; }
        [DataMember]
        public Decimal? decAreaPintura { get; set; }
        [DataMember]
        public Int32? intCara { get; set; }
        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
