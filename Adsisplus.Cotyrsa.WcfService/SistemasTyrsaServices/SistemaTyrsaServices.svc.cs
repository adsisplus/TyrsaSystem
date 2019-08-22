using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.SistemasTyrsaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SistemaTyrsaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SistemaTyrsaServices.svc o SistemaTyrsaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SistemaTyrsaServices : ISistemaTyrsaServices
    {
        #region SISTEMA SELECTIVO
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos Viga
        /// </summary>
        /// <param name="datosMarco"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosMarco(DatosMarco datosMarco, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosMarco(datosMarco, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos Viga
        /// </summary>
        /// <param name="datosViga"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosViga(DatosViga datosViga, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosViga(datosViga, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos panel
        /// </summary>
        /// <param name="datosPanel"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPanel(DatosPanel datosPanel, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosPanel(datosPanel, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos de Cross Bar
        /// </summary>
        /// <param name="datosCrossBar"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosCrossBar(DatosCrossBar datosCrossBar, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosCrossBar(datosCrossBar, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos de distanciador
        /// </summary>
        /// <param name="datosDistanciador"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDistanciador(DatosDistanciador datosDistanciador, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosDistanciador(datosDistanciador, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Parrilla
        /// </summary>
        /// <param name="datosParrilla"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosParrilla(DatosParrilla datosParrilla, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosParrilla(datosParrilla, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Viga tope
        /// </summary>
        /// <param name="datosVigaTope"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosVigaTope(DatosVigaTope datosVigaTope, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosVigaTope(datosVigaTope, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos protector poste
        /// </summary>
        /// <param name="datosProtector"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorPoste(DatosProtectorBase datosProtector, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosProtectorPoste(datosProtector, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Protector Batería
        /// </summary>
        /// <param name="datosProtectorBateria"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorBateria(DatosProtectorBateria datosProtectorBateria, short sintTipoBateria, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosProtectorBateria(datosProtectorBateria, sintTipoBateria, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que muestra los datos de tornilleria
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="bitEstructural"></param>
        /// <param name="bitEsCuadruple"></param>
        /// <returns></returns>
        public List<DatosTornilleria> ListarDatosTornilleria(int intCotizacionID, bool bitEstructural, bool bitEsCuadruple)
        {
            List<DatosTornilleria> result = new List<DatosTornilleria>();
            try
            {
                result = (new SistemasTyrsaLogic()).ListarDatosTornilleria(intCotizacionID, bitEstructural, bitEsCuadruple);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que devuelve los datos de tornillería en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosTornilleria> ListarTornillosSelectivoCotizacion(int intCotizacionID)
        {
            List<DatosTornilleria> result = new List<DatosTornilleria>();
            try
            {
                result = (new SistemasTyrsaLogic()).ListarTornillosSelectivoCotizacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        #endregion

        #region SISTEMA DRIVE IN
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de los datos Drive In
        /// </summary>
        /// <param name="driveIn"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDriveIn(DatosDriveIn driveIn, byte tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosDriveIn(driveIn, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos Atirantado
        /// </summary>
        /// <param name="atirantado"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosAtirantado(DatosAtirantado atirantado, byte tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new SistemasTyrsaLogic()).setDatosAtirantado(atirantado, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        #endregion
    }
}
