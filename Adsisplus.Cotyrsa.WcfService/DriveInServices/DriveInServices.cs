using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adsisplus.Cotyrsa.WcfService.DriveInServices
{
    public class DriveInServices : IDriveInServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de DriveIn
        /// </summary>
        /// <param name="intDatosDriveInID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosDriveIn> ListarDatosDriveIn(int intDatosDriveInID, int intDetCotizaID)
        {
            List<DatosDriveIn> result = new List<DatosDriveIn>();
            try
            {
                result = (new DriveInLogic()).ListarDatosDriveIn(intDatosDriveInID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
         /// <summary>
         /// Procedimiento que realiza el alta, modificación o baja de los datos Drive In
         /// </summary>
         /// <param name="drive"></param>
         /// <param name="intCotizacionID"></param>
         /// <param name="intDetCotizaID"></param>
         /// <param name="tinOpcion"></param>
         /// <returns></returns>
        public Resultado setDatosDriveIn(DatosDriveIn drive, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new DriveInLogic()).setDatosDriveIn(drive, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}