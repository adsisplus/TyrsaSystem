using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
   public class EmpresaLogic
    {
        #region Constructor

        private EmpresaDataAccess CatalogosDA;

        public EmpresaLogic()
        {
            CatalogosDA = new EmpresaDataAccess();

        }

        #endregion

        public List<Empresa> ListarDatosPersona(Int32 @intEmpresaID, Int16 @sintTipoEmpresaID)
        {
            List<Empresa> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPersona(@intEmpresaID, @sintTipoEmpresaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
