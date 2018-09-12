using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Configuracion_Marco
    {
        [DataMember]
        public Int32? intConfiguraMarcoID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public Int16? sintTipoMarcoID { get; set; }

        [DataMember]
        public String vchTipoMarcoTyrsa { get; set; }

        [DataMember]
        public Int32? intAlturaMarcoID { get; set; }

        [DataMember]
        public Decimal? decAlturaMarco { get; set; }

        [DataMember]
        public Int16? sintFondoMarcoID { get; set; }

        [DataMember]
        public Decimal? decFondoMarco { get; set; }

        [DataMember]
        public Int32? intSKUID { get; set; }

        [DataMember]
        public Int16? sintSKU { get; set; }

        [DataMember]
        public String vchSubFamiliaMarco { get; set; }

        [DataMember]
        public String vchContanteMarco { get; set; }

        [DataMember]
        public Decimal? decCalibre { get; set; }

        [DataMember]
        public Decimal? decSolera { get; set; }

        [DataMember]
        public Decimal? decTotalKilo { get; set; }

        [DataMember]
        public Decimal? decPrecioTyrsa { get; set; }

        [DataMember]
        public Decimal? decRelacionPrecios { get; set; }

        [DataMember]
        public Decimal? decPrecioTyrsaMetro { get; set; }

        [DataMember]
        public Decimal? decPrecioTyrsaKg { get; set; }

        [DataMember]
        public Int16? sintNumPosteReq { get; set; }

        [DataMember]
        public Int16? sintNumTravesanio { get; set; }

        [DataMember]
        public Int16? sintDiagonalLarga { get; set; }

        [DataMember]
        public Int16? sintDiagonalCorta { get; set; }

        [DataMember]
        public Decimal? decPesoCobroLam14 { get; set; }

        [DataMember]
        public Decimal? decPesoTotal { get; set; }

        [DataMember]
        public Decimal? decPintaPoste { get; set; }

        [DataMember]
        public Decimal? decPintaTravesanio { get; set; }

        [DataMember]
        public Decimal? decPintaDiagonalLarga { get; set; }

        [DataMember]
        public Decimal? decPintaDiagonalCorta { get; set; }

        [DataMember]
        public Decimal? decPintaPlacaBase { get; set; }

        [DataMember]
        public Decimal? decTotalMarcoCompleto { get; set; }

        [DataMember]
        public Decimal? decCalibreDosCaras { get; set; }

        [DataMember]
        public Int32? intNumeroNivelSobreViga { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
