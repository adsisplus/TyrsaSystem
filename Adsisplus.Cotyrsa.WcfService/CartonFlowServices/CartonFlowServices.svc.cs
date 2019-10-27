using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CartonFlowServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CartonFlowServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CartonFlowServices.svc o CartonFlowServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CartonFlowServices : ICartonFlowServices
    {
        /// <summary>
        /// Procedimiento que lista el catálogo tipo carton flow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <returns></returns>
        public List<Catalogo> ListarCatCalibreCartonFlow(short sintTipoCartonFlowID)
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CartonFlowLogic()).ListarCatCalibreCartonFlow(sintTipoCartonFlowID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de Carton Flow
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intDatosCartonFlowID"></param>
        /// <returns></returns>
        public List<DatosCartonFlow> ListarDatosCartonFlow(int intDetCotizaID, int intDatosCartonFlowID)
        {
            List<DatosCartonFlow> result = new List<DatosCartonFlow>();
            try
            {
                result = (new CartonFlowLogic()).ListarDatosCartonFlow(intDetCotizaID, intDatosCartonFlowID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los datos de Carton Flow
        /// </summary>
        /// <param name="carton"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosCaronFlow(DatosCartonFlow carton, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new CartonFlowLogic()).setDatosCaronFlow(carton, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
