using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.GastosServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGastosServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGastosServices
    {
        /// <summary>
        /// Procedimiento que devuelve los datos de la pantalla de Gastos
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosPantallaGastos")]
        List<DatosGastos> ListarDatosPantallaGastos(int intCotizacionID, int intDetCotizaID);

        ///// <summary>
        ///// Procedimiento que realiza el alta, modificación o baja de los datos de gastos
        ///// </summary>
        ///// <param name="flete"></param>
        ///// <param name="instalacion"></param>
        ///// <param name="viaticos"></param>
        ///// <param name="intCotizacionID"></param>
        ///// <param name="bitActivo"></param>
        ///// <param name="tinOpcion"></param>
        ///// <returns></returns>
        //[OperationContract]
        //[WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosGastos")]
        //Resultado setDatosGastos(DatosFlete flete, DatosInstalacion instalacion, DatosViaticos viaticos, int intCotizacionID, bool bitActivo, short tinOpcion);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de flete
        /// </summary>
        /// <param name="flete"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosFlete")]
        Resultado setDatosFlete(List<DatosFlete> lstFlete, short tinOpcion);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de instalación
        /// </summary>
        /// <param name="instalacion"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosInstalacion")]
        Resultado setDatosInstalacion(List<DatosInstalacion> lstInstalacion, short tinOpcion);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de viaticos
        /// </summary>
        /// <param name="viatico"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosViatico")]
        Resultado setDatosViatico(List<DatosViaticos> lstViatico, short tinOpcion);
    }
}
