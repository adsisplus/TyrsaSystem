using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class CotizacionDataAccess
    {
        public List<Cotizacion> ListarCatAlturaMarco(Int32 intCotizacionID, Int32 intEstatusID, Int32 sintPrioridadID, Int32 intEmpresaID)
        {
            List<Cotizacion> results = new List<Cotizacion>();
            try
            {
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosCotizacion(intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID)
                                select new Cotizacion()
                                {
                                    intCotizacionID = item.intCotizacionID,
                                    vchEstatus = item.vchEstatus,
                                    vchPrioridad = item.vchPrioridad,
                                    vchNombreCliente = item.vchNombreCliente,
                                    vchFolio = item.vchFolio,
                                    datFechaCotizacion = item.datFechaCotizacion,
                                    datFechaAceptacion = item.datFechaAceptacion,
                                    datFechaRechazo = item.datFechaRechazo
                                    
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
        /// Obtiene la lista de la relación de tipo elemento almacen vs Factor de cotización
        /// </summary>
        /// <param name="intTipoElementoAlmacen_FactorID"></param>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="sintFactorID"></param>
        /// <returns></returns>
        public List<RelTipoElementoAlmacenFactorCotizacion> ListarRel_TipoElementoAlmacen_FactorCotizacion(int intTipoElementoAlmacen_FactorID,
            int intTipoElementoAlmacenID, short sintFactorID)
        {
            List<RelTipoElementoAlmacenFactorCotizacion> result = new List<RelTipoElementoAlmacenFactorCotizacion>();
            try
            {
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarRel_TipoElementoAlmacen_FactorCotizacion(intTipoElementoAlmacen_FactorID, intTipoElementoAlmacenID, sintFactorID)
                                select new RelTipoElementoAlmacenFactorCotizacion
                                {
                                    bitActivo = (bool)item.bitActivo,
                                    datFechaAlta = (DateTime)item.datFechaAlta,
                                    decFactor = (decimal)item.decFactor,
                                    intTipoElementoAlmacenID = (int)item.intTipoElementoAlmacenID,
                                    intTipoElementoAlmacen_FactorID = item.intTipoElementoAlmacen_FactorID,
                                    sintFactorID = (short)item.sintFactorID,
                                    vchFactor = item.vchFactor
                                };
                    result.AddRange(query);
                }
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
