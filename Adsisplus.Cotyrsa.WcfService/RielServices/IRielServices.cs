using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.RielServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRielServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRielServices
    {
        /// <summary>
        /// Procedimiento que lista los datos de Riel de rueda en base a la cotización y al id principal
        /// </summary>
        /// <param name="intRielPortaRuedaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarDatosRielPortaRueda")]
        List<DatosRielPortaRueda> ListarDatosRielPortaRueda(int intRielPortaRuedaID, int intCotizacionID);

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
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarRielesRuedaMetalicaCartonFlow")]
        List<SeleccionRiel> ListarRielesRuedaMetalicaCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, short sintCantidadRiel,
            int intNumNivel, decimal decLargoPerfil, short sintCantidadRuedas, decimal decPrecioRuedas, decimal decTipoCambio);
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
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarRielesRuedaPlasticaCartonFlow")]
        List<SeleccionRiel> ListarRielesRuedaPlasticaCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, decimal decAncho, decimal decLargo, short sintCantidadRiel,
            short decTotalKiloUnitario, int intNumNivel, decimal decLargoPerfil, short sintCantidadRuedas, decimal decPrecioRuedas, decimal decTipoCambio, int intInternacion, decimal decCostoInternacion);

    }
}
