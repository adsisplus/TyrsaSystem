using Adsisplus.Cotyrsa.BusinessEntities;
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
        /// Procedimiento que almacena los datos del Distanciador
        /// </summary>
        /// <param name="distanciador"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDistanciador(DatosDistanciador distanciador, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new DistanciadorLogic()).setDatosDistanciador(distanciador, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
