using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PanelServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PanelServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PanelServices.svc o PanelServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PanelServices : IPanelServices
    {
        /// <summary>
        /// Obtiene la lista de datos del panel
        /// </summary>
        /// <param name="intDatosPanelID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosPanel> ListarDatosPanel(int intDatosPanelID, int intElementoID, int intDatoMarcoID, short sintPinturaID)
        {
            List<DatosPanel> result = new List<DatosPanel>();
            try
            {
                result = (new PanelLogic()).ListarDatosPanel(intDatosPanelID, intElementoID, intDatoMarcoID, sintPinturaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que obtiene la lista de anchos del panel
        /// </summary>
        /// <returns></returns>
        public List<decimal> ListarAnchoPanel()
        {
            List<decimal> result = new List<decimal>();
            try
            {
                result = (new PanelLogic()).ListarAnchoPanel();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que nos muestra la lista de páneles para cotizaciones
        /// </summary>
        /// <param name="decCapacidadCarga"></param>
        /// <param name="decAncho"></param>
        /// <param name="sintSistemaID"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<SeleccionPanel> ListarSeleccionPanel(decimal decCapacidadCarga, decimal decAncho, short sintSistemaID, bool bitGalvanizado)
        {
            List<SeleccionPanel> result = new List<SeleccionPanel>();
            try
            {
                result = (new PanelLogic()).ListarSeleccionPanel(decCapacidadCarga, decAncho, sintSistemaID, bitGalvanizado);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
