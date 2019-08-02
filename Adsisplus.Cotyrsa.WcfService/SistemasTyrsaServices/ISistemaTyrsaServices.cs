using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.SistemasTyrsaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISistemaTyrsaServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISistemaTyrsaServices
    {
        ///// <summary>
        ///// Obtiene la lista de las relaciones de los sistemas selectivos
        ///// </summary>
        ///// <param name="intCotizacionID"></param>
        ///// <param name="intTipoElementoCoti_Producto"></param>
        ///// <param name="intTipoElementoID"></param>
        ///// <param name="intTipoElementoAlmacenID"></param>
        ///// <param name="intConfiguraMarcoID"></param>
        ///// <param name="intConfiguraVigaID"></param>
        ///// <param name="intDatoMarcoID"></param>
        ///// <param name="intDatosVigaID"></param>
        ///// <param name="intDatosPanelID"></param>
        ///// <param name="intDatosCrossBarID"></param>
        ///// <param name="intDistanciadorID"></param>
        ///// <param name="intParrillaID"></param>
        ///// <param name="intVigaTopeID"></param>
        ///// <param name="intProtectorPosteID"></param>
        ///// <param name="intProtectorBateriaID"></param>
        ///// <param name="sintSistemaCargaMarcoID"></param>
        ///// <param name="datFechaAlta"></param>
        ///// <returns></returns>
        //[OperationContract]
        //[WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarRelSistemaSelectivo")]
        //List<RelSistemaSelectivo> ListarRelSistemaSelectivo(Int32 intCotizacionID, Int32 intTipoElementoCoti_Producto, Int32 intTipoElementoID,
        //                                                    Int32 intTipoElementoAlmacenID, Int32 intConfiguraMarcoID, Int32 intConfiguraVigaID,
        //                                                    Int32 intDatoMarcoID, Int32 intDatosVigaID, Int32 intDatosPanelID, Int32 intDatosCrossBarID,
        //                                                    Int32 intDistanciadorID, Int32 intParrillaID, Int32 intVigaTopeID, Int32 intProtectorPosteID,
        //                                                    Int32 intProtectorBateriaID, Int16 sintSistemaCargaMarcoID, DateTime datFechaAlta);

        /// <summary>
        /// Realiza el alta, modificación o baja a los datos Viga
        /// </summary>
        /// <param name="datosMarco"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosMarco")]
        Resultado setDatosMarco(DatosMarco datosMarco, short sintOpcion);
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos Viga
        /// </summary>
        /// <param name="datosViga"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosViga")]
        Resultado setDatosViga(DatosViga datosViga, short sintOpcion);
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos panel
        /// </summary>
        /// <param name="datosPanel"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosPanel")]
        Resultado setDatosPanel(DatosPanel datosPanel, short sintOpcion);
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos de Cross Bar
        /// </summary>
        /// <param name="datosCrossBar"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosCrossBar")]
        Resultado setDatosCrossBar(DatosCrossBar datosCrossBar, short sintOpcion);
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos de distanciador
        /// </summary>
        /// <param name="datosDistanciador"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosDistanciador")]
        Resultado setDatosDistanciador(DatosDistanciador datosDistanciador, short sintOpcion);
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Parrilla
        /// </summary>
        /// <param name="datosParrilla"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosParrilla")]
        Resultado setDatosParrilla(DatosParrilla datosParrilla, short sintOpcion);
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Viga tope
        /// </summary>
        /// <param name="datosVigaTope"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosVigaTope")]
        Resultado setDatosVigaTope(DatosVigaTope datosVigaTope, short sintOpcion);
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos protector poste
        /// </summary>
        /// <param name="datosProtector"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosProtectorPoste")]
        Resultado setDatosProtectorPoste(DatosProtectorBase datosProtector, short sintOpcion);
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Protector Batería
        /// </summary>
        /// <param name="datosProtectorBateria"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosProtectorBateria")]
        Resultado setDatosProtectorBateria(DatosProtectorBateria datosProtectorBateria, short sintTipoBateria, short sintOpcion);

        /// <summary>
        /// Procedimiento que muestra los datos de tornilleria
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="bitEstructural"></param>
        /// <param name="bitEsCuadruple"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosTornilleria")]
        List<DatosTornilleria> ListarDatosTornilleria(int intCotizacionID, bool bitEstructural, bool bitEsCuadruple);

        /// <summary>
        /// Procedimiento que devuelve los datos de tornillería en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarTornillosSelectivoCotizacion")]
        List<DatosTornilleria> ListarTornillosSelectivoCotizacion(int intCotizacionID);
    }
}
