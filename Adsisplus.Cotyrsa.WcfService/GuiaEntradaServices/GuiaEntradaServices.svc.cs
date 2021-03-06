﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.GuiaEntradaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "GuiaEntradaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione GuiaEntradaServices.svc o GuiaEntradaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class GuiaEntradaServices : IGuiaEntradaServices
    {
        /// <summary>
        /// Procedimiento que lista los datos Guia Entrada
        /// </summary>
        /// <param name="intGuiaEntradaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosGuiaEntrada> ListarDatosGuiaEntrada(int intGuiaEntradaID, int intCotizacionID)
        {
            List<DatosGuiaEntrada> result = new List<DatosGuiaEntrada>();
            try
            {
                result = (new GuiaEntradaLogic()).ListarDatosGuiaEntrada(intGuiaEntradaID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de guia monta carga en base al largo
        /// </summary>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        public List<DatosMontaCargaDriveIn> ListarDatosGuiaMontaCargaDriveIn(short sintLargoID)
        {
            List<DatosMontaCargaDriveIn> result = new List<DatosMontaCargaDriveIn>();
            try
            {
                result = (new GuiaEntradaLogic()).ListarDatosGuiaMontaCargaDriveIn(sintLargoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion de guia monta carga en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionGuiaMonteCarga> ListarSeleccionGuiaMontaCarga(int intCotizacionID)
        {
            List<SeleccionGuiaMonteCarga> result = new List<SeleccionGuiaMonteCarga>();
            try
            {
                result = (new GuiaEntradaLogic()).ListarSeleccionGuiaMontaCarga(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos Guia Entrada
        /// </summary>
        /// <param name="guia"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosGuiaEntrada(DatosGuiaEntrada guia, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new GuiaEntradaLogic()).setDatosGuiaEntrada(guia, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

    }
}
