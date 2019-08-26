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
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosPiso> ListarDatosPiso(int intDatosPisoID, int intDetCotizaID)
        {
            List<DatosPiso> result = new List<DatosPiso>();
            try
            {
                result = PisoDA.ListarDatosPiso(intDatosPisoID, intDetCotizaID);
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
                detCotizacion.intElementoID = 2; // Falta definir el ID
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = piso.intCantidad;
                detCotizacion.decMonto = piso.decPrecioTotal;
                detCotizacion.decSubtotal = Decimal.Round((Math.Truncate(100 * piso.decPrecioTotal.Value) / 100) * piso.intCantidad.Value);

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
                        ListPiso = ListarDatosPiso((int)piso.intDatoPisoID, intDetCotizaID);
                    // Validamos si existe registro
                    if (ListPiso.Count() > 0)
                        _piso = ListPiso.First();
                    else
                        _piso.intDatoPisoID = 0;
                    // Actualizamos la información
                    _piso.bitActivo = piso.bitActivo;
                    _piso.bitTipoPisoAbierto = piso.bitTipoPisoAbierto;
                    _piso.bitUsoPatin = piso.bitUsoPatin;
                    _piso.decAncho = piso.decAncho;
                    _piso.decLargoPiso = piso.decLargoPiso;
                    _piso.decPesoTotal = piso.decPesoTotal;
                    _piso.decPesoUnitario = piso.decPesoUnitario;
                    _piso.decPrecioTotal = piso.decPrecioTotal;
                    _piso.decPrecioUnitario = piso.decPrecioUnitario;
                    _piso.intCantidad = piso.intCantidad;
                    _piso.intCotizacionID = intCotizacionID;
                    _piso.intDatoPisoID = piso.intDatoPisoID;
                    _piso.intDetCotizaID = intDetCotizaID;
                    _piso.intElementoID = 0; // ID FALTANTE
                    _piso.sintPinturaID = piso.sintPinturaID;


                    //Realizamos el registro de los datos
                    result = (new DriveInLogic()).setDatosPiso(_piso, tinOpcion);
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
