using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class GastosLogic
    {
        #region Constructor

        private GastosDataAccess GastosDA;

        public GastosLogic()
        {
            GastosDA = new GastosDataAccess();
        }

        #endregion

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
                result = GastosDA.ListarDatosPantallaGastos(intCotizacionID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        ///// <summary>
        ///// Procedimiento que realiza el alta, modificación o baja de los datos de gastos
        ///// </summary>
        ///// <param name="flete"></param>
        ///// <param name="instalacion"></param>
        ///// <param name="viaticos"></param>
        ///// <param name="intCotizacionID"></param>
        ///// <param name="intDetCotizaID"></param>
        ///// <param name="bitActivo"></param>
        ///// <param name="tinOpcion"></param>
        ///// <returns></returns>
        //public Resultado setDatosGastos(List<DatosFlete> lstFletes, List<DatosInstalacion> lstInstalacion, List<DatosViaticos> lstViaticos, int intCotizacionID, bool bitActivo, short tinOpcion)
        //{
        //    Resultado result = new Resultado();
        //    int? intDetCotizaID;
        //    try
        //    {
        //        // Obtenemos la información del sistema Selectivo
        //        RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo((int)intCotizacionID);

        //        // Procedemos a llenar la entidad de la cotización
        //        Cotizacion detCotizacion = new Cotizacion();
        //        detCotizacion.intDetCotizaID = flete.intDetCotizaID;
        //        detCotizacion.intCotizacionID = intCotizacionID;
        //        detCotizacion.intElementoID = 13; // ID correspondiente a Distanciador
        //        detCotizacion.intPartida = 0;
        //        detCotizacion.intCantidad = flete.intCantidad;
        //        detCotizacion.decMonto = 0;
        //        detCotizacion.decSubtotal = 0;

        //        // 1. Realizamos el alta de la cotización
        //        result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(flete.intDetCotizaID == 0 ? 1 : tinOpcion));
        //        // Validamos la respuesta obtenida
        //        if (result.vchResultado != "NOK")
        //        {
        //            // Almacenamos el ID del detalle de la cotización
        //            intDetCotizaID = Convert.ToInt32(result.vchResultado);
        //            flete.intDetCotizaID = intDetCotizaID;
        //            flete.intElementoID = 13;

        //            // Almacenamos el siguiente detalle para instalación
        //            detCotizacion = new Cotizacion();
        //            detCotizacion.intDetCotizaID = instalacion.intDetCotizaID;
        //            detCotizacion.intCotizacionID = intCotizacionID;
        //            detCotizacion.intElementoID = 12; // ID correspondiente a instalacion
        //            detCotizacion.intPartida = 0;
        //            detCotizacion.intCantidad = instalacion.intCantidad;
        //            detCotizacion.decMonto = 0;
        //            detCotizacion.decSubtotal = 0;

        //            // Realizamos el alta de la cotización
        //            result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(instalacion.intDetCotizaID == 0 ? 1 : tinOpcion));

        //            if (result.vchResultado != "NOK")
        //            {
        //                // Almacenamos el ID del detalle de la cotización
        //                intDetCotizaID = Convert.ToInt32(result.vchResultado);
        //                instalacion.intDetCotizaID = intDetCotizaID;
        //                instalacion.intElementoID = 12;

        //                // Almacenamos el siguiente detalle para instalación
        //                detCotizacion = new Cotizacion();
        //                detCotizacion.intDetCotizaID = viaticos.intDetCotizaID;
        //                detCotizacion.intCotizacionID = intCotizacionID;
        //                detCotizacion.intElementoID = 14; // ID correspondiente a Distanciador
        //                detCotizacion.intPartida = 0;
        //                detCotizacion.intCantidad = viaticos.intCantidad;
        //                detCotizacion.decMonto = 0;
        //                detCotizacion.decSubtotal = 0;

        //                // Realizamos el alta de la cotización
        //                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(viaticos.intDetCotizaID == 0 ? 1 : tinOpcion));
        //                if (result.vchResultado != "NOK")
        //                {
        //                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
        //                    viaticos.intDetCotizaID = intDetCotizaID;
        //                    viaticos.intElementoID = 14;

        //                    // Procedeimos a realizar el almacenado de la información
        //                    result = GastosDA.setDatosGastos(flete, instalacion, viaticos, intCotizacionID, bitActivo, tinOpcion);
        //                    if (result.vchResultado != "NOK")
        //                    {
        //                        // Obtenemos la lista de ID's
        //                        string[] intID = result.vchResultado.Split('|');
        //                        // Pasamos la información
        //                        if ((sistema.intDatoFleteID == null || sistema.intDatoFleteID == 0) ||
        //                            (sistema.intDatosInstalacionID == null || sistema.intDatosInstalacionID == 0) ||
        //                            (sistema.intDatoViaticoID == null || sistema.intDatoViaticoID == 0) || tinOpcion == 3)
        //                        {
        //                            // En caso de realizar la baja, establecemos el valor a 0
        //                            if (tinOpcion == 3)
        //                            {
        //                                // Borramos los ID's de los gastos
        //                                sistema.intDatoFleteID = 0;
        //                                sistema.intDatosInstalacionID = 0;
        //                                sistema.intDatoViaticoID = 0;
        //                            }
        //                            else
        //                            {
        //                                // Almacenamos los ID's recuperados
        //                                sistema.intDatoFleteID = Convert.ToInt32(intID[0]);
        //                                sistema.intDatosInstalacionID = Convert.ToInt32(intID[1]);
        //                                sistema.intDatoViaticoID = Convert.ToInt32(intID[2]);
        //                            }
        //                            // Establecemos los datos generales
        //                            sistema.intTipoElementoAlmacenID = 17;
        //                            sistema.intCotizacionID = intCotizacionID;
        //                            // almacenamos los cambios realizados
        //                            result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, 2);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result;
        //}
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de flete
        /// </summary>
        /// <param name="flete"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosFlete(List<DatosFlete> lstFlete, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                foreach (DatosFlete flete in lstFlete)
                {
                    //// Obtenemos la información del sistema Selectivo
                    //RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo((int)flete.intCotizacionID);

                    // Procedemos a llenar la entidad de la cotización
                    Cotizacion detCotizacion = new Cotizacion();
                    detCotizacion.intDetCotizaID = flete.intDetCotizaID;
                    detCotizacion.intCotizacionID = flete.intCotizacionID;
                    detCotizacion.intElementoID = 13; // ID correspondiente a Distanciador
                    detCotizacion.intPartida = 0;
                    detCotizacion.intCantidad = flete.intCantidad;
                    detCotizacion.decMonto = 0;
                    detCotizacion.decSubtotal = 0;

                    // 1. Realizamos el alta de la cotización
                    result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(flete.intDetCotizaID == 0 ? 1 : tinOpcion));
                    // Validamos la respuesta obtenida
                    if (result.vchResultado != "NOK")
                    {
                        // Asignamos el ID del detalle
                        flete.intDetCotizaID = Convert.ToInt32(result.vchResultado);
                        // Almacenamos el dato de los fletes
                        result = GastosDA.setDatosFlete(flete, tinOpcion);
                    }
                    else // en caso de existir un error, rompemos el ciclo
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de instalación
        /// </summary>
        /// <param name="instalacion"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosInstalacion(List<DatosInstalacion> lstInstalacion, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                foreach (DatosInstalacion instalacion in lstInstalacion)
                {
                    // Procedemos a llenar la entidad de la cotización
                    Cotizacion detCotizacion = new Cotizacion();
                    // Almacenamos el siguiente detalle para instalación
                    detCotizacion = new Cotizacion();
                    detCotizacion.intDetCotizaID = instalacion.intDetCotizaID;
                    detCotizacion.intCotizacionID = instalacion.intCotizacionID;
                    detCotizacion.intElementoID = 12; // ID correspondiente a instalacion
                    detCotizacion.intPartida = 0;
                    detCotizacion.intCantidad = instalacion.intCantidad;
                    detCotizacion.decMonto = 0;
                    detCotizacion.decSubtotal = 0;

                    // Realizamos el alta de la cotización
                    result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(instalacion.intDetCotizaID == 0 ? 1 : tinOpcion));

                    if (result.vchResultado != "NOK")
                    {
                        // Asignamos el ID del detalle
                        instalacion.intDetCotizaID = Convert.ToInt32(result.vchResultado);
                        // Almacenamos los datos de la instalación
                        result = GastosDA.setDatosInstalacion(instalacion, tinOpcion);
                    }
                    else // En caso de existir un error, rompemos el ciclo
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de viaticos
        /// </summary>
        /// <param name="viatico"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosViatico(List<DatosViaticos> lstViatico, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                foreach (DatosViaticos viaticos in lstViatico)
                {
                    // Procedemos a llenar la entidad de la cotización
                    Cotizacion detCotizacion = new Cotizacion();
                    // Almacenamos el siguiente detalle para instalación
                    detCotizacion = new Cotizacion();
                    detCotizacion.intDetCotizaID = viaticos.intDetCotizaID;
                    detCotizacion.intCotizacionID = viaticos.intCotizacionID;
                    detCotizacion.intElementoID = 14; // ID correspondiente a Distanciador
                    detCotizacion.intPartida = 0;
                    detCotizacion.intCantidad = viaticos.intCantidad;
                    detCotizacion.decMonto = 0;
                    detCotizacion.decSubtotal = 0;

                    // Realizamos el alta de la cotización
                    result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(viaticos.intDetCotizaID == 0 ? 1 : tinOpcion));
                    if (result.vchResultado != "NOK")
                    {
                        //Asignamos el ID del detalle de cotización
                        viaticos.intDetCotizaID = Convert.ToInt32(result.vchResultado);
                        // Almacenamos los datos del viático
                        result = GastosDA.setDatosViatico(viaticos, tinOpcion);
                    }
                    else // En caso de existir error, rompemos el ciclo
                        break;
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
