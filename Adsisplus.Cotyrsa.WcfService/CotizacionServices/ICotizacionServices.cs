using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CotizacionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICotizacionServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICotizacionServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intEstatusID"></param>
        /// <param name="sintPrioridadID"></param>
        /// <param name="intEmpresaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosCotizacion")]
        List<Cotizacion> ListarDatosCotizacion(Int32 intCotizacionID, Int32 intEstatusID, Int32 sintPrioridadID, Int32 intEmpresaID);
        /// <summary>
        /// Obtiene la lista de la relación de tipo elemento almacen vs Factor de cotización
        /// </summary>
        /// <param name="intTipoElementoAlmacen_FactorID"></param>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="sintFactorID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarRel_TipoElementoAlmacen_FactorCotizacion")]
        List<RelTipoElementoAlmacenFactorCotizacion> ListarRel_TipoElementoAlmacen_FactorCotizacion(int intTipoElementoAlmacen_FactorID,
            int intTipoElementoAlmacenID, short sintFactorID);

        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de la tabla mst_Cotizacion
        /// </summary>
        /// <param name="cotizacion"></param>
        /// <param name="rack"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setMstCotizacion")]
        Resultado setMstCotizacion(Cotizacion cotizacion, RackSelectivo rack, short tinOpcion);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de la tabla det_Cotizacion
        /// </summary>
        /// <param name="cotizacion"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDetCotizacion")]
        Resultado setDetCotizacion(Cotizacion cotizacion, short tinOpcion);
        /// <summary>
        /// Procedimiento que realiza la relación entre cotización y el sistema selectivo
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosRelSistemaSelectivo")]
        Resultado setDatosRelSistemaSelectivo(RelSistemaSelectivo sistema, short tinOpcion);
        /// <summary>
        /// Procedimeinto que lista los datos de la cotización
        /// </summary>
        /// <param name="intEmpresaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCotizacion")]
        List<Cotizacion> ListarCotizacion(int intEmpresaID, int intCotizacionID);
        /// <summary>
        /// Procedimiento que nos devuelve los ID's de los elementos ligados a la cotización
        /// y al sistema selectivo
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosSistemaSelectivo")]
        RelSistemaSelectivo ListarDatosSistemaSelectivo(int intCotizacionID);

        /// <summary>
        /// Procedimiento que lista el detalle de cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDetalleCotizacion")]
        List<Cotizacion> ListarDetalleCotizacion(int intCotizacionID, int intElementoID);
        /// <summary>
        /// Procedimiento que nos devuelve la información capturada/mostrada en cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPantallaCotizacion")]
        Cotizacion ListarDatosPantallaCotizacion(int intCotizacionID);

    }
}
