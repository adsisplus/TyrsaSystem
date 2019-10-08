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

        #region SISTEMA SELECTIVO
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
        /// <summary>
        /// Procedimiento que lista los datos de la viga tope lisgado a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosVigaTope> ListarDatosVigaTope(Int32 intCotizacionID)
        {
            List<DatosVigaTope> results = null;
            try
            {
                results = CatalogosDA.ListarDatosVigaTope(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
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
        /// Procedimiento que obtiene la lista de vigas tipo C
        /// </summary>
        /// <param name="decLongitudViga"></param>
        /// <returns></returns>
        public List<SeleccionViga_TipoC> ListarSeleccionVigas_TipoC(decimal decLongitudViga)
        {
            List<SeleccionViga_TipoC> result = new List<SeleccionViga_TipoC>();
            try
            {
                result = CatalogosDA.ListarSeleccionVigas_TipoC(decLongitudViga);
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
        /// Procedimiento que obtiene los datos de la pantalla de la viga a mostrar
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<RackSelectivo> ListarDatosPantallaViga(int intCotizacionID, int intSeleccionVigaID)
        {
            List<RackSelectivo> result = new List<RackSelectivo>();
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
        /// Procedimiento que nos indica si existen elementos vinculados a la Viga seleccionada al borrado
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public bool hayElementosVinculadosAlaViga(int intDetCotizaID)
        {
            bool result = false;
            try
            {
                result = CatalogosDA.hayElementosVinculadosAlaViga(intDetCotizaID);
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
        public Resultado setDatosViga(SeleccionViga viga, RackSelectivo rack, int intCotizacionID, int intDetCotizaID, short sintPinturaID, int intCantidad, short tinOpcion)
        {
            Resultado result = new Resultado();
            int? intSeleccionVigaID = null;
            //int? intDetCotizaID_ = null;
            int? intDatosViga = null;
            // Obtenemos la información de la cotización
            //Cotizacion datosCotizacion = (new CotizacionLogic()).ListarDatosPantallaCotizacion(intCotizacionID);
            // Obtenemos la información del sistema Selectivo
            RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo(intCotizacionID);
            try
            {
                // Obtenemos el ID de la seleccion Viga ID
                intSeleccionVigaID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intElementoID = 2; // ID correspondiente a Viga
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = intCantidad;
                detCotizacion.decMonto = viga.decPrecioUnitarioSinIVA;
                detCotizacion.decSubtotal =Decimal.Round((Math.Truncate(100 * viga.decGranTotal.Value) / 100) * intCantidad);

                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));

                if(result.vchResultado != "NOK")
                {
                    // Establecemos el id del detalle de la cotización
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    viga.intDetCotizaID = intDetCotizaID;

                    // 1. Se realiza el registro de la viga en las tablas tbl_RackSelectivo y tbl_SeleccionViga, 
                    // devolverá el intSeleccionVigaID
                    if (viga.intSeleccionVigaID != null)
                        // En caso de que exista valor en el ID, solo actualizamos los valores
                        result = CatalogosDA.setDatosViga(viga, rack, tinOpcion);
                    else
                        // En caso contrario, realizamos la inserción
                        result = CatalogosDA.setDatosViga(viga, rack, 1);

                    if (result.vchResultado != "NOK")
                    {
                        // Obtenemos el ID de la cotización
                        intSeleccionVigaID = Convert.ToInt32(result.vchResultado);
                        List<DatosViga> ListMstViga = new List<DatosViga>();
                        DatosViga mstViga = new DatosViga();

                        // Validamos si es un nuevo registro
                        if(tinOpcion != 1)
                            //Buscamos la viga en base al detalle de la cotización
                            ListMstViga = (new VigaLogic()).ListarDatosViga(0, 0, 2, 0, intDetCotizaID);
                        // En caso de existir, asignamos el resultado
                        if (ListMstViga.Count > 0)
                            mstViga = ListMstViga.First();
                        else // En caso contrario, establecemos el valor a 0
                            mstViga.intDatosVigaID = 0;
                        // Actualizamos la información
                        mstViga.intDetCotizaID = intDetCotizaID;
                        mstViga.SKU = viga.SKU;
                        mstViga.sintPinturaID = sintPinturaID;
                        mstViga.intElementoID = 2;
                        mstViga.decLargo = rack.decLongitudViga;
                        mstViga.intCantidad = intCantidad;
                        mstViga.intDatoMarcoID = sistema.intDatoMarcoID;
                        
                        // Realizamos el alta / modificación de la viga
                        result = (new SistemasTyrsaLogic()).setDatosViga(mstViga, tinOpcion);

                        // Validamos el resultado
                        if (result.vchResultado != "NOK")
                        {
                            intDatosViga = Convert.ToInt32(result.vchResultado);
                            if ((sistema.intDatosVigaID == 0 || sistema.intDatosVigaID == null) || tinOpcion == 3)
                            {
                                // En caso de realizar la baja, establecemos el valor a 0 en caso de coincidir la baja con el registrado
                                // en el sistema selectivo
                                if (tinOpcion == 3 && sistema.intDatosVigaID == mstViga.intDatosVigaID)
                                {
                                    // Obtenemos la lista de las vigas registradas activas en base a la cotización
                                    List<SeleccionViga> listViga = new List<SeleccionViga>();
                                    listViga = ListaDatosSeleccionViga(intCotizacionID);
                                    if (listViga.Count > 0)
                                        sistema.intDatosVigaID = listViga.First().intDatosVigaID;
                                    else
                                        sistema.intDatosVigaID = 0;
                                }
                                else
                                    sistema.intDatosVigaID = intDatosViga;
                                sistema.intTipoElementoAlmacenID = 17; // Valor por default
                                sistema.intCotizacionID = intCotizacionID;

                                result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, 2);
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
        /// Procedimiento que almacena los datos de Viga Tope
        /// </summary>
        /// <param name="vigaTope"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosVigaTope(DatosVigaTope vigaTope, short tinOpcion)
        {
            Resultado result = new Resultado();
            int? intVigaTopeID;
            int? intDetCotizaID;
            try
            {
                // Obtenemos la información del sistema Selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo((int)vigaTope.intCotizacionID);
                intVigaTopeID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = vigaTope.intDetCotizaID;
                detCotizacion.intCotizacionID = vigaTope.intCotizacionID;
                detCotizacion.intElementoID = 7; // ID correspondiente a Vigas Topes
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = vigaTope.intCantidadVigaTope;
                detCotizacion.decMonto = vigaTope.decPrecioUnitario;
                detCotizacion.decSubtotal = Decimal.Round((decimal)(vigaTope.decPrecioUnitario * vigaTope.intCantidadVigaTope));

                // 1. Realizamos el alta de la cotización
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(vigaTope.intDetCotizaID == 0 ? 1 : tinOpcion));
                // Validamos la respuesta obtenida
                if (result.vchResultado != "NOK")
                {
                    // Almacenamos el ID del detalle de la cotización
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    vigaTope.intDetCotizaID = intDetCotizaID;
                    vigaTope.intDatosVigaID = sistema.intDatosVigaID;

                    vigaTope.intElementoID = 7;
                    // Procedeimos a realizar el almacenado de la información
                    result = (new SistemasTyrsaLogic()).setDatosVigaTope(vigaTope, tinOpcion);
                    if (result.vchResultado != "NOK")
                    {
                        intVigaTopeID = Convert.ToInt32(result.vchResultado);
                        if ((sistema.intVigaTopeID == null || sistema.intVigaTopeID == 0) || tinOpcion == 3)
                        {
                            // En caso de realizar la baja, establecemos el valor a 0
                            if (tinOpcion == 3)
                                sistema.intParrillaID = 0;
                            else
                                sistema.intVigaTopeID = intVigaTopeID;

                            sistema.intTipoElementoAlmacenID = 17;
                            sistema.intCotizacionID = vigaTope.intCotizacionID;

                            result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, 2);
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
        /// Procedimiento que realiza el borrado lógico o físico(en caso de error) de los datos de la viga
        /// capturada
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollback">1 = Realiza el borrado físico de las tablas <br /> 
        ///                             0 = Realiza el borrado lógico</param>
        /// <returns></returns>
        public Resultado setBajaViga(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setBajaViga(intDetCotizaID, bitRollBack);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el borrado lógico o físico (en caso de error) de los datos de la Viga Tope
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollback">1 = Realiza el borrado físico de las tablas <br /> 
        ///                             0 = Realiza el borrado lógico</param>
        /// <returns></returns>
        public Resultado setBajaVigaTope(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setBajaVigaTope(intDetCotizaID, bitRollBack);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
#endregion

        #region SISTEMA DRIVE IN
        /// <summary>
        /// Procedimiento que lista los datos de Viga atirantado
        /// </summary>
        /// <param name="intVigaAtirantadoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosVigaAtirantado> ListarDatosVigaAtirantado(int intVigaAtirantadoID, int intDetCotizaID)
        {
            List<DatosVigaAtirantado> result = new List<DatosVigaAtirantado>();
            try
            {
                result = CatalogosDA.ListarDatosVigaAtirantado(intVigaAtirantadoID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos Viga Atirantado
        /// </summary>
        /// <param name="viga"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosVigaAtirantado(DatosVigaAtirantado viga, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 19;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = viga.intCantidad;
                detCotizacion.decMonto = viga.decPrecioVentaTotal;
                detCotizacion.decSubtotal = 0;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    viga.intDetCotizaID = intDetCotizaID;

                    List<DatosVigaAtirantado> ListViga = new List<DatosVigaAtirantado>();
                    DatosVigaAtirantado _viga = new DatosVigaAtirantado();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListViga = ListarDatosVigaAtirantado((int)viga.intVigaAtirantadoID, intDetCotizaID);
                    // Validamos si existe registro
                    if (ListViga.Count() > 0)
                        _viga = ListViga.First();
                    else
                        _viga.intVigaAtirantadoID = 0;
                    // Actualizamos la información
                    _viga.bitActivo = viga.bitActivo;
                    _viga.decLargo = viga.decLargo;
                    _viga.decLongitud = viga.decLongitud;
                    _viga.decPeso = viga.decPeso;
                    _viga.decPesoTotal = viga.decPesoTotal;
                    _viga.decPesoUnitario = viga.decPesoUnitario;
                    _viga.decPrecioVentaTotal = viga.decPrecioVentaTotal;
                    _viga.decPrecioVentaUnitario = viga.decPrecioVentaUnitario;
                    _viga.intCalibreID = viga.intCalibreID;
                    _viga.intCantidad = viga.intCantidad;
                    _viga.intCotizacionID = intCotizacionID;
                    _viga.intDetCotizaID = intDetCotizaID;
                    _viga.intElementoID = 19;
                    _viga.sintPinturaID = viga.sintPinturaID;


                    //Realizamos el registro de los datos
                    result = (new DriveInLogic()).setDatosVigaAtirantado(_viga, tinOpcion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista las vigas tipo caja
        /// </summary>
        /// <returns></returns>
        public List<DatosVigaTipoCaja> ListarSeleccionVigaTipoCaja()
        {
            List<DatosVigaTipoCaja> result = new List<DatosVigaTipoCaja>();
            try
            {
                result = CatalogosDA.ListarSeleccionVigaTipoCaja();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de angulo ranurado en base a la capacidad de carga
        /// </summary>
        /// <param name="decCapacidadCarga"></param>
        /// <returns></returns>
        public List<DatosAnguloRanurado> ListarAnguloRanurado(decimal decCapacidadCarga)
        {
            List<DatosAnguloRanurado> result = new List<DatosAnguloRanurado>();
            try
            {
                result = CatalogosDA.ListarAnguloRanurado(decCapacidadCarga);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion
    }
}
