﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosViga
    {
        [DataMember]
        public Int32? intDatosVigaID { get; set; }

        [DataMember]
        public Int32? intElementoID { get; set; }
        [DataMember]
        public String vchElemento { get; set; }

        [DataMember]
        public Int16? intDatoMarcoID { get; set; }
        [DataMember]
        public Int16? sintCantidadDatosMarco { get; set; }

        [DataMember]
        public Int16? sintPinturaID { get; set; }
        [DataMember]
        public String vchPintura { get; set; }

        [DataMember]
        public Int32? intCantidad { get; set; }

        [DataMember]
        public Decimal? decLargo { get; set; }

        [DataMember]
        public Boolean? bitActivo { get; set; }
    }
}
