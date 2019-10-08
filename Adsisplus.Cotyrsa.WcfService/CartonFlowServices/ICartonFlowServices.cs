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
        /// Procedmiento que lista el catálogo de perfil carton Flow
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatPerfilCartonFlow")]
        List<Catalogo> ListarCatPerfilCartonFlow();
        /// <summary>
        /// Procedimiento que lista el catálogo tipo carton flow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatCalibreCartonFlow")]
        List<Catalogo> ListarCatCalibreCartonFlow(short sintTipoCartonFlowID);
        /// <summary>
        /// Procedimiento que lista los datos perfil carton flow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="decLargoPerfil"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarPerfilCartonFlow")]
        List<DatosPerfilCartonFlow> ListarPerfilCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, decimal decLargoPerfil);
    }
}
