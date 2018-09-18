using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.DistanciadorServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDistanciadorServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDistanciadorServices
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
