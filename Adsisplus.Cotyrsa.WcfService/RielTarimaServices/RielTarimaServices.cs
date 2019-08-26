using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adsisplus.Cotyrsa.WcfService.RielTarimaServices
{
    public class RielTarimaServices : IRielTarimaServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Riel Tarima
        /// </summary>
        /// <param name="intRielTarimaID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosRielTarima> ListarDatosRielTarima(int intRielTarimaID, int intDetCotizaID)
        {
            List<DatosRielTarima> result = new List<DatosRielTarima>();
            try
            {
                result = (new RielTarimaLogic()).ListarDatosRielTarima(intRielTarimaID, intDetCotizaID);
            }
            catch (Exception ex)
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