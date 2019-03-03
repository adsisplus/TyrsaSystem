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
        /// <summary>
        /// Procedimiento que obtiene los datos de la viga (tbl_MST_DatosVigA)
        /// </summary>
        /// <param name="intDatosVigaID"></param>
        /// <param name="sintPinturaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="intDetCotizacionID"></param>
        /// <returns></returns>
        public List<DatosViga> ListarDatosViga(Int32 intDatosVigaID, Int16 sintPinturaID, Int32 intElementoID, Int32 intDatoMarcoID, int intDetCotizacionID)
        {
            List<DatosViga> results = null;
            try
            {
                results = CatalogosDA.ListarDatosViga(intDatosVigaID, sintPinturaID, intElementoID, intDatoMarcoID, intDetCotizacionID);
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
        /// Procedimiento que muestra la lista de las vigas ligadas a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionViga> ListaDatosSeleccionViga(int iintCotizacionID)
        {
            List<SeleccionViga> result = new List<SeleccionViga>();
            try
            {
                result = CatalogosDA.ListaDatosSeleccionViga(iintCotizacionID);
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
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizacionID"></param>
        /// <param name="sintPinturaID"></param>
        /// <param name="intCantidad"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosViga(SeleccionViga viga, RackSelectivo rack, int intCotizacionID, int intDetCotizacionID, short sintPinturaID, int intCantidad, short tinOpcion)
        {
            Resultado result = new Resultado();
            int intSeleccionVigaID = 0;
            int intDetCotizaID = 0;
            int intDatosViga = 0;
            // Obtenemos la información de la cotización
            //Cotizacion datosCotizacion = (new CotizacionLogic()).ListarDatosPantallaCotizacion(intCotizacionID);
            // Obtenemos la información del sistema Selectivo
            RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo(intCotizacionID);
            try
            {
                // 1. Se realiza el registro de la viga en las tablas tbl_RackSelectivo y tbl_SeleccionViga, 
                // devolverá el intSeleccionVigaID
                if(viga.intSeleccionVigaID != 0 || viga.intSeleccionVigaID != null)
                    // En caso de que exista valor en el ID, solo actualizamos los valores
                    result = CatalogosDA.setDatosViga(viga, rack, 2);
                else
                    // En caso contrario, realizamos la inserción
                    result = CatalogosDA.setDatosViga(viga, rack, 1);

                if (result.vchResultado != "NOK")
                {
                    // Obtenemos el ID de la seleccion Viga ID
                    intSeleccionVigaID = Convert.ToInt32(result.vchResultado);

                    // Procedemos a llenar la entidad de la cotización
                    Cotizacion detCotizacion = new Cotizacion();
                    detCotizacion.intDetCotizaID = intDetCotizacionID;
                    detCotizacion.intCotizacionID = intCotizacionID;
                    detCotizacion.intElementoID = 2; // ID correspondiente a Viga
                    detCotizacion.intPartida = 0;
                    detCotizacion.intCantidad = intCantidad;
                    detCotizacion.decMonto = viga.decPrecioUnitarioSinIVA;
                    detCotizacion.decSubtotal = viga.decPrecioUnitarioSinIVA * intCantidad;

                    result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizacionID == 0 ? 1 : 2));

                    if (result.vchResultado != "NOK")
                    {
                        // Obtenemos el ID de la cotización
                        intDetCotizaID = Convert.ToInt32(result.vchResultado);
                        DatosViga mstViga = new DatosViga();
                        //Buscamos la viga en base al detalle de la cotización
                        mstViga = (new VigaLogic()).ListarDatosViga((int)sistema.intDatosVigaID, 0, 2, 0, intDetCotizacionID).First();

                        mstViga.intDetCotizaID = intDetCotizaID;
                        mstViga.SKU = viga.SKU;
                        mstViga.sintPinturaID = sintPinturaID;
                        mstViga.intElementoID = 2;
                        mstViga.decLargo = viga.decLongitud;
                        mstViga.intCantidad = intCantidad;
                        
                        // Realizamos el alta / modificación de la viga
                        result = (new SistemasTyrsaLogic()).setDatosViga(mstViga, (short)((int)sistema.intDatosVigaID == 0 ? 1 : 2));

                        // Validamos el resultado
                        if (result.vchResultado != "NOK")
                        {
                            intDatosViga = Convert.ToInt32(result.vchResultado);
                            if (sistema.intDatosVigaID == 0 || sistema.intDatosVigaID == null)
                            {
                                sistema.intDatosVigaID = intDatosViga;
                                sistema.intTipoElementoAlmacenID = 17; // Valor por default
                                sistema.intCotizacionID = intCotizacionID;

                                result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, tinOpcion);
                            }
                        }
                    }
                }
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
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<RackSelectivo> ListarDatosPantallaViga(int intCotizacionID, int intSeleccionVigaID)
        {
            List <RackSelectivo> result = new List<RackSelectivo>();
            try
            {
                result = CatalogosDA.ListarDatosPantallaViga(intCotizacionID, intSeleccionVigaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
