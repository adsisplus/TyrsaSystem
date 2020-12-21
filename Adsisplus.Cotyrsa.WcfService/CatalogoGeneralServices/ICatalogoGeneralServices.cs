using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessEntities.Catalogos;
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

        #region Catálogos iniciales
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
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarViatico")]
        List<DatosViaticos> ListarViatico();
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
        List<DatosFlete> ListarCatFlete(short sintDestinoFleteID);
        /// <summary>
        /// Procedimiento que lista los datos de instalación
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatInstalacion")]
        List<DatosInstalacion> ListarCatInstalacion(int intCotizacionID);
        /// <summary>
        /// Procedimiento que lista el tipo de unidad flete
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoUnidadFlete")]
        List<Catalogo> ListarCatTipoUnidadFlete();
        /// <summary>
        /// Procedimiento que lista el catálogo de monedas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatMoneda")]
        List<Catalogo> ListarCatMoneda();

        #endregion


        #region Unidades de Medición
        [OperationContract]
        [WebGet(UriTemplate = "GetUnidadesMedicion", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<UnidadMedicion> GetUnidadesMedicion();
        #endregion


        #region Viaticos 
        [OperationContract]
        [WebGet(UriTemplate = "GetViaticos", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Viatico> GetViaticos();

        [OperationContract]
        [WebInvoke( UriTemplate = "EditViatico", ResponseFormat = WebMessageFormat.Json,Method = "POST")]
        void EditViatico(Viatico viatico);


        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteViatico?viaticoId={viaticoId}", ResponseFormat = WebMessageFormat.Json,Method ="DELETE")]
        void DeleteViatico(short viaticoId);
        #endregion


        #region Tornillería
        /// <summary>
        /// Obtiene la colección de tornillos
        /// </summary>
        /// <returns>Tornillos</returns>
        /// <author>Fernando Ricardo Morán</author>
        [OperationContract]
        [WebGet(UriTemplate = "GetTornillos", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Tornillo> GetTornillos();

        /// <summary>
        /// Crea/actualiza un registro de tornillo
        /// </summary>
        /// <param name="tornillo">Instancia del tornillo</param>
        /// <author>Fernando Ricardo Morán</author>
        [OperationContract]
        [WebInvoke(UriTemplate = "EditTornillo", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        void EditTornillo(Tornillo viatico);


        /// <summary>
        /// Elimina el registro de un tornillo
        /// </summary>
        /// <param name="tornilloId">Identificador del tornillo</param>
        /// <author>Fernando Ricardo Morán</author>
        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteTornillo?tornilloId={tornilloId}", ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        void DeleteTornillo(short tornilloId);
        #endregion
    }
}
