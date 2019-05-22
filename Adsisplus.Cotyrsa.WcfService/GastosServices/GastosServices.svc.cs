﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.GastosServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "GastosServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione GastosServices.svc o GastosServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class GastosServices : IGastosServices
    {
        /// <summary>
        /// Procedimiento que devuelve los datos de la pantalla de Gastos
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosGastos> ListarDatosPantallaGastos(int intCotizacionID, int intDetCotizaID)
        {
            List<DatosGastos> result = new List<DatosGastos>();
            try
            {
                result = (new GastosLogic()).ListarDatosPantallaGastos(intCotizacionID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de gastos
        /// </summary>
        /// <param name="flete"></param>
        /// <param name="instalacion"></param>
        /// <param name="viaticos"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitActivo"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosGastos(DatosFlete flete, DatosInstalacion instalacion, DatosViaticos viaticos, int intCotizacionID, int intDetCotizaID, bool bitActivo, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new GastosLogic()).setDatosGastos(flete, instalacion, viaticos, intCotizacionID, intDetCotizaID, bitActivo, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
