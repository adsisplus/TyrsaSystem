using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.Distanciador.Contract
{
    [ServiceContract]
    interface IDistanciadorServices
    {
        /// <summary>
        /// Obtiene la lista de Datos por panel
        /// </summary>
        /// <param name="intDistanciadorID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosDistanciador> ListarDatosPanel(Int32 @intDistanciadorID, Int32 @intCotizacionID, Int32 @intElementoID);
    }
}
