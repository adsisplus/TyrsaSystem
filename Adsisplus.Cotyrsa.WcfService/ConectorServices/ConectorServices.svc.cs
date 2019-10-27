using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.ConectorServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ConectorServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ConectorServices.svc o ConectorServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ConectorServices : IConectorServices
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
                result = (new ConectorLogic()).ListarConectorCartonFlow(intCalibreAceroID, intCantidad);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new ConectorLogic()).ListarDatosConectorCartonFlow(intCotizacionID, intDatosConectorCFID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los conectores carton flow
        /// </summary>
        /// <param name="conector"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosConectorCartonFlow(DatosConectorCartonFlow conector, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new ConectorLogic()).setDatosConectorCartonFlow(conector, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
