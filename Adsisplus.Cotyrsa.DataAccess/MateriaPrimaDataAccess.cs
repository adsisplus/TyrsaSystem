using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class MateriaPrimaDataAccess
    {
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de un producto acero
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setProductoAcero(ProductoAcero producto, short sintOpcion)
        {
            Resultado result = new Resultado();
            tmpResultado _result = new tmpResultado();
            try
            {
                using (MateriaPrimaDataContext dc = new MateriaPrimaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setProductoAcero(producto.intTipoElementoAlmacenID, producto.intCalibreAceroID, producto.decCostoNegra, producto.decCostoSolera,
                        producto.decCostoGalvanizada, producto.decCapacidadAcero, producto.decFactorNegra, producto.decFactorGalvanizado, 
                        producto.intVigencia, producto.vchUsuario, (byte)sintOpcion)
                                select new tmpResultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    _result = query.First();
                    // vaciamos la información
                    result.vchDescripcion = _result.vchDescripcion;
                    result.vchResultado = _result.vchResultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
