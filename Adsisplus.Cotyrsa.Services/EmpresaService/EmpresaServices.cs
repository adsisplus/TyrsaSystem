using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.EmpresaService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.EmpresaService
{
    public class EmpresaServices : IEmpresaServicescs
    {
        /// <summary>
        /// Obtiene los datos de la persona
        /// </summary>
        /// <param name="intEmpresaID"></param>
        /// <param name="sintTipoEmpresaID"></param>
        /// <returns></returns>
        public List<Empresa> ListarDatosPersona(Int32 @intEmpresaID, Int16 @sintTipoEmpresaID)
        {
            List<Empresa> result = new List<Empresa>();
            try
            {
                result = (new EmpresaLogic()).ListarDatosPersona(@intEmpresaID, @sintTipoEmpresaID);
            }
            catch (Exception ex)
            {
#if (DEBUG)
                Console.WriteLine("Error en EmpresaServices.ListarDatosPersona: " + ex.Message);
#else
                    EventLogManager.LogErrorEntry("Error en EmpresaServices.ListarDatosPersona: " + ex.Message);
                    //TODO: Codificar envío de notificación de error al EventLog
#endif
            }
            return result;
        }
        /// <summary>
        /// Permite realizar el alta, modificación y baja de la empresa
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setEmpresa(Empresa empresa, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new EmpresaLogic()).setEmpresa(empresa, tinOpcion);
            }
            catch (Exception ex)
            {
#if (DEBUG)
                Console.WriteLine("Error en EmpresaServices.setEmpresa: " + ex.Message);
#else
                    EventLogManager.LogErrorEntry("Error en EmpresaServices.setEmpresa: " + ex.Message);
                    //TODO: Codificar envío de notificación de error al EventLog
#endif
            }
            return result;
        }
    }
}
