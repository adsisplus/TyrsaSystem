using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class DistanciadorDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos del distanciador en base a la cotización
        /// </summary>
        /// <param name="intDistanciadorID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        public List<DatosDistanciador> ListarDatosDistanciador(Int32 intDistanciadorID, Int32 intCotizacionID, int intDetCotizaID, Int32 intElementoID)
        {
            List<DatosDistanciador> results = new List<DatosDistanciador>();
            try
            {
                using (DistanciadorDataContext dc = new DistanciadorDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosDistanciador(intDistanciadorID, intCotizacionID, intDetCotizaID, intElementoID)
                                select new DatosDistanciador()
                                {
                                    intDistanciadorID = item.intDistanciadorID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    vchFolio = item.vchFolio,
                                    intElementoID = item.intElementoID,
                                    vchElemento = item.vchElemento,
                                    sintPinturaID = item.sintPinturaID,
                                    vchPintura = item.vchPintura,
                                    intCantidadDistanciador = item.intCantidadDistanciador,
                                    decLargoDistanciador = item.decLargoDistanciador,
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
