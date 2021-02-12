using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class DireccionLogic
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
        public Resultado SetDomicilio(Direccion direccion, short tinOpcion)
        {

            try
            {
                //Si no tiene id la dirección, entonces asignamos la opción de inserción (1), ya que con la opción de actualización (2), no se actualziará
                //byte realOption = (byte)((direccion.intDireccionID == null || direccion.intDireccionID == 0) && tinOpcion == 2 ? 1 : tinOpcion);
                Resultado result = CatalogosDA.setDomicilio(direccion, tinOpcion);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
