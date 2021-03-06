﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class PisoLogic
    {
        private PisoDataAccess PisoDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public PisoLogic()
        {
            PisoDA = new PisoDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos de piso
        /// </summary>
        /// <param name="intDatosPisoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPiso> ListarDatosPiso(int intDatosPisoID, int intCotizacionID)
        {
            List<DatosPiso> result = new List<DatosPiso>();
            try
            {
                result = PisoDA.ListarDatosPiso(intDatosPisoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de los pisos registrados
        /// </summary>
        /// <param name="intDatoPisoID"></param>
        /// <returns></returns>
        public List<SeleccionPiso> ListarDatosSeleccionPiso(int intDatoPisoID)
        {
            List<SeleccionPiso> result = new List<SeleccionPiso>();
            try
            {
                result = PisoDA.ListarDatosSeleccionPiso(intDatoPisoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion Piso Drive In
        /// </summary>
        /// <param name="intCantidad"></param>
        /// <param name="decLargo"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<SeleccionPisoDriveIn> ListarPisoDriveIn(int? intCantidad, decimal? decLargo, bool? bitGalvanizado)
        {
            List<SeleccionPisoDriveIn> result = new List<SeleccionPisoDriveIn>();
            try
            {
                result = PisoDA.ListarPisoDriveIn(intCantidad, decLargo, bitGalvanizado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos piso
        /// </summary>
        /// <param name="piso"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPiso(DatosPiso piso, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 21;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = piso.intCantidad;
                detCotizacion.decMonto = tinOpcion == 3 ? 0 : piso.decPrecioTotal;
                detCotizacion.decSubtotal = tinOpcion == 3 ? 0 : Decimal.Round((Math.Truncate(100 * piso.decPrecioTotal.Value) / 100) * piso.intCantidad.Value);

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    piso.intDetCotizaID = intDetCotizaID;
                    
                    List<DatosPiso> ListPiso = new List<DatosPiso>();
                    DatosPiso _piso = new DatosPiso();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListPiso = ListarDatosPiso((int)piso.intDatoPisoID, intCotizacionID);
                    // Validamos si existe registro
                    if (ListPiso.Count() > 0)
                        _piso = ListPiso.First();
                    else
                        _piso.intDatoPisoID = 0;

                    _piso.intCotizacionID = intCotizacionID;
                    _piso.intDetCotizaID = intDetCotizaID;
                    if (tinOpcion != 3)
                    {
                        // Actualizamos la información
                        _piso.bitActivo = piso.bitActivo;
                        _piso.bitTipoPisoAbierto = piso.bitTipoPisoAbierto;
                        _piso.bitGalvanizado = piso.bitGalvanizado;
                        _piso.bitUsoPatin = piso.bitUsoPatin;
                        _piso.decAncho = piso.decAncho;
                        _piso.decLargoPiso = piso.decLargoPiso;
                        _piso.decPesoTotal = piso.decPesoTotal;
                        _piso.decPesoUnitario = piso.seleccion.First().decPesoBase;
                        _piso.decPrecioTotal = piso.decPrecioTotal;
                        _piso.decPrecioUnitario = piso.seleccion.First().decPrecioBase;
                        _piso.intCantidad = piso.intCantidad;

                        _piso.intDatoPisoID = piso.intDatoPisoID;
                        _piso.intElementoID = 21;
                        _piso.sintPinturaID = piso.sintPinturaID;
                    }
                    //Realizamos el registro de los datos
                    result = (new DriveInLogic()).setDatosPiso(_piso, tinOpcion);

                    // Validamos el cambio realizado
                    if (result.vchResultado != "NOK")
                        result = (new DriveInLogic()).setSeleccionPiso(tinOpcion == 3 ? _piso.seleccion :  piso.seleccion, (int)piso.intCantidad, Convert.ToInt32(result.vchResultado), _piso.intDetCotizaID, tinOpcion);
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
