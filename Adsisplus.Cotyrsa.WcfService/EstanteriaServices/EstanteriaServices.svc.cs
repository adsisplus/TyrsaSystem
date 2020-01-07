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
        /// Procedimiento que realiza el alta y modificación de los datos entrepaños
        /// </summary>
        /// <param name="entrepanio"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
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
    }
}
