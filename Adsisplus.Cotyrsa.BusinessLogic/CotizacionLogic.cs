using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;

using Adsisplus.Cotyrsa.DataAccess;
using Adsisplus.Cotyrsa.Shared.Utilities;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class CotizacionLogic
    {
        #region Constructor

        private readonly CotizacionDataAccess CatalogosDA;

        public CotizacionLogic()
        {
            CatalogosDA = new CotizacionDataAccess();

        }

        #endregion

        /// <summary>
        /// Procedimiento que lista los datos de cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intEstatusID"></param>
        /// <param name="sintPrioridadID"></param>
        /// <param name="intEmpresaID"></param>
        /// <param name="intUsuarioID"></param>
        /// /// <param name="bitMuestraDatos">1 para muestrar toda la información de las cotizaciones, 0 para mostrar solo la información del usuario</param>
        /// <returns></returns>
        public List<Cotizacion> ListarDatosCotizacion(Int32 intCotizacionID, Int32 intEstatusID, Int32 sintPrioridadID, Int32 intEmpresaID, int intUsuarioID, bool bitMuestraDatos)
        {
            List<Cotizacion> result = new List<Cotizacion>();
            try
            {
                // Validamos si se mostrará toda la información
                intUsuarioID = bitMuestraDatos == true ? 0 : intUsuarioID;
                result = CatalogosDA.ListarDatosCotizacion(intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID, intUsuarioID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarRel_TipoElementoAlmacen_FactorCotizacion(intTipoElementoAlmacen_FactorID, intTipoElementoAlmacenID, sintFactorID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.setMstCotizacion(cotizacion, rack, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.setDetCotizacion(cotizacion, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.setDatosRelSistemaSelectivo(sistema, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarCotizacion(intEmpresaID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarDatosSistemaSelectivo(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarDetalleCotizacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarDatosPantallaCotizacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
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
            Cotizacion cotizacion = new Cotizacion();
            try
            {
                cotizacion.intCotizacionID = intCotizacionID;
                //  Obtenemos los datos de la cotización seleccionada
                result = CatalogosDA.setMstCotizacion(cotizacion, null, 3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
