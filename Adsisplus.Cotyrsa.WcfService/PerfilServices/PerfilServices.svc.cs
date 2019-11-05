using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.PerfilServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PerfilServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PerfilServices.svc o PerfilServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PerfilServices : IPerfilServices
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
                result = (new PerfilLogic()).ListarCatPerfilCartonFlow();
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
                result = (new PerfilLogic()).ListarPerfilCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, decLargoPerfil);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de perfil de Carton Flow
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intPerfilID"></param>
        /// <returns></returns>
        public List<DatosPerfil> ListarDatosPerfil(int intCotizacionID, int intPerfilID)
        {
            List<DatosPerfil> result = new List<DatosPerfil>();
            try
            {
                result = (new PerfilLogic()).ListarDatosPerfil(intCotizacionID, intPerfilID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los datos de perfil
        /// </summary>
        /// <param name="perfil"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPerfil(DatosPerfil perfil, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new PerfilLogic()).setDatosPerfil(perfil, intCotizacionID, intDetCotizaID, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
