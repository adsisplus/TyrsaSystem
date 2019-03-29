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
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosParrilla")]
        List<DatosParrilla> ListarDatosParrilla(Int32 intCotizacionID);
        /// <summary>
        /// Procedimiento que almacena los datos de la parrilla
        /// </summary>
        /// <param name="parrilla"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosParrilla")]
        Resultado setDatosParrilla(DatosParrilla parrilla, short tinOpcion);
    }
}
