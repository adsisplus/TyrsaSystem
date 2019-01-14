using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class CotizacionLogic
    {
        #region Constructor

        private CotizacionDataAccess CatalogosDA;

        public CotizacionLogic()
        {
            CatalogosDA = new CotizacionDataAccess();

        }

        #endregion

        /// <summary>
        /// Procedimiento que lista los datos de cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intEstatusID"></param>
        /// <param name="sintPrioridadID"></param>
        /// <param name="intEmpresaID"></param>
        /// <returns></returns>
        public List<Cotizacion> ListarDatosCotizacion(Int32 intCotizacionID, Int32 intEstatusID, Int32 sintPrioridadID, Int32 intEmpresaID)
        {
            List<Cotizacion> result = new List<Cotizacion>();
            try
            {
                result = CatalogosDA.ListarDatosCotizacion(intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de la relación de tipo elemento almacen vs Factor de cotización
        /// </summary>
        /// <param name="intTipoElementoAlmacen_FactorID"></param>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="sintFactorID"></param>
        /// <returns></returns>
        public List<RelTipoElementoAlmacenFactorCotizacion> ListarRel_TipoElementoAlmacen_FactorCotizacion(int intTipoElementoAlmacen_FactorID,
            int intTipoElementoAlmacenID, short sintFactorID)
        {
            List<RelTipoElementoAlmacenFactorCotizacion> result = new List<RelTipoElementoAlmacenFactorCotizacion>();
            try
            {
                result = CatalogosDA.ListarRel_TipoElementoAlmacen_FactorCotizacion(intTipoElementoAlmacen_FactorID, intTipoElementoAlmacenID, sintFactorID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de la tabla mst_Cotizacion
        /// </summary>
        /// <param name="cotizacion"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setMstCotizacion(Cotizacion cotizacion, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setMstCotizacion(cotizacion, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de la tabla det_Cotizacion
        /// </summary>
        /// <param name="cotizacion"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDetCotizacion(Cotizacion cotizacion, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDetCotizacion(cotizacion, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimeinto que lista los datos de la cotización
        /// </summary>
        /// <param name="intEmpresaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<Cotizacion> ListarCotizacion(int intEmpresaID, int intCotizacionID)
        {
            List<Cotizacion> result = new List<Cotizacion>();
            try
            {
                result = CatalogosDA.ListarCotizacion(intEmpresaID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el detalle de cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<Cotizacion> ListarDetalleCotizacion(int intCotizacionID)
        {
            List<Cotizacion> result = new List<Cotizacion>();
            try
            {
                result = CatalogosDA.ListarDetalleCotizacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #region Métodos para la selección de Vigas
        /// <summary>
        /// Obtiene la lista de longitud de Viga
        /// </summary>
        /// <param name="intNumeroTarimasPorNivel">NTPN</param>
        /// <param name="tarima">Valor capturado de la tarima</param>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarLongitudViga(int intNumeroTarimasPorNivel, Tarima tarima)
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                CatalogoDecimal opcion = new CatalogoDecimal();
                decimal decLongitudViga = 0;
                // Obtenemos la primera opción
                decLongitudViga = Convert.ToDecimal((intNumeroTarimasPorNivel + 1) * 0.1016) + Convert.ToDecimal((intNumeroTarimasPorNivel * tarima.decTarimaProductoFrente));
                // Agregamos la primera opción
                opcion.intCatalogoID = 3;
                opcion.decValor = decLongitudViga;
                result.Add(opcion);

                // Optenemos la segunda opción
                decLongitudViga = Convert.ToDecimal((intNumeroTarimasPorNivel + 1) * 0.0762) + Convert.ToDecimal((intNumeroTarimasPorNivel * tarima.decTarimaProductoFrente));
                // Agregamos la segunda opción
                opcion.intCatalogoID = 4;
                opcion.decValor = decLongitudViga;
                result.Add(opcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Obtiene la capacidad de carga requerrida por par de Vigas CPPV
        /// </summary>
        /// <param name="intNumeroTarimasPorNivel">NTPN</param>
        /// <param name="decTarimaProductoPeso"></param>
        /// <returns></returns>
        public decimal getCapacidadCargaRequerridaViga(int intNumeroTarimasPorNivel, decimal decTarimaProductoPeso)
        {
            decimal decResult = 0;
            try
            {
                decResult = Convert.ToDecimal(intNumeroTarimasPorNivel) * decTarimaProductoPeso * Convert.ToDecimal(1.10);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return decResult;
        }
        /// <summary>
        /// Procedimiento que nos devuelve la lista de vigas en base a la longitud de la viga (LV),
        /// Capacidad de carga requerida por par de vigas (CPPV)
        /// </summary>
        /// <param name="decLongitudViga"></param>
        /// <param name="intNumeroTarimasPorNivel"></param>
        /// <param name="decTarimaProductoPeso"></param>
        /// <returns></returns>
        public List<SeleccionViga> seleccionVigas(decimal decLongitudViga, int intNumeroTarimasPorNivel, decimal decTarimaProductoPeso)
        {
            List<SeleccionViga> result = new List<SeleccionViga>();
            decimal decCapacidadCarga = 0;
            try
            {
                // Obtenemos la capacidad de carga requerida para la viga
                decCapacidadCarga = getCapacidadCargaRequerridaViga(intNumeroTarimasPorNivel, decTarimaProductoPeso);
                // obtenemos la lista de vigas que cumplen las longitudes de viga y la capacidad de carga
                result = CatalogosDA.seleccionVigas(decLongitudViga, decCapacidadCarga);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que muestra los datos de la viga seleccionada
        /// </summary>
        /// <param name="intSeleccionVigaID"></param>
        /// <param name="intDatosVigaID"></param>
        /// <returns></returns>
        public List<SeleccionViga> ListarDatosSelecionViga(int intSeleccionVigaID, int intDatosVigaID)
        {
            List<SeleccionViga> result = new List<SeleccionViga>();
            try
            {
                result = CatalogosDA.ListarDatosSelecionViga(intSeleccionVigaID, intDatosVigaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion

        #region Metodo para la selección de Marco
        /// <summary>
        /// Obtiene el valor del fonde del marco
        /// </summary>
        /// <param name="decFondoTarimaVacia"></param>
        /// <returns></returns>
        public decimal getFondoMarco(decimal decFondoTarimaVacia)
        {
            decimal result = new decimal();
            try
            {
                result = decFondoTarimaVacia - Convert.ToDecimal(0.1524);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Método que nos permite determinar la altura del Marco
        /// </summary>
        /// <param name="decDimensionClaro"></param>
        /// <param name="intNumNivelesSobreVigaClaro"></param>
        /// <param name="decAlturaPiso"></param>
        /// <param name="intNumNivelesSobreVigaPeralte"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public List<CatalogoDecimal> getAlturaMarco(decimal decDimensionClaro, int intNumNivelesSobreVigaClaro, decimal decAlturaPiso, int intNumNivelesSobreVigaPeralte)
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                CatalogoDecimal opcion = new CatalogoDecimal();
                decimal decLongitudViga = 0;
                // Obtenemos la primera opción
                decLongitudViga = Math.Round((decDimensionClaro + Convert.ToDecimal(intNumNivelesSobreVigaPeralte) + Convert.ToDecimal(0.30)), 0, MidpointRounding.AwayFromZero);
                // Agregamos la primera opción
                opcion.intCatalogoID = 1;
                opcion.decValor = decLongitudViga;
                result.Add(opcion);


                // Optenemos la segunda opción
                decLongitudViga = Math.Round((decAlturaPiso + Convert.ToDecimal(intNumNivelesSobreVigaClaro) + Convert.ToDecimal(intNumNivelesSobreVigaPeralte) + Convert.ToDecimal(0.30)), 0, MidpointRounding.AwayFromZero);
                // Agregamos la segunda opción
                opcion.intCatalogoID = 2;
                opcion.decValor = decLongitudViga;
                result.Add(opcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que permite listar los marcos en base a la capacidad
        /// de carga y la altura de pandeo
        /// </summary>
        /// <param name="decCapacidadCarga"></param>
        /// <param name="decAlturaPandeo"></param>
        /// <returns></returns>
        public List<SeleccionMarco> seleccionMarco(decimal decCapacidadCarga, decimal decAlturaPandeo)
        {
            List<SeleccionMarco> result = new List<SeleccionMarco>();
            try
            {
                result = CatalogosDA.seleccionMarco(decCapacidadCarga, decAlturaPandeo);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion
    }
}
