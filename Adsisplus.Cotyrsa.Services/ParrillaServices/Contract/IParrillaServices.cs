using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.ParrillaServices.Contract
{
    [ServiceContract]
    interface IParrillaServices
    {
        /// <summary>
        /// Obtiene la lista de datos del panel
        /// </summary>
        /// <param name="intParrillaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="sintPinturaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosParrilla> ListarDatosPanel(Int32 @intParrillaID, Int32 @intElementoID, Int16 @sintPinturaID, Int32 @intCotizacionID);
    }
}
