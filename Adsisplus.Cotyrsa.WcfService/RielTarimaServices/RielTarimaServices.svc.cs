using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.RielTarimaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RielTarimaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RielTarimaServices.svc o RielTarimaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RielTarimaServices : IRielTarimaServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Riel Tarima
        /// </summary>
        /// <param name="intRielTarimaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosRielTarima> ListarDatosRielTarima(int intRielTarimaID, int intCotizacionID)
        {
            List<DatosRielTarima> result = new List<DatosRielTarima>();
            try
            {
                result = (new RielTarimaLogic()).ListarDatosRielTarima(intRielTarimaID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de Riel Tarima en base al ID de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionRielDeCarga> ListarSeleccionRielTarima(int intCotizacionID)
        {
            List<SeleccionRielDeCarga> result = new List<SeleccionRielDeCarga>();
            try
            {
                result = (new RielTarimaLogic()).ListarSeleccionRielTarima(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion riel de carga
        /// </summary>
        /// <param name="decPeso"></param>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        public List<SeleccionRielDeCarga> ListarDriveInRielDeCarga(decimal decPeso, bool bitEsEstructural)
        {
            List<SeleccionRielDeCarga> result = new List<SeleccionRielDeCarga>();
            try
            {
                result = (new RielTarimaLogic()).ListarDriveInRielDeCarga(decPeso, bitEsEstructural);
            }
            catch(Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta o modificación de los datos Riel Tarima
        /// </summary>
        /// <param name="riel"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosRielTarima(DatosRielTarima riel, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new RielTarimaLogic()).setDatosRielTarima(riel, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
