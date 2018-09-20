using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.DireccionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "DireccionServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DireccionServices.svc o DireccionServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class DireccionServices : IDireccionServices
    {
        /// <summary>
        /// Devuelve la lista de datos de personas
        /// </summary>
        /// <param name="intDireccionID"></param>
        /// <param name="intPersonaID"></param>
        /// <param name="intEmpresaID"></param>
        /// <param name="intTipoDomicilioID"></param>
        /// <returns></returns>
        public List<Direccion> ListarDireccion(Int32 @intDireccionID, Int32 @intPersonaID, Int32 @intEmpresaID, Int32 @intTipoDomicilioID)
        {
            List<Direccion> result = new List<Direccion>();
            try
            {
                result = (new DireccionLogic()).ListarDireccion(@intDireccionID, @intPersonaID, @intEmpresaID, @intTipoDomicilioID);
            }
            catch (Exception ex)
            {
#if (DEBUG)
                Console.WriteLine("Error en DireccionServices.ListarDatosPersona: " + ex.Message);
#else
                    EventLogManager.LogErrorEntry("Error en DireccionServices.ListarDatosPersona: " + ex.Message);
                    //TODO: Codificar envío de notificación de error al EventLog
#endif
            }
            return result;
        }

        /// <summary>
        /// Permite realizar el alta, modificación o baja de los datos de domicilio
        /// </summary>
        /// <param name="direccion"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDomicilio(Direccion direccion, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new DireccionLogic()).setDomicilio(direccion, tinOpcion);
            }
            catch (Exception ex)
            {
#if (DEBUG)
                Console.WriteLine("Error en DireccionServices.setDomicilio: " + ex.Message);
#else
                    EventLogManager.LogErrorEntry("Error en DireccionServices.setDomicilio: " + ex.Message);
                    //TODO: Codificar envío de notificación de error al EventLog
#endif
            }
            return result;
        }
    }
}
