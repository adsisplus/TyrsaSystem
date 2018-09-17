using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.PanelServices.Contrac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.PanelServices
{
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
            catch(Exception ex)
            {

            }
            return result;
        }
    }
}
