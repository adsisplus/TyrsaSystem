using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosProtectorBateria
    {
        [DataMember]
        public Int32? intProtectorBateriaID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public String vchFolio { get; set; }

        [DataMember]
        public Int32? intCantidadSencilla { get; set; }
        [DataMember]
        public Int32? intCantidadDoble { get; set; }

        [DataMember]
        public int? intCantidadTriple { get; set; }

        [DataMember]
        public Int32? intCantidadCuadruple { get; set; }

        [DataMember]
        public decimal? decPrecioSencilla { get; set; }

        [DataMember]
        public decimal? decPrecioDoble { get; set; }

        [DataMember]
        public decimal? decPrecioTriple { get; set; }

        [DataMember]
        public decimal? decPrecioCuadruple { get; set; }

        [DataMember]
        public decimal? decLargoSencilla { get; set; }

        [DataMember]
        public decimal? decLargoDoble { get; set; }

        [DataMember]
        public decimal? decLargoTriple { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
