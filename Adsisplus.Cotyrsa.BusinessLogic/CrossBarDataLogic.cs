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
    }
}
