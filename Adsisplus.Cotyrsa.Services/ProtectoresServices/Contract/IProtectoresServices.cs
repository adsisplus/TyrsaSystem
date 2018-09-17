using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.ProtectoresServices.Contract
{
    [ServiceContract]
    interface IProtectoresServices
    {
        /// <summary>
        /// Obtiene la lista de los datos de protector por poste
        /// </summary>
        /// <param name="intProtectorPosteID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosProtectorBase> ListarDatosProtectorPoste(Int32 @intProtectorPosteID, Int32 @intElementoID, Int32 @intCotizacionID, Int16 @sintPinturaID);
        /// <summary>
        /// Obtiene la lista de los datos de proctector por batería.
        /// </summary>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosProtectorBateria> ListarDatosProtectorBateria(Int32 @intProtectorBateriaID, Int32 @intElementoID, Int32 @intCotizacionID);
    }
}
