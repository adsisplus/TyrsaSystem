﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionRielDeCarga
    {
        [DataMember]
        public int? intSeleccionRielCargaID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public short? sintDriveInID { get; set; }
        [DataMember]
        public int? intRielTarimaID { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public decimal? decLongitud { get; set; }
        [DataMember]
        public decimal? decAncho { get; set; }

        [DataMember]
        public int? intCantidad { get; set; }
        /*
         DATOS DE IMPORTE UNITARIO
             */

        [DataMember]
        public decimal? decTotalKiloUnitario { get; set; }
        [DataMember]
        public decimal? decPrecioFinal { get; set; }
        
        /*
            DATOS DE IMPORTE TOTAL
            */
        [DataMember]
        public decimal? decPesoTotal { get; set; }
        [DataMember]
        public decimal? decPrecioVentaTotal { get; set; }
    }
}
