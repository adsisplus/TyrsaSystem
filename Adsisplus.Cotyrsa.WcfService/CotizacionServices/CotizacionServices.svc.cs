using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CotizacionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CotizacionServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CotizacionServices.svc o CotizacionServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CotizacionServices : ICotizacionServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intEstatusID"></param>
        /// <param name="sintPrioridadID"></param>
        /// <param name="intEmpresaID"></param>
        /// <param name="bitMuestraDatos">1 para muestrar toda la información de las cotizaciones, 0 para mostrar solo la información del usuario</param>
        /// <returns></returns>
        public List<Cotizacion> ListarDatosCotizacion(Int32 intCotizacionID, Int32 intEstatusID, Int32 sintPrioridadID, Int32 intEmpresaID, int intUsuarioID, bool @bitMuestraDatos)
        {
            List<Cotizacion> result = new List<Cotizacion>();
            try
            {
                result = (new CotizacionLogic()).ListarDatosCotizacion(intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID, intUsuarioID, bitMuestraDatos);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de la relación de tipo elemento almacen vs Factor de cotización
        /// </summary>
        /// <param name="intTipoElementoAlmacen_FactorID"></param>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="sintFactorID"></param>
        /// <returns></returns>
        public List<RelTipoElementoAlmacenFactorCotizacion> ListarRel_TipoElementoAlmacen_FactorCotizacion(int intTipoElementoAlmacen_FactorID,
            int intTipoElementoAlmacenID, short sintFactorID)
        {
            List<RelTipoElementoAlmacenFactorCotizacion> result = new List<RelTipoElementoAlmacenFactorCotizacion>();
            try
            {
                result = (new CotizacionLogic()).ListarRel_TipoElementoAlmacen_FactorCotizacion(intTipoElementoAlmacen_FactorID, intTipoElementoAlmacenID, sintFactorID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimeinto que lista los datos de la cotización
        /// </summary>
        /// <param name="intEmpresaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<Cotizacion> ListarCotizacion(int intEmpresaID, int intCotizacionID)
        {
            List<Cotizacion> result = new List<Cotizacion>();
            try
            {
                result = (new CotizacionLogic()).ListarCotizacion(intEmpresaID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que nos devuelve los ID's de los elementos ligados a la cotización
        /// y al sistema selectivo
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public RelSistemaSelectivo ListarDatosSistemaSelectivo(int intCotizacionID)
        {
            RelSistemaSelectivo result = new RelSistemaSelectivo();
            try
            {
                result = (new CotizacionLogic()).ListarDatosSistemaSelectivo(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el detalle de cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<Cotizacion> ListarDetalleCotizacion(int intCotizacionID)
        {
            List<Cotizacion> result = new List<Cotizacion>();
            try
            {
                result = (new CotizacionLogic()).ListarDetalleCotizacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que nos devuelve la información capturada/mostrada en cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public Cotizacion ListarDatosPantallaCotizacion(int intCotizacionID)
        {
            Cotizacion result = new Cotizacion();
            try
            {
                result = (new CotizacionLogic()).ListarDatosPantallaCotizacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de la tabla mst_Cotizacion
        /// </summary>
        /// <param name="cotizacion"></param>
        /// <param name="rack"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setMstCotizacion(Cotizacion cotizacion, RackSelectivo rack, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new CotizacionLogic()).setMstCotizacion(cotizacion, rack, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de la tabla det_Cotizacion
        /// </summary>
        /// <param name="cotizacion"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDetCotizacion(Cotizacion cotizacion, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new CotizacionLogic()).setDetCotizacion(cotizacion, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza la relación entre cotización y el sistema selectivo
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosRelSistemaSelectivo(RelSistemaSelectivo sistema, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza la cancelación de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public Resultado setCancelacionCotizacion(int intCotizacionID)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new CotizacionLogic()).setCancelacionCotizacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
