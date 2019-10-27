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
        /// <param name="intDetCotizaID"></param>
        /// <param name="intDatosCartonFlowID"></param>
        /// <returns></returns>
        public List<DatosCartonFlow> ListarDatosCartonFlow(int intDetCotizaID, int intDatosCartonFlowID)
        {
            List<DatosCartonFlow> result = new List<DatosCartonFlow>();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosCartonFlow(intDetCotizaID, intDatosCartonFlowID)
                                select new DatosCartonFlow
                                {
                                    intDatosCartonFlowID = item.intDatosCartonFlowID,
                                    intCotizacionID = item.intCotizacionID,
                                    decFrente = item.decFrente,
                                    decFondo = item.decFondo,
                                    decAltura = item.decAltura,
                                    decPeso = item.decPeso,
                                    intNumCajaNivel = item.intNumCajaNivel,
                                    decPesoNivel = item.decPesoNivel,
                                    intNumNivel = item.intNumNivel,
                                    intCantRefuerzoNivel = item.intCantRefuerzoNivel,
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    intCalibre = item.intCalibre
                                };
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
                        carton.riel.sintTipoCartonFlowID, carton.sintMonedaID, carton.intUnidadMedicionID, carton.decFrente, carton.decFondo,
                        carton.decAltura, carton.decLargoPerfil, (short)carton.riel.intTotalRieles, carton.riel.decClip, carton.intInternacion,
                        carton.decCostoInternacion, carton.riel.decTotalInternacion, carton.riel.intTotalRieles, carton.riel.intTotalRuedas, carton.decPrecioRuedas,
                        carton.decTipoCambio, carton.riel.decCostoTotalRuedas, carton.decPeso, carton.decPesoTotal, carton.intNumCajaNivel,
                        carton.decPesoNivel, carton.intNumNivel, carton.intCantRefuerzoNivel, carton.decPrecioUnitario, carton.decPrecioTotal,
                        carton.vchLeyenda, carton.bitActivo, (byte)tinOpcion)
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
                    var query = from item in dc.stp_setDatosPerfil(perfil.intPerfilID, perfil.sintTipoPerfilID, perfil.intElementoID, perfil.sintPinturaID,
                        perfil.intDetCotizaID, perfil.intCalibreAceroID, perfil.decLargo, perfil.decCapacidad, perfil.intCantidad,
                        perfil.vchLeyenda, perfil.decPrecioUnitario, perfil.decPrecioTotal, perfil.decPesoUnitario,
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

        public Resultado setDatosRielPortaRueda(DatosRielPortaRueda riel, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
                { 
                
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
