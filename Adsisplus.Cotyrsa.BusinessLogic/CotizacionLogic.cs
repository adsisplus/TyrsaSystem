using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class CotizacionLogic
    {
        #region Constructor

        private CotizacionDataAccess CatalogosDA;

        public CotizacionLogic()
        {
            CatalogosDA = new CotizacionDataAccess();

        }

        #endregion

        public List<Cotizacion> ListarCatAlturaMarco(Int32 intCotizacionID, Int32 intEstatusID, Int32 sintPrioridadID, Int32 intEmpresaID)
        {
            List<Cotizacion> results = null;
            try
            {
                results = CatalogosDA.ListarCatAlturaMarco(intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Obtiene la lista de la relación de tipo elemento almacen vs Factor de cotización
        /// </summary>
        /// <param name="intTipoElementoAlmacen_FactorID"></param>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="sintFactorID"></param>
        /// <returns></returns>
        public List<RelTipoElementoAlmacenFactorCotizacion> ListarRel_TipoElementoAlmacen_FactorCotizacion(int intTipoElementoAlmacen_FactorID,
            int intTipoElementoAlmacenID, short sintFactorID)
        {
            List<RelTipoElementoAlmacenFactorCotizacion> result = new List<RelTipoElementoAlmacenFactorCotizacion>();
            try
            {
                result = CatalogosDA.ListarRel_TipoElementoAlmacen_FactorCotizacion(intTipoElementoAlmacen_FactorID, intTipoElementoAlmacenID, sintFactorID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }
}
