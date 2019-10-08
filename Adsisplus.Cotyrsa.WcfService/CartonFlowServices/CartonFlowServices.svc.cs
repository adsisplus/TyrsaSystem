using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CartonFlowServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CartonFlowServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CartonFlowServices.svc o CartonFlowServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CartonFlowServices : ICartonFlowServices
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
                result = (new CartonFlowLogic()).ListarCatPerfilCartonFlow();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new CartonFlowLogic()).ListarCatCalibreCartonFlow(sintTipoCartonFlowID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new CartonFlowLogic()).ListarPerfilCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, decLargoPerfil);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
