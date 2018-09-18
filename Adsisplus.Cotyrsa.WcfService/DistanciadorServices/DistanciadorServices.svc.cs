using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.DistanciadorServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "DistanciadorServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DistanciadorServices.svc o DistanciadorServices.svc.cs en el Explorador de soluciones e inicie la depuración.
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
