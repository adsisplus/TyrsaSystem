using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.DriveInServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDriveInServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDriveInServices
    {
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
        /// <summary>
        /// Procedimiento que lista los datos de DriveIn
        /// </summary>
        /// <param name="intDatosDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosDriveIn")]
        List<DatosDriveIn> ListarDatosDriveIn(int intDatosDriveInID, int intCotizacionID);
        /// <summary>
        /// Procedimiento que lista los datos Drive In en base al tipo de viga
        /// </summary>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="sintLongitudID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosMstDriveIn")]
        List<DriveIn> ListarDatosMstDriveIn(short sintTipoVigaID, short sintLongitudID, int intCalibreID, short sintLargoID);
    }
}
