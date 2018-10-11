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
                                    sintTipoVigaID = (short)item.sintTipoVigaID,
                                    vchTipoViga = item.vchTipoViga,
                                    intElementoID = (int)item.intElementoID,
                                    vchElemento = item.vchElemento,
                                    intCalibreID = (int)item.intCalibreID,
                                    vchCalibre = item.vchCalibre,
                                    sintFactorVigaID = (short)item.sintFactorVigaID,
                                    vchAcero = item.vchAcero,
                                    decAcero = (decimal)item.decAcero,
                                    vchRemache = item.vchRemache,
                                    decRemache = (decimal)item.decRemache,
                                    vchKgMetroCuadrado = item.vchKgMetroCuadrado,
                                    decKgMetroCuadrado = (decimal)item.decKgMetroCuadrado,
                                    decFactorAcero = (decimal)item.decFactorAcero,
                                    decFactorRemache = (decimal)item.decFactorRemache,
                                    decFactorKgMt = (decimal)item.decFactorKgMt,
                                    sintInsumoViga = (short)item.sintInsumoViga,
                                    intNumeroViga = (int)item.intNumeroViga,
                                    intNumeroPza = (int)item.intNumeroPza,
                                    decDesarrollo = (decimal)item.decDesarrollo,
                                    intLongitud = (int)item.intLongitud,
                                    vchDescripcion = item.vchDescripcion,
                                    decAncho = (decimal)item.decAncho,
                                    decLargo = (decimal)item.decLargo,
                                    intPiezaxLamina = (int)item.intPiezaxLamina,
                                    intNumPiezaProm = (int)item.intNumPiezaProm,
                                    decPesoPieza = (int)item.decPesoPieza,
                                    decPesoPartida = (decimal)item.decPesoPartida,
                                    decTotal = (decimal)item.decTotal,
                                    decAreaPintura = (decimal)item.decAreaPintura,
                                    intCara = (int)item.intCara,
                                    bitActivo = (bool)item.bitActivo
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
                                    decAncho = (decimal)item.decAncho,
                                    decAreaPintura = (decimal)item.decAreaPintura,
                                    decDesarrollo = (decimal)item.decDesarrollo,
                                    decFactorAcero = (decimal)item.decFactorAcero,
                                    decFactorRemache = (decimal)item.decFactorRemache,
                                    decLargo = (decimal)item.decLargo,
                                    decPesoPartida = (decimal)item.decPesoPartida,
                                    decPesoPieza = (decimal)item.decPesoPieza,
                                    decTotal = (decimal)item.decTotal,
                                    intCalibreID = (int)item.intCalibreID,
                                    intCara = (int)item.intCara,
                                    intConectorVigaID = (int)item.intConectorVigaID,
                                    intLongitud = (int)item.intLongitud,
                                    intNumeroConector = (int)item.intNumeroConector,
                                    intNumeroPza = (int)item.intNumeroPza,
                                    intNumPiezaProm = (int)item.intNumPiezaProm,
                                    intPiezaxLamina = (int)item.intPiezaxLamina,
                                    sintFamiliaVigaID = (short)item.sintFamiliaVigaID,
                                    sintInsumoViga = (short)item.sintInsumoViga,
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
    }
}
