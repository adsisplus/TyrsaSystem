using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class BarandalDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos Barandal
        /// </summary>
        /// <param name="intDatosBarandalID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosBarandal> ListarDatosBarandal(int intDatosBarandalID, int intCotizacionID)
        {
            List<DatosBarandal> result = new List<DatosBarandal>();
            try
            {
                using (BarandalDataContext dc = new BarandalDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosBarandal(intDatosBarandalID, intCotizacionID)
                                select new DatosBarandal
                                {
                                    intDatosBarandalID = item.intDatosBarandalID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    sintPinturaID = item.sintPinturaID,
                                    decLargo = item.decLargo,
                                    decCantidad = item.decCantidad,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    bitActivo = item.bitActivo
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
