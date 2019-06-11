using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class ProtectoresLogic
    {
        #region Constructor

        private ProtectoresDataAccess CatalogosDA;

        public ProtectoresLogic()
        {
            CatalogosDA = new ProtectoresDataAccess();

        }

        #endregion
        /// <summary>
        /// Procedimiento que muestra los datos del protector viga en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        public List<DatosProtectorBase> ListarDatosProtectorPoste(Int32 intCotizacionID)
        {
            List<DatosProtectorBase> results = null;
            try
            {
                results = CatalogosDA.ListarDatosProtectorPoste(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Procedimeinto que nos muestra la información del protector de batería en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosProtectorBateria> ListarDatosProtectorBateria(Int32 intCotizacionID)
        {
            List<DatosProtectorBateria> results = null;
            try
            {
                results = CatalogosDA.ListarDatosProtectorBateria(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        /// <summary>
        /// Realiza el alta, modificación o baja a los datos protector poste
        /// </summary>
        /// <param name="datosProtector"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorPoste(DatosProtectorBase datosProtector, short tinOpcion)
        {
            Resultado result = new Resultado();
            int? intProtectorPosteID;
            int? intDetCotizaID;
            try
            {
                // Obtenemos la información del sistema Selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo((int)datosProtector.intCotizacionID);
                intProtectorPosteID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = datosProtector.intDetCotizaID;
                detCotizacion.intCotizacionID = datosProtector.intCotizacionID;
                detCotizacion.intElementoID = 8; // ID correspondiente a Distanciador
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = datosProtector.intCantidadProtectorPoste;
                detCotizacion.decMonto = datosProtector.decPrecioVentaUnitario;
                detCotizacion.decSubtotal = datosProtector.decPrecioVentaUnitario * datosProtector.intCantidadProtectorPoste;

                // 1. Realizamos el alta de la cotización
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(datosProtector.intDetCotizaID == 0 ? 1 : tinOpcion));
                // Validamos la respuesta obtenida
                if (result.vchResultado != "NOK")
                {
                    // Almacenamos el ID del detalle de la cotización
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    datosProtector.intDetCotizaID = intDetCotizaID;
                    datosProtector.intElementoID = 8;
                    // Procedeimos a realizar el almacenado de la información
                    result = (new SistemasTyrsaLogic()).setDatosProtectorPoste(datosProtector, tinOpcion);
                    if (result.vchResultado != "NOK")
                    {
                        intProtectorPosteID = Convert.ToInt32(result.vchResultado);
                        if ((sistema.intProtectorPosteID == null || sistema.intProtectorPosteID == 0) || tinOpcion == 3)
                        {
                            // En caso de realizar la baja, establecemos el valor a 0
                            if (tinOpcion == 3)
                                sistema.intProtectorPosteID = 0;
                            else
                                sistema.intProtectorPosteID = intProtectorPosteID;

                            sistema.intTipoElementoAlmacenID = 17;
                            sistema.intCotizacionID = datosProtector.intCotizacionID;

                            result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, 2);
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
        /// Realiza el alta, baja o modificación a los datos de Protector Batería
        /// </summary>
        /// <param name="datosProtectorBateria"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorBateria(DatosProtectorBateria datosProtectorBateria, short tinOpcion)
        {
            Resultado result = new Resultado();
            int? intProtectorBateriaID;
            int? intDetCotizaID;
            try
            {
                // Obtenemos la información del sistema Selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo((int)datosProtectorBateria.intCotizacionID);
                intProtectorBateriaID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = datosProtectorBateria.intDetCotizaID;
                detCotizacion.intCotizacionID = datosProtectorBateria.intCotizacionID;
                detCotizacion.intElementoID = 9; // ID correspondiente a Distanciador
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = datosProtectorBateria.intCantidadSencilla;
                detCotizacion.decMonto = datosProtectorBateria.decPrecioSencilla;
                detCotizacion.decSubtotal = datosProtectorBateria.decPrecioSencilla * datosProtectorBateria.intCantidadSencilla;

                // 1. Realizamos el alta de la cotización
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(datosProtectorBateria.intDetCotizaID == 0 ? 1 : tinOpcion));
                // Validamos la respuesta obtenida
                if (result.vchResultado != "NOK")
                {
                    // Almacenamos el ID del detalle de la cotización
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    datosProtectorBateria.intDetCotizaID = intDetCotizaID;
                    datosProtectorBateria.intElementoID = 9;
                    // Procedeimos a realizar el almacenado de la información
                    result = (new SistemasTyrsaLogic()).setDatosProtectorBateria(datosProtectorBateria, tinOpcion);
                    if (result.vchResultado != "NOK")
                    {
                        intProtectorBateriaID = Convert.ToInt32(result.vchResultado);
                        if ((sistema.intProtectorBateriaID == null || sistema.intProtectorBateriaID == 0) || tinOpcion == 3)
                        {
                            // En caso de realizar la baja, establecemos el valor a 0
                            if (tinOpcion == 3)
                                sistema.intProtectorBateriaID = 0;
                            else
                                sistema.intProtectorBateriaID = intProtectorBateriaID;

                            sistema.intTipoElementoAlmacenID = 17;
                            sistema.intCotizacionID = datosProtectorBateria.intCotizacionID;

                            result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, 2);
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
        /// Procedimiento que permite obtener la lista de protectores rack
        /// </summary>
        /// <returns></returns>
        public List<DatosProtectorRack> ListarDatosSeleccionProtectorRack()
        {
            List<DatosProtectorRack> result = new List<DatosProtectorRack>();
            try
            {
                result = CatalogosDA.ListarDatosSeleccionProtectorRack();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que devuelve la lista de baterias sencillas
        /// </summary>
        /// <returns></returns>
        public List<DatosSeleccionBateria> ListarSeleccionBateriaSencilla()
        {
            List<DatosSeleccionBateria> result = new List<DatosSeleccionBateria>();
            try
            {
                result = CatalogosDA.ListarSeleccionBateriaSencilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de batería doble
        /// </summary>
        /// <returns></returns>
        public List<DatosSeleccionBateria> ListarSeleccionBateriaDoble()
        {
            List<DatosSeleccionBateria> result = new List<DatosSeleccionBateria>();
            try
            {
                result = CatalogosDA.ListarSeleccionBateriaDoble();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de batería cuadruple
        /// </summary>
        /// <returns></returns>
        public List<DatosSeleccionBateria> ListarSeleccionBateriaCuadruple()
        {
            List<DatosSeleccionBateria> result = new List<DatosSeleccionBateria>();
            try
            {
                result = CatalogosDA.ListarSeleccionBateriaCuadruple();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
