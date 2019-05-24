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

        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de gastos
        /// </summary>
        /// <param name="flete"></param>
        /// <param name="instalacion"></param>
        /// <param name="viaticos"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="bitActivo"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosGastos")]
        Resultado setDatosGastos(DatosFlete flete, DatosInstalacion instalacion, DatosViaticos viaticos, int intCotizacionID, bool bitActivo, short tinOpcion);
    }
}
