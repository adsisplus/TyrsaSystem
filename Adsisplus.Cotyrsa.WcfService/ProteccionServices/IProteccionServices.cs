using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.ProteccionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProteccionServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProteccionServices
    {
        /// <summary>
        /// Procedimiento que muestra los datos del protector viga en base a la cotización
        /// </summary>
        /// <param name="intProtectorPosteID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="sintPinturaID"></param>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosProtectorPoste")]
        List<DatosProtectorBase> ListarDatosProtectorPoste(Int32 intProtectorPosteID, Int32 intElementoID, Int32 intCotizacionID, int intDetCotizaID, Int16 sintPinturaID);
        /// <summary>
        /// Procedimeinto que nos muestra la información del protector de batería en base a la cotización
        /// </summary>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosProtectorBateria")]
        List<DatosProtectorBateria> ListarDatosProtectorBateria(Int32 intProtectorBateriaID, Int32 intElementoID, Int32 intCotizacionID, int intDetCotizaID);

        /// <summary>
        /// Realiza el alta, modificación o baja a los datos protector poste
        /// </summary>
        /// <param name="datosProtector"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosProtectorPoste")]
        Resultado setDatosProtectorPoste(DatosProtectorBase datosProtector, short tinOpcion);

        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Protector Batería
        /// </summary>
        /// <param name="datosProtectorBateria"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosProtectorBateria")]
        Resultado setDatosProtectorBateria(DatosProtectorBateria datosProtectorBateria, short tinOpcion);
    }
}
