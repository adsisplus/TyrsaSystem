using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.Distanciador.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.Distanciador
{
    public class DistanciadorServices : IDistanciadorServices
    {
        /// <summary>
        /// Obtiene la lista de Datos por panel
        /// </summary>
        /// <param name="intDistanciadorID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        public List<DatosDistanciador> ListarDatosPanel(int intDistanciadorID, int intCotizacionID, int intElementoID)
        {
            List<DatosDistanciador> result = new List<DatosDistanciador>();
            try
            {
                result = (new DistanciadorLogic()).ListarDatosPanel(intDistanciadorID, intCotizacionID, intElementoID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
