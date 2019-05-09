using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPantallaMarco
    {
        [DataMember]
        public SeleccionMarco seleccion { get; set; }

        [DataMember]
        public DatosMarco marco { get; set; }

        [DataMember]
        public List<NivelPorMarco> nivel { get; set; }
    }
}
