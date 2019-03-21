using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{

    public class PanelDataAccess
    {
        public List<DatosPanel> ListarDatosPanel(Int32 intDatosPanelID, Int32 intElementoID, Int32 intDatoMarcoID, Int16 sintPinturaID)
        {
            List<DatosPanel> results = new List<DatosPanel>();
            try
            {
                using (PanelesDataContext dc = new PanelesDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPanel(intDatosPanelID, intElementoID, intDatoMarcoID, sintPinturaID)
                                select new DatosPanel()
                                {
                                    intDatosPanelID = item.intDatosPanelID,
                                    vchElemento = item.vchElemento,
                                    sintCantidadDatoMarco = item.sintCantidadDatoMarco,
                                    vchPintura = item.vchPintura,
                                    decAnchoPanel = item.decAnchoPanel,
                                    intCantidadPanel = item.intCantidadPanel,
                                    decCapacidadCargaPanel = item.decCapacidadCargaPanel,
                                    bitActivo = item.bitActivo
                                };
                    results.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
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
                using (PanelesDataContext dc = new PanelesDataContext(Helper.ConnectionString()))
                {
                    var query = dc.stp_ListarAnchoPanel();
                    result = (List<decimal>)query;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                using (PanelesDataContext dc = new PanelesDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionPanel(decCapacidadCarga, decAncho, sintSistemaID, bitGalvanizado)
                                select new SeleccionPanel
                                {
                                    intPanelID = item.intPanelID,
                                    sintSKU = item.sintSKU,
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    decAncho = item.decAncho,
                                    decFondo = item.decFondo,
                                    decPesoKg = item.decPesoKg,
                                    sintCorreccion = item.sintCorreccion,
                                    decTotal = item.decTotal,
                                    decPrecioEfectivoRef = item.decPrecioEfectivoRef,
                                    decRelPrecioTyrsa = item.decRelPrecioTyrsa,
                                    decKgTyrsa = item.decKgTyrsa,
                                    decKgReferencia = item.decKgReferencia,
                                    bitActivo = item.bitActivo
                                };
                    result.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                using (PanelesDataContext dc = new PanelesDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPantallaPanel(intDetCotizacionID, intSeleccionPanelID)
                                select new DatosPantallaPanel
                                {
                                    intRackID = item.intRackID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intCotizacionID = item.intCotizacionID,
                                    
                                    // Datos generales de la pantalla
                                    sintPinturaID = item.sintPinturaID,
                                    decAnchoBus = item.decAnchoBus,
                                    decLargo = item.decLargo,
                                    sintCantidadPanelNivel = item.sintCantidadPanelNivel,
                                    intCantidadPanel = item.intCantidadPanel,
                                    vchCalibre = item.vchCalibre,

                                    intSeleccionPanelID = item.intSeleccionPanelID,
                                    intPanelID = item.intPanelID,
                                    bitGalvanizado = item.bitGalvanizado,
                                    bitPintado = item.bitPintado,



                                    // Datos de la selección
                                    sintSKU = item.sintSKU,
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    decAncho = item.decAncho,
                                    decFondo = item.decFondo,
                                    decPesoKg = item.decPesoKg,
                                    sintCorreccion = item.sintCorreccion,
                                    decTotal = item.decTotal,
                                    decPrecioEfectivoRef = item.decPrecioEfectivoRef,
                                    decRelPrecioTyrsa = item.decRelPrecioTyrsa,
                                    decKgTyrsa = item.decKgTyrsa,
                                    decKgReferencia = item.decKgReferencia
                                };
                    result.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que almacena los datos del panel seleccionado
        /// </summary>
        /// <param name="dppPanel"></param>
        /// <param name="panel"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionPanel(DatosPantallaPanel dppPanel, SeleccionPanel panel, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (PanelesDataContext dc = new PanelesDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setSeleccionPanel(dppPanel.intSeleccionPanelID, dppPanel.intRackID, panel.intDetCotizaID, panel.intPanelID,
                        dppPanel.bitGalvanizado, dppPanel.bitPintado, dppPanel.decAnchoBus, dppPanel.sintCantidadPanelNivel, 
                        // Datos de la seleccion
                        panel.sintSKU, panel.vchCalibreAcero, panel.decAncho, panel.decFondo, panel.decPesoKg, panel.sintCorreccion, panel.decTotal,
                        panel.decPrecioEfectivoRef, panel.decRelPrecioTyrsa, panel.decKgTyrsa, panel.decKgReferencia, panel.bitActivo,
                        (byte)tinOpcion)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
