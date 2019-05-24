using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Adsisplus.Cotyrsa.BusinessEntities
{
    [DataContract]
    public class RelSistemaSelectivo
    {
        [DataMember]
        public Int32? intTipoElementoCoti_Producto { get; set; }

        [DataMember]
        public Int32? intCotizacionID { get; set; }
        // SISTEMA SELECTIVO
        [DataMember]
        public Int32? intDatosVigaID { get; set; }
        [DataMember]
        public Int32? intDatoMarcoID { get; set; }
        [DataMember]
        public Int32? intDatosPanelID { get; set; }
        [DataMember]
        public Int32? intDatosCrossBarID { get; set; }
        [DataMember]
        public Int32? intDistanciadorID { get; set; }
        [DataMember]
        public Int32? intTipoElementoID { get; set; }
        [DataMember]
        public Int32? intTipoElementoAlmacenID { get; set; }
        [DataMember]
        public Int32? intParrillaID { get; set; }
        [DataMember]
        public Int32? intVigaTopeID { get; set; }
        [DataMember]
        public Int32? intProtectorPosteID { get; set; }
        [DataMember]
        public Int32? intProtectorBateriaID { get; set; }
        [DataMember]
        public short? sintSistemaCargaMarcoID { get; set; }
        [DataMember]
        public int? intDatoTornilleriaID { get; set; }
        // GASTOS
        [DataMember]
        public int? intDatoFleteID { get; set; }
        [DataMember]
        public int? intDatosInstalacionID { get; set; }
        [DataMember]
        public int? intDatoViaticoID { get; set; }

        #region Variables que no se usan
        //[DataMember]
        //public String vchDescElementoCotizar { get; set; }
        //[DataMember]
        //public String vchProductoAcero { get; set; }
        //[DataMember]
        //public Int32? intConfiguraMarcoID { get; set; }
        //[DataMember]
        //public Decimal? decPrecioTyrsa { get; set; }
        //[DataMember]
        //public Int32? intConfiguraVigaID { get; set; }
        //[DataMember]
        //public String vchConfiguraViga { get; set; }
        //[DataMember]
        //public Int32? intCantidadMarco { get; set; }
        //[DataMember]
        //public Int32? intCantidadViga { get; set; }
        //[DataMember]
        //public Int32? intCantidadPanel { get; set; }
        //[DataMember]
        //public Int32? intCantidadNivelCrossbar { get; set; }
        //[DataMember]
        //public Int32? intCantidadDistanciador { get; set; }
        //[DataMember]
        //public Decimal? decCostoParrilla { get; set; }
        //[DataMember]
        //public Int32? intCantidadVigaTope { get; set; }
        //[DataMember]
        //public Int32? intCantidadProctorPoste { get; set; }
        //[DataMember]
        //public Int32? intCantidadSencillaProtectorBateria { get; set; }
        //[DataMember]
        //public Int32? intCantidadDobleProtectorBateria { get; set; }
        //[DataMember]
        //public Int32? intCantidadCuadrupleProtectorBateria { get; set; }
        //[DataMember]
        //public String vchFondoTyrsaMarco { get; set; }
        //[DataMember]
        //public String vchFrenteTyrsaMarco { get; set; }
        //[DataMember]
        //public Int32? intCapacidadPesoMarco { get; set; }
        //[DataMember]
        //public String vchFondoTyrsaPoste { get; set; }
        //[DataMember]
        //public String vchFrenteTyrsaPoste { get; set; }
        //[DataMember]
        //public Int32? intCapacidadPesoPoste { get; set; }
        #endregion

        [DataMember]
        public DateTime? datFechaAlta { get; set; }
        [DataMember]
        public bool? bitActivo { get; set; }
    }
}
