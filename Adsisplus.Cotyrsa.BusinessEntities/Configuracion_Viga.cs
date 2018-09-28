using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Configuracion_Viga
    {
        [DataMember]
        public short sintTipoVigaID { get; set; }
        [DataMember]
        public int intElementoID { get; set; }
        [DataMember]
        public int intCalibreID { get; set; }
        [DataMember]
        public decimal decFactorAcero { get; set; }
        [DataMember]
        public decimal decFactorRemache { get; set; }
        [DataMember]
        public decimal decFactorKgMt { get; set; }
        [DataMember]
        public short sintInsumoViga { get; set; }
        [DataMember]
        public int intNumeroViga { get; set; }
        [DataMember]
        public int intNumeroPza { get; set; }
        [DataMember]
        public decimal decDesarrollo { get; set; }
        [DataMember]
        public int intLongitud { get; set; }
        [DataMember]
        public string vchDescripcion { get; set; }
        [DataMember]
        public decimal decAncho { get; set; }
        [DataMember]
        public decimal decLargo { get; set; }
        [DataMember]
        public int intPiezaxLamina { get; set; }
        [DataMember]
        public int intNumPiezaProm { get; set; }
        [DataMember]
        public decimal decPesoPieza { get; set; }
        [DataMember]
        public decimal decPesoPartida { get; set; }
        [DataMember]
        public decimal decTotal { get; set; }
        [DataMember]
        public decimal decAreaPintura { get; set; }
        [DataMember]
        public int intCara { get; set; }
        [DataMember]
        public bool bitActivo { get; set; }
    }
}
