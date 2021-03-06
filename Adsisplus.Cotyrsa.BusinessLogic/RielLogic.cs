﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class RielLogic
    {
        private RielDataAccess RielDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public RielLogic()
        {
            RielDA = new RielDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos de Riel de rueda en base a la cotización y al id principal
        /// </summary>
        /// <param name="intRielPortaRuedaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosRielPortaRueda> ListarDatosRielPortaRueda(int intRielPortaRuedaID, int intCotizacionID)
        {
            List<DatosRielPortaRueda> result = new List<DatosRielPortaRueda>();
            try
            {
                result = RielDA.ListarDatosRielPortaRueda(intRielPortaRuedaID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los rieles de rueda metálica de cartonflow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="sintCantidadRiel"></param>
        /// <param name="intNumNivel"></param>
        /// <param name="decLargoPerfil"></param>
        /// <param name="sintCantidadRuedas"></param>
        /// <param name="decPrecioRuedas"></param>
        /// <param name="decTipoCambio"></param>
        /// <returns></returns>
        public List<SeleccionRiel> ListarRielesRuedaMetalicaCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, short sintCantidadRiel,
            int intNumNivel, decimal decLargoPerfil, short sintCantidadRuedas, decimal decPrecioRuedas, decimal decTipoCambio)
        {
            List<SeleccionRiel> result = new List<SeleccionRiel>();
            try
            {
                result = RielDA.ListarRielesRuedaMetalicaCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, sintCantidadRiel,
                    intNumNivel, decLargoPerfil, sintCantidadRuedas, decPrecioRuedas, decTipoCambio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los rieles de rueda platica de cartonflow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="decAncho"></param>
        /// <param name="decLargo"></param>
        /// <param name="sintCantidadRiel"></param>
        /// <param name="decTotalKiloUnitario"></param>
        /// <param name="intNumNivel"></param>
        /// <param name="decLargoPerfil"></param>
        /// <param name="sintCantidadRuedas"></param>
        /// <param name="decPrecioRuedas"></param>
        /// <param name="decTipoCambio"></param>
        /// <param name="intInternacion"></param>
        /// <param name="decCostoInternacion"></param>
        /// <returns></returns>
        public List<SeleccionRiel> ListarRielesRuedaPlasticaCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, decimal decAncho, decimal decLargo, short sintCantidadRiel,
            short decTotalKiloUnitario, int intNumNivel, decimal decLargoPerfil, short sintCantidadRuedas, decimal decPrecioRuedas, decimal decTipoCambio, int intInternacion, decimal decCostoInternacion)
        {
            List<SeleccionRiel> result = new List<SeleccionRiel>();
            try
            {
                result = RielDA.ListarRielesRuedaPlasticaCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, decAncho, decLargo, sintCantidadRiel,
                    decTotalKiloUnitario, intNumNivel, decLargoPerfil, sintCantidadRuedas, decPrecioRuedas, decTipoCambio, intInternacion, decCostoInternacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y  baja de los datos de riel porta rueda
        /// </summary>
        /// <param name="riel"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosRielPortaRueda(DatosRielPortaRueda riel, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = riel.sintTipoCartonFlowID == 7 ? 27 : 28;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = riel.intNumNivel;
                detCotizacion.decMonto = riel.decPrecioUnitario;
                detCotizacion.decSubtotal = riel.decPrecioTotal;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    riel.intDetCotizaID = intDetCotizaID;

                    List<DatosRielPortaRueda> ListRiel = new List<DatosRielPortaRueda>();
                    DatosRielPortaRueda _riel = new DatosRielPortaRueda();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListRiel = ListarDatosRielPortaRueda((int)riel.intRielPortaRuedaID, intCotizacionID);
                    // Validamos si existe registro
                    if (ListRiel.Count() > 0)
                        _riel = ListRiel.First();
                    else
                        _riel.intRielPortaRuedaID = 0;

                    // Actualizamos la información
                    _riel = riel;
                    _riel.intCotizacionID = intCotizacionID;


                    // Realizamos el registro del Carton Flow
                    result = (new CartonFlowLogic()).setDatosRielPortaRueda(_riel, tinOpcion);
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
