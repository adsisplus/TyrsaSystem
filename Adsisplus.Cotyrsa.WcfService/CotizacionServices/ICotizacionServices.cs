using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CotizacionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICotizacionServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICotizacionServices
    {
        /// <summary>
        /// Obtiene la lista de calculo de altura por marco
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intEstatusID"></param>
        /// <param name="sintPrioridadID"></param>
        /// <param name="intEmpresaID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Cotizacion> ListarCatAlturaMarco(Int32 @intCotizacionID, Int32 @intEstatusID, Int32 @sintPrioridadID, Int32 @intEmpresaID);
    }
}
