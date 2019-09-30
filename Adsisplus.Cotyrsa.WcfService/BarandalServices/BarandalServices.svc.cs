using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.BarandalServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "BarandalServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione BarandalServices.svc o BarandalServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class BarandalServices : IBarandalServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Barandal
        /// </summary>
        /// <param name="intDatosBarandalID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosBarandal> ListarDatosBarandal(int intDatosBarandalID, int intCotizacionID)
        {
            List<DatosBarandal> result = new List<DatosBarandal>();
            try
            {
                result = (new BarandalLogic()).ListarDatosBarandal(intDatosBarandalID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de precio DriveIn Barandal en base al largo
        /// </summary>
        /// <param name="decLargo"></param>
        /// <returns></returns>
        public List<SeleccionBarandal> ListarDriveInBarandal(decimal decLargo)
        {
            List<SeleccionBarandal> result = new List<SeleccionBarandal>();
            try
            {
                result = (new BarandalLogic()).ListarDriveInBarandal(decLargo);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, baja o modificación de los datos de barandal
        /// </summary>
        /// <param name="barandal"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBarandal(DatosBarandal barandal, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new BarandalLogic()).setDatosBarandal(barandal, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
