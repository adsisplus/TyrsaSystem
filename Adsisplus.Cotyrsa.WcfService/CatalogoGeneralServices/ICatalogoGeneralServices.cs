using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CatalogoGeneralServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICatalogoGeneralServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICatalogoGeneralServices
    {
        /// <summary>
        /// Obtiene la lista de localidades en base al municipio
        /// </summary>
        /// <param name="int_MunicipioID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatLocalidad")]
        List<Localidad> ListarCatLocalidad(Int32 int_MunicipioID);
        /// <summary>
        /// Obtiene la lista de estados de la república mexicana
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatEstado")]
        List<Catalogo> ListarCatEstado();
        /// <summary>
        /// Obtiene la lista de municipios en base al estado seleccionado
        /// </summary>
        /// <param name="intEstadoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatMunicipio")]
        List<Municipio> ListarCatMunicipio(Int32 intEstadoID);
        /// <summary>
        /// Obtiene la lista de personalidades
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatPersonalidad")]
        List<Catalogo> ListarCatPersonalidad();
        /// <summary>
        /// Obtiene la lista de prioridades
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatPrioridad")]
        List<Catalogo> ListarCatPrioridad();
        /// <summary>
        /// Obtiene la lista de tipos de domicilios
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoDomicilio")]
        List<Catalogo> ListarCatTipoDomicilio();
        /// <summary>
        /// Obtiene la lista de tipos de empresas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoEmpresa")]
        List<Catalogo> ListarCatTipoEmpresa();
        /// <summary>
        /// Obtiene la lista de tipos de personas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoPersona")]
        List<Catalogo> ListarCatTipoPersona();

        /// <summary>
        /// Procedimiento que lista los datos de catálogos
        /// </summary>
        /// <param name="intUnidadMedicionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatViatico")]
        List<Catalogo> ListarCatViatico(int intUnidadMedicionID);
        /// <summary>
        /// Procedimiento que lista los datos de destino flete
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatDestinoFlete")]
        List<Catalogo> ListarCatDestinoFlete();
        /// <summary>
        /// Procedimiento que obtiene la lista de catálogo flete
        /// </summary>
        /// <param name="sintDestinoFleteID"></param>
        /// <param name="sintTipoUnidadFleteID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatFlete")]
        List<Catalogo> ListarCatFlete(short sintDestinoFleteID, short sintTipoUnidadFleteID);
        /// <summary>
        /// Procedimiento que lista los datos de instalación
        /// </summary>
        /// <param name="intUnidadMedicionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatInstalacion")]
        List<Catalogo> ListarCatInstalacion(int intUnidadMedicionID);
    }
}
