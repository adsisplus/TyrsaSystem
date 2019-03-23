using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CrossBarServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICrossBarServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICrossBarServices
    {
        /// <summary>
        /// Obtiene la lista de datos del panel
        /// </summary>
        /// <param name="intDatosCrossBarID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPanel")]
        List<DatosCrossBar> ListarDatosPanel(Int32 intDatosCrossBarID, Int32 intElementoID, Int32 intDatoMarcoID);

        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarAnchoCrossBar")]
        List<decimal> ListarAnchoCrossBar();

        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <param name="decAncho"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarSeleccionCrossBar")]
        List<SeleccionCrossBar> ListarSeleccionCrossBar(decimal decAncho);
        /// <summary>
        /// Procedimiento que devuelve la información de una CrossBar seleccionadao
        /// </summary>
        /// <param name="intSeleccionCrossBarID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPantallaCrossBar")]
        List<DatosPantallaCrossBar> ListarDatosPantallaCrossBar(int intSeleccionCrossBarID, int intCotizacionID);
        /// <summary>
        /// Procedimiento que realiza el alta del CrossBar a la cotización
        /// </summary>
        /// <param name="dppCrossBar"></param>
        /// <param name="crossBar"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intCantidad"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setSeleccionCrossBar")]
        Resultado setSeleccionCrossBar(DatosPantallaCrossBar dppCrossBar, SeleccionCrossBar crossBar, int intCotizacionID, int intDetCotizaID, int intCantidad, short tinOpcion);
    }
}
