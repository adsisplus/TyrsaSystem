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
        /// <summary>
        /// Procedimiento que muestra los datos del protector viga en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosProtectorBase> ListarDatosProtectorPoste(Int32 intCotizacionID)
        {
            List<DatosProtectorBase> results = new List<DatosProtectorBase>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosProtectorPoste(intCotizacionID)
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
        /// <summary>
        /// Procedimeinto que nos muestra la información del protector de batería en base a la cotización
        /// </summary>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosProtectorBateria> ListarDatosProtectorBateria(int intCotizacionID)
        {
            List<DatosProtectorBateria> results = new List<DatosProtectorBateria>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosProtectorBateria(intCotizacionID)
                                select new DatosProtectorBateria()
                                {
                                    intProtectorBateriaID = item.intProtectorBateriaID,
                                    vchElemento = item.vchElemento,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    vchFolio = item.vchFolio,
                                    intCantidadSencilla = item.intCantidadSencilla,
                                    intCantidadDoble = item.intCantidadDoble,
                                    intCantidadTriple = item.intCantidadTriple,
                                    intCantidadCuadruple = item.intCantidadCuadruple,
                                    decPrecioSencilla = item.decPrecioSencilla,
                                    decPrecioDoble = item.decPrecioDoble,
                                    decPrecioTriple = item.decPrecioTriple,
                                    decPrecioCuadruple = item.decPrecioCuadruple,
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
