using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class Cotizacion
    {
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public int? intEstatusID { get; set; }
        [DataMember]
        public String vchEstatus { get; set; }
        [DataMember]
        public int? sintPrioridadID { get; set; }
        [DataMember]
        public String vchPrioridad { get; set; }
        [DataMember]
        public String vchNombreCliente { get; set; }
        [DataMember]
        public String vchFolio { get; set; }
        [DataMember]
        public DateTime? datFechaCotizacion { get; set; }
        [DataMember]
        public DateTime? datFechaAceptacion { get; set; }
        [DataMember]
        public DateTime? datFechaRechazo { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? sintMontajeID { get; set; }
        [DataMember]
        public int? intPartida { get; set; }
        [DataMember]
        public int? intCantidad { get; set; }
        [DataMember]
        public int? sintVisitas { get; set; }
        [DataMember]
        public String vchDimensionMontacarga { get; set; }
        [DataMember]
        public Decimal? decDolar { get; set; }
        [DataMember]
        public Decimal? decMonto { get; set; }
        [DataMember]
        public Decimal? decSubtotal { get; set; }
        [DataMember]
        public Decimal? decDescuento { get; set; }
        [DataMember]
        public Decimal? decDescuentoFin { get; set; }
        [DataMember]
        public Decimal? decIEMPS { get; set; }
        [DataMember]
        public Decimal? decRetISR { get; set; }
        [DataMember]
        public Decimal? decRetIVA { get; set; }
        [DataMember]
        public Decimal? decIVA { get; set; }
        [DataMember]
        public Decimal? decTotal { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }

    }
}
