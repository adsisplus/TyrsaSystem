using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CartonFlowServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICartonFlowServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICartonFlowServices
    {
        /// <summary>
        /// Procedimiento que lista el catálogo tipo carton flow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatCalibreCartonFlow")]
        List<Catalogo> ListarCatCalibreCartonFlow(short sintTipoCartonFlowID);
        /// <summary>
        /// Procedimiento que lista los datos de Carton Flow
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intDatosCartonFlowID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosCartonFlow")]
        List<DatosCartonFlow> ListarDatosCartonFlow(int intDetCotizaID, int intDatosCartonFlowID);
        /// <summary>
        /// Procedimiento que realiza el alta de los datos de Carton Flow
        /// </summary>
        /// <param name="carton"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosCaronFlow")]
        Resultado setDatosCaronFlow(DatosCartonFlow carton, int intCotizacionID, int intDetCotizaID, short tinOpcion);
    }
}
