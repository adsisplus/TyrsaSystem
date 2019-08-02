using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class ProductoAcero
    {
        [DataMember]
        public Int32? intTipoElementoAlmacenID { get; set; }

        [DataMember]
        public Int32? intUnidadMedicionID { get; set; }
        [DataMember]
        public String vchUnidadMedicion { get; set; }

        [DataMember]
        public Int32? intModeloID { get; set; }
        [DataMember]
        public String vchModelo { get; set; }

        [DataMember]
        public Int32? intCalibreAceroID { get; set; }
        [DataMember]
        public String vchCalibreAcero { get; set; }

        [DataMember]
        public String vchDescripcionTipoElemento { get; set; }

        [DataMember]
        public Decimal? decCostoNegra { get; set; }

        [DataMember]
        public Decimal? decCostoGalvanizada { get; set; }

        [DataMember]
        public decimal? decCostoSolera { get; set; }

        [DataMember]
        public Decimal? decCapacidadAcero { get; set; }

        [DataMember]
        public Decimal? decFactorNegra { get; set; }

        [DataMember]
        public Decimal? decFactorGalvanizado { get; set; }

        [DataMember]
        public DateTime? datFechaAlta { get; set; }

        [DataMember]
        public DateTime? datFechaActualizacion { get; set; }

        [DataMember]
        public Int32? intVigencia { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }

        [DataMember]
        public string vchUsuario { get; set; }
    }
}
