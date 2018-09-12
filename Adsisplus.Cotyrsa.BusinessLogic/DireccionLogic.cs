using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
  public  class DireccionLogic
    {
        #region Constructor

        private DireccionDataAccess CatalogosDA;

        public DireccionLogic()
        {
            CatalogosDA = new DireccionDataAccess();

        }

        #endregion

        public List<Direccion> ListarDatosPersona(Int32 @intDireccionID, Int32 @intMunicipioID, Int32 @intEstadoID, Int32 @intLocalidadID, Int32 @intTipoDomicilioID)
        {
            List<Direccion> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPersona(@intDireccionID, @intMunicipioID, @intEstadoID, @intLocalidadID, @intTipoDomicilioID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
