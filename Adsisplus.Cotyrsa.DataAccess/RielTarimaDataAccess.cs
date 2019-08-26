using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class RielTarimaDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos Riel Tarima
        /// </summary>
        /// <param name="intRielTarimaID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosRielTarima> ListarDatosRielTarima(int intRielTarimaID, int intDetCotizaID)
        {
            List<DatosRielTarima> result = new List<DatosRielTarima>();
            using (RielTarimaDataContext dc = new RielTarimaDataContext(Helper.ConnectionString()))
            {
                var query = from item in dc.stp_ListarDatosRielTarima(intRielTarimaID, intDetCotizaID)
                            select new DatosRielTarima
                            {
                                intRielTarimaID = item.intRielTarimaID,
                                intElementoID = item.intElementoID,
                                intCotizacionID = item.intCotizacionID,
                                intDetCotizaID = item.intDetCotizaID,
                                sintTipoRielTarimaID = item.sintTipoRielTarimaID,
                                sintPinturaID = item.sintPinturaID,
                                intCantidad = item.intCantidad,
                                decCarga = item.decCarga,
                                decLargo = item.decLargo,
                                bitActivo = item.bitActivo
                            };
                result.AddRange(query);
            }
                return result;
        }
    }
}
