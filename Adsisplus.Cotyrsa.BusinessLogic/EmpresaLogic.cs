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

        public List<Empresa> ListarEmpresa(Int32 intEmpresaID, Int16 sintTipoEmpresaID)
        {
            List<Empresa> results = null;
            try
            {
                results = CatalogosDA.ListarEmpresa(intEmpresaID, sintTipoEmpresaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Permite realizar el alta, modificación y baja de la empresa
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setEmpresa(Empresa empresa, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setEmpresa(empresa, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
