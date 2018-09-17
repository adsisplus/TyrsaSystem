using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.DireccionService.Contract
{
    [ServiceContract]
    interface IDireccionServicescs
    {
        /// <summary>
        /// Nos devuelve los datos de las personas
        /// </summary>
        /// <param name="intDireccionID"></param>
        /// <param name="intMunicipioID"></param>
        /// <param name="intEstadoID"></param>
        /// <param name="intLocalidadID"></param>
        /// <param name="intTipoDomicilioID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Direccion> ListarDatosPersona(Int32 @intDireccionID, Int32 @intMunicipioID, Int32 @intEstadoID, Int32 @intLocalidadID, Int32 @intTipoDomicilioID);

        /// <summary>
        /// Permite realizar el alta, modificación o baja de los datos de domicilio
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns></returns>
        [OperationContract]
        Resultado setDomicilio(Direccion direccion, short tinOpcion);
    }
}
