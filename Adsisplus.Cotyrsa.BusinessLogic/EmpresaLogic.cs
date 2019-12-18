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
        /// <summary>
        /// Procedimiento que lista los datos de la empresa en base al usuario y al tipo de empresa
        /// </summary>
        /// <param name="intEmpresaID"></param>
        /// <param name="sintTipoEmpresaID"></param>
        /// <param name="intUsuarioID"></param>
        /// <param name="bitMuestraDatos"></param>
        /// <returns></returns>
        public List<Empresa> ListarEmpresa(Int32 intEmpresaID, Int16 sintTipoEmpresaID, int intUsuarioID, bool bitMuestraDatos)
        {
            List<Empresa> results = null;
            try
            {
                // Validamos si se mostrará toda la información
                intUsuarioID = bitMuestraDatos == true ? 0 : intUsuarioID;
                results = CatalogosDA.ListarEmpresa(intEmpresaID, sintTipoEmpresaID, intUsuarioID);
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
