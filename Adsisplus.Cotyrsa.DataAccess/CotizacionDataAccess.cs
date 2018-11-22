using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class CotizacionDataAccess
    {
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
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosCotizacion(intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID)
                                select new Cotizacion()
                                {
                                    intCotizacionID = item.intCotizacionID,
                                    vchEstatus = item.vchEstatus,
                                    vchPrioridad = item.vchPrioridad,
                                    vchNombreCliente = item.vchNombreCliente,
                                    vchFolio = item.vchFolio,
                                    datFechaCotizacion = item.datFechaCotizacion,
                                    datFechaAceptacion = item.datFechaAceptacion,
                                    datFechaRechazo = item.datFechaRechazo,
                                    intEmpresaID = item.intEmpresaID,
                                    decMonto = item.decMonto,
                                    decIVA = item.decIVA,
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
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarRel_TipoElementoAlmacen_FactorCotizacion(intTipoElementoAlmacen_FactorID, intTipoElementoAlmacenID, sintFactorID)
                                select new RelTipoElementoAlmacenFactorCotizacion
                                {
                                    bitActivo = (bool)item.bitActivo,
                                    datFechaAlta = (DateTime)item.datFechaAlta,
                                    decFactor = (decimal)item.decFactor,
                                    intTipoElementoAlmacenID = (int)item.intTipoElementoAlmacenID,
                                    intTipoElementoAlmacen_FactorID = item.intTipoElementoAlmacen_FactorID,
                                    sintFactorID = (short)item.sintFactorID,
                                    vchFactor = item.vchFactor
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
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setMstCotizacion(cotizacion.intCotizacionID, cotizacion.intEstatusID, cotizacion.sintPrioridadID, cotizacion.intEmpresaID,
                        cotizacion.vchFolio, cotizacion.datFechaAceptacion, cotizacion.datFechaRechazo,
                        cotizacion.bitActivo, (byte)tinOpcion)
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
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDetCotizacion(cotizacion.intDetCotizaID, cotizacion.intCotizacionID, cotizacion.sintMontajeID, cotizacion.intPartida, cotizacion.intCantidad,
                        cotizacion.decMedidaFrente, cotizacion.decMedidaFondo, cotizacion.decAlto, cotizacion.decPesoKg, cotizacion.bitMontaCarga,
                        cotizacion.intNumeroTarimaPorNivel, cotizacion.intNumeroNivelSobreViga, cotizacion.intPosicion, cotizacion.sintVisitas, cotizacion.vchDimensionMontacarga,
                        cotizacion.decDolar, cotizacion.decMonto, cotizacion.decSubtotal, cotizacion.decDescuento, cotizacion.decDescuentoFin,
                        cotizacion.decIEMPS, cotizacion.decRetISR, cotizacion.decRetIVA, cotizacion.decIVA, cotizacion.decTotal, cotizacion.bitActivo,
                        (byte)tinOpcion)
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
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCotizacion(intEmpresaID, intCotizacionID)
                                select new Cotizacion
                                {
                                    intCotizacionID = item.intCotizacionID,
                                    intEstatusID = item.intEstatusID,
                                    sintPrioridadID = item.sintPrioridadID,
                                    intEmpresaID = item.intEmpresaID,
                                    vchNombreCliente = item.vchNombre,
                                    vchFolio = item.vchFolio,
                                    datFechaCotizacion = item.datFechaCotizacion,
                                    datFechaAceptacion = item.datFechaAceptacion,
                                    datFechaRechazo = item.datFechaRechazo
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
        /// Procedimiento que lista el detalle de cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<Cotizacion> ListarDetalleCotizacion(int intCotizacionID)
        {
            List<Cotizacion> result = new List<Cotizacion>();
            try
            {
                using (CotizacionDataContext dc = new CotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDetalleCotizacion(intCotizacionID)
                                select new Cotizacion
                                {
                                    intDetCotizaID = item.intDetCotizaID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintMontajeID = item.sintMontajeID,
                                    intPartida = item.intPartida,
                                    intCantidad = item.intCantidad,
                                    decMedidaFrente = item.decMedidaFrente,
                                    decMedidaFondo = item.decMedidaFondo,
                                    decAlto = item.decAlto,
                                    decPesoKg = item.decPesoKg,
                                    bitMontaCarga = item.bitMontacarga,
                                    intNumeroTarimaPorNivel = item.intNumeroTarimaPorNivel,
                                    intNumeroNivelSobreViga = item.intNumeroNivelSobreViga,
                                    intPosicion = item.intPosicion,
                                    sintVisitas = item.sintVisitas,
                                    vchDimensionMontacarga = item.vchDimensionMontacarga,
                                    decDolar = item.decDolar,
                                    decMonto = item.decMonto,
                                    decSubtotal = item.decSubtotal,
                                    decDescuento = item.decDescuento,
                                    decDescuentoFin = item.decDescuentoFin,
                                    decIEMPS = item.decIEMPS,
                                    decRetISR = item.decRetISR,
                                    decRetIVA = item.decRetIVA,
                                    decIVA = item.decIVA,
                                    decTotal = item.decTotal,
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
    }
}
