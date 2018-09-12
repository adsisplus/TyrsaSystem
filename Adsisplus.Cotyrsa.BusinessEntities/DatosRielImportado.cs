using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosRielImportado
    {
        [DataMember]
        public Int32? intRielImportadoID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public Decimal? decLargoFT { get; set; }

        [DataMember]
        public Decimal? decCostoFTUSD { get; set; }

        [DataMember]
        public Int32? intCantidadRielNivel { get; set; }

        [DataMember]
        public Int32? intCantidadRielProyecto { get; set; }

        [DataMember]
        public Int32? decTipoCambio { get; set; }

        [DataMember]
        public Int32? intCantidadNivel { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
