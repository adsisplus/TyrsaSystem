using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Configuracion_Viga
    {
        [DataMember]
        public short? sintTipoVigaID { get; set; }
        [DataMember]
        public int? intElementoID { get; set; }
        [DataMember]
        public int? intCalibreID { get; set; }
        [DataMember]
        public decimal? decFactorAcero { get; set; }
        [DataMember]
        public decimal? decFactorRemache { get; set; }
        [DataMember]
        public decimal? decFactorKgMt { get; set; }
        [DataMember]
        public short? sintInsumoViga { get; set; }
        [DataMember]
        public int? intNumeroViga { get; set; }
        [DataMember]
        public int? intNumeroPza { get; set; }
        [DataMember]
        public decimal? decDesarrollo { get; set; }
        [DataMember]
        public int? intLongitud { get; set; }
        [DataMember]
        public string vchDescripcion { get; set; }
        [DataMember]
        public decimal? decAncho { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public int? intPiezaxLamina { get; set; }
        [DataMember]
        public int? intNumPiezaProm { get; set; }
        [DataMember]
        public decimal? decPesoPieza { get; set; }
        [DataMember]
        public decimal? decPesoPartida { get; set; }
        [DataMember]
        public decimal? decTotal { get; set; }
        [DataMember]
        public decimal? decAreaPintura { get; set; }
        [DataMember]
        public int? intCara { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }

        /// <summary>
        /// Id de la confirguración de la viga
        /// </summary>
        [DataMember]
        public int? intConfiguraVigaID { get; set; }
        /// <summary>
        /// Tipo de Viga
        /// </summary>
        [DataMember]
        public string vchTipoViga { get; set; }
        /// <summary>
        /// Elemento
        /// </summary>
        [DataMember]
        public string vchElemento { get; set; }
        /// <summary>
        /// Calibre
        /// </summary>
        [DataMember]
        public string vchCalibre { get; set; }
        /// <summary>
        /// Id del factor de la viga
        /// </summary>
        [DataMember]
        public short? sintFactorVigaID { get; set; }
        /// <summary>
        /// Acero
        /// </summary>
        [DataMember]
        public string vchAcero { get; set; }
        /// <summary>
        /// Tamaño del acero
        /// </summary>
        [DataMember]
        public decimal? decAcero { get; set; }
        /// <summary>
        /// Remache
        /// </summary>
        [DataMember]
        public string vchRemache { get; set; }
        /// <summary>
        /// Tamaño del remache
        /// </summary>
        [DataMember]
        public decimal? decRemache { get; set; }
        /// <summary>
        /// Metro cuadrado de la viga
        /// </summary>
        [DataMember]
        public string vchKgMetroCuadrado { get; set; }
        /// <summary>
        /// Metro cuadrado de la viga
        /// </summary>
        public decimal? decKgMetroCuadrado { get; set; }
    }
}
