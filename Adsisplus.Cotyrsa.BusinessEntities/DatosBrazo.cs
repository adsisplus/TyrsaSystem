using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosBrazo
    {
        [DataMember]
        public Int32? intBrazoID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }

        [DataMember]
        public Int16? sintPinturaID { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
        [DataMember]
        public short? sintLargoBrazoID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        //[DataMember]
        //public decimal? decPrecioVentaUnitario { get; set; }
        //[DataMember]
        //public decimal? decPrecioVentaTotal { get; set; }
        //[DataMember]
        //public decimal? decPesoUnitario { get; set; }
        //[DataMember]
        //public decimal? decPesoTotal { get; set; }
        // Agregamos la entidad seleccion Brazo
        [DataMember]
        public SeleccionBrazo seleccion { get; set; }
    }
}
