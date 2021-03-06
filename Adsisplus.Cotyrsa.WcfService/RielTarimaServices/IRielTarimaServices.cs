﻿using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.RielTarimaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRielTarimaServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRielTarimaServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Riel Tarima
        /// </summary>
        /// <param name="intRielTarimaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosRielTarima")]
        List<DatosRielTarima> ListarDatosRielTarima(int intRielTarimaID, int intCotizacionID);
        /// <summary>
        /// Procedimiento que lista los datos de Riel Tarima en base al ID de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarSeleccionRielTarima")]
        List<SeleccionRielDeCarga> ListarSeleccionRielTarima(int intCotizacionID);
        /// <summary>
        /// Procedimiento que lista los datos de seleccion riel de carga
        /// </summary>
        /// <param name="decPeso"></param>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDriveInRielDeCarga")]
        List<SeleccionRielDeCarga> ListarDriveInRielDeCarga(decimal decPeso, bool bitEsEstructural);
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
