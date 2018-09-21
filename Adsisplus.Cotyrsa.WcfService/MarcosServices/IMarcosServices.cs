using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.MarcosServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMarcosServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMarcosServices
    {
        /// <summary>
        /// Obtiene la lista de las configuraciones de Marcos
        /// </summary>
        /// <param name="intConfiguraMarcoID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intAlturaMarcoID"></param>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="intSKUID"></param>
        /// <param name="sintFactorMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ConfiguraMarco")]
        List<Configuracion_Marco> ConfiguraMarco(Int32 intConfiguraMarcoID, Int32 intElementoID, Int16 sintTipoMarcoID, Int32 intAlturaMarcoID, Int16 sintFondoMarcoID, Int32 intSKUID, Int16 sintFactorMarcoID);
        /// <summary>
        /// Obtiene la lista de relaciones de sistema de carga de Marcos contra postes
        /// </summary>
        /// <param name="sintSistemaCargaMarcoID"></param>
        /// <param name="intSubProductoID"></param>
        /// <param name="intCargaPosteID"></param>
        /// <param name="intCargaMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "RelSistemaCargaMarcoPoste")]
        List<RelSistemaCargaMarcoPoste> RelSistemaCargaMarcoPoste(Int16 sintSistemaCargaMarcoID, Int32 intSubProductoID, Int32 intCargaPosteID, Int32 intCargaMarcoID);
        /// <summary>
        /// Obtiene la lista de datos de un marco en particular
        /// </summary>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosMarco")]
        List<DatosMarco> ListarDatosMarco(Int32 intDatoMarcoID, Int32 intCotizacionID, Int32 intElementoID, Int16 sintPinturaID);
        /// <summary>
        /// Obtiene la lista de fonto por un marco en particular
        /// </summary>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarFondoMarco")]
        List<FondoMarco> ListarFondoMarco(Int32 sintFondoMarcoID, Int32 sintTipoMarcoID);

        /// <summary>
        /// Cambia los factores de configuración para los marcos
        /// </summary>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="decCostoLamina"></param>
        /// <param name="decCostoSolera"></param>
        /// <param name="decFactorAcero"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ActualizaFactorMarco")]
        Resultado ActualizaFactorMarco(Int16 sintFondoMarcoID, Decimal decCostoLamina, Decimal decCostoSolera, Decimal decFactorAcero, byte tinOpcion);
        /// <summary>
        /// Obtiene la lista el catálogo de factores para los marcos
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatFactorMarco")]
        List<FactorMarco> ListarCatFactorMarco();
    }
}
