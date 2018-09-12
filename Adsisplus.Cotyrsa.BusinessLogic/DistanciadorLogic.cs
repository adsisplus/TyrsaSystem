using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;


namespace Adsisplus.Cotyrsa.BusinessLogic
{
   public class DistanciadorLogic
    {
        #region Constructor

        private DistanciadorDataAccess CatalogosDA;

        public DistanciadorLogic()
        {
            CatalogosDA = new DistanciadorDataAccess();

        }

        #endregion

        public List<DatosDistanciador> ListarDatosPanel(Int32 @intDistanciadorID, Int32 @intCotizacionID, Int32 @intElementoID)
        {
            List<DatosDistanciador> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPanel(@intDistanciadorID, @intCotizacionID, @intElementoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
