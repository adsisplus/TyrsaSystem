using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.WcfService.RielTarimaServices
{
    public interface IRielTarimaServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Riel Tarima
        /// </summary>
        /// <param name="intRielTarimaID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosRielTarima")]
        List<DatosRielTarima> ListarDatosRielTarima(int intRielTarimaID, int intDetCotizaID);
        /// <summary>
        /// Procedimiento que realiza el alta o modificación de los datos Riel Tarima
        /// </summary>
        /// <param name="riel"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosRielTarima")]
        Resultado setDatosRielTarima(DatosRielTarima riel, int intCotizacionID, int intDetCotizaID, short tinOpcion);
    }
}
