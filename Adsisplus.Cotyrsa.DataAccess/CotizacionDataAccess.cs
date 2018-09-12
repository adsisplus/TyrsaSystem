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
        public List<Cotizacion> ListarCatAlturaMarco(Int32 @intCotizacionID, Int32 @intEstatusID, Int32 @sintPrioridadID, Int32 @intEmpresaID)
        {
            List<Cotizacion> results = new List<Cotizacion>();
            try
            {
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosCotizacion(@intCotizacionID, @intEstatusID, @sintPrioridadID, @intEmpresaID)
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
    }
}
