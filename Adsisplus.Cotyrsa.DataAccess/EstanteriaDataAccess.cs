using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class EstanteriaDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos de entrepaño
        /// </summary>
        /// <param name="sintRefuerzo"></param>
        /// <param name="decFrente"></param>
        /// <param name="decFondo"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<SeleccionEntrepanio> ListarEntrepanio(short sintRefuerzo, decimal decFrente, decimal decFondo, int intCalibreAceroID, bool bitGalvanizado)
        {
            List<SeleccionEntrepanio> result = new List<SeleccionEntrepanio>();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarEntrepanio(sintRefuerzo, decFrente, decFondo, intCalibreAceroID, bitGalvanizado)
                                select new SeleccionEntrepanio
                                {
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    decFondo = item.decFondo,
                                    decFrente = item.decFrente,
                                    sintNumRefuerzo = item.sintNumRefuerzo,
                                    intCapCargaXEntrepanio = item.intCapCargaXEntrepanio,
                                    decDesarrollo = item.decDesarrollo,
                                    decLongitud = item.decLongitud,
                                    vchMaterial = item.vchMaterial,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioFinal = item.decPrecioFinal
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
        /// Procedimiento que lista los datos de Entrepaño
        /// </summary>
        /// <param name="intEntrepanioID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosEntrepanio> ListarDatosEntrepanio(int intEntrepanioID, int intCotizacionID)
        {
            List<DatosEntrepanio> result = new List<DatosEntrepanio>();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosEntrepanio(intEntrepanioID, intCotizacionID)
                                select new DatosEntrepanio
                                {
                                    intEntrepanioID = item.intEntrepanioID,
                                    sintTipoEntrepanioID = item.sintTipoEntrepanioID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intElementoID = item.intElementoID,
                                    sintPinturaID = item.sintPinturaID,
                                    intCalibreAceroID = item.intCalibreAceroID,
                                    intCantidad = item.intCantidad,
                                    bitGalvanizado = item.bitGalvanizado,
                                    bitPintura = item.bitPintura,
                                    sintRefuerzo = item.sintRefuerzo,
                                    decFrente = item.decFrente,
                                    decFondo = item.decFondo,
                                    decPesoPartida = item.decPesoPartida,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioVenta = item.decPrecioVenta,
                                    decPrecioFinal = item.decPrecioFinal,
                                    decPesoTotal = item.decPesoTotal,
                                    decPrecioTotal = item.decPrecioTotal,
                                    seleccion = new SeleccionEntrepanio()
                                    {
                                        intSeleccionEntrepanioID = item.intSeleccionEntrepanioID,
                                        vchCalibreAcero = item.vchCalibreAcero,
                                        decFondo = item.decFondoSel,
                                        decFrente = item.decFrenteSel,
                                        sintNumRefuerzo = item.sintNumRefuerzo,
                                        intCapCargaXEntrepanio = item.intCapCargaXEntrepanio,
                                        decDesarrollo = item.decDesarrollo,
                                        decLongitud = item.decLongitud,
                                        vchMaterial = item.vchMaterial,
                                        decTotalKiloUnitario = item.decTotalKiloUnitarioSel,
                                        decPrecioFinal = item.decPrecioFinalSel
                                    }
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
        public List<SeleccionAnguloRanurado> ListarAnguloRanurado(decimal decCapacidadCarga)
        {
            List<SeleccionAnguloRanurado> result = new List<SeleccionAnguloRanurado>();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarAnguloRanurado(decCapacidadCarga)
                                select new SeleccionAnguloRanurado
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
        /// <summary>
        /// Procedimiento que lista los datos de seleccion angulo ranurado almacenado
        /// </summary>
        /// <param name="intAnguloRanuradoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionAnguloRanurado> ListarSeleccionAnguloRanurado(int intAnguloRanuradoID, int intCotizacionID)
        {
            List<SeleccionAnguloRanurado> result = new List<SeleccionAnguloRanurado>();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionAnguloRanurado(intAnguloRanuradoID, intCotizacionID)
                                select new SeleccionAnguloRanurado
                                {
                                    intSeleccionAnguloID = item.intSeleccionAnguloID,
                                    intAnguloRanuradoID = item.intAnguloRanuradoID,
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
        /// <summary>
        /// ¨Procedimiento que lista los datos de angulo ranurado
        /// </summary>
        /// <param name="intAnguloRanuradoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosAnguloRanurado> ListarDatosAnguladoRanurado(int intAnguloRanuradoID, int intCotizacionID)
        {
            List<DatosAnguloRanurado> result = new List<DatosAnguloRanurado>();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosAnguloRanurado(intAnguloRanuradoID, intCotizacionID)
                                select new DatosAnguloRanurado
                                {
                                    intAnguloRanuradoID = item.intAnguloRanuradoID,
                                    sintTipoAnguloRanuradoID = (short)item.sintTipoAnguloRanuradoID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintPinturaID = item.sintPinturaID,
                                    intCantidad = item.intCantidad,
                                    decLargo = item.decLargo,
                                    decCapacidadCarga = item.decCapacidadCarga,
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
        /// Procedimiento que lista los valores de frente para entrepaño
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatFrenteEntrepanio()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatFrenteEntrepanio()
                                select new CatalogoDecimal
                                {
                                    decValor = item.decFrente,
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
        /// Procedimiento que lista los valores de fondo para entrepaño
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatFondoEntrepanio()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatFondoEntrepanio()
                                select new CatalogoDecimal
                                {
                                    decValor = item.decFondo
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
        /// Procedimiento que lista los valores de calibre para estanteria
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatCalibreEstanteria()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCalibreEstanteria()
                                select new Catalogo
                                {
                                    vchDescripcion = item.vchCalibreAcero
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
        /// Procedimiento que realiza el alta y modificación de los datos entrepaños
        /// </summary>
        /// <param name="entrepanio"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosEntrepanio(DatosEntrepanio entrepanio, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosEntrepanio(entrepanio.intEntrepanioID, entrepanio.sintTipoEntrepanioID, entrepanio.intCotizacionID, entrepanio.intDetCotizaID,
                        entrepanio.intElementoID, entrepanio.sintPinturaID, entrepanio.intCalibreAceroID, entrepanio.intCantidad, entrepanio.bitGalvanizado,
                        entrepanio.bitPintura, (byte)entrepanio.sintRefuerzo, entrepanio.decFrente, entrepanio.decFondo, entrepanio.decPesoPartida,
                        entrepanio.decTotalKiloUnitario, entrepanio.decPrecioVenta, entrepanio.decPrecioFinal, entrepanio.decPesoTotal, entrepanio.decPrecioTotal,
                        entrepanio.seleccion.intSeleccionEntrepanioID, entrepanio.seleccion.sintNumRefuerzo, entrepanio.seleccion.vchCalibreAcero, entrepanio.seleccion.intCapCargaXEntrepanio,
                        entrepanio.seleccion.decDesarrollo, entrepanio.seleccion.decLongitud, entrepanio.seleccion.vchMaterial, entrepanio.bitActivo, (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, modificación de los datos de angulo ranurado
        /// </summary>
        /// <param name="anguloRanurado"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosAnguloRanurado(DatosAnguloRanurado anguloRanurado, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaEstanteriaDataContext dc = new SistemaEstanteriaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosAnguloRanurado(anguloRanurado.intAnguloRanuradoID, anguloRanurado.sintTipoAnguloRanuradoID, anguloRanurado.intElementoID, anguloRanurado.intCotizacionID,
                        anguloRanurado.intDetCotizaID, anguloRanurado.sintPinturaID, anguloRanurado.intCantidad, anguloRanurado.decLargo, anguloRanurado.decCapacidadCarga,
                        anguloRanurado.seleccion.intSeleccionAnguloID, anguloRanurado.seleccion.decDesarrollo, anguloRanurado.seleccion.decLongitud, anguloRanurado.seleccion.decAncho, anguloRanurado.seleccion.vchMaterial,
                        anguloRanurado.seleccion.decPesoUnitario, anguloRanurado.seleccion.decPrecioUnitario, anguloRanurado.bitActivo, (byte)tinOpcion)
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
