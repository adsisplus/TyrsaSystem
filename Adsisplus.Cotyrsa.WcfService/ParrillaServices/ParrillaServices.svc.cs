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
        /// Obtiene la lista de datos del panel
        /// </summary>
        /// <param name="intParrillaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="sintPinturaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosParrilla> ListarDatosPanel(int intParrillaID, int intElementoID, short sintPinturaID, int intCotizacionID)
        {
            List<DatosParrilla> result = new List<DatosParrilla>();
            try
            {
                result = (new ParrillaLogic()).ListarDatosPanel(intParrillaID, intElementoID, sintPinturaID, intCotizacionID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
