using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class CartonFlowDataAccess
    {
        /// <summary>
        /// Procedimiento que lista el catálogo tipo carton flow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <returns></returns>
        public List<Catalogo> ListarCatCalibreCartonFlow(short sintTipoCartonFlowID)
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCalibreCartonFlow(sintTipoCartonFlowID)
                                select new Catalogo
                                {
                                    intCatalogoID = item.intCalibreAceroID,
                                    vchDescripcion = item.vchCalibreAcero
                                };
                    result.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de Carton Flow
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatosCartonFlowID"></param>
        /// <returns></returns>
        public List<DatosCartonFlow> ListarDatosCartonFlow(int intCotizacionID, int intDatosCartonFlowID)
        {
            List<DatosCartonFlow> result = new List<DatosCartonFlow>();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosCartonFlow(intCotizacionID, intDatosCartonFlowID)
                                select new DatosCartonFlow
                                {
                                    intDatosCartonFlowID = item.intDatosCartonFlowID,
                                    intCotizacionID = item.intCotizacionID,
                                    decFrente = item.decFrente,
                                    decFondo = item.decFondo,
                                    decAltura = item.decAltura,
                                    decPeso = item.decPeso,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    decLargo = item.decLargo,
                                    intNumCajaNivel = item.intNumCajaNivel,
                                    decPesoNivel = item.decPesoNivel,
                                    intNumNivel = item.intNumNivel,
                                    intCantRefuerzoNivel = item.intCantRefuerzoNivel,
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    intCalibreAceroID = item.intCalibreAceroID
                                };
                    result.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los datos de Carton Flow
        /// </summary>
        /// <param name="carton"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosCaronFlow(DatosCartonFlow carton, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosCartonFlow(carton.intDatosCartonFlowID, carton.intElementoID, carton.intDetCotizaID, carton.sintPinturaID,
                        carton.sintTipoCartonFlowID, carton.sintMonedaID, carton.intUnidadMedicionID, carton.intCalibreAceroID, carton.decFrente, carton.decFondo,
                        carton.decAltura, carton.decLargo, carton.decPeso,carton.decPesoUnitario, carton.decPesoTotal, carton.decPrecioUnitario, carton.decPrecioTotal,
                        carton.intNumCajaNivel, carton.decPesoNivel, carton.intNumNivel, carton.intCantRefuerzoNivel, carton.bitActivo, (byte)tinOpcion)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los datos de perfil
        /// </summary>
        /// <param name="perfil"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPerfil(DatosPerfil perfil, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosPerfil(perfil.intPerfilID, perfil.sintTipoPerfilID, perfil.intElementoID, perfil.sintTipoCartonFlowID,
                        perfil.sintPinturaID, perfil.intDetCotizaID, perfil.intCalibreAceroID, perfil.decLargo, perfil.decCapacidad, 
                        perfil.intCantidad, perfil.vchLeyenda, perfil.decPrecioUnitario, perfil.decPrecioTotal, perfil.decPesoUnitario,
                        perfil.decPesoTotal, perfil.intCotizacionID, perfil.bitActivo, (byte)tinOpcion)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los conectores carton flow
        /// </summary>
        /// <param name="conector"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosConectorCartonFlow(DatosConectorCartonFlow conector, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosConectorCartonFlow(conector.intDatosConectorCFID, conector.intCotizacionID, conector.intDetCotizaID, conector.sintTipoCartonFlowID,
                        conector.intCalibreAceroID, conector.decAncho, conector.decLargo, conector.sintPesoPieza, conector.decTotalKiloUnitario,
                        conector.decPesoTotal, conector.decPrecioUnitario, conector.decPrecioTotal, conector.vchLeyenda, conector.bitActivo, (byte)tinOpcion)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de los datos de riel por rueda
        /// </summary>
        /// <param name="riel"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosRielPortaRueda(DatosRielPortaRueda riel, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosRielPortaRueda(riel.intRielPortaRuedaID, riel.intElementoID, riel.intCotizacionID, riel.intDetCotizaID,
                        riel.intCalibreAceroID, riel.intUnidadMedicionID, riel.sintMonedaID, riel.sintTipoCartonFlowID, riel.decLargo, 
                        riel.intNumNivel, riel.intClip, riel.intCantidadRuedaRiel, riel.intCantidad, riel.decCostoPorRuedaUSD, 
                        riel.decTipoCambio, riel.decTotalRielPartida, riel.bitPlastica, riel.decPrecioUnitario,
                        riel.decPrecioTotal, riel.bitActivo, (byte)tinOpcion)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
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
