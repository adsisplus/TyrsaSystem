﻿using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.BarandalServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IBarandalServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IBarandalServices
    {
        ///// <summary>
        ///// Procedimiento que lista los datos de precio DriveIn Barandal en base al largo
        ///// </summary>
        ///// <param name="decLargo"></param>
        ///// <returns></returns>
        //[OperationContract]
        //[WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDriveInBarandal")]
        //List<SeleccionBarandal> ListarDriveInBarandal(decimal decLargo);
        /// <summary>
        /// Procedimiento que lista los datos Barandal
        /// </summary>
        /// <param name="intDatosBarandalID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosBarandal")]
        List<DatosBarandal> ListarDatosBarandal(int intDatosBarandalID, int intCotizacionID);
        /// <summary>
        /// Procedimiento que realiza el alta, baja o modificación de los datos de barandal
        /// </summary>
        /// <param name="barandal"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosBarandal")]
        Resultado setDatosBarandal(DatosBarandal barandal, int intCotizacionID, int intDetCotizaID, short tinOpcion);
    }
}
