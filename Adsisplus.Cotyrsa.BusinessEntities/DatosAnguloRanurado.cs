using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosAnguloRanurado
    {
        [DataMember]
        public int? intAnguloRanuradoID {get;set;}

        [DataMember]
        public int? sintTipoAnguloRanuradoID { get; set; }

        [DataMember]
        public int? intElementoID { get; set; }
        
        [DataMember]
        public int? intCotizacionID { get; set; }

        [DataMember]
        public int? intDetCotizaID { get; set; }

        [DataMember]
        public short? sintPinturaID { get; set; }

        [DataMember]
        public int? intCantidad { get; set; }

        [DataMember]
        public decimal? decLargo { get; set; }
        
        [DataMember]
        public decimal? decCapacidadCarga { get; set; }

        [DataMember]
        public bool? bitActivo { get; set; }

        //[DataMember]
        //public short? sintMstAnguloRanuradoID { get; set; }

        //[DataMember]
        //public decimal? decDesarrollo { get; set; }

        //[DataMember]
        //public decimal? decLongitud { get; set; }

        //[DataMember]
        //public decimal? decAncho { get; set; }

        //[DataMember]
        //public string vchMaterial { get; set; }

        //[DataMember]
        //public decimal? decPesoUnitario { get; set; }

        //[DataMember]
        //public decimal? decPrecioUnitario { get; set; }

        //[DataMember]
        //public Boolean? bitActivo { get; set; }
        [DataMember]
        public SeleccionAnguloRanurado seleccion { get; set; }
    }
}
