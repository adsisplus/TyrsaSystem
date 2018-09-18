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
        /// Obtiene la lista de los datos de protector por poste
        /// </summary>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosProtectorBateria> ListarDatosProtectorBateria(int intProtectorBateriaID, int intElementoID, int intCotizacionID)
        {
            List<DatosProtectorBateria> result = new List<DatosProtectorBateria>();
            try
            {
                result = (new ProtectoresLogic()).ListarDatosProtectorBateria(intProtectorBateriaID, intElementoID, intCotizacionID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de los datos de proctector por batería.
        /// </summary>
        /// <param name="intProtectorPosteID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosProtectorBase> ListarDatosProtectorPoste(int intProtectorPosteID, int intElementoID, int intCotizacionID, short sintPinturaID)
        {
            List<DatosProtectorBase> result = new List<DatosProtectorBase>();
            try
            {
                result = (new ProtectoresLogic()).ListarDatosProtectorPoste(intProtectorPosteID, intElementoID, intCotizacionID, sintPinturaID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
