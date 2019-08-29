using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class BrazoDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos de brazo
        /// </summary>
        /// <param name="intBrazoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosBrazo> ListarDatosBrazo(int intBrazoID, int intDetCotizaID)
        {
            List<DatosBrazo> result = new List<DatosBrazo>();
            try
            {
                using (BrazoDataContext dc = new BrazoDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosBrazo(intBrazoID, intDetCotizaID)
                                select new DatosBrazo
                                {
                                    intBrazoID = item.intBrazoID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintPinturaID = item.sintPinturaID,
                                    intCantidad = item.intCantidad,
                                    bitActivo = item.bitActivo,
                                    sintLargoBrazoID = item.sintLargoBrazoID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    decLargo = item.decLargo,
                                    decPrecioVentaUnitario = item.decPrecioVentaUnitario,
                                    decPrecioVentaTotal = item.decPrecioVentaTotal,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPesoTotal = item.decPesoTotal
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
