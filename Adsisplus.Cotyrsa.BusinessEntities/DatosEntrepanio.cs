using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosEntrepanio
    {
        //[DataMember]
        //public Int32? intEntrepanioID { get; set; }

        //[DataMember]
        //public Int32? sintTipoEntrepanioID { get; set; }

        //[DataMember]
        //public Int32? intElementoID { get; set; }

        //[DataMember]
        //public Int32? intCotizacionID { get; set; }

        //[DataMember]
        //public Int16? sintPinturaID { get; set; }

        //[DataMember]
        //public Int32? intCantidad { get; set; }

        //[DataMember]
        //public Boolean? bitRefuerzo { get; set; }

        //[DataMember]
        //public Int32? intCalibre { get; set; }

        //[DataMember]
        //public Boolean? bitActivo { get; set; }
        [DataMember]
        public string vchCalibreAcero { get; set; }
        [DataMember]
        public decimal? decFondo { get; set; }
        [DataMember]
        public decimal? decFrente { get; set; }
        [DataMember]
        public short? sintNumRefuerzo { get; set; }
        [DataMember]
        public int? intCapCargaXEntrepanio { get; set; }
        [DataMember]
        public decimal? decDesarrollo { get; set; }
        [DataMember]
        public decimal? decLongitud { get; set; }
        [DataMember]
        public string vchMaterial { get; set; }
        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioFinal { get; set; }
    }
}
