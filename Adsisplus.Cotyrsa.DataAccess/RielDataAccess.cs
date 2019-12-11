using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class RielDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos de Riel de rueda en base a la cotización y al id principal
        /// </summary>
        /// <param name="intRielPortaRuedaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosRielPortaRueda> ListarDatosRielPortaRueda(int intRielPortaRuedaID, int intCotizacionID)
        {
            List<DatosRielPortaRueda> result = new List<DatosRielPortaRueda>();
            try
            {
                using (RielDataContext dc = new RielDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosRielPortaRueda(intCotizacionID, intRielPortaRuedaID)
                                select new DatosRielPortaRueda
                                {
                                    intRielPortaRuedaID = item.intRielPortaRuedaID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intCalibreAceroID = item.intCalibreAceroID,
                                    intUnidadMedicionID = item.intUnidadMedicionID,
                                    sintMonedaID = item.sintMonedaID,
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    decLargo = item.decLargo,
                                    intNumNivel = item.intNumNivel,
                                    intClip = item.intClip,
                                    intCantidadRuedaRiel = item.intCantidadRuedaRiel,
                                    intCantidad = item.intCantidad,
                                    decCostoPorRuedaUSD = item.decCostoPorRuedaUSD,
                                    decTipoCambio = item.decTipoCambio,
                                    decTotalRielPartida = item.decTotalRielPartida,
                                    bitPlastica = item.bitPlastica,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    intInternacion = item.intInternacion,
                                    decCostoInternacion = item.decCostoInternacion,
                                    
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    
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
        /// <summary>
        /// Procedimiento que lista los rieles de rueda metálica de cartonflow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="sintCantidadRiel"></param>
        /// <param name="intNumNivel"></param>
        /// <param name="decLargoPerfil"></param>
        /// <param name="sintCantidadRuedas"></param>
        /// <param name="decPrecioRuedas"></param>
        /// <param name="decTipoCambio"></param>
        /// <returns></returns>
        public List<SeleccionRiel> ListarRielesRuedaMetalicaCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, short sintCantidadRiel, 
            int intNumNivel, decimal decLargoPerfil, short sintCantidadRuedas, decimal decPrecioRuedas, decimal decTipoCambio)
        {
            List<SeleccionRiel> result = new List<SeleccionRiel>();
            try
            {
                using (RielDataContext dc = new RielDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarRielesRuedaMetalicaCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, sintCantidadRuedas, intNumNivel, decLargoPerfil, sintCantidadRuedas, decPrecioRuedas,
                        decTipoCambio)
                                select new SeleccionRiel
                                {
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    sintCalibre = item.sintCalibre,
                                    vchTipoCartonFlow = item.vchTipoCartonFlow,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    intTotalRieles = item.intTotalRieles,
                                    intTotalRuedas = item.intTotalRuedas,
                                    decCostoTotalRuedas = item.decCostoTotalRuedas,
                                    decClip =  item.decClip,
                                    sintPesoPieza = item.sintPesoPieza,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    vchLeyenda = item.vchLeyenda
                                    //decPesoTotal = item.decPesoTotal,
                                    //decPesoUnitario = item.decPesoUnitario
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
        /// Procedimiento que lista los rieles de rueda platica de cartonflow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="decAncho"></param>
        /// <param name="decLargo"></param>
        /// <param name="sintCantidadRiel"></param>
        /// <param name="decTotalKiloUnitario"></param>
        /// <param name="intNumNivel"></param>
        /// <param name="decLargoPerfil"></param>
        /// <param name="sintCantidadRuedas"></param>
        /// <param name="decPrecioRuedas"></param>
        /// <param name="decTipoCambio"></param>
        /// <param name="intInternacion"></param>
        /// <param name="decCostoInternacion"></param>
        /// <returns></returns>
        public List<SeleccionRiel> ListarRielesRuedaPlasticaCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, decimal decAncho, decimal decLargo, short sintCantidadRiel,
            short decTotalKiloUnitario, int intNumNivel, decimal decLargoPerfil, short sintCantidadRuedas, decimal decPrecioRuedas, decimal decTipoCambio, int intInternacion, decimal decCostoInternacion)
        {
            List<SeleccionRiel> result = new List<SeleccionRiel>();
            try
            {
                using (RielDataContext dc = new RielDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarRielesRuedaPlasticaCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, decAncho, decLargo,
                        sintCantidadRiel, decTotalKiloUnitario, intNumNivel, decLargoPerfil, sintCantidadRuedas,
                        decPrecioRuedas, decTipoCambio, intInternacion, decCostoInternacion)
                                select new SeleccionRiel
                                {
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    sintCalibre = item.sintCalibre,
                                    vchTipoCartonFlow = item.vchTipoCartonFlow,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    intTotalRieles = item.intTotalRieles,
                                    intTotalRuedas = item.intTotalRuedas,
                                    decCostoTotalRuedas = item.decCostoTotalRuedas,
                                    decClip = item.decClip,
                                    decTotalInternacion = item.decTotalInternacion,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    vchLeyenda = item.vchLeyenda
                                    //decPesoTotal = item.decPesoTotal,
                                    //decPesoUnitario = item.decPesoUnitario
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
