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
    }
}
