using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PersonaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPersonaServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPersonaServices
    {
        /// <summary>
        /// Obtiene los datos de la persona
        /// </summary>
        /// <param name="intPersonaID"></param>
        /// <param name="intTipoPersonaID"></param>
        /// <param name="intEmpresaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPersona")]
        List<Persona> ListarDatosPersona(Int32 intPersonaID, Int32 intTipoPersonaID, Int32 intEmpresaID);
        /// <summary>
        /// Obtiene la relación de persona, dirección y empresa
        /// </summary>
        /// <param name="intPersonaDomEmpreID"></param>
        /// <param name="intPersonaID"></param>
        /// <param name="intDireccionID"></param>
        /// <param name="intEmpresaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarRelPersonaDireccionEmpresa")]
        List<Persona> ListarRelPersonaDireccionEmpresa(Int32 intPersonaDomEmpreID, Int32 intPersonaID, Int32 intDireccionID, Int32 intEmpresaID);
        /// <summary>
        /// Permite el alta, modificación o baja de la persona
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setPersona")]
        Resultado setPersona(Persona persona, short tinOpcion);
        /// <summary>
        /// Realiza alta, modificación y baja de la relación Persona, Domicilio y Empresa
        /// </summary>
        /// <param name="relPersonaDomicilioEmpresa"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setRelacionPersonaDomicilioEmpresa")]
        Resultado setRelacionPersonaDomicilioEmpresa(RelPersonaDomicilioEmpresa relPersonaDomicilioEmpresa, short tinOpcion);
    }
}
