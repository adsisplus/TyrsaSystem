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
        /// Procedmiento que lista el catálogo de perfil carton Flow
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPerfilCartonFlow()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
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
                using (SistemasCartonFlowDataContext dc = new SistemasCartonFlowDataContext(Helper.ConnectionString()))
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
    }
}
