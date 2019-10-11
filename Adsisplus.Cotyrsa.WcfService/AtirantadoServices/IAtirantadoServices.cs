using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.AtirantadoServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAtirantadoServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAtirantadoServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Atirantado
        /// </summary>
        /// <param name="intAtirantadoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosAtirantado")]
        List<DatosAtirantado> ListarDatosAtirantado(int intAtirantadoID, int intCotizacionID);
        /// <summary>
        /// Procedimiento que lista los datos de selección Arriestrado
        /// </summary>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDriveInArriestrado")]
        List<SeleccionArriestrado> ListarDriveInArriestrado(bool bitEsEstructural);
        /// <summary>
        /// Procedimiento que lista los datos de seleccion Atirantado en base al ID de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarSeleccionAtirantado")]
        List<SeleccionArriestrado> ListarSeleccionAtirantado(int intCotizacionID);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos atirantado
        /// </summary>
        /// <param name="atirantado"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosAtirantado")]
        Resultado setDatosAtirantado(DatosAtirantado atirantado, int intCotizacionID, int intDetCotizaID, short tinOpcion);
    }
}
