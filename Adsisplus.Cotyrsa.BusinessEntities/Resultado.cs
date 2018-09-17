using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Resultado
    {
        /// <summary>
        /// Propiedadd que nos indicará el resultado OK o NOK
        /// </summary>
        [DataMember]
        public string vchResultado { get; set; }
        /// <summary>
        /// Propiedad que nos describe el resultado
        /// </summary>
        [DataMember]
        public string vchDescripcion { get; set; }
    }
}
