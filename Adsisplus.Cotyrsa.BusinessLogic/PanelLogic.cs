using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
   public class PanelLogic
    {
        #region Constructor

        private PanelDataAccess CatalogosDA;

        public PanelLogic()
        {
            CatalogosDA = new PanelDataAccess();

        }

        #endregion

        public List<DatosPanel> ListarDatosPanel(Int32 intDatosPanelID, Int32 intElementoID, Int32 intDatoMarcoID, Int16 sintPinturaID)
        {
            List<DatosPanel> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPanel(intDatosPanelID, intElementoID, intDatoMarcoID, sintPinturaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Procedimiento que obtiene la lista de anchos del panel
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarAnchoPanel()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = CatalogosDA.ListarAnchoPanel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que nos muestra la lista de páneles para cotizaciones
        /// </summary>
        /// <param name="decAncho"></param>
        /// <param name="sintCalibre"></param>
        /// <param name="decFondo"></param>
        /// <param name="sintSistemaID"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<SeleccionPanel> ListarSeleccionPanel (decimal decAncho, short sintCalibre, decimal decFondo, short sintSistemaID, bool bitGalvanizado)
        {
            List<SeleccionPanel> result = new List<SeleccionPanel>();
            try
            {
                result = CatalogosDA.ListarSeleccionPanel(decAncho, sintCalibre, decFondo, sintSistemaID, bitGalvanizado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que devuelve información de la pantalla del panel seleccionado
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <param name="intSeleccionPanelID"></param>
        /// <returns></returns>
        public List<DatosPantallaPanel> ListarDatosPantallaPanel(int intDetCotizacionID, int intSeleccionPanelID)
        {
            List<DatosPantallaPanel> result = new List<DatosPantallaPanel>();
            try
            {
                result = CatalogosDA.ListarDatosPantallaPanel(intDetCotizacionID, intSeleccionPanelID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimeinto que nos muestra la lista de seleccion panel en base a una cotizacion
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionPanel> ListarDatosSeleccionPanel(int intCotizacionID)
        {
            List<SeleccionPanel> result = new List<SeleccionPanel>();
            try
            {
                result = CatalogosDA.ListarDatosSeleccionPanel(intCotizacionID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiemto que realiza el alta del panel a la cotización
        /// </summary>
        /// <param name="dppPanel"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intCantidad"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionPanel(DatosPantallaPanel dppPanel, SeleccionPanel panel, int intCotizacionID, int intDetCotizaID, int intCantidad, short tinOpcion)
        {
            Resultado result = new Resultado();
            int? intSeleccionPanelID = 0;
            int? intDatosPanelID = 0;

            try
            {
                // Obtenemos la información del sistema Selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo(intCotizacionID);
                intSeleccionPanelID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intElementoID = 3; // ID correspondiente a Panel
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = intCantidad;
                detCotizacion.decMonto = panel.decTotal;
                detCotizacion.decSubtotal = Decimal.Round((decimal)panel.decTotal * intCantidad);

                // 1. Realizamos el alta de la cotización
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                // Validamos la respuesta obtenida
                if (result.vchResultado != "NOK")
                {
                    // Obtenemos el ID de detalle insertado / actualizado
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    dppPanel.intDetCotizaID = intDetCotizaID;

                    // 2. Se realiza el registro del panel en las tablas tbl_RackSelectivo y tbl_SeleccionPanel, 
                    // devolverá el intSeleccionPanelID
                    if (panel.intSeleccionPanelID != null)
                        // En caso de no ser 0, realizamos la actualización de los datos del marco
                        result = CatalogosDA.setSeleccionPanel(dppPanel, panel, tinOpcion);
                    else
                        // En caso contrario, almacenamos los datos de la selección Marco
                        result = CatalogosDA.setSeleccionPanel(dppPanel, panel, 1);

                    // Validamos la respuesta del procedimiento
                    if (result.vchResultado != "NOK")
                    {
                        // Obtenemos el ID del Panel insertado/Actualizado
                        intSeleccionPanelID = Convert.ToInt32(result.vchResultado);
                        // Lista que nos almacenará los páneles
                        List<DatosPanel> lstMstPanel = new List<DatosPanel>();
                        DatosPanel mstPanel = new DatosPanel();

                        // validamos si es un registro nuevo
                        if (tinOpcion != 1)
                            // Obtenemos información del Marco (tbl_MST_DatosMarco)
                            lstMstPanel = (new PanelLogic()).ListarDatosPanel((int)sistema.intDatosPanelID, 3, (int)sistema.intDatoMarcoID, 0);

                        // En caso de existir, asignamos el resultado
                        if (lstMstPanel.Count > 0)
                            mstPanel = lstMstPanel.First();
                        else // En caso contrario, establecemos el valor a 0
                            mstPanel.intDatosPanelID = 0;
                        // Actualizamos la información
                        mstPanel.decAnchoPanel = panel.decAncho;
                        mstPanel.intDetCotizaID = intDetCotizaID;
                        mstPanel.decCapacidadCargaPanel = panel.decPesoKg;
                        mstPanel.intCantidadPanel = intCantidad;
                        mstPanel.intDatoMarcoID = sistema.intDatoMarcoID;
                        mstPanel.intElementoID = 3; // ID correspondiente al panel
                        mstPanel.sintCantidadDatoMarco = 0; // ¿Qué corresponde este dato?
                        mstPanel.sintPinturaID = dppPanel.sintPinturaID; // Se supone que no existe pintura?

                        // Realizamos el registro del panel
                        result = (new SistemasTyrsaLogic()).setDatosPanel(mstPanel, tinOpcion);

                        // Validamos el resultado
                        if (result.vchResultado != "NOK")
                        {
                            intDatosPanelID = Convert.ToInt32(result.vchResultado);
                            if ((sistema.intDatosPanelID == null || sistema.intDatosPanelID == 0) || tinOpcion == 3)
                            {
                                // En caso de realizar la baja, establecemos el valor a 0
                                if (tinOpcion == 3)
                                    sistema.intDatosPanelID = 0;
                                else
                                    sistema.intDatosPanelID = intDatosPanelID;

                                sistema.intTipoElementoAlmacenID = 17;
                                sistema.intCotizacionID = intCotizacionID;

                                result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, 2);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza la baja de los 
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = Realiza el borrado físico de las tablas <br /> 
        ///                             0 = Realiza el borrado lógico</param>
        /// <returns></returns>
        public Resultado setBajaPanel(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setBajaPanel(intDetCotizaID, bitRollBack);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
