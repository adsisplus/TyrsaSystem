using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.ParrillaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ParrillaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ParrillaServices.svc o ParrillaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ParrillaServices : IParrillaServices
    {
        /// <summary>
        /// Procedimiento que muestra los datos de la parrilla en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosParrilla> ListarDatosParrilla(int intCotizacionID)
        {
            List<DatosParrilla> result = new List<DatosParrilla>();
            try
            {
                result = (new ParrillaLogic()).ListarDatosParrilla(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que almacena los datos de la parrilla
        /// </summary>
        /// <param name="parrilla"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosParrilla(DatosParrilla parrilla, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new ParrillaLogic()).setDatosParrilla(parrilla, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que realiza la baja lógica y física (en caso de existir error) en los 
        /// datos de la parrilla
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = realiza el borrado físico de los datos
        ///                         0 = realiza el borrado lógico de los datos</param>
        /// <returns></returns>
        public Resultado setBajaParrilla(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new ParrillaLogic()).setBajaParrilla(intDetCotizaID, bitRollBack);
            }
            catch(Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
