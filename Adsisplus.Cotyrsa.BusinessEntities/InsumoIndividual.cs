using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class InsumoIndividual
    {
        [DataMember]
        public short? sintInsumoIndividualID { get; set; }
        [DataMember]
        public int? intSubProductoID { get; set; }
        [DataMember]
        public int? intUnidadMedicionID { get; set; }
        [DataMember]
        public string vchDescripcion { get; set; }
        [DataMember]
        public decimal? decFactor { get; set; }
        [DataMember]
        public decimal? decPesos { get; set; }
        [DataMember]
        public decimal? decUSA { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
