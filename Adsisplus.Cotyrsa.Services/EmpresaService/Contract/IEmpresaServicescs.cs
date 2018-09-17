using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.EmpresaService.Contract
{
    [ServiceContract]
    interface IEmpresaServicescs
    {
        /// <summary>
        /// Obtiene los datos de la persona
        /// </summary>
        /// <param name="intEmpresaID"></param>
        /// <param name="sintTipoEmpresaID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Empresa> ListarDatosPersona(Int32 @intEmpresaID, Int16 @sintTipoEmpresaID);
        [OperationContract]
        /// <summary>
        /// Permite realizar el alta, modificación y baja de la empresa
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        Resultado setEmpresa(Empresa empresa, short tinOpcion);
    }
}
