using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.MarcosService.Contract
{
    [ServiceContract]
    interface IMarcosServices
    {
        /// <summary>
        /// Obtiene la lista de las configuraciones de Marcos
        /// </summary>
        /// <param name="intConfiguraMarcoID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intAlturaMarcoID"></param>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="intSKUID"></param>
        /// <param name="sintFactorMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Configuracion_Marco> ConfiguraMarco(Int32 @intConfiguraMarcoID, Int32 @intElementoID, Int16 @sintTipoMarcoID, Int32 @intAlturaMarcoID, Int16 @sintFondoMarcoID, Int32 @intSKUID, Int16 @sintFactorMarcoID);
        /// <summary>
        /// Obtiene la lista de relaciones de sistema de carga de Marcos contra postes
        /// </summary>
        /// <param name="sintSistemaCargaMarcoID"></param>
        /// <param name="intSubProductoID"></param>
        /// <param name="intCargaPosteID"></param>
        /// <param name="intCargaMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<RelSistemaCargaMarcoPoste> RelSistemaCargaMarcoPoste(Int16 @sintSistemaCargaMarcoID, Int32 @intSubProductoID, Int32 @intCargaPosteID, Int32 @intCargaMarcoID);
        /// <summary>
        /// Obtiene la lista de datos de un marco en particular
        /// </summary>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosMarco> ListarDatosMarco(Int32 @intDatoMarcoID, Int32 @intCotizacionID, Int32 @intElementoID, Int16 @sintPinturaID);
        /// <summary>
        /// Obtiene la lista de fonto por un marco en particular
        /// </summary>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<FondoMarco> ListarFondoMarco(Int32 @sintFondoMarcoID, Int32 @sintTipoMarcoID);
    }
}
