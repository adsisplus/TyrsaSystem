using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PisoServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PisoServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PisoServices.svc o PisoServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PisoServices : IPisoServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de piso
        /// </summary>
        /// <param name="intDatosPisoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPiso> ListarDatosPiso(int intDatosPisoID, int intCotizacionID)
        {
            List<DatosPiso> result = new List<DatosPiso>();
            try
            {
                result = (new PisoLogic()).ListarDatosPiso(intDatosPisoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de los pisos registrados
        /// </summary>
        /// <param name="intDatoPisoID"></param>
        /// <returns></returns>
        public List<SeleccionPiso> ListarDatosSeleccionPiso(int intDatoPisoID)
        {
            List<SeleccionPiso> result = new List<SeleccionPiso>();
            try
            {
                result = (new PisoLogic()).ListarDatosSeleccionPiso(intDatoPisoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion Piso Drive In
        /// </summary>
        /// <param name="intCantidad"></param>
        /// <param name="decLargo"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<SeleccionPisoDriveIn> ListarPisoDriveIn(int? intCantidad, decimal? decLargo, bool? bitGalvanizado)
        {
            List<SeleccionPisoDriveIn> result = new List<SeleccionPisoDriveIn>();
            try
            {
                result = (new PisoLogic()).ListarPisoDriveIn(intCantidad, decLargo, bitGalvanizado);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos piso
        /// </summary>
        /// <param name="piso"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPiso(DatosPiso piso, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new PisoLogic()).setDatosPiso(piso, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
