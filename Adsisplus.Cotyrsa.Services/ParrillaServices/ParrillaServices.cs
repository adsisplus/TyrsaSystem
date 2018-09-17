using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.ParrillaServices.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.ParrillaServices
{
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
