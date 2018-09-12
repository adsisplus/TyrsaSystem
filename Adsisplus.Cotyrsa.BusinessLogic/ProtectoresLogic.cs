using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class ProtectoresLogic
    {
        #region Constructor

        private ProtectoresDataAccess CatalogosDA;

        public ProtectoresLogic()
        {
            CatalogosDA = new ProtectoresDataAccess();

        }

        #endregion

        public List<DatosProtectorBase> ListarDatosProtectorPoste(Int32 @intProtectorPosteID, Int32 @intElementoID, Int32 @intCotizacionID, Int16 @sintPinturaID)
        {
            List<DatosProtectorBase> results = null;
            try
            {
                results = CatalogosDA.ListarDatosProtectorPoste(@intProtectorPosteID, @intElementoID, @intCotizacionID, @sintPinturaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<DatosProtectorBateria> ListarDatosProtectorBateria(Int32 @intProtectorBateriaID, Int32 @intElementoID, Int32 @intCotizacionID)
        {
            List<DatosProtectorBateria> results = null;
            try
            {
                results = CatalogosDA.ListarDatosProtectorBateria(@intProtectorBateriaID, @intElementoID, @intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
