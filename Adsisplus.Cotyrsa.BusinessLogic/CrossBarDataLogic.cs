using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;


namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class CrossBarDataLogic
    {
        #region Constructor

        private CrossBarDataAccess CatalogosDA;

        public CrossBarDataLogic()
        {
            CatalogosDA = new CrossBarDataAccess();

        }

        #endregion

        public List<DatosCrossBar> ListarDatosPanel(Int32 intDatosCrossBarID, Int32 intElementoID, Int32 intDatoMarcoID)
        {
            List<DatosCrossBar> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPanel(intDatosCrossBarID, intElementoID, intDatoMarcoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <returns></returns>
        public List<decimal> ListarAnchoCrossBar()
        {
            List<decimal> result = new List<decimal>();
            try
            {
                result = CatalogosDA.ListarAnchoCrossBar();
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarSeleccionCrossBar(decAncho);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que muestra los datos de CrossBar, tabla tbl_MST_DatosCrossBar
        /// </summary>
        /// <param name="intDatosCrossBarID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        public List<DatosCrossBar> ListarDatosCrossBar(int intDatosCrossBarID, int intElementoID, int intDatoMarcoID)
        {
            List<DatosCrossBar> result = new List<DatosCrossBar>();
            try
            {
                result = CatalogosDA.ListarDatosCrossBar(intDatosCrossBarID, intElementoID, intDatoMarcoID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarDatosPantallaCrossBar(intSeleccionCrossBarID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarDatosSeleccionCrossBar(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
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
            int? intSeleccionCrossBarID = 0;
            int? intDatosCrossBarID = 0;

            try
            {
                // Obtenemos la información del sistema Selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo(intCotizacionID);
                intSeleccionCrossBarID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intElementoID = 4; // ID correspondiente a Panel
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = intCantidad;
                detCotizacion.decMonto = crossBar.decTotal;
                detCotizacion.decSubtotal = crossBar.decTotal * intCantidad;

                // 1. Realizamos el alta de la cotización
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                // Validamos la respuesta obtenida
                if (result.vchResultado != "NOK")
                {
                    // Obtenemos el ID de detalle insertado / actualizado
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    dppCrossBar.intDetCotizaID = intDetCotizaID;

                    // 2. Se realiza el registro del panel en las tablas tbl_RackSelectivo y tbl_SeleccionCrossBar, 
                    // devolverá el intSeleccionCrossBarID
                    if (crossBar.intSeleccionCrossBarID != null)
                        // En caso de no ser 0, realizamos la actualización de los datos del marco
                        result = CatalogosDA.setSeleccionCrossBar(dppCrossBar, crossBar, tinOpcion);
                    else
                        // En caso contrario, almacenamos los datos de la selección Marco
                        result = CatalogosDA.setSeleccionCrossBar(dppCrossBar, crossBar, 1);
                    // Validamos la respuesta del procedimiento
                    if (result.vchResultado != "NOK")
                    {
                        // Obtenemos el ID del Panel insertado/Actualizado
                        intSeleccionCrossBarID = Convert.ToInt32(result.vchResultado);
                        // Lista que nos almacenará los páneles
                        List<DatosCrossBar> lstMstCrossBar = new List<DatosCrossBar>();
                        DatosCrossBar mstCrossBar = new DatosCrossBar();

                        // validamos si es un registro nuevo
                        if (tinOpcion != 1)
                            // Obtenemos información del Marco (tbl_MST_DatosMarco)
                            lstMstCrossBar = (new CrossBarDataLogic()).ListarDatosCrossBar((int)sistema.intDatosCrossBarID, 4, (int)sistema.intDatoMarcoID);

                        // En caso de existir, asignamos el resultado
                        if (lstMstCrossBar.Count > 0)
                            mstCrossBar = lstMstCrossBar.First();
                        else // En caso contrario, establecemos el valor a 0
                            mstCrossBar.intDatosCrossBarID = 0;
                        // Actualizamos la información
                        mstCrossBar.intElementoID = 4; // ID correspondiente al CrossBar
                        mstCrossBar.intDatoMarcoID = sistema.intDatoMarcoID;
                        mstCrossBar.intDetCotizaID = intDetCotizaID;
                        mstCrossBar.decAnchoCrossBar = crossBar.decAncho;
                        mstCrossBar.bitConectorVigaCrossbar = dppCrossBar.bitConectorViga;
                        mstCrossBar.intCantidadNivelCrossbar = dppCrossBar.intCantNivel;
                        mstCrossBar.intCantidad = intCantidad;

                        // Realizamos el registro del panel
                        result = (new SistemasTyrsaLogic()).setDatosCrossBar(mstCrossBar, tinOpcion);

                        // Validamos el resultado
                        if (result.vchResultado != "NOK")
                        {
                            intDatosCrossBarID = Convert.ToInt32(result.vchResultado);
                            if ((sistema.intDatosCrossBarID == null || sistema.intDatosCrossBarID == 0) || tinOpcion == 3)
                            {
                                // En caso de realizar la baja, establecemos el valor a 0
                                if (tinOpcion == 3)
                                    sistema.intDatosCrossBarID = 0;
                                else
                                    sistema.intDatosCrossBarID = intDatosCrossBarID;

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
    }
}
