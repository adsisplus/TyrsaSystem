using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class ConectorDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los conectores en base al calibre y cantidad
        /// </summary>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="intCantidad"></param>
        /// <returns></returns>
        public List<SeleccionConector> ListarConectorCartonFlow(short intCalibreAceroID, int intCantidad)
        {
            List<SeleccionConector> result = new List<SeleccionConector>();
            try
            {
                using (ConectorDataContext dc = new ConectorDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarConectorCartonFlow(intCalibreAceroID, intCantidad)
                                select new SeleccionConector
                                {
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    sintCalibre = item.sintCalibre,
                                    vchTipoCartonFlow = item.vchTipoCartonFlow,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    sintPesoPieza = item.sintPesoPieza,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    vchLeyenda = item.vchLeyenda
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
        /// <summary>
        /// Procedimiento que lista los datos de conector de carton flow en base al ID de la cotización o al Id del conector
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatosConectorCFID"></param>
        /// <returns></returns>
        public List<DatosConectorCartonFlow> ListarDatosConectorCartonFlow(int intCotizacionID, int intDatosConectorCFID)
        {
            List<DatosConectorCartonFlow> result = new List<DatosConectorCartonFlow>();
            try
            {
                using (ConectorDataContext dc = new ConectorDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosConectorCartonFlow(intCotizacionID, intDatosConectorCFID)
                                select new DatosConectorCartonFlow
                                {
                                    intDatosConectorCFID = item.intDatosConectorCFID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    intCalibreAceroID = item.intCalibreAceroID,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    sintPesoPieza = item.sintPesoPieza,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    vchLeyenda = item.vchLeyenda,
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
