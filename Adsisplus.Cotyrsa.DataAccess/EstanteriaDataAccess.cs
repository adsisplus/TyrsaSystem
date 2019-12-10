using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class EstanteriaDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos de entrepaño
        /// </summary>
        /// <param name="sintRefuerzo"></param>
        /// <param name="decFrente"></param>
        /// <param name="decFondo"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<DatosEntrepanio> ListarEntrepanio(short sintRefuerzo, decimal decFrente, decimal decFondo, int intCalibreAceroID, bool bitGalvanizado)
        {
            List<DatosEntrepanio> result = new List<DatosEntrepanio>();
            try
            {
                using (EstanteriaDataContext dc = new EstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarEntrepanio(sintRefuerzo, decFrente, decFondo, intCalibreAceroID, bitGalvanizado)
                                select new DatosEntrepanio
                                {
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    decFondo = item.decFondo,
                                    decFrente = item.decFrente,
                                    sintNumRefuerzo = item.sintNumRefuerzo,
                                    intCapCargaXEntrepanio = item.intCapCargaXEntrepanio,
                                    decDesarrollo = item.decDesarrollo,
                                    decLongitud = item.decLongitud,
                                    vchMaterial = item.vchMaterial,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioFinal = item.decPrecioFinal
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
