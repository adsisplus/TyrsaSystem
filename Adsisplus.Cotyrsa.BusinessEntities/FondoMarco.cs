using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class FondoMarco
    {
        [DataMember]
        public Int16? sintFondoMarcoID { get; set; }

        [DataMember]
        public Int16? sintTipoMarcoID { get; set; }
        [DataMember]
        public String vchTipoMarcoTyrsa { get; set; }

        [DataMember]
        public String vchFondoMarco { get; set; }

        [DataMember]
        public Decimal? decFondoMarco { get; set; }

        [DataMember]
        public String vchParte1 { get; set; }
        [DataMember]
        public String vchDescripcion1 { get; set; }
        [DataMember]
        public Decimal? decFactor1 { get; set; }
        [DataMember]
        public String vchParte2 { get; set; }
        [DataMember]
        public String vchDescripcion2 { get; set; }
        [DataMember]
        public Decimal? decFactor2 { get; set; }
        [DataMember]
        public String vchParte3 { get; set; }
        [DataMember]
        public String vchDescripcion3 { get; set; }
        [DataMember]
        public Decimal? decFactor3 { get; set; }
        [DataMember]
        public String vchParte4 { get; set; }
        [DataMember]
        public String vchDescripcion4 { get; set; }
        [DataMember]
        public Decimal? decFactor4 { get; set; }
        [DataMember]
        public String vchParte5 { get; set; }
        [DataMember]
        public String vchDescripcion5 { get; set; }
        [DataMember]
        public Decimal? decFactor5 { get; set; }
        [DataMember]
        public String vchParte6 { get; set; }
        [DataMember]
        public String vchDescripcion6 { get; set; }
        [DataMember]
        public Decimal? decFactor6 { get; set; }
        [DataMember]
        public String vchParte7 { get; set; }
        [DataMember]
        public String vchDescripcion7 { get; set; }
        [DataMember]
        public Decimal? decFactor7 { get; set; }
        [DataMember]
        public String vchParte8 { get; set; }
        [DataMember]
        public String vchDescripcion8 { get; set; }
        [DataMember]
        public Decimal? decFactor8 { get; set; }
        [DataMember]
        public String vchParte9 { get; set; }
        [DataMember]
        public String vchDescripcion9 { get; set; }
        [DataMember]
        public Decimal? decFactor9 { get; set; }
        [DataMember]
        public String vchParte10 { get; set; }
        [DataMember]
        public String vchDescripcion10 { get; set; }
        [DataMember]
        public Decimal? decFactor10 { get; set; }
        [DataMember]
        public String vchParte11 { get; set; }
        [DataMember]
        public String vchDescripcion11 { get; set; }
        [DataMember]
        public Decimal? decFactor11 { get; set; }
        [DataMember]
        public String vchParte12 { get; set; }
        [DataMember]
        public String vchDescripcion12 { get; set; }
        [DataMember]
        public Decimal? decFactor12 { get; set; }
        [DataMember]
        public String vchParte13 { get; set; }
        [DataMember]
        public String vchDescripcion13 { get; set; }
        [DataMember]
        public Decimal? decFactor13 { get; set; }
        [DataMember]
        public String vchParte14 { get; set; }
        [DataMember]
        public String vchDescripcion14 { get; set; }
        [DataMember]
        public Decimal? decFactor14 { get; set; }
        [DataMember]
        public String vchParte15 { get; set; }
        [DataMember]
        public String vchDescripcion15 { get; set; }
        [DataMember]
        public Decimal? decFactor15 { get; set; }
        [DataMember]
        public String vchParte16 { get; set; }
        [DataMember]
        public String vchDescripcion16 { get; set; }
        [DataMember]
        public Decimal? decFactor16 { get; set; }
        [DataMember]
        public String vchParte17 { get; set; }
        [DataMember]
        public String vchDescripcion17 { get; set; }
        [DataMember]
        public Decimal? decFactor17 { get; set; }
        [DataMember]
        public String vchParte18 { get; set; }
        [DataMember]
        public String vchDescripcion18 { get; set; }
        [DataMember]
        public Decimal? decFactor18 { get; set; }
        [DataMember]
        public String vchParte19 { get; set; }
        [DataMember]
        public String vchDescripcion19 { get; set; }
        [DataMember]
        public Decimal? decFactor19 { get; set; }

        [DataMember]
        public String vchParaCostoLamina { get; set; }
        [DataMember]
        public String vchCostoLamina { get; set; }
        [DataMember]
        public Decimal? decCostoLamina { get; set; }

        [DataMember]
        public String vchParaCostoSolera { get; set; }
        [DataMember]
        public String vchCostoSolera { get; set; }
        [DataMember]
        public Decimal? decCostoSolera { get; set; }

        [DataMember]
        public String vchParaFactorAcero { get; set; }
        [DataMember]
        public String vchFactorAcero { get; set; }
        [DataMember]
        public Decimal? decFactorAcero { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
