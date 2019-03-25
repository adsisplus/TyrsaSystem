using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.ProteccionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ProteccionServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ProteccionServices.svc o ProteccionServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProteccionServices : IProteccionServices
    {
        /// <summary>
        /// Procedimeinto que nos muestra la información del protector de batería en base a la cotización
        /// </summary>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosProtectorBateria> ListarDatosProtectorBateria(int intProtectorBateriaID, int intElementoID, int intCotizacionID, int intDetCotizaID)
        {
            List<DatosProtectorBateria> result = new List<DatosProtectorBateria>();
            try
            {
                result = (new ProtectoresLogic()).ListarDatosProtectorBateria(intProtectorBateriaID, intElementoID, intCotizacionID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que muestra los datos del protector viga en base a la cotización
        /// </summary>
        /// <param name="intProtectorPosteID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="sintPinturaID"></param>
        public List<DatosProtectorBase> ListarDatosProtectorPoste(int intProtectorPosteID, int intElementoID, int intCotizacionID, int intDetCotizaID, short sintPinturaID)
        {
            List<DatosProtectorBase> result = new List<DatosProtectorBase>();
            try
            {
                result = (new ProtectoresLogic()).ListarDatosProtectorPoste(intProtectorPosteID, intElementoID, intCotizacionID, intDetCotizaID, sintPinturaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Realiza el alta, modificación o baja a los datos protector poste
        /// </summary>
        /// <param name="datosProtector"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorPoste(DatosProtectorBase datosProtector, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new ProtectoresLogic()).setDatosProtectorPoste(datosProtector, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Protector Batería
        /// </summary>
        /// <param name="datosProtectorBateria"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorBateria(DatosProtectorBateria datosProtectorBateria, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new ProtectoresLogic()).setDatosProtectorBateria(datosProtectorBateria, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
