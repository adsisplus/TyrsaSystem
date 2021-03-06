﻿using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.GuiaEntradaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGuiaEntradaServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGuiaEntradaServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Guia Entrada
        /// </summary>
        /// <param name="intGuiaEntradaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosGuiaEntrada")]
        List<DatosGuiaEntrada> ListarDatosGuiaEntrada(int intGuiaEntradaID, int intCotizacionID);
        /// <summary>
        /// Procedimiento que lista los datos de guia monta carga en base al largo
        /// </summary>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosGuiaMontaCargaDriveIn")]
        List<DatosMontaCargaDriveIn> ListarDatosGuiaMontaCargaDriveIn(short sintLargoID);
        /// <summary>
        /// Procedimiento que lista los datos de seleccion de guia monta carga en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarSeleccionGuiaMontaCarga")]
        List<SeleccionGuiaMonteCarga> ListarSeleccionGuiaMontaCarga(int intCotizacionID);
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos Guia Entrada
        /// </summary>
        /// <param name="guia"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setDatosGuiaEntrada")]
        Resultado setDatosGuiaEntrada(DatosGuiaEntrada guia, int intCotizacionID, int intDetCotizaID, short tinOpcion);
    }
}
