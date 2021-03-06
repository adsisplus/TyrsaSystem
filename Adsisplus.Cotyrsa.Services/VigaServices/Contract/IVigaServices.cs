﻿using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.VigaServices.Contract
{
    [ServiceContract]
    interface IVigaServices
    {
        /// <summary>
        /// Obtiene la lista del total por viga
        /// </summary>
        /// <param name="intTotalViga"></param>
        /// <param name="intConfiguraVigaID"></param>
        /// <returns></returns>
        [OperationContract]
        List<TotalViga> ListarTotalViga(Int32 @intTotalViga, Int32 @intConfiguraVigaID);
        /// <summary>
        /// Obtiene la lista de configuración por viga
        /// </summary>
        /// <param name="intConfiguraVigaID"></param>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="intCapacidadVigaID"></param>
        /// <param name="intFactorVigaID"></param>
        /// <param name="sintInsumoViga"></param>
        /// <returns></returns>
        [OperationContract]
        List<Viga> ListarConfiguracionViga(Int32 @intConfiguraVigaID, Int32 @sintTipoVigaID, Int32 @intElementoID, Int32 @intCalibreID, Int32 @intCapacidadVigaID, Int32 @intFactorVigaID, Int16 @sintInsumoViga);
        /// <summary>
        /// Obtiene la lista de los datos por viga
        /// </summary>
        /// <param name="intDatosVigaID"></param>
        /// <param name="sintPinturaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosViga> ListarDatosViga(Int32 @intDatosVigaID, Int16 @sintPinturaID, Int32 @intElementoID, Int32 @intDatoMarcoID);
        /// <summary>
        /// Obtiene la lista de las viga por tope
        /// </summary>
        /// <param name="intCantidadVigaTope"></param>
        /// <param name="intVigaTopeID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatosVigaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosVigaTope> ListarDatosVigaTope(Int32 @intCantidadVigaTope, Int32 @intVigaTopeID, Int32 @intElementoID, Int32 @intDatosVigaID, Int32 @intCotizacionID, Int16 @sintPinturaID);
    }
}
