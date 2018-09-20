using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
  public  class SistemasTyrsaDataAccess
    {
        public List<RelSistemaSelectivo> ListarRelSistemaSelectivo(Int32 intCotizacionID, Int32 intTipoElementoCoti_Producto, Int32 intTipoElementoID, Int32 intTipoElementoAlmacenID, Int32 intConfiguraMarcoID, Int32 intConfiguraVigaID, Int32 intDatoMarcoID, Int32 intDatosVigaID, Int32 intDatosPanelID, Int32 intDatosCrossBarID, Int32 intDistanciadorID, Int32 intParrillaID, Int32 intVigaTopeID, Int32 intProtectorPosteID, Int32 intProtectorBateriaID, Int16 sintSistemaCargaMarcoID, DateTime datFechaAlta)
        {
            List<RelSistemaSelectivo> results = new List<RelSistemaSelectivo>();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarRelSistemaSelectivo(intCotizacionID, intTipoElementoCoti_Producto, intTipoElementoID, intTipoElementoAlmacenID, intConfiguraMarcoID, intConfiguraVigaID, intDatoMarcoID, intDatosVigaID, intDatosPanelID, intDatosCrossBarID, intDistanciadorID, intParrillaID, intVigaTopeID, intProtectorPosteID, intProtectorBateriaID, sintSistemaCargaMarcoID, datFechaAlta)
                                select new RelSistemaSelectivo()
                                {
                                    intTipoElementoCoti_Producto = item.intTipoElementoCoti_Producto,
                                    intCotizacionID = item.intCotizacionID,
                                    vchDescElementoCotizar = item.vchDescElementoCotizar,
                                    vchProductoAcero = item.vchProductoAcero,
                                    decPrecioTyrsa = item.decPrecioTyrsa,
                                    vchConfiguraViga = item.vchConfiguraViga,
                                    intCantidadMarco = item.intCantidadMarco,
                                    intCantidadViga = item.intCantidadViga,
                                    intCantidadPanel = item.intCantidadPanel,
                                    intCantidadNivelCrossbar = item.intCantidadNivelCrossbar,
                                    intCantidadDistanciador = item.intCantidadDistanciador,
                                    decCostoParrilla = item.decCostoParrilla,
                                    intCantidadVigaTope = item.intCantidadVigaTope,
                                    intCantidadProctorPoste = item.intCantidadProctorPoste,
                                    intCantidadSencillaProtectorBateria = item.intCantidadSencillaProtectorBateria,
                                    intCantidadDobleProtectorBateria = item.intCantidadDobleProtectorBateria,
                                    intCantidadCuadrupleProtectorBateria = item.intCantidadCuadrupleProtectorBateria,
                                    vchFondoTyrsaMarco = item.vchFondoTyrsaMarco,
                                    vchFrenteTyrsaMarco = item.vchFrenteTyrsaMarco,
                                    intCapacidadPesoMarco = item.intCapacidadPesoMarco,
                                    vchFondoTyrsaPoste = item.vchFondoTyrsaPoste,
                                    vchFrenteTyrsaPoste = item.vchFrenteTyrsaPoste,
                                    intCapacidadPesoPoste = item.intCapacidadPesoPoste,
                                    datFechaAlta = item.datFechaAlta,
                                    bitActivo = item.bitActivo
                                };
                    results.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
