﻿using Adsisplus.Cotyrsa.BusinessEntities;
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
        /// <summary>
        /// Procedimiento que lista los datos de DriveIn
        /// </summary>
        /// <param name="intDatosDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosDriveIn> ListarDatosDriveIn(int intDatosDriveInID, int intCotizacionID)
        {
            List<DatosDriveIn> result = new List<DatosDriveIn>();
            try
            {
                result = (new DriveInLogic()).ListarDatosDriveIn(intDatosDriveInID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos Drive In en base al tipo de viga
        /// </summary>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="sintLongitudID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        public List<DriveIn> ListarDatosMstDriveIn(short sintTipoVigaID, short sintLongitudID, int intCalibreID, short sintLargoID)
        {
            List<DriveIn> result = new List<DriveIn>();
            try
            {
                result = (new DriveInLogic()).ListarDatosMstDriveIn(sintTipoVigaID, sintLargoID, intCalibreID, sintLargoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
