﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.DistanciadorServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "DistanciadorServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DistanciadorServices.svc o DistanciadorServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class DistanciadorServices : IDistanciadorServices
    {
        /// <summary>
        /// Procedimiento que lista los datos del distanciador en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosDistanciador> ListarDatosDistanciador(int intCotizacionID)
        {
            List<DatosDistanciador> result = new List<DatosDistanciador>();
            try
            {
                result = (new DistanciadorLogic()).ListarDatosDistanciador(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de distanciadores en base al altura
        /// </summary>
        /// <param name="decAltura"></param>
        /// <returns></returns>
        public List<SeleccionDistanciador> ListarSeleccionDistanciador(decimal decAltura)
        {
            List<SeleccionDistanciador> result = new List<SeleccionDistanciador>();
            try
            {
                result = (new DistanciadorLogic()).ListarSeleccionDistanciador(decAltura);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de valores de altura de distanciador
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatalogoDistanciador()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = (new DistanciadorLogic()).ListarCatalogoDistanciador();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de selección distanciador
        /// </summary>
        /// <param name="intCotizacion"></param>
        /// <returns></returns>
        public List<SeleccionDistanciador> ListarDatosSeleccionDistanciador(int intCotizacion)
        {
            List<SeleccionDistanciador> result = new List<SeleccionDistanciador>();
            try
            {
                result = (new DistanciadorLogic()).ListarDatosSeleccionDistanciador(intCotizacion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Lista los datos de la pantalla Distanciador
        /// </summary>
        /// <param name="intSeleccionDistanciadorID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPantallaDistanciador> ListarDatosPantallaDistanciador(int intSeleccionDistanciadorID, int intCotizacionID)
        {
            List<DatosPantallaDistanciador> result = new List<DatosPantallaDistanciador>();
            try
            {
                result = (new DistanciadorLogic()).ListarDatosPantallaDistanciador(intSeleccionDistanciadorID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que almacena los datos del Distanciador
        /// </summary>
        /// <param name="distanciador"></param>
        /// <param name="seleccionDistanciador"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDistanciador(DatosDistanciador distanciador, SeleccionDistanciador seleccionDistanciador, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new DistanciadorLogic()).setDatosDistanciador(distanciador, seleccionDistanciador, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza la baja lógica y física(en caso de existir error) en la captura de los
        /// datos de distanciador
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = se realiza borrado físico de la información
        ///                         0 = se realiza borrado lógico de la información</param>
        /// <returns></returns>
        public Resultado setBajaDistanciador(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new DistanciadorLogic()).setBajaDistanciador(intDetCotizaID, bitRollBack);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
