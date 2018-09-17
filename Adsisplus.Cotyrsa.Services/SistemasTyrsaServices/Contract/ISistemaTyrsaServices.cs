using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.SistemasTyrsaServices.Contract
{
    [ServiceContract]
    interface ISistemaTyrsaServices
    {
        /// <summary>
        /// Obtiene la lista de las relaciones de los sistemas selectivos
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intTipoElementoCoti_Producto"></param>
        /// <param name="intTipoElementoID"></param>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="intConfiguraMarcoID"></param>
        /// <param name="intConfiguraVigaID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="intDatosVigaID"></param>
        /// <param name="intDatosPanelID"></param>
        /// <param name="intDatosCrossBarID"></param>
        /// <param name="intDistanciadorID"></param>
        /// <param name="intParrillaID"></param>
        /// <param name="intVigaTopeID"></param>
        /// <param name="intProtectorPosteID"></param>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="sintSistemaCargaMarcoID"></param>
        /// <param name="datFechaAlta"></param>
        /// <returns></returns>
        [OperationContract]
        List<RelSistemaSelectivo> ListarRelSistemaSelectivo(Int32 @intCotizacionID, Int32 @intTipoElementoCoti_Producto, Int32 @intTipoElementoID, 
                                                            Int32 @intTipoElementoAlmacenID, Int32 @intConfiguraMarcoID, Int32 @intConfiguraVigaID, 
                                                            Int32 @intDatoMarcoID, Int32 @intDatosVigaID, Int32 @intDatosPanelID, Int32 @intDatosCrossBarID, 
                                                            Int32 @intDistanciadorID, Int32 @intParrillaID, Int32 @intVigaTopeID, Int32 @intProtectorPosteID, 
                                                            Int32 @intProtectorBateriaID, Int16 @sintSistemaCargaMarcoID, DateTime @datFechaAlta);
    }
}
