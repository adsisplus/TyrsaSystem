using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.AtirantadoServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AtirantadoServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AtirantadoServices.svc o AtirantadoServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AtirantadoServices : IAtirantadoServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Atirantado
        /// </summary>
        /// <param name="intAtirantadoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosAtirantado> ListarDatosAtirantado(int intAtirantadoID, int intCotizacionID)
        {
            List<DatosAtirantado> result = new List<DatosAtirantado>();
            try
            {
                result = (new AtirantadoLogic()).ListarDatosAtirantado(intAtirantadoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de selección Arriestrado
        /// </summary>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        public List<SeleccionArriestrado> ListarDriveInArriestrado(bool bitEsEstructural)
        {
            List<SeleccionArriestrado> result = new List<SeleccionArriestrado>();
            try
            {
                result = (new AtirantadoLogic()).ListarDriveInArriestrado(bitEsEstructural);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion Atirantado en base al ID de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionArriestrado> ListarSeleccionAtirantado(int intCotizacionID)
        {
            List<SeleccionArriestrado> result = new List<SeleccionArriestrado>();
            try
            {
                result = (new AtirantadoLogic()).ListarSeleccionAtirantado(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos atirantado
        /// </summary>
        /// <param name="atirantado"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosAtirantado(DatosAtirantado atirantado, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new AtirantadoLogic()).setDatosAtirantado(atirantado, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
