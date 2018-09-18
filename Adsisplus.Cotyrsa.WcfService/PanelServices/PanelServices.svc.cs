using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PanelServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PanelServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PanelServices.svc o PanelServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PanelServices : IPanelServices
    {
        /// <summary>
        /// Obtiene la lista de datos del panel
        /// </summary>
        /// <param name="intDatosPanelID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosPanel> ListarDatosPanel(int intDatosPanelID, int intElementoID, int intDatoMarcoID, short sintPinturaID)
        {
            List<DatosPanel> result = new List<DatosPanel>();
            try
            {
                result = (new PanelLogic()).ListarDatosPanel(intDatosPanelID, intElementoID, intDatoMarcoID, sintPinturaID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
