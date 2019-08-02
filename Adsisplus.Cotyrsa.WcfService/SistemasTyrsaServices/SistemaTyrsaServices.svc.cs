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
        ///// <summary>
        ///// Obtiene la lista de las relaciones de los sistemas selectivos
        ///// </summary>
        ///// <param name="intCotizacionID"></param>
        ///// <param name="intTipoElementoCoti_Producto"></param>
        ///// <param name="intTipoElementoID"></param>
        ///// <param name="intTipoElementoAlmacenID"></param>
        ///// <param name="intConfiguraMarcoID"></param>
        ///// <param name="intConfiguraVigaID"></param>
        ///// <param name="intDatoMarcoID"></param>
        ///// <param name="intDatosVigaID"></param>
        ///// <param name="intDatosPanelID"></param>
        ///// <param name="intDatosCrossBarID"></param>
        ///// <param name="intDistanciadorID"></param>
        ///// <param name="intParrillaID"></param>
        ///// <param name="intVigaTopeID"></param>
        ///// <param name="intProtectorPosteID"></param>
        ///// <param name="intProtectorBateriaID"></param>
        ///// <param name="sintSistemaCargaMarcoID"></param>
        ///// <param name="datFechaAlta"></param>
        ///// <returns></returns>
        //public List<RelSistemaSelectivo> ListarRelSistemaSelectivo(int intCotizacionID, int intTipoElementoCoti_Producto, int intTipoElementoID, int intTipoElementoAlmacenID,
        //    int intConfiguraMarcoID, int intConfiguraVigaID, int intDatoMarcoID, int intDatosVigaID, int intDatosPanelID, int intDatosCrossBarID, int intDistanciadorID,
        //    int intParrillaID, int intVigaTopeID, int intProtectorPosteID, int intProtectorBateriaID, short sintSistemaCargaMarcoID, DateTime datFechaAlta)
        //{
        //    List<RelSistemaSelectivo> result = new List<RelSistemaSelectivo>();
        //    try
        //    {
        //        result = (new SistemasTyrsaLogic()).ListarRelSistemaSelectivo(intCotizacionID, intTipoElementoCoti_Producto, intTipoElementoID, intTipoElementoAlmacenID,
        //            intConfiguraMarcoID, intConfiguraVigaID, intDatoMarcoID, intDatosVigaID, intDatosPanelID, intDatosCrossBarID, intDistanciadorID, intParrillaID,
        //            intVigaTopeID, intProtectorPosteID, intProtectorBateriaID, sintSistemaCargaMarcoID, datFechaAlta);
        //    }
        //    catch (Exception ex)
        //    {
        //        Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
        //    }
        //    return result;
        //}
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
    }
}
