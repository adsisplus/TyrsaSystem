using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosGastos
    {
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public List<DatosFlete> flete { get; set; }
        [DataMember]
        public List<DatosInstalacion> instalacion { get; set; }
        [DataMember]
        public List<DatosViaticos> viatico { get; set; }
    }
}
