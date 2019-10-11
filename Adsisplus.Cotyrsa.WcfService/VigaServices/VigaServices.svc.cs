using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.VigaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "VigaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione VigaServices.svc o VigaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class VigaServices : IVigaServices
    {
        #region PROCEDIMIENTOS QUE SON USADOS EN EL SISTEMA SELECTIVO
        /// <summary>
        /// Obtiene la lista del total por viga
        /// </summary>
        /// <param name="intConfiguraVigaID"></param>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="intCapacidadVigaID"></param>
        /// <param name="intFactorVigaID"></param>
        /// <param name="sintInsumoViga"></param>
        /// <returns></returns>
        public List<Viga> ListarConfiguracionViga(int intConfiguraVigaID, int sintTipoVigaID, int intElementoID, int intCalibreID, int intCapacidadVigaID, int intFactorVigaID, short sintInsumoViga)
        {
            List<Viga> result = new List<Viga>();
            try
            {
                result = (new VigaLogic()).ListarConfiguracionViga(intConfiguraVigaID, sintTipoVigaID, intElementoID, intCalibreID, intCapacidadVigaID, intFactorVigaID, sintInsumoViga);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
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
                result = (new VigaLogic()).ListarConfiguracion_Viga(sintTipoVigaID, intElementoID, intCalibreID, sintFactorVigaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
        public List<DatosViga> ListarDatosViga(int intDatosVigaID, short sintPinturaID, int intElementoID, int intDatoMarcoID, int intDetCotizacion)
        {
            List<DatosViga> result = new List<DatosViga>();
            try
            {
                result = (new VigaLogic()).ListarDatosViga(intDatosVigaID, sintPinturaID, intElementoID, intDatosVigaID, intDetCotizacion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de la viga tope ligado a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosVigaTope> ListarDatosVigaTope(int intCotizacionID)
        {
            List<DatosVigaTope> result = new List<DatosVigaTope>();
            try
            {
                result = (new VigaLogic()).ListarDatosVigaTope(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de las viga por tope
        /// </summary>
        /// <param name="intTotalViga"></param>
        /// <param name="intConfiguraVigaID"></param>
        /// <returns></returns>
        public List<TotalViga> ListarTotalViga(int intTotalViga, int intConfiguraVigaID)
        {
            List<TotalViga> result = new List<TotalViga>();
            try
            {
                result = (new VigaLogic()).ListarTotalViga(intTotalViga, intConfiguraVigaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).ListarConectorViga(intCalibreID, sintInsumoViga, sintTipoConectorID, sintFamiliaVigaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
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
                result = (new VigaLogic()).ListarLongitudViga(intNumeroTarimasPorNivel, decFrente);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
            try
            {
                result = (new VigaLogic()).seleccionVigas(decLongitudViga, intNumeroTarimasPorNivel, decTarimaProductoPeso, sintSistemaID, bitEstructural);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que obtiene la lista de vigas tipo C
        /// </summary>
        /// <param name="decLongitudViga"></param>
        /// <returns></returns>
        public List<SeleccionVigaTipoCaja> ListarSeleccionVigas_TipoC(decimal decLongitudViga)
        {
            List<SeleccionVigaTipoCaja> result = new List<SeleccionVigaTipoCaja>();
            try
            {
                result = (new VigaLogic()).ListarSeleccionVigas_TipoC(decLongitudViga);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).ListaDatosSeleccionViga(intCotizacionID);
            }
            catch(Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que obtiene los datos de la pantalla de la viga a mostrar
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <returns></returns>
        public List<RackSelectivo> ListarDatosPantallaViga(int intDetCotizacionID, int intSeleccionVigaID)
        {
            List<RackSelectivo> result = new List<RackSelectivo>();
            try
            {
                result = (new VigaLogic()).ListarDatosPantallaViga(intDetCotizacionID, intSeleccionVigaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).hayElementosVinculadosAlaViga(intDetCotizaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).setConfiguracionViga(decFactorAcero, decFactorRemache, decFactorKgMt, intNumeroViga, intNumeroPza);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).setFactorViga(intCalibreID, decAcero, decRemache, decKgMetroCuadrado, decFactorVenta, decFactorDespiste, decFactorDescuento);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que almacena toda la información de la pantalla de captura de Viga
        /// </summary>
        /// <param name="viga"></param>
        /// <param name="rack"></param>
        /// <param name="sintPinturaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizacionID"></param>
        /// <param name="intCantidad"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosViga(SeleccionViga viga, RackSelectivo rack, short sintPinturaID, int intCotizacionID, int intDetCotizacionID, int intCantidad, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new VigaLogic()).setDatosViga(viga, rack, intCotizacionID, intDetCotizacionID, sintPinturaID, intCantidad, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
            try
            {
                result = (new VigaLogic()).setDatosVigaTope(vigaTope, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).setBajaViga(intDetCotizaID, bitRollBack);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).setBajaVigaTope(intDetCotizaID, bitRollBack);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        #endregion

        #region PROCEDIMIENTO QUE SON USADOS EN EL SISTEMA DRIVE IN
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
                result = (new VigaLogic()).ListarDatosVigaAtirantado(intVigaAtirantadoID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).setDatosVigaAtirantado(viga, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista las vigas tipo caja
        /// </summary>
        /// <returns></returns>
        public List<SeleccionVigaTipoCaja> ListarSeleccionVigaTipoCaja()
        {
            List<SeleccionVigaTipoCaja> result = new List<SeleccionVigaTipoCaja>();
            try
            {
                result = (new VigaLogic()).ListarSeleccionVigaTipoCaja();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new VigaLogic()).ListarAnguloRanurado(decCapacidadCarga);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        #endregion
    }
}
