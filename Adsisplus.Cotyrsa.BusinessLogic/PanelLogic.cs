using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
   public class PanelLogic
    {
        #region Constructor

        private PanelDataAccess CatalogosDA;

        public PanelLogic()
        {
            CatalogosDA = new PanelDataAccess();

        }

        #endregion

        public List<DatosPanel> ListarDatosPanel(Int32 intDatosPanelID, Int32 intElementoID, Int32 intDatoMarcoID, Int16 sintPinturaID)
        {
            List<DatosPanel> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPanel(intDatosPanelID, intElementoID, intDatoMarcoID, sintPinturaID);
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
                result = CatalogosDA.ListarAnchoPanel();
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
                result = CatalogosDA.ListarSeleccionPanel(decCapacidadCarga, decAncho, sintSistemaID, bitGalvanizado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
