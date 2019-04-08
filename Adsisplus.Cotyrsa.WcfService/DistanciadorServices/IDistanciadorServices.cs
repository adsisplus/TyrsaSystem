using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.DistanciadorServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDistanciadorServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDistanciadorServices
    {
        /// <summary>
        /// Procedimiento que lista los datos del distanciador en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosDistanciador")]
        List<DatosDistanciador> ListarDatosDistanciador(Int32 intCotizacionID);
        /// <summary>
        /// Obtiene la lista de distanciadores en base al altura
        /// </summary>
        /// <param name="decAltura"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarSeleccionDistanciador")]
        List<SeleccionDistanciador> ListarSeleccionDistanciador(decimal decAltura);
        /// <summary>
        /// Obtiene la lista de valores de altura de distanciador
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatalogoDistanciador")]
        List<CatalogoDecimal> ListarCatalogoDistanciador();
        /// <summary>
        /// Procedimiento que almacena los datos del Distanciador
        /// </summary>
        /// <param name="distanciador"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosDistanciador")]
        Resultado setDatosDistanciador(DatosDistanciador distanciador, short tinOpcion);
    }
}
