using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.DireccionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDireccionServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDireccionServices
    {
        /// <summary>
        /// Nos devuelve los datos de las personas
        /// </summary>
        /// <param name="intDireccionID"></param>
        /// <param name="intMunicipioID"></param>
        /// <param name="intEstadoID"></param>
        /// <param name="intLocalidadID"></param>
        /// <param name="intTipoDomicilioID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPersona")]
        List<Direccion> ListarDatosPersona(Int32 @intDireccionID, Int32 @intMunicipioID, Int32 @intEstadoID, Int32 @intLocalidadID, Int32 @intTipoDomicilioID);

        /// <summary>
        /// Permite realizar el alta, modificación o baja de los datos de domicilio
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDomicilio")]
        Resultado setDomicilio(Direccion direccion, short tinOpcion);
    }
}
