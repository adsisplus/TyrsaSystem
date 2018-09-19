using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PersonaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PersonaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PersonaServices.svc o PersonaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PersonaServices : IPersonaServices
    {
        /// <summary>
        /// OBtiene la lista de datos de persona
        /// </summary>
        /// <param name="intPersonaID"></param>
        /// <param name="intTipoPersonaID"></param>
        /// <param name="intEmpresaID"></param>
        /// <returns></returns>
        public List<Persona> ListarDatosPersona(Int32 @intPersonaID, Int32 @intTipoPersonaID, Int32 @intEmpresaID)
        {
            List<Persona> result = new List<Persona>();
            try
            {
                result = (new PersonaLogic()).ListarDatosPersona(@intPersonaID, @intTipoPersonaID, @intEmpresaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obitiene la lista de la relación de dirección y empresa
        /// </summary>
        /// <param name="intPersonaDomEmpreID"></param>
        /// <param name="intPersonaID"></param>
        /// <param name="intDireccionID"></param>
        /// <param name="intEmpresaID"></param>
        /// <returns></returns>
        public List<Persona> ListarRelPersonaDireccionEmpresa(Int32 @intPersonaDomEmpreID, Int32 @intPersonaID, Int32 @intDireccionID, Int32 @intEmpresaID)
        {
            List<Persona> result = new List<Persona>();
            try
            {
                result = (new PersonaLogic()).ListarRelPersonaDireccionEmpresa(@intPersonaDomEmpreID, @intPersonaID, @intDireccionID, @intEmpresaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Permite el alta, modificación o baja de la persona
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setPersona(Persona persona, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new PersonaLogic()).setPersona(persona, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza alta, modificación y baja de la relación Persona, Domicilio y Empresa
        /// </summary>
        /// <param name="relPersonaDomicilioEmpresa"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setRelaciónPersonaDomicilioEmpresa(RelPersonaDomicilioEmpresa relPersonaDomicilioEmpresa, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new PersonaLogic()).setRelaciónPersonaDomicilioEmpresa(relPersonaDomicilioEmpresa, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
