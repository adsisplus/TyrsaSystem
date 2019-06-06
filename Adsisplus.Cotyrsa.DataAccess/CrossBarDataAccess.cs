using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
namespace Adsisplus.Cotyrsa.DataAccess
{
   public class CrossBarDataAccess
    {
       
            public List<DatosCrossBar> ListarDatosPanel(Int32 intDatosCrossBarID, Int32 intElementoID, Int32 intDatoMarcoID)
            {
                List<DatosCrossBar> results = new List<DatosCrossBar>();
                try
                {
                    using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                    {
                        var query = from item in dc.stp_ListarDatosCrossBar(intDatosCrossBarID, intElementoID, intDatoMarcoID)
                                    select new DatosCrossBar()
                                    {
                                        intDatosCrossBarID = item.intDatosCrossBarID,
                                        vchElemento = item.vchElemento,
                                        sintCantidadDatoMarco = item.sintCantidadDatoMarco,
                                        decAnchoCrossBar = item.decAnchoCrossBar,
                                        bitConectorVigaCrossbar = item.bitConectorVigaCrossbar,
                                        intCantidadNivelCrossbar = item.intCantidadNivelCrossbar,
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
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <returns></returns>
        public List<decimal> ListarAnchoCrossBar()
        {
            List<decimal> result = new List<decimal>();
            try
            {
                using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                {
                    var query = dc.stp_ListarAnchoCrossBar();
                    result = (List<decimal>) query;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <param name="decAncho"></param>
        /// <returns></returns>
        public List<SeleccionCrossBar> ListarSeleccionCrossBar(decimal decAncho)
        {
            List<SeleccionCrossBar> result = new List<SeleccionCrossBar>();
            try
            {
                using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionCrossBar(decAncho)
                                select new SeleccionCrossBar
                                {
                                    sintCrossBarID = item.sintCrossBarID,
                                    vchTipoCrossBar = item.vchTipoCrossBar,
                                    decPrecioFinal = item.decPrecioFinal,
                                    sintFactorCrossBarID = item.sintFactorCrossBarID,
                                    sintNumPieza = item.sintNumPieza,
                                    decDesarrollo = item.decDesarrollo,
                                    decLongitud = item.decLongitud,
                                    vchMaterial = item.vchMaterial,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    intPiezaLamina = item.intPiezaLamina,
                                    intNumPiezas = item.intNumPiezas,
                                    sintPesoPieza = item.sintPesoPieza,
                                    decPesoPartida = item.decPesoPartida,
                                    decPrecioAcero = item.decPrecioAcero,
                                    decTotal = item.decTotal,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decAreaPintura = item.decAreaPintura,
                                    sintCara = item.sintCara,
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
        /// Procedimiento que muestra los datos de CrossBar, tabla tbl_MST_DatosCrossBar
        /// </summary>
        /// <param name="intDatosCrossBarID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        public List<DatosCrossBar> ListarDatosCrossBar(int intDatosCrossBarID, int intElementoID, int intDatoMarcoID)
        {
            List<DatosCrossBar> result = new List<DatosCrossBar>();
            try
            {
                using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosCrossBar(intDatosCrossBarID, intElementoID, intDatoMarcoID)
                                select new DatosCrossBar
                                {
                                    bitActivo = item.bitActivo,
                                    bitConectorVigaCrossbar = item.bitConectorVigaCrossbar,
                                    decAnchoCrossBar = item.decAnchoCrossBar,
                                    intCantidadNivelCrossbar = item.intCantidadNivelCrossbar,
                                    intDatosCrossBarID = item.intDatosCrossBarID,
                                    vchElemento = item.vchElemento,
                                    intNumeroNivel = item.intNumeroNivel
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
        /// Procedimiento que devuelve la información de una CrossBar seleccionadao
        /// </summary>
        /// <param name="intSeleccionCrossBarID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPantallaCrossBar> ListarDatosPantallaCrossBar(int intSeleccionCrossBarID, int intCotizacionID)
        {
            List<DatosPantallaCrossBar> result = new List<DatosPantallaCrossBar>();
            try
            {
                using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPantallaCrossBar(intSeleccionCrossBarID, intCotizacionID)
                                select new DatosPantallaCrossBar
                                {
                                    bitConectorViga = item.bitConectorViga,
                                    decAncho = item.decAnchoBus,
                                    decLargo = item.decLargoBus,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intRackID = item.intRackID,
                                    intCantNivel = item.intCantidadNivelCrossbar,
                                    intCantidad = item.intCantidad,
                                    crossBar = new SeleccionCrossBar()
                                    {
                                        bitActivo = item.bitActivo,
                                        decAncho = item.decAncho,
                                        decAreaPintura = item.decAreaPintura,
                                        decDesarrollo = item.decDesarrollo,
                                        decLargo = item.decLargo,
                                        decLongitud = item.decLongitud,
                                        decPesoPartida = item.decPesoPartida,
                                        decPrecioAcero = item.decPrecioAcero,
                                        decPrecioFinal = item.decPrecioFinal,
                                        decTotal = item.decTotal,
                                        decTotalKiloUnitario = item.decTotalKiloUnitario,
                                        intNumPiezas = item.intNumPiezas,
                                        intPiezaLamina = item.intPiezaLamina,
                                        intSeleccionCrossBarID = item.intSeleccionCrossBarID,
                                        sintCara = item.sintCara,
                                        sintCrossBarID = item.sintCrossBarID,
                                        sintFactorCrossBarID = item.sintFactorCrossBarID,
                                        sintNumPieza = item.sintNumPieza,
                                        sintPesoPieza = item.sintPesoPieza,
                                        vchMaterial = item.vchMaterial,
                                        vchTipoCrossBar = item.vchTipoCrossBar
                                    }
                                };
                    result.AddRange(query);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que obtiene los datos de la seleccion de Cross Bar
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionCrossBar> ListarDatosSeleccionCrossBar(int intCotizacionID)
        {
            List<SeleccionCrossBar> result = new List<SeleccionCrossBar>();
            try
            {
                using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosSeleccionCrossBar(intCotizacionID)
                                select new SeleccionCrossBar
                                {
                                    intSeleccionCrossBarID = item.intSeleccionCrossBarID,
                                    sintCrossBarID = item.sintCrossBarID,
                                    vchTipoCrossBar = item.vchTipoCrossBar,
                                    decPrecioFinal = item.decPrecioFinal,
                                    sintFactorCrossBarID = item.sintFactorCrossBarID,
                                    sintNumPieza = item.sintNumPieza,
                                    decDesarrollo = item.decDesarrollo,
                                    decLongitud = item.decLongitud,
                                    vchMaterial = item.vchMaterial,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    intPiezaLamina = item.sintPesoPieza,
                                    intNumPiezas = item.intNumPiezas,
                                    sintPesoPieza = item.sintPesoPieza,
                                    decPesoPartida = item.decPesoPartida,
                                    decPrecioAcero = item.decPrecioAcero,
                                    decTotal = item.decTotal,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decAreaPintura = item.decAreaPintura,
                                    sintCara = item.sintCara,
                                    intCantidad = item.intCantidad,
                                    decSubtotal = item.decSubtotal,
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
        /// Procedimiento que realiza el alta del Crossbar
        /// </summary>
        /// <param name="datosGrales"></param>
        /// <param name="crossBar"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionCrossBar(DatosPantallaCrossBar datosGrales, SeleccionCrossBar crossBar, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setSeleccionCrossBar(crossBar.intSeleccionCrossBarID, datosGrales.intRackID, datosGrales.intDetCotizaID, datosGrales.decAncho,
                        datosGrales.decLargo, datosGrales.bitConectorViga, crossBar.sintCrossBarID, crossBar.vchTipoCrossBar, crossBar.decPrecioFinal,
                        crossBar.sintFactorCrossBarID, crossBar.sintNumPieza, crossBar.decDesarrollo, crossBar.decLongitud, crossBar.vchMaterial,
                        crossBar.decAncho, crossBar.decLargo, crossBar.intPiezaLamina, crossBar.intNumPiezas, crossBar.sintPesoPieza,
                        crossBar.decPesoPartida, crossBar.decPrecioAcero, crossBar.decTotal, crossBar.decTotalKiloUnitario, crossBar.decAreaPintura,
                        crossBar.sintCara, crossBar.bitActivo, (byte) tinOpcion)
                                select new Resultado
                                {
                                    vchResultado = item.vchResultado,
                                    vchDescripcion = item.vchDescripcion
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
