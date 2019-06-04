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
        public int? intSeleccionVigaID { get; set; }

        [DataMember]
        public int? intSeleccionMarcoID { get; set; }

        [DataMember]
        public int? intElementoID { get; set; }

        [DataMember]
        public int? intRackID { get; set; }

        [DataMember]
        public int? intEstatusID { get; set; }
        [DataMember]
        public String vchEstatus { get; set; }
        [DataMember]
        public short? sintPrioridadID { get; set; }
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
        public short? sintMontajeID { get; set; }
        [DataMember]
        public int? intPartida { get; set; }
        [DataMember]
        public int? intCantidad { get; set; }
        [DataMember]
        public short? sintVisitas { get; set; }
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

        // Datos que seran almacenados en la tabla tbl_RackSelectivo
        [DataMember]
        public decimal? decMedidaFrente { get; set; }
        [DataMember]
        public decimal? decMedidaFondo { get; set; }
        [DataMember]
        public decimal? decAlto { get; set; }
        [DataMember]
        public decimal? decPesoKg { get; set; }


        [DataMember]
        public bool? bitMontaCarga { get; set; }
        [DataMember]
        public int? intNumeroTarimaPorNivel { get; set; }

        [DataMember]
        public int? intNumeroNivelSobreViga { get; set; }
        [DataMember]
        public int? intPosicion { get; set; }
        [DataMember]
        public int? intEmpresaID { get; set; }

        [DataMember]
        public DateTime? datFechaArmado { get; set; }
        [DataMember]
        public int? intProductoGralID { get; set; }
        [DataMember]
        public int? intRelCotizaProductoID { get; set; }

        [DataMember]
        public int? intSubProductoID { get; set; }

        [DataMember]
        public int? intUsuarioID { get; set; }
    }
}
