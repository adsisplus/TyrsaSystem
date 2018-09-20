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

        public List<Direccion> ListarDireccion(Int32 intDireccionID, Int32 intPersonaID, Int32 intEmpresaID, Int32 intTipoDomicilioID)
        {
            List<Direccion> results = null;
            try
            {
                results = CatalogosDA.ListarDireccion(intDireccionID, intPersonaID, intEmpresaID, intTipoDomicilioID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Permite realizar el alta, modificación o baja de los datos de domicilio
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns></returns>
        public Resultado setDomicilio(Direccion direccion, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDomicilio(direccion, tinOpcion);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
