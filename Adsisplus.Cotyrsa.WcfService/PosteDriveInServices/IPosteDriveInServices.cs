using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PosteDriveInServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPosteDriveInServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPosteDriveInServices
    {
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos Poste Drive In
        /// </summary>
        /// <param name="poste"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosPosteDriveIn")]
        Resultado setDatosPosteDriveIn(DatosPosteDriveIn poste, int intCotizacionID, int intDetCotizaID, short tinOpcion);
        /// <summary>
        /// Procedimiento que lista el precio poste TC 2
        /// </summary>
        /// <param name="intAlturaMarcoID"></param>
        /// <param name="decFondoMarco"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarPrecioPosteTC2")]
        List<DatosPrecioPoste> ListarPrecioPosteTC2(int intAlturaMarcoID, decimal decFondoMarco);
        /// <summary>
        /// Procedimiento que lista los datos poste drive in
        /// </summary>
        /// <param name="intDatoPosteDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPosteDriveIn")]
        List<DatosPosteDriveIn> ListarDatosPosteDriveIn(int intDatoPosteDriveInID, int intCotizacionID, int intDatoMarcoID);
    }
}
