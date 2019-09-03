using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.DriveInServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "DriveInServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DriveInServices.svc o DriveInServices.svc.cs en el Explorador de soluciones e inicie la depuración.
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
        ///// <summary>
        ///// Procedimiento que realiza el alta, modificación o baja de los datos Poste Drive In
        ///// </summary>
        ///// <param name="poste"></param>
        ///// <param name="intCotizacionID"></param>
        ///// <param name="intDetCotizaID"></param>
        ///// <param name="tinOpcion"></param>
        ///// <returns></returns>
        //public Resultado setDatosPosteDriveIn(DatosPosteDriveIn poste, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        //{
        //    Resultado result = new Resultado();
        //    try
        //    {
        //        result = (new DriveInLogic()).setDatosPosteDriveIn(poste, intCotizacionID, intDetCotizaID, tinOpcion);
        //    }
        //    catch (Exception ex)
        //    {
        //        Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
        //    }
        //    return result;
        //}
    }
}
