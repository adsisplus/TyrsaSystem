using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.ConectorServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IConectorServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConectorServices
    {

        /// <summary>
        /// Procedimiento que lista los conectores en base al calibre y cantidad
        /// </summary>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="intCantidad"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarConectorCartonFlow")]
        List<SeleccionConector> ListarConectorCartonFlow(short intCalibreAceroID, int intCantidad);
        /// <summary>
        /// Procedimiento que lista los datos de conector de carton flow en base al ID de la cotización o al Id del conector
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatosConectorCFID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosConectorCartonFlow")]
        List<DatosConectorCartonFlow> ListarDatosConectorCartonFlow(int intCotizacionID, int intDatosConectorCFID);
        /// <summary>
        /// Procedimiento que realiza el alta de los conectores carton flow
        /// </summary>
        /// <param name="conector"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosConectorCartonFlow")]
        Resultado setDatosConectorCartonFlow(DatosConectorCartonFlow conector, int intCotizacionID, int intDetCotizaID, short tinOpcion);
    }
}
