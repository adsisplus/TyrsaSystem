using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class PisoDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos de piso
        /// </summary>
        /// <param name="intDatosPisoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosPiso> ListarDatosPiso(int intDatosPisoID, int intDetCotizaID)
        {
            List<DatosPiso> result = new List<DatosPiso>();
            try
            {
                using (PisoDataContext dc = new PisoDataContext())
                {
                    var query = from item in dc.stp_ListarDatosPiso(intDatosPisoID, intDetCotizaID)
                                select new DatosPiso
                                {
                                    intDatoPisoID = item.intDatoPisoID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintPinturaID = item.sintPinturaID,
                                    intCantidad = item.intCantidad,
                                    decLargoPiso = item.decLargoPiso,
                                    bitUsoPatin = item.bitUsoPatin,
                                    bitActivo = item.bitActivo,
                                    intDetCotizaID = item.intDetCotizaID,
                                    decAncho = item.decAncho,
                                    bitTipoPisoAbierto = item.bitTipoPisoAbierto,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal
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
