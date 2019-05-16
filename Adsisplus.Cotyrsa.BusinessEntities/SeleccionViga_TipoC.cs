﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class SeleccionViga_TipoC
    {
        [DataMember]
        public long? SKU { get; set; }

        [DataMember]
        public decimal? decPesoPieza { get; set; }

        [DataMember]
        public decimal? TOTAL { get; set; }

        [DataMember]
        public decimal? decTotal { get; set; }
    }
}