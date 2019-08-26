using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.WcfService.BrazoServices
{
    public interface IBrazoServices
    {
        /// <summary>
        /// Procedimiento que lista el catálogo de largo de Brazo
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatLargoBrazo")]
        List<CatalogoDecimal> ListarCatLargoBrazo();

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
