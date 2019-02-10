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
        public List<DatosViga> ListarDatosViga(Int32 intDatosVigaID, Int16 sintPinturaID, Int32 intElementoID, Int32 intDatoMarcoID)
        {
            List<DatosViga> results = new List<DatosViga>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosViga(intDatosVigaID, sintPinturaID, intElementoID, intDatoMarcoID)
                                select new DatosViga()
                                {
                                    intDatosVigaID = item.intDatosVigaID,
                                    intConfiguraVigaID = item.intConfiguraVigaID,
                                    vchPintura = item.vchPintura,
                                    vchElemento = item.vchElemento,
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

        public List<DatosVigaTope> ListarDatosVigaTope(Int32 intCantidadVigaTope, Int32 intVigaTopeID, Int32 intElementoID, Int32 intDatosVigaID, Int32 intCotizacionID, Int16 sintPinturaID)
        {
            List<DatosVigaTope> results = new List<DatosVigaTope>();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosVigaTope(intCantidadVigaTope, intVigaTopeID, intElementoID, intDatosVigaID, intCotizacionID, sintPinturaID)
                                select new DatosVigaTope()
                                {
                                    intVigaTopeID = item.intVigaTopeID,
                                    vchElemento = item.vchElemento,
                                    intCantidadDatosViga = item.intCantidadDatosViga,
                                    intCotizacionID = item.intCotizacionID,
                                    vchFolio = item.vchFolio,
                                    vchPintura = item.vchPintura,
                                    intCantidadVigaTope = item.intCantidadVigaTope,
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
                                    decCapacidadParVigasMaxima = item.decPesoPartida,
                                    decCapacidadParVigasRequerida = item.decPesoPieza,
                                    decLongitud = Convert.ToDecimal(item.vchLongitud),
                                    decPatin = Convert.ToDecimal(item.intPatin),
                                    decPeralte = Convert.ToDecimal(item.intPeralte),
                                    decPesoViga = item.decPesoViga,
                                    decPrecioUnitarioSinIVA = item.decPrecioUnitario,
                                    vchMaterial = item.vchMaterial,
                                    SKU = item.SKU,
                                    vchTipo = item.vchTipo,
                                    decTotal = item.TOTAL,
                                    intLargo = item.intLargo,
                                    sintLongitudID = item.sintLongitudId,
                                    sintTipoVigaID = item.sintTipoVigaID
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
        /// Procedimiento que muestra la seleccion de Viga
        /// </summary>
        /// <param name="intSeleccionVigaID"></param>
        /// <returns></returns>
        public SeleccionViga ListaDatosSeleccionViga(int intSeleccionVigaID)
        {
            SeleccionViga result = new SeleccionViga();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosSeleccionViga(intSeleccionVigaID)
                                select new SeleccionViga
                                {
                                    intSeleccionVigaID = item.intSeleccionVigaID,
                                    SKU = int.Parse(item.SKU),
                                    decPesoViga = item.decPesoViga,
                                    decPrecioUnitarioSinIVA = item.decPrecioUnitario,
                                    intTipoID = item.intTipoID,
                                    vchTipo = item.vchTipo,
                                    intMaterialID = item.intMaterialID,
                                    vchMaterial = item.vchMaterial,
                                    decPatin = item.decPatin,
                                    decPeralte = item.decPeralte,
                                    decLongitud = item.decLongitud,
                                    decCapacidadParVigasRequerida = item.decCapViga,
                                    decCapacidadParVigasMaxima = item.decCapVigaMax,
                                    bitActivo = item.bitActivo
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
                    var query = from item in dc.stp_setSeleccionViga(viga.intRackID, viga.intSeleccionVigaID, viga.intCotizacionID, Convert.ToString(viga.SKU), viga.decPesoViga,
                        viga.decPrecioUnitarioSinIVA, viga.intTipoID, viga.intMaterialID, viga.decPatin, viga.decPeralte, viga.decLongitud, 
                        viga.decCapacidadParVigasRequerida, viga.decCapacidadParVigasMaxima,
                        // Datos que serán almacenados en la tabla tbl_RackSelectivo
                        rack.bitEstructural, rack.bitSobresale, rack.decDistanciaLargoProducto, (byte) rack.tinOpcionViga, rack.intNumTarimaNivel, rack.decLongitudViga, 
                        rack.decCapCargaReqViga,
                        
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
        /// Procedimiento que obtiene los datos de la pantalla de la viga a mostrar
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <returns></returns>
        public RackSelectivo ListarDatosPantallaViga(int intCotizacionID)
        {
            RackSelectivo result = new RackSelectivo();
            try
            {
                using (VigasDataContext dc = new VigasDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPantallaViga(intCotizacionID)
                                select new RackSelectivo
                                {
                                    intRackID = item.intRackID,
                                    intCotizacionID = item.intCotizacionID,
                                    intSeleccionVigaID = item.intSeleccionVigaID,
                                    bitEstructural = item.bitEstructural,
                                    bitSobresale = item.bitSobresale,
                                    decFrente = item.decFrente,
                                    decFondo = item.decFondo,
                                    decAltura = item.decAltura,
                                    decPeso = item.decPeso,
                                    intNumTarimaNivel = item.intNumTarimaNivel,
                                    tinOpcionViga = item.tinOpcionViga,
                                    decLongitudViga = item.decLongitudViga,
                                    decCapCargaReqViga = item.decCapCargaReqViga
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

    }
}
