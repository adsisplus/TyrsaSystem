using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class MateriaPrimaLogic
    {
        private MateriaPrimaDataAccess materiaDA = null;

        public MateriaPrimaLogic()
        {
            materiaDA = new MateriaPrimaDataAccess();
        }

        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de un producto acero
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setProductoAcero(ProductoAcero producto, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = materiaDA.setProductoAcero(producto, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
