using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.Cotizacion.Contract
{
    [ServiceContract]
    interface ICotizacionServices
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
        List<Adsisplus.Cotyrsa.BusinessEntities.Cotizacion> ListarCatAlturaMarco(Int32 @intCotizacionID, Int32 @intEstatusID, Int32 @sintPrioridadID, Int32 @intEmpresaID);
    }
}
