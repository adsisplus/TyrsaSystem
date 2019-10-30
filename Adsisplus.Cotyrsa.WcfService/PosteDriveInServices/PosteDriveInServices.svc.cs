using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PosteDriveInServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PosteDriveInServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PosteDriveInServices.svc o PosteDriveInServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PosteDriveInServices : IPosteDriveInServices
    {
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos Poste Drive In
        /// </summary>
        /// <param name="poste"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPosteDriveIn(DatosPosteDriveIn poste, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new PosteDriveInLogic()).setDatosPosteDriveIn(poste, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el precio poste TC 2
        /// </summary>
        /// <param name="intAlturaMarcoID"></param>
        /// <param name="decFondoMarco"></param>
        /// <returns></returns>
        public List<DatosPrecioPoste> ListarPrecioPosteTC2(int intAlturaMarcoID, decimal decFondoMarco)
        {
            List<DatosPrecioPoste> result = new List<DatosPrecioPoste>();
            try
            {
                result = (new PosteDriveInLogic()).ListarPrecioPosteTC2(intAlturaMarcoID, decFondoMarco);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los postes en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPrecioPoste> ListarSeleccionPoste(int intCotizacionID)
        {
            List<DatosPrecioPoste> result = new List<DatosPrecioPoste>();
            try
            {
                result = (new PosteDriveInLogic()).ListarSeleccionPoste(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos poste drive in
        /// </summary>
        /// <param name="intDatoPosteDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        public List<DatosPosteDriveIn> ListarDatosPosteDriveIn(int intDatoPosteDriveInID, int intCotizacionID, int intDatoMarcoID)
        {
            List<DatosPosteDriveIn> result = new List<DatosPosteDriveIn>();
            try
            {
                result = (new PosteDriveInLogic()).ListarDatosPosteDriveIn(intDatoPosteDriveInID, intCotizacionID, intDatoMarcoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
