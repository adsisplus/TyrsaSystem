using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DiversosElementoCotizar
    {
        [DataMember]
        public Int32? intTipoElementoID { get; set; }

        [DataMember]
        public Int16? sintPinturaID { get; set; }

        [DataMember]
        public Int16? sintTipoMaterialID { get; set; }

        [DataMember]
        public Decimal? sintTipoGalvanizadoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public Int32? intDatosVigaID { get; set; }

        [DataMember]
        public Int32? intDatoMarcoID { get; set; }

        [DataMember]
        public String vchDescripcionElemento { get; set; }

        [DataMember]
        public Decimal? decFactorCotiza { get; set; }
        
        [DataMember]
        public Decimal? decCantidad { get; set; }
        
        [DataMember]
        public Decimal? decCalibre { get; set; }

        [DataMember]
        public Decimal? decMedidaFrente { get; set; }

        [DataMember]
        public String vchPosicion { get; set; }

        [DataMember]
        public Boolean? bitEsRequerido { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
