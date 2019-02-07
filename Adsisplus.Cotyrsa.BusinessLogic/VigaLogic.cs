using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class VigaLogic
    {
        #region Constructor

        private VigaDataAccess CatalogosDA;

        public VigaLogic()
        {
            CatalogosDA = new VigaDataAccess();

        }

        #endregion

        public List<TotalViga> ListarTotalViga(Int32 intTotalViga, Int32 intConfiguraVigaID)
        {
            List<TotalViga> results = null;
            try
            {
                results = CatalogosDA.ListarTotalViga(intTotalViga, intConfiguraVigaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Viga> ListarConfiguracionViga(Int32 intConfiguraVigaID, Int32 sintTipoVigaID, Int32 intElementoID, Int32 intCalibreID, Int32 intCapacidadVigaID, Int32 intFactorVigaID, Int16 sintInsumoViga)
        {
            List<Viga> results = null;
            try
            {
                results = CatalogosDA.ListarConfiguracionViga(intConfiguraVigaID, sintTipoVigaID, intElementoID, intCalibreID, intCapacidadVigaID, intFactorVigaID, sintInsumoViga);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Configuración de vigas
        /// </summary>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="sintFactorVigaID"></param>
        /// <returns></returns>
        public List<Configuracion_Viga> ListarConfiguracion_Viga(short sintTipoVigaID, int intElementoID, int intCalibreID, short sintFactorVigaID)
        {
            List<Configuracion_Viga> result = new List<Configuracion_Viga>();
            try
            {
                result = CatalogosDA.ListarConfiguracion_Viga(sintTipoVigaID, intElementoID, intCalibreID, sintFactorVigaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public List<DatosViga> ListarDatosViga(Int32 intDatosVigaID, Int16 sintPinturaID, Int32 intElementoID, Int32 intDatoMarcoID)
        {
            List<DatosViga> results = null;
            try
            {
                results = CatalogosDA.ListarDatosViga(intDatosVigaID, sintPinturaID, intElementoID, intDatoMarcoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<DatosVigaTope> ListarDatosVigaTope(Int32 intCantidadVigaTope, Int32 intVigaTopeID, Int32 intElementoID, Int32 intDatosVigaID, Int32 intCotizacionID, Int16 sintPinturaID)
        {
            List<DatosVigaTope> results = null;
            try
            {
                results = CatalogosDA.ListarDatosVigaTope(intCantidadVigaTope, intVigaTopeID, intElementoID, intDatosVigaID, intCotizacionID, sintPinturaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Permite realizar la actualización de las vigas en factores y número de viga y piezas
        /// </summary>
        /// <param name="decFactorAcero"></param>
        /// <param name="decFactorRemache"></param>
        /// <param name="decFactorKgMt"></param>
        /// <param name="intNumeroViga"></param>
        /// <param name="intNumeroPza"></param>
        /// <returns></returns>
        public Resultado setConfiguracionViga(decimal decFactorAcero, decimal decFactorRemache, decimal decFactorKgMt, int intNumeroViga, int intNumeroPza)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setConfiguracionViga(decFactorAcero, decFactorRemache, decFactorKgMt, intNumeroViga, intNumeroPza);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de conector por viga
        /// </summary>
        /// <param name="intCalibreID"></param>
        /// <param name="sintInsumoViga"></param>
        /// <param name="sintTipoConectorID"></param>
        /// <param name="sintFamiliaVigaID"></param>
        /// <returns></returns>
        public List<ConectorViga> ListarConectorViga(int intCalibreID, short sintInsumoViga, short sintTipoConectorID, short sintFamiliaVigaID)
        {
            List<ConectorViga> result = new List<ConectorViga>();
            try
            {
                result = CatalogosDA.ListarConectorViga(intCalibreID, sintInsumoViga, sintTipoConectorID, sintFamiliaVigaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Alta de factor de viga
        /// </summary>
        /// <param name="intCalibreID"></param>
        /// <param name="decAcero"></param>
        /// <param name="decRemache"></param>
        /// <param name="decKgMetroCuadrado"></param>
        /// <param name="decFactorVenta"></param>
        /// <param name="decFactorDespiste"></param>
        /// <param name="decFactorDescuento"></param>
        /// <returns></returns>
        public Resultado setFactorViga(int intCalibreID, decimal decAcero, decimal decRemache, decimal decKgMetroCuadrado,
            decimal decFactorVenta, decimal decFactorDespiste, decimal decFactorDescuento)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setFactorViga(intCalibreID, decAcero, decRemache, decKgMetroCuadrado, decFactorVenta, decFactorDespiste, decFactorDescuento);
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
        /// Obtiene la lista de longitud de Viga
        /// </summary>
        /// <param name="intNumeroTarimasPorNivel">NTPN</param>
        /// <param name="tarima">Valor capturado de la tarima</param>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarLongitudViga(int intNumeroTarimasPorNivel, decimal decFrente)
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                CatalogoDecimal opcion = new CatalogoDecimal();
                decimal decLongitudViga = 0;
                // Obtenemos la primera opción
                decLongitudViga = Convert.ToDecimal((intNumeroTarimasPorNivel + 1) * 0.1016) + Convert.ToDecimal((intNumeroTarimasPorNivel * decFrente));
                // Agregamos la primera opción
                opcion.intCatalogoID = 3;
                opcion.decValor = decLongitudViga;
                result.Add(opcion);

                // Optenemos la segunda opción
                decLongitudViga = Convert.ToDecimal((intNumeroTarimasPorNivel + 1) * 0.0762) + Convert.ToDecimal((intNumeroTarimasPorNivel * decFrente));
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
        /// Procedimiento que nos devuelve la lista de vigas en base a la longitud de la viga (LV),
        /// Capacidad de carga requerida por par de vigas (CPPV)
        /// </summary>
        /// <param name="decLongitudViga"></param>
        /// <param name="intNumeroTarimasPorNivel"></param>
        /// <param name="decTarimaProductoPeso"></param>
        /// <returns></returns>
        public List<SeleccionViga> seleccionVigas(decimal decLongitudViga, int intNumeroTarimasPorNivel, decimal decTarimaProductoPeso,
            short sintSistemaID, bool bitEstructural)
        {
            List<SeleccionViga> result = new List<SeleccionViga>();
            decimal decCapacidadCarga = 0;
            try
            {
                // Obtenemos la capacidad de carga requerida para la viga
                decCapacidadCarga = getCapacidadCargaRequerridaViga(intNumeroTarimasPorNivel, decTarimaProductoPeso);
                // obtenemos la lista de vigas que cumplen las longitudes de viga y la capacidad de carga
                result = CatalogosDA.ListarSeleccionVigas(decLongitudViga, decCapacidadCarga, sintSistemaID, bitEstructural);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que muestra la seleccion de Viga
        /// </summary>
        /// <param name="intSeleccionVigaID"></param>
        /// <returns></returns>
        public SeleccionViga ListaDatosSeleccionViga(int intSeleccionVigaID)
        {
            SeleccionViga result = new SeleccionViga();
            try
            {
                result = CatalogosDA.ListaDatosSeleccionViga(intSeleccionVigaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que almacena toda la información de la pantalla de captura de Viga
        /// </summary>
        /// <param name="viga"></param>
        /// <param name="rack"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosViga(SeleccionViga viga, RackSelectivo rack, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosViga(viga, rack, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que obtiene los datos de la pantalla de la viga a mostrar
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <returns></returns>
        public RackSelectivo ListarDatosPantallaViga(int intDetCotizacionID)
        {
            RackSelectivo result = new RackSelectivo();
            try
            {
                result = CatalogosDA.ListarDatosPantallaViga(intDetCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
