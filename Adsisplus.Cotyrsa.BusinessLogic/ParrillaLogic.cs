using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
   public class ParrillaLogic
    {
        #region Constructor

        private ParrillaDataAccess CatalogosDA;

        public ParrillaLogic()
        {
            CatalogosDA = new ParrillaDataAccess();

        }

        #endregion

        public List<DatosParrilla> ListarDatosPanel(Int32 @intParrillaID, Int32 @intElementoID, Int16 @sintPinturaID, Int32 @intCotizacionID)
        {
            List<DatosParrilla> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPanel(@intParrillaID, @intElementoID, @sintPinturaID, @intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
