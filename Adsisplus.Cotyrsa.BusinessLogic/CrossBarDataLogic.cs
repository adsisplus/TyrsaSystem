using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;


namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class CrossBarDataLogic
    {
        #region Constructor

        private CrossBarDataAccess CatalogosDA;

        public CrossBarDataLogic()
        {
            CatalogosDA = new CrossBarDataAccess();

        }

        #endregion

        public List<DatosCrossBar> ListarDatosPanel(Int32 intDatosCrossBarID, Int32 intElementoID, Int32 intDatoMarcoID)
        {
            List<DatosCrossBar> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPanel(intDatosCrossBarID, intElementoID, intDatoMarcoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <returns></returns>
        public List<decimal> ListarAnchoCrossBar()
        {
            List<decimal> result = new List<decimal>();
            try
            {
                result = CatalogosDA.ListarAnchoCrossBar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <param name="decAncho"></param>
        /// <returns></returns>
        public List<SeleccionCrossBar> ListarSeleccionCrossBar(decimal decAncho)
        {
            List<SeleccionCrossBar> result = new List<SeleccionCrossBar>();
            try
            {
                result = CatalogosDA.ListarSeleccionCrossBar(decAncho);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
