﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adsisplus.Cotyrsa.WcfService.PisoServices
{
    public class PisoServices : IPisoServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de piso
        /// </summary>
        /// <param name="intDatosPisoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosPiso> ListarDatosPiso(int intDatosPisoID, int intDetCotizaID)
        {
            List<DatosPiso> result = new List<DatosPiso>();
            try
            {
                result = (new PisoLogic()).ListarDatosPiso(intDatosPisoID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos piso
        /// </summary>
        /// <param name="piso"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPiso(DatosPiso piso, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new PisoLogic()).setDatosPiso(piso, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}