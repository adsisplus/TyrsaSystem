using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class CartonFlowLogic
    {
        private CartonFlowDataAccess CartonFlowDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public CartonFlowLogic()
        {
            CartonFlowDA = new CartonFlowDataAccess();
        }
        /// <summary>
        /// Procedmiento que lista el catálogo de perfil carton Flow
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPerfilCartonFlow()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = CartonFlowDA.ListarCatPerfilCartonFlow();
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
                result = CartonFlowDA.ListarCatCalibreCartonFlow(sintTipoCartonFlowID);
            }
            catch(Exception ex)
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
                result = CartonFlowDA.ListarPerfilCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, decLargoPerfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
