using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.ParrillaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IParrillaServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IParrillaServices
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
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPanel")]
        List<DatosParrilla> ListarDatosPanel(Int32 @intParrillaID, Int32 @intElementoID, Int16 @sintPinturaID, Int32 @intCotizacionID);
    }
}
