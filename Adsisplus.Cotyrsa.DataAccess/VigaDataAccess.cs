using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class VigaDataAccess
    {
        #region PROCEDIMIENTO PARA EL SISTEMA SELECTIVO
        public List<TotalViga> ListarTotalViga(Int32 intTotalViga, Int32 intConfiguraVigaID)
        {
            List<TotalViga> results = new List<TotalViga>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarTotalViga(intTotalViga, intConfiguraVigaID)
                                select new TotalViga()
                                {
                                    intTotalViga = item.intTotalViga,
                                    decTotalConfViga = item.decTotalConfViga,
                                    vchInsumoViga = item.vchInsumoViga,
                                    vchDescripcion = item.vchDescripcion,
                                    decTotalViga = item.decTotalViga,
                                    bitActivo = item.bitActivo
                                };
                    results.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Viga> ListarConfiguracionViga(Int32 intConfiguraVigaID, Int32 sintTipoVigaID, Int32 intElementoID, Int32 intCalibreID, Int32 intCapacidadVigaID, Int32 intFactorVigaID, Int16 sintInsumoViga)
        {
            List<Viga> results = new List<Viga>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarConfiguracionViga(intConfiguraVigaID, sintTipoVigaID, intElementoID, intCalibreID, intCapacidadVigaID, intFactorVigaID, sintInsumoViga)
                                select new Viga()
                                {
                                    intConfiguraVigaID = item.intConfiguraVigaID,
                                    vchTipoViga = item.vchTipoViga,
                                    vchElemento = item.vchElemento,
                                    vchCalibre = item.vchCalibre,
                                    decCapacidadViga = item.decCapacidadViga,
                                    vchFactorViga = item.vchFactorViga,
                                    vchInsumoViga = item.vchInsumoViga,
                                    decDesarrollo = item.decDesarrollo,
                                    intLongitud = item.intLongitud,
                                    vchDescripcion = item.vchDescripcion,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    intPiezaxLamina = item.intPiezaxLamina,
                                    decPesoPieza = item.decPesoPieza,
                                    decPesoPartida = item.decPesoPartida,
                                    decTotal = item.decTotal,
                                    decAreaPintura = item.decAreaPintura,
                                    intCara = item.intCara,
                                    bitActivo = item.bitActivo
                                };
                    results.AddRange(query);
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarConfiguracion_Viga(sintTipoVigaID, intElementoID, intCalibreID, sintFactorVigaID)
                                select new Configuracion_Viga
                                {
                                    intConfiguraVigaID = item.intConfiguraVigaID,
                                    sintTipoVigaID = item.sintTipoVigaID,
                                    vchTipoViga = item.vchTipoViga,
                                    intElementoID = item.intElementoID,
                                    vchElemento = item.vchElemento,
                                    intCalibreID = item.intCalibreID,
                                    vchCalibre = item.vchCalibre,
                                    sintFactorVigaID =item.sintFactorVigaID,
                                    vchAcero = item.vchAcero,
                                    decAcero = item.decAcero,
                                    vchRemache = item.vchRemache,
                                    decRemache = item.decRemache,
                                    vchKgMetroCuadrado = item.vchKgMetroCuadrado,
                                    decKgMetroCuadrado = item.decKgMetroCuadrado,
                                    decFactorAcero = item.decFactorAcero,
                                    decFactorRemache = item.decFactorRemache,
                                    decFactorKgMt = item.decFactorKgMt,
                                    sintInsumoViga = item.sintInsumoViga,
                                    intNumeroViga = item.intNumeroViga,
                                    intNumeroPza = item.intNumeroPza,
                                    decDesarrollo = item.decDesarrollo,
                                    intLongitud = item.intLongitud,
                                    vchDescripcion = item.vchDescripcion,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    intPiezaxLamina = item.intPiezaxLamina,
                                    intNumPiezaProm = item.intNumPiezaProm,
                                    decPesoPieza = item.decPesoPieza,
                                    decPesoPartida = item.decPesoPartida,
                                    decTotal = item.decTotal,
                                    decAreaPintura = item.decAreaPintura,
                                    intCara = item.intCara,
                                    bitActivo = item.bitActivo
                                };
                    result.AddRange(query);
                }
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
            List<DatosViga> results = new List<DatosViga>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosViga(intDatosVigaID, sintPinturaID, intElementoID, intDatoMarcoID, intDetCotizacionID)
                                select new DatosViga()
                                {
                                    intDatosVigaID = item.intDatosVigaID,
                                    //intConfiguraVigaID = item.intConfiguraVigaID,
                                    sintPinturaID = item.sintPinturaID,
                                    vchPintura = item.vchPintura,
                                    intElementoID = item.intElementoID,
                                    vchElemento = item.vchElemento,
                                    intDatoMarcoID = item.intDatoMarcoID,
                                    SKU = (int)item.SKU,
                                    sintCantidadDatosMarco = item.sintCantidadDatosMarco,
                                    decLargo = item.decLargo,
                                    intCantidad = item.intCantidad,
                                    bitActivo = item.bitActivo
                                };
                    results.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Procedimiento que lista los datos de viga tope
        /// </summary>
        /// <param name="intCantidadVigaTope"></param>
        /// <param name="intVigaTopeID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatosVigaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosVigaTope> ListarDatosVigaTope(Int32 intCotizacionID)
        {
            List<DatosVigaTope> results = new List<DatosVigaTope>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosVigaTope(intCotizacionID)
                                select new DatosVigaTope()
                                {
                                    intVigaTopeID = item.intVigaTopeID,
                                    vchElemento = item.vchElemento,
                                    intDatosVigaID = item.intDatosVigaID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    sintPinturaID = item.sintPinturaID,
                                    vchPintura = item.vchPintura,
                                    intCantidadDatosViga = item.intCantidadDatosViga,
                                    vchFolio = item.vchFolio,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    intCantidad = item.intCantidad,

                                    decPrecioVentaUnitario = item.decPrecioVentaUnitario,
                                    decPrecioVentaTotal = item.decPrecioVentaTotal,
                                    decPeso = item.decPeso,
                                    sintLongitudID = item.sintLongitudID,
                                    vchLongitud = item.vchLongitud,
                                    intCalibreID = item.intCalibreID,
                                    vchCalibre = item.vchCalibre,
                                    decLargo = item.decLargo,

                                    decPesoUnitario = item.decPesoUnitario,

                                    bitActivo = item.bitActivo
                                };
                    results.AddRange(query);
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarConector_Viga(intCalibreID, sintInsumoViga, sintTipoConectorID, sintFamiliaVigaID)
                                select new ConectorViga
                                {
                                    bitActivo = (bool)item.bitActivo,
                                    decAncho = item.decAncho,
                                    decAreaPintura = item.decAreaPintura,
                                    decDesarrollo = item.decDesarrollo,
                                    decFactorAcero = item.decFactorAcero,
                                    decFactorRemache = item.decFactorRemache,
                                    decLargo = item.decLargo,
                                    decPesoPartida = item.decPesoPartida,
                                    decPesoPieza = item.decPesoPieza,
                                    decTotal = item.decTotal,
                                    intCalibreID = item.intCalibreID,
                                    intCara = item.intCara,
                                    intConectorVigaID = item.intConectorVigaID,
                                    intLongitud = item.intLongitud,
                                    intNumeroConector = item.intNumeroConector,
                                    intNumeroPza = item.intNumeroPza,
                                    intNumPiezaProm = item.intNumPiezaProm,
                                    intPiezaxLamina = item.intPiezaxLamina,
                                    sintFamiliaVigaID = item.sintFamiliaVigaID,
                                    sintInsumoViga = item.sintInsumoViga,
                                    vchCalibre = item.vchCalibre,
                                    vchDescripcion = item.vchDescripcion,
                                    vchFamiliaViga = item.vchFamiliaViga,
                                    vchInsumoViga = item.vchInsumoViga,
                                    vchTipoConector = item.vchTipoConector
                                };
                    result.AddRange(query);
                }
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
        /// <param name="decCapacidadCarga"></param>
        /// <param name="bitEstructural"></param>
        /// <param name="sintSistemaID"></param>
        /// <returns></returns>
        public List<SeleccionViga> ListarSeleccionVigas(decimal decLongitudViga, decimal decCapacidadCarga, short sintSistemaID, bool bitEstructural)
        {
            List<SeleccionViga> result = new List<SeleccionViga>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionViga(decCapacidadCarga, decLongitudViga, sintSistemaID, bitEstructural)
                                select new SeleccionViga
                                {
                                    SKU = item.SKU,
                                    sintTipoVigaID = item.sintTipoVigaID,
                                    decPesoViga = item.decPesoViga,
                                    decTotal = item.TOTAL,
                                    decPrecioUnitarioSinIVA = item.decPrecioUnitario,
                                    vchFamiliaViga = item.vchFamiliaViga,
                                    vchTipo = item.vchTipo,
                                    vchMaterial = item.vchMaterial,
                                    vchLongitud = item.vchLongitud,
                                    intLargo = item.intLargo,
                                    decPatin = Convert.ToDecimal(item.decPatin),
                                    decPeralte = Convert.ToDecimal(item.intPeralte),
                                    decCapacidadParVigasRequerida = item.decPesoPartida,
                                    decCapacidadParVigasMaxima = item.decPesoPartida,
                                    sintLongitudID = item.sintLongitudId,
                                    intMaterialID = item.intMaterialID,
                                    intTipoID = item.intTipoID,
                                    decConector = item.decConector,
                                    decGranTotal = item.decGranTotal
                                };
                    result.AddRange(query);
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionViga_Tipo_C(decLongitudViga)
                                select new SeleccionViga_TipoC
                                {
                                    SKU = item.SKU,
                                    decPesoPieza = item.decPesoPieza,
                                    TOTAL = item.TOTAL,
                                    decTotal = item.decTotal
                                };
                    result.AddRange(query);
                }
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
        public List<SeleccionViga> ListaDatosSeleccionViga(int intCotizacionID)
        {
            List<SeleccionViga> result = new List<SeleccionViga>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosSeleccionViga(intCotizacionID)
                                select new SeleccionViga
                                {
                                    intSeleccionVigaID = item.intSeleccionVigaID,
                                    intDatosVigaID = item.intDatosVigaID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    SKU = int.Parse(item.SKU),
                                    decPesoViga = item.decPesoViga,
                                    decGranTotal = item.decPrecioUnitario,
                                    intTipoID = item.intTipoID,
                                    vchTipo = item.vchTipo,
                                    intMaterialID = item.intMaterialID,
                                    vchMaterial = item.vchMaterial,
                                    decPatin = item.decPatin,
                                    decPeralte = item.decPeralte,
                                    decLongitud = item.decLongitud,
                                    decCapacidadParVigasRequerida = item.decCapViga,
                                    decCapacidadParVigasMaxima = item.decCapVigaMax,
                                    intCantidad = item.intCantidad,
                                    decSubtotal = item.decSubtotal,
                                    decConector = item.decConector,
                                    bitActivo = item.bitActivo,
                                    decLargoViga = item.decLargoViga
                                };
                    result.AddRange(query);
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
        /// <param name="intDetCotizacionID"></param>
        /// <returns></returns>
        public List<RackSelectivo> ListarDatosPantallaViga(int intCotizacionID, int intSeleccionVigaID)
        {
            List<RackSelectivo> result = new List<RackSelectivo>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPantallaViga(intCotizacionID, intSeleccionVigaID)
                                select new RackSelectivo
                                {
                                    intRackID = item.intRackID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intCotizacionID = item.intCotizacionID,
                                    intSeleccionVigaID = item.intSeleccionVigaID,

                                    intNumeroTarimaPorNivel = item.intNumTarimaNivel,
                                    intCantidad = item.intCantidad,
                                    sintPinturaID = item.sintPinturaID,

                                    bitEstructural = item.bitEstructural,
                                    bitSobresale = item.bitSobresale,
                                    decDistanciaLargoProducto = item.decDistanciaLargoProducto,
                                    decFrente = item.decFrente,
                                    decFondo = item.decFondo,
                                    decAltura = item.decAltura,
                                    decPeso = item.decPeso,
                                    tinOpcionViga = item.tinOpcionViga,
                                    decLongitudViga = item.decLongitudViga,
                                    decCapCargaReqViga = item.decCapCargaReqViga,
                                    //intPiezaXLamina = item.intPiezaXLamina,
                                    //intPiezaXLaminaCuerpo = item.intPiezaXLaminaCuerpo
                                    bitMontacarga = item.bitMontaCarga,
                                    bitManual = item.bitManual,
                                    vchDimensionMontacarga = item.vchDimensionMontacarga
                                };
                    result.AddRange(query);
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    result = (bool)dc.fn_getHayElementosVinculadosAlaViga(intDetCotizaID);
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setConfiguracionViga(decFactorAcero, decFactorRemache, decFactorKgMt, intNumeroViga, intNumeroPza)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setFactorViga(intCalibreID, decAcero, decRemache, decKgMetroCuadrado, decFactorVenta, decFactorDespiste, decFactorDescuento)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setSeleccionViga(viga.intRackID, viga.intSeleccionVigaID, viga.intCotizacionID, viga.intDetCotizaID,
                        rack.decFrente, rack.decFondo, rack.decAltura, rack.decPeso, rack.decLongitudViga,
                        rack.decCapCargaReqViga, rack.bitEstructural, rack.bitSobresale, Convert.ToByte(rack.tinOpcionViga), rack.decDistanciaLargoProducto,
                        Convert.ToString(viga.SKU), viga.decPesoViga, viga.decGranTotal, viga.intTipoID, viga.intMaterialID,
                        viga.decPatin, viga.decPeralte, Convert.ToDecimal(viga.vchLongitud), viga.decCapacidadParVigasRequerida, viga.decCapacidadParVigasMaxima,
                        rack.intNumeroTarimaPorNivel,
                        // DATOS DEL RACK SELECTIVO
                        rack.bitMontacarga, rack.bitManual, rack.vchDimensionMontacarga, viga.decConector,
                        viga.bitActivo, (byte)tinOpcion)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setBajaViga(intDetCotizaID, bitRollBack)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setBajaVigaTope(intDetCotizaID, bitRollBack)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion

        #region PROCEDIMIENTO PARA EL SISTEMA DRIVE IN
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosVigaAtirantado(intVigaAtirantadoID, intDetCotizaID)
                                select new DatosVigaAtirantado
                                {
                                    intVigaAtirantadoID = item.intVigaAtirantadoID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintPinturaID = item.sintPinturaID,
                                    decLargo = item.decLargo,
                                    intCantidad = item.intCantidad,
                                    bitActivo = item.bitActivo,
                                    intDetCotizaID = item.intDetCotizaID,
                                    decPrecioVentaUnitario = item.decPrecioVentaUnitario,
                                    decPrecioVentaTotal = item.decPrecioVentaTotal,
                                    decPeso = item.decPeso,
                                    decLongitud = item.decLongitud,
                                    intCalibreID = item.intCalibreID,
                                    decPesoUnitario = item.decPesoUnitario
                                };
                    result.AddRange(query);
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionViga_Tipo_Caja()
                                select new DatosVigaTipoCaja
                                {
                                    SKU = Convert.ToInt32(item.SKU),
                                    decPesoPieza = item.decPesoPieza,
                                    TOTAL = item.TOTAL,
                                    decTotal = item.decTotal
                                };
                    result.AddRange(query);
                }
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
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarAnguloRanurado(decCapacidadCarga)
                                select new DatosAnguloRanurado
                                {
                                    sintMstAnguloRanuradoID = item.sintMstAnguloRanuradoID,
                                    decDesarrollo = item.decDesarrollo,
                                    decLongitud = item.decLongitud,
                                    decAncho = item.decAncho,
                                    vchMaterial = item.vchMaterial,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPrecioUnitario = item.decPrecioUnitario
                                };
                    result.AddRange(query);
                }
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
