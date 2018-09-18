using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.ProteccionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProteccionServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProteccionServices
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
