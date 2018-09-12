using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class ParrillaDataAccess
    {
        public List<DatosParrilla> ListarDatosPanel(Int32 @intParrillaID, Int32 @intElementoID, Int16 @sintPinturaID, Int32 @intCotizacionID)
        {
            List<DatosParrilla> results = new List<DatosParrilla>();
            try
            {
                using (ParrillaDataContext dc = new ParrillaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosParrilla(@intParrillaID, @intElementoID, @sintPinturaID, @intCotizacionID)
                                select new DatosParrilla()
                                {
                                    intParrillaID = item.intParrillaID,
                                    vchElemento = item.vchElemento,
                                    vchPintura = item.vchPintura,
                                    intCotizacionID = item.intCotizacionID,
                                    vchFolio = item.vchFolio,
                                    decFrenteParrilla = item.decFrenteParrilla,
                                    decFondoParrilla = item.decFondoParrilla,
                                    decCostoParrilla = item.decCostoParrilla,
                                    decTamanioCuadroParrilla = item.decTamanioCuadroParrilla,
                                    intCantidadParrilla = item.intCantidadParrilla,
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
