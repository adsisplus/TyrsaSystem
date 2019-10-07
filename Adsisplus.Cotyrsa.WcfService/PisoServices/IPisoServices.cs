using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PisoServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPisoServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPisoServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de piso
        /// </summary>
        /// <param name="intDatosPisoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPiso")]
        List<DatosPiso> ListarDatosPiso(int intDatosPisoID, int intCotizacionID);
        /// <summary>
        /// Procedimiento que lista los datos de los pisos registrados
        /// </summary>
        /// <param name="intDatoPisoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosSeleccionPiso")]
        List<SeleccionPiso> ListarDatosSeleccionPiso(int intDatoPisoID);
        /// <summary>
        /// Procedimiento que lista los datos de seleccion Piso Drive In
        /// </summary>
        /// <param name="intCantidad"></param>
        /// <param name="decLargo"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarPisoDriveIn")]
        List<SeleccionPisoDriveIn> ListarPisoDriveIn(int? intCantidad, decimal? decLargo, bool? bitGalvanizado);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos piso
        /// </summary>
        /// <param name="piso"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosPiso")]
        Resultado setDatosPiso(DatosPiso piso, int intCotizacionID, int intDetCotizaID, short tinOpcion);
    }
}
