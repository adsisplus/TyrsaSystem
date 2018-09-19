using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.EmpresaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EmpresaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EmpresaServices.svc o EmpresaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EmpresaServices : IEmpresaServices
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
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
