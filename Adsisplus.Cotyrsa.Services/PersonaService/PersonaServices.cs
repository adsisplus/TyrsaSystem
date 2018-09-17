using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.PersonaService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.PersonaService
{
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
#if (DEBUG)
                Console.WriteLine("Error en PersonaServices.ListarDatosPersona: " + ex.Message);
#else
                    EventLogManager.LogErrorEntry("Error en EmpresaServices.ListarDatosPersona: " + ex.Message);
                    //TODO: Codificar envío de notificación de error al EventLog
#endif
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
#if (DEBUG)
                Console.WriteLine("Error en PersonaServices.ListarRelPersonaDireccionEmpresa: " + ex.Message);
#else
                    EventLogManager.LogErrorEntry("Error en EmpresaServices.ListarRelPersonaDireccionEmpresa: " + ex.Message);
                    //TODO: Codificar envío de notificación de error al EventLog
#endif
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
#if (DEBUG)
                Console.WriteLine("Error en PersonaServices.setPersona: " + ex.Message);
#else
                    EventLogManager.LogErrorEntry("Error en EmpresaServices.setEmpresa: " + ex.Message);
                    //TODO: Codificar envío de notificación de error al EventLog
#endif
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
#if (DEBUG)
                Console.WriteLine("Error en PersonaServices.setRelaciónPersonaDomicilioEmpresa: " + ex.Message);
#else
                    EventLogManager.LogErrorEntry("Error en EmpresaServices.setRelaciónPersonaDomicilioEmpresa: " + ex.Message);
                    //TODO: Codificar envío de notificación de error al EventLog
#endif
            }
            return result;
        }
    }
}
