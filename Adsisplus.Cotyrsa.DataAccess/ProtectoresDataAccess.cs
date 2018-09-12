using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;


namespace Adsisplus.Cotyrsa.DataAccess
{
  public  class ProtectoresDataAccess
    {
        public List<DatosProtectorBase> ListarDatosProtectorPoste(Int32 @intProtectorPosteID, Int32 @intElementoID, Int32 @intCotizacionID, Int16 @sintPinturaID)
        {
            List<DatosProtectorBase> results = new List<DatosProtectorBase>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosProtectorPoste(@intProtectorPosteID, @intElementoID, @intCotizacionID, @sintPinturaID)
                                select new DatosProtectorBase()
                                {
                                    intProtectorPosteID = item.intProtectorPosteID,
                                    vchElemento = item.vchElemento,
                                    intCotizacionID = item.intCotizacionID,
                                    vchFolio = item.vchFolio,
                                    vchPintura = item.vchPintura,
                                    intCantidadProtectorPoste = item.intCantidadProtectorPoste,
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

        public List<DatosProtectorBateria> ListarDatosProtectorBateria(Int32 @intProtectorBateriaID, Int32 @intElementoID, Int32 @intCotizacionID)
        {
            List<DatosProtectorBateria> results = new List<DatosProtectorBateria>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosProtectorBateria(@intProtectorBateriaID, @intElementoID, @intCotizacionID)
                                select new DatosProtectorBateria()
                                {
                                    intProtectorBateriaID = item.intProtectorBateriaID,
                                    vchElemento = item.vchElemento,
                                    intCotizacionID = item.intCotizacionID,
                                    vchFolio = item.vchFolio,
                                    intCantidadSencilla = item.intCantidadSencilla,
                                    intCantidadDoble = item.intCantidadDoble,
                                    intCantidadCuadruple = item.intCantidadCuadruple,
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
