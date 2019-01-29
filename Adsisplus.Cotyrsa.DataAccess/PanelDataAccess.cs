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
                                    bitActivo = item.bitActivo,
                                    decAncho = item.decAncho,
                                    decFondo = item.decFondo,
                                    decKgReferencia = item.decKgReferencia,
                                    decKgTyrsa = item.decKgTyrsa,
                                    decPesoKg = item.decPesoKg,
                                    decPrecioEfectivoRef = item.decPrecioEfectivoRef,
                                    decRelPrecioTyrsa = item.decRelPrecioTyrsa,
                                    decTotal = item.decTotal,
                                    sintCorreccion = item.sintCorreccion,
                                    sintSKU = item.sintSKU,
                                    vchCalibreAcero = item.vchCalibreAcero
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
    }
}
