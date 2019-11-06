using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class PerfilDataAccess
    {
        /// <summary>
        /// Procedmiento que lista el catálogo de perfil carton Flow
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPerfilCartonFlow()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                using (PerfilDataContext dc = new PerfilDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatPerfilCartonFlow()
                                select new Catalogo
                                {
                                    intCatalogoID = item.sintTipoCartonFlowID,
                                    vchDescripcion = item.vchTipoCartonFlow
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
        /// Procedimiento que lista los datos perfil carton flow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="decLargoPerfil"></param>
        /// <returns></returns>
        public List<DatosPerfilCartonFlow> ListarPerfilCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, decimal decLargoPerfil)
        {
            List<DatosPerfilCartonFlow> result = new List<DatosPerfilCartonFlow>();
            try
            {
                using (PerfilDataContext dc = new PerfilDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarPerfilCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, decLargoPerfil)
                                select new DatosPerfilCartonFlow
                                {
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    sintCalibre = item.sintCalibre,
                                    vchTipoCartonFlow = item.vchTipoCartonFlow,
                                    decAncho = item.decAncho,
                                    decLargo = item.decLargo,
                                    sintPesoPieza = item.sintPesoPieza,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    vchLeyenda = item.vchLeyenda
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
        /// Procedimiento que lista los datos de perfil de Carton Flow
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intPerfilID"></param>
        /// <returns></returns>
        public List<DatosPerfil> ListarDatosPerfilCartonFlow(int intCotizacionID, int intPerfilID)
        {
            List<DatosPerfil> result = new List<DatosPerfil>();
            try
            {
                using (PerfilDataContext dc = new PerfilDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPerfilCartonFlow(intPerfilID, intCotizacionID)
                                select new DatosPerfil
                                {
                                    intPerfilID = item.intPerfilID,
                                    sintTipoPerfilID = item.sintTipoPerfilID,
                                    sintTipoCartonFlowID = item.sintTipoCartonFlowID,
                                    intElementoID = item.intElementoID,
                                    sintPinturaID = item.sintPinturaID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intCalibreAceroID = item.intCalibreAceroID,
                                    decLargo = item.decLargo,
                                    decCapacidad = item.decCapacidad,
                                    intCantidad = item.intCantidad,
                                    vchLeyenda = item.vchLeyenda,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    sintNumXNivel = item.sintNumXNivel,
                                    bitActivo = item.bitActivo
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
    }
}
