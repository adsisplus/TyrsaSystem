﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class DatosPantallaPanel
    {
        [DataMember]
        public int? intRackID { get; set; }
        [DataMember]
        public int? intDetCotizaID { get; set; }
        [DataMember]
        public int? intCotizacionID { get; set; }
        [DataMember]
        public short? sintPinturaID { get; set; }
        [DataMember]
        public decimal? decAnchoBus { get; set; }
        [DataMember]
        public decimal? decLargo { get; set; }
        [DataMember]
        public short? sintCantidadPanelNivel { get; set; }
        [DataMember]
        public int? intCantidadPanel { get; set; }
        [DataMember]
        public string vchCalibre { get; set; }

        [DataMember]
        public int? intSeleccionPanelID { get; set; }
        [DataMember]
        public int? intPanelID { get; set; }
        [DataMember]
        public bool? bitGalvanizado { get; set; }
        [DataMember]
        public bool? bitPintado { get; set; }

        // datos que se mostrarán en el grid

        [DataMember]
        public short? sintSKU { get; set; }
        [DataMember]
        public string vchCalibreAcero { get; set; }
        [DataMember]
        public decimal? decAncho { get; set; }
        [DataMember]
        public decimal? decFondo { get; set; }
        [DataMember]
        public decimal? decPesoKg { get; set; }
        [DataMember]
        public short? sintCorreccion { get; set; }
        [DataMember]
        public decimal? decTotal { get; set; }
        [DataMember]
        public decimal? decPrecioEfectivoRef { get; set; }
        [DataMember]
        public decimal? decRelPrecioTyrsa { get; set; }
        [DataMember]
        public decimal? decKgTyrsa { get; set; }
        [DataMember]
        public decimal? decKgReferencia { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
