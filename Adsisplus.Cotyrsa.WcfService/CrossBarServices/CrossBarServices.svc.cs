using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CrossBarServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CrossBarServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CrossBarServices.svc o CrossBarServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CrossBarServices : ICrossBarServices
    {
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="intDatosCrossBarID"></param>
        ///// <param name="intElementoID"></param>
        ///// <param name="intDatoMarcoID"></param>
        ///// <returns></returns>
        //public List<DatosCrossBar> ListarDatosPanel(int intDatosCrossBarID, int intElementoID, int intDatoMarcoID)
        //{
        //    List<DatosCrossBar> result = new List<DatosCrossBar>();
        //    try
        //    {
        //        result = (new CrossBarDataLogic()).ListarDatosPanel(intDatosCrossBarID, intElementoID, intDatoMarcoID);
        //    }
        //    catch (Exception ex)
        //    {
        //        Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
        //    }
        //    return result;
        //}
        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarAnchoCrossBar()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = (new CrossBarDataLogic()).ListarAnchoCrossBar();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <param name="decAncho"></param>
        /// <returns></returns>
        public List<SeleccionCrossBar> ListarSeleccionCrossBar(decimal decAncho)
        {
            List<SeleccionCrossBar> result = new List<SeleccionCrossBar>();
            try
            {
                result = (new CrossBarDataLogic()).ListarSeleccionCrossBar(decAncho);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que devuelve la información de una CrossBar seleccionadao
        /// </summary>
        /// <param name="intSeleccionCrossBarID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPantallaCrossBar> ListarDatosPantallaCrossBar(int intSeleccionCrossBarID, int intCotizacionID)
        {
            List<DatosPantallaCrossBar> result = new List<DatosPantallaCrossBar>();
            try
            {
                result = (new CrossBarDataLogic()).ListarDatosPantallaCrossBar(intSeleccionCrossBarID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que obtiene los datos de la seleccion de Cross Bar
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionCrossBar> ListarDatosSeleccionCrossBar(int intCotizacionID)
        {
            List<SeleccionCrossBar> result = new List<SeleccionCrossBar>();
            try
            {
                result = (new CrossBarDataLogic()).ListarDatosSeleccionCrossBar(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta del CrossBar a la cotización
        /// </summary>
        /// <param name="dppCrossBar"></param>
        /// <param name="crossBar"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intCantidad"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionCrossBar(DatosPantallaCrossBar dppCrossBar, SeleccionCrossBar crossBar, int intCotizacionID, int intDetCotizaID, int intCantidad, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new CrossBarDataLogic()).setSeleccionCrossBar(dppCrossBar, crossBar, intCotizacionID, intDetCotizaID, intCantidad, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
