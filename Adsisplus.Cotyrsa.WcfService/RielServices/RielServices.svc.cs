using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.RielServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RielServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RielServices.svc o RielServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RielServices : IRielServices
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
                result = (new RielLogic()).ListarDatosRielPortaRueda(intRielPortaRuedaID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new RielLogic()).ListarRielesRuedaMetalicaCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, sintCantidadRiel,
                    intNumNivel, decLargoPerfil, sintCantidadRuedas, decPrecioRuedas, decTipoCambio);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new RielLogic()).ListarRielesRuedaPlasticaCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, decAncho, decLargo, sintCantidadRiel,
                    decTotalKiloUnitario, intNumNivel, decLargoPerfil, sintCantidadRuedas, decPrecioRuedas, decTipoCambio, intInternacion, decCostoInternacion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y  baja de los datos de riel porta rueda
        /// </summary>
        /// <param name="riel"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosRielPortaRueda(DatosRielPortaRueda riel, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new RielLogic()).setDatosRielPortaRueda(riel, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
