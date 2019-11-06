using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPerfil
    {
        [DataMember]
        public Int32? intPerfilID { get; set; }
        [DataMember]
        public Int16? sintTipoPerfilID { get; set; }
        [DataMember]
        public short? sintTipoCartonFlowID { get; set; }
        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public short? sintPinturaID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? intCalibreAceroID { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public Decimal? decCapacidad { get; set; }
        [DataMember]
        public Int32? intCantidad { get; set; }
        [DataMember]
        public string vchLeyenda { get; set; }
        [DataMember]
        public decimal? decPrecioUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioTotal { get; set; }
        [DataMember]
        public decimal? decPesoUnitario { get; set; }
        [DataMember]
        public decimal? decPesoTotal { get; set; }
        [DataMember]
        public Int32? intCotizacionID { get; set; }
        [DataMember]
        public short? sintNumXNivel { get; set; }
        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
