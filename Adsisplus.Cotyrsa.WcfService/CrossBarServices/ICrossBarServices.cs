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
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarAnchoCrossBar")]
        List<CatalogoDecimal> ListarAnchoCrossBar();

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
        /// Procedimiento que obtiene los datos de la seleccion de Cross Bar
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosSeleccionCrossBar")]
        List<SeleccionCrossBar> ListarDatosSeleccionCrossBar(int intCotizacionID);
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
        /// <summary>
        /// Procedimiento que realiza la baja lógica y física (en caso de existir un error) de los registros
        /// de CrossBar
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = realiza el borrado físico del registro
        ///                         0 = realiza el borrado lógido del registro</param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setBajaCrossBar")]
        Resultado setBajaCrossBar(int intDetCotizaID, bool bitRollBack);
    }
}
