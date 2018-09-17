using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.DireccionService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.DireccionService
{
    public class DireccionServices : IDireccionServicescs
    {
        /// <summary>
        /// Devuelve la lista de datos de personas
        /// </summary>
        /// <param name="intDireccionID"></param>
        /// <param name="intMunicipioID"></param>
        /// <param name="intEstadoID"></param>
        /// <param name="intLocalidadID"></param>
        /// <param name="intTipoDomicilioID"></param>
        /// <returns></returns>
        public List<Direccion> ListarDatosPersona(Int32 @intDireccionID, Int32 @intMunicipioID, Int32 @intEstadoID, Int32 @intLocalidadID, Int32 @intTipoDomicilioID)
        {
            List<Direccion> result = new List<Direccion>();
            try
            {
                result = (new DireccionLogic()).ListarDatosPersona(@intDireccionID, @intMunicipioID, @intEstadoID, @intLocalidadID, @intTipoDomicilioID);
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
