﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.BrazoServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "BrazoServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione BrazoServices.svc o BrazoServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class BrazoServices : IBrazoServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de brazo
        /// </summary>
        /// <param name="intBrazoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosBrazo> ListarDatosBrazo(int intBrazoID, int intCotizacionID)
        {
            List<DatosBrazo> result = new List<DatosBrazo>();
            try
            {
                result = (new BrazoLogic()).ListarDatosBrazo(intBrazoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista datos Drive In Brazo
        /// </summary>
        /// <param name="intDatosDriveInID"></param>
        /// <returns></returns>
        public List<SeleccionBrazo> ListarDatosBrazoDriveIn(int intDatosDriveInID)
        {
            List<SeleccionBrazo> result = new List<SeleccionBrazo>();
            try
            {
                result = (new BrazoLogic()).ListarDatosBrazoDriveIn(intDatosDriveInID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion brazo en base al ID de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionBrazo> ListarSeleccionBrazo(int intCotizacionID)
        {
            List<SeleccionBrazo> result = new List<SeleccionBrazo>();
            try
            {
                result = (new BrazoLogic()).ListarSeleccionBrazo(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos de brazo
        /// </summary>
        /// <param name="brazo"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBrazo(DatosBrazo brazo, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new BrazoLogic()).setDatosBrazo(brazo, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
