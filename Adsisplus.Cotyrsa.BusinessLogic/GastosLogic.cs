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
        /// <returns></returns>
        public DatosGastos ListarDatosPantallaGastos(int intCotizacionID)
        {
            DatosGastos result = new DatosGastos();
            try
            {
                result = GastosDA.ListarDatosPantallaGastos(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
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
                    result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(flete.intDetCotizaID == 0  || flete.intDetCotizaID == null? 1 : 2));
                    // Validamos la respuesta obtenida
                    if (result.vchResultado != "NOK")
                    {
                        // Asignamos el ID del detalle
                        flete.intDetCotizaID = Convert.ToInt32(result.vchResultado);
                        flete.intElementoID = 13;
                        // Realizamos la búsqueda de fletes
                        List<DatosFlete> lstBusFlete = GastosDA.ListarDatosFlete((int)flete.intCotizacionID, flete.intDatoFleteID);
                        
                        if(lstBusFlete.Count > 0)
                        {
                            DatosFlete fleteResult = lstBusFlete.First();
                            // En caso de existir, obtenemos la información
                            flete.intDatoFleteID = fleteResult.intDatoFleteID;
                            flete.sintFleteID = fleteResult.sintFleteID;

                            // Actualizamos la información
                            result = GastosDA.setDatosFlete(flete, 2);
                        }
                        // Almacenamos el dato de los fletes
                        result = GastosDA.setDatosFlete(flete, 1);
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
                    result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)((instalacion.intDetCotizaID == 0 || instalacion.intDetCotizaID == null) ? 1 : 2));

                    if (result.vchResultado != "NOK")
                    {
                        // Asignamos el ID del detalle
                        instalacion.intDetCotizaID = Convert.ToInt32(result.vchResultado);
                        instalacion.intElementoID = 12;
                        
                        //Realizamos la búsqueda del gastos
                        List<DatosInstalacion> lstBusinstalacion = GastosDA.ListarDatosInstalacion((int)instalacion.intCotizacionID, (short)instalacion.sintInstalacionID);
                        // Revisamos si la lista contiene datos
                        if (lstBusinstalacion.Count > 0)
                        {
                            DatosInstalacion instalacionResult = new DatosInstalacion();
                            // En caso de exisitr resultado, asignamos los datos de la 
                            // búsqueda a la entidad a almacenar
                            instalacionResult = lstBusinstalacion.First();
                            instalacion.intDatosInstalacionID = instalacionResult.intDatosInstalacionID;
                            instalacion.sintInstalacionID = instalacion.sintInstalacionID;
                            // Almacenamos los datos de la instalación
                            result = GastosDA.setDatosInstalacion(instalacion, 2);
                        }
                        else
                        // Almacenamos los datos de la instalación
                            result = GastosDA.setDatosInstalacion(instalacion, 1);
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
                    result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(viaticos.intDetCotizaID == 0 || viaticos.intDetCotizaID == null ? 1 : 2));
                    if (result.vchResultado != "NOK")
                    {
                        //Asignamos el ID del detalle de cotización
                        viaticos.intDetCotizaID = Convert.ToInt32(result.vchResultado);
                        viaticos.intElementoID = 14;

                        List<DatosViaticos> lstBusViatico = GastosDA.ListarDatosViatico((int)viaticos.intCotizacionID, (short)viaticos.sintViaticoID);
                        if (lstBusViatico.Count > 0)
                        {
                            DatosViaticos viaticoResult = lstBusViatico.First();
                            /*
                         viatico.intCotizacionID, viatico.intDetCotizaID, viatico.intDatoViaticoID, viatico.intElementoID,
                        viatico.sintViaticoID, viatico.intCantidad, viatico.datFecha,    
                         */
                            viaticos.intDatoViaticoID = viaticoResult.intDatoViaticoID;
                            viaticos.sintViaticoID = viaticoResult.sintViaticoID;
                            // Almacenamos los datos de viatico
                            result = GastosDA.setDatosViatico(viaticos, 2);
                        }
                        else
                            // Almacenamos los datos del viático
                            result = GastosDA.setDatosViatico(viaticos, 1);
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
