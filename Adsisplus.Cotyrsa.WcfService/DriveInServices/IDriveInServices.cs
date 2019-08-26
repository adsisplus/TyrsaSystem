using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.WcfService.DriveInServices
{
    public interface IDriveInServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de DriveIn
        /// </summary>
        /// <param name="intDatosDriveInID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosDriveIn")]
        List<DatosDriveIn> ListarDatosDriveIn(int intDatosDriveInID, int intDetCotizaID);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos Drive In
        /// </summary>
        /// <param name="drive"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosDriveIn")]
        Resultado setDatosDriveIn(DatosDriveIn drive, int intCotizacionID, int intDetCotizaID, short tinOpcion);
    }
}
