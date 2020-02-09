using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.EstanteriaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EstanteriaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EstanteriaServices.svc o EstanteriaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EstanteriaServices : IEstanteriaServices
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
                result = (new EstanteriaLogic()).ListarEntrepanio(sintRefuerzo, decFrente, decFondo, intCalibreAceroID, bitGalvanizado);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new EstanteriaLogic()).ListarDatosEntrepanio(intEntrepanioID, intCotizacionID);
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
        public List<SeleccionAnguloRanurado> ListarAnguloRanurado(decimal decCapacidadCarga)
        {
            List<SeleccionAnguloRanurado> result = new List<SeleccionAnguloRanurado>();
            try
            {
                result = (new EstanteriaLogic()).ListarAnguloRanurado(decCapacidadCarga);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new EstanteriaLogic()).ListarSeleccionAnguloRanurado(intAnguloRanuradoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new EstanteriaLogic()).ListarDatosAnguladoRanurado(intAnguloRanuradoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new EstanteriaLogic()).ListarCatFrenteEntrepanio();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new EstanteriaLogic()).ListarCatFondoEntrepanio();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new EstanteriaLogic()).ListarCatCalibreEstanteria();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta y modificación de los datos entrepaños
        /// </summary>
        /// <param name="entrepanio"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        ///         /// <summary>
        /// Procedimiento que lista las escuadra de refuerzo
        /// </summary>
        /// <returns></returns>
        public List<SeleccionEscuadraRefuerzo> ListarEscuadraRefuerzo()
        {
            List<SeleccionEscuadraRefuerzo> result = new List<SeleccionEscuadraRefuerzo>();
            try
            {
                result = (new EstanteriaLogic()).ListarEscuadraRefuerzo();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos escuadra refuerzo
        /// </summary>
        /// <param name="intEscuadraRefID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosEscuadraRefuerzo> ListarDatosEscuadraRefuerzo(int intEscuadraRefID, int intCotizacionID)
        {
            List<DatosEscuadraRefuerzo> result = new List<DatosEscuadraRefuerzo>();
            try
            {
                result = (new EstanteriaLogic()).ListarDatosEscuadraRefuerzo(intEscuadraRefID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        public Resultado setDatosEntrepanio(DatosEntrepanio entrepanio, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new EstanteriaLogic()).setDatosEntrepanio(entrepanio, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta y modificación de los datos de angulo ranurado
        /// </summary>
        /// <param name="anguloRanurado"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosAnguloRanurato(DatosAnguloRanurado anguloRanurado, int intDetCotizaID, int intCotizacionID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new EstanteriaLogic()).setDatosAnguloRanurato(anguloRanurado, intDetCotizaID, intCotizacionID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos escuadra refuerzo
        /// </summary>
        /// <param name="escuadra"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosEscuadraRefuerzo(DatosEscuadraRefuerzo escuadra, int intDetCotizaID, int intCotizacionID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new EstanteriaLogic()).setDatosEscuadraRefuerzo(escuadra, intDetCotizaID, intCotizacionID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
