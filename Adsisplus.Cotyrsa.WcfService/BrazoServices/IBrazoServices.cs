using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.BrazoServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IBrazoServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IBrazoServices
    {

        /// <summary>
        /// Procedimiento que lista los datos de brazo
        /// </summary>
        /// <param name="intBrazoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosBrazo")]
        List<DatosBrazo> ListarDatosBrazo(int intBrazoID, int intDetCotizaID);
        /// <summary>
        /// Procedimiento que lista datos Drive In Brazo
        /// </summary>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosBrazoDriveIn")]
        List<SeleccionBrazo> ListarDatosBrazoDriveIn(bool bitEsEstructural);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos de brazo
        /// </summary>
        /// <param name="brazo"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosBrazo")]
        Resultado setDatosBrazo(DatosBrazo brazo, int intCotizacionID, int intDetCotizaID, short tinOpcion);

    }
}
