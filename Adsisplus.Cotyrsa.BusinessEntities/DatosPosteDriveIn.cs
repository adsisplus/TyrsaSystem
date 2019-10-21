using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPosteDriveIn
    {
        [DataMember]
        public int? intDatoPosteDriveInID { get; set; }
        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? intDatoMarcoID { get; set; }
        //[DataMember]
        //public int? intSKUID { get; set; }
        [DataMember]
        public int? intCantidad { get; set; }

        [DataMember]
        public short? sintPinturaID { get; set; }
        [DataMember]
        public decimal? decAlturaPandeo { get; set; }
        [DataMember]
        public bool? bitEstructural { get; set; }
        [DataMember]
        public bool? bitRolado { get; set; }
        //[DataMember]
        //public decimal? decCalibre { get; set; }
        //[DataMember]
        //public decimal? decSolera { get; set; }
        //[DataMember]
        //public decimal? decTotalKilo { get; set; }
        //[DataMember]
        //public decimal? decPrecioTyrsa { get; set; }
        //[DataMember]
        //public decimal? decRelacionPrecios { get; set; }
        //[DataMember]
        //public decimal? decPrecioTyrsaMetro { get; set; }
        //[DataMember]
        //public decimal? decPrecioTyrsaKg { get; set; }
        //[DataMember]
        //public short? sintNumPosteReq { get; set; }
        //[DataMember]
        //public short? sintNumTravesanio { get; set; }

        [DataMember]
        public bool? bitDobleMonten { get; set; }
        [DataMember]
        public decimal? decAlturaDobleMonten { get; set; }
        [DataMember]
        public int? intDatosDriveInID { get; set; }
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intAlturaMarcoID { get; set; }
        [DataMember]
        public decimal? decFondo { get; set; }

        [DataMember]
        public bool? bitActivo { get; set; }
        [DataMember]
        public List<DatosPrecioPoste> seleccion { get; set; }
    }
}
