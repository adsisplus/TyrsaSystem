﻿using Adsisplus.Cotyrsa.BusinessEntities;
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
        /// <param name="intDetCotizaID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosPanel> ListarDatosPanel(int intDatosPanelID, int intElementoID, int intDetCotizaID, short sintPinturaID)
        {
            List<DatosPanel> result = new List<DatosPanel>();
            try
            {
                result = (new PanelLogic()).ListarDatosPanel(intDatosPanelID, intElementoID, intDetCotizaID, sintPinturaID);
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
        public List<CatalogoDecimal> ListarAnchoPanel()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
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
        /// <param name="decAncho"></param>
        /// <param name="sintCalibre"></param>
        /// <param name="decFondo"></param>
        /// <param name="sintSistemaID"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<SeleccionPanel> ListarSeleccionPanel(decimal decAncho, short sintCalibre, decimal decFondo, short sintSistemaID, bool bitGalvanizado)
        {
            List<SeleccionPanel> result = new List<SeleccionPanel>();
            try
            {
                result = (new PanelLogic()).ListarSeleccionPanel(decAncho, sintCalibre, decFondo, sintSistemaID, bitGalvanizado);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que devuelve información de la pantalla del panel seleccionado
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <param name="intSeleccionPanelID"></param>
        /// <returns></returns>
        public List<DatosPantallaPanel> ListarDatosPantallaPanel(int intDetCotizacionID, int intSeleccionPanelID)
        {
            List<DatosPantallaPanel> result = new List<DatosPantallaPanel>();
            try
            {
                result = (new PanelLogic()).ListarDatosPantallaPanel(intDetCotizacionID, intSeleccionPanelID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimeinto que nos muestra la lista de seleccion panel en base a una cotizacion
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionPanel> ListarDatosSeleccionPanel(int intCotizacionID)
        {
            List<SeleccionPanel> result = new List<SeleccionPanel>();
            try
            {
                result = (new PanelLogic()).ListarDatosSeleccionPanel(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiemto que realiza el alta del panel a la cotización
        /// </summary>
        /// <param name="dppPanel"></param>
        /// <param name="panel"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intCantidad"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionPanel(DatosPantallaPanel dppPanel, SeleccionPanel panel, int intCotizacionID, int intDetCotizaID, int intCantidad, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new PanelLogic()).setSeleccionPanel(dppPanel, panel, intCotizacionID, intDetCotizaID, intCantidad, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que realiza la baja de los 
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = Realiza el borrado físico de las tablas <br /> 
        ///                             0 = Realiza el borrado lógico</param>
        /// <returns></returns>
        public Resultado setBajaPanel(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new PanelLogic()).setBajaPanel(intDetCotizaID, bitRollBack);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
