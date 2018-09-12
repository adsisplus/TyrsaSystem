using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class TipoElementoCotizar_CatalogoProducto
    {
        [DataMember]
        public Int32? intTipoElementoCoti_Producto { get; set; }

        [DataMember]
        public Int32? intTipoElementoID { get; set; }

        [DataMember]
        public Int32? intTipoElementoAlmacenID { get; set; }

        [DataMember]
        public Int32? intConfiguraMarcoID { get; set; }

        [DataMember]
        public Int32? intConfiguraVigaID { get; set; }

        [DataMember]
        public Int32? intDatoMarcoID { get; set; }

        [DataMember]
        public Int32? intDatosVigaID { get; set; }

        [DataMember]
        public Int32? intDatosPanelID { get; set; }

        [DataMember]
        public Int32? intDatosCrossBarID { get; set; }

        [DataMember]
        public Int32? intDistanciadorID { get; set; }

        [DataMember]
        public Int32? intParrillaID { get; set; }

        [DataMember]
        public Int32? intVigaTopeID { get; set; }

        [DataMember]
        public Int32? intProtectorBateriaID { get; set; }

        [DataMember]
        public Int32? intPerfilID { get; set; }

        [DataMember]
        public Int32? intProtectorPosteID { get; set; }

        [DataMember]
        public Int32? intDatoPisoID { get; set; }

        [DataMember]
        public Int32? intRielPortaRuedaID { get; set; }

        [DataMember]
        public Int32? intRielImportadoID { get; set; }

        [DataMember]
        public Int32? intVigaAtirantadoID { get; set; }

        [DataMember]
        public Int32? intEntrepanioID { get; set; }

        [DataMember]
        public Int32? intAtirantadoID { get; set; }

        [DataMember]
        public Int32? intRielTarimaID { get; set; }

        [DataMember]
        public Int32? intBrazoID { get; set; }

        [DataMember]
        public Int32? intAnguloRanuradoID { get; set; }

        [DataMember]
        public Int32? intCarroID { get; set; }

        [DataMember]
        public Int32? intVigaEntradaID { get; set; }

        [DataMember]
        public Int32? intDatosCarrilID { get; set; }

        [DataMember]
        public Int32? intVigaIntermediaID { get; set; }

        [DataMember]
        public Int32? intGuiaEntradaID { get; set; }

        [DataMember]
        public Int32? intFrenoID { get; set; }

        [DataMember]
        public Int32? intRielDinamicoID { get; set; }

        [DataMember]
        public Int32? intVigaEntrepisoID { get; set; }

        [DataMember]
        public Int32? intPosteDobleID { get; set; }

        [DataMember]
        public DateTime? datFechaAlta { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
