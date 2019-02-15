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
        /// Obtiene la lista de los datos por viga
        /// </summary>
        /// <param name="intCantidadVigaTope"></param>
        /// <param name="intVigaTopeID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatosVigaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosVigaTope> ListarDatosVigaTope(int intCantidadVigaTope, int intVigaTopeID, int intElementoID, int intDatosVigaID, int intCotizacionID, short sintPinturaID)
        {
            List<DatosVigaTope> result = new List<DatosVigaTope>();
            try
            {
                result = (new VigaLogic()).ListarDatosVigaTope(intCantidadVigaTope, intVigaTopeID, intElementoID, intDatosVigaID, intCotizacionID, sintPinturaID);
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
        /// Procedimiento que muestra la seleccion de Viga
        /// </summary>
        /// <param name="intSeleccionVigaID"></param>
        /// <returns></returns>
        public SeleccionViga ListaDatosSeleccionViga(int intSeleccionVigaID)
        {
            SeleccionViga result = new SeleccionViga();
            try
            {
                result = (new VigaLogic()).ListaDatosSeleccionViga(intSeleccionVigaID);
            }
            catch(Exception ex)
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
        /// Procedimiento que obtiene los datos de la pantalla de la viga a mostrar
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <returns></returns>
        public RackSelectivo ListarDatosPantallaViga(int intDetCotizacionID)
        {
            RackSelectivo result = new RackSelectivo();
            try
            {
                result = (new VigaLogic()).ListarDatosPantallaViga(intDetCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
