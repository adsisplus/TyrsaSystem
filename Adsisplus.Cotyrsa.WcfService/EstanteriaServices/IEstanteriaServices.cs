using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.EstanteriaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEstanteriaServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEstanteriaServices
    {
        [OperationContract]
        /// <summary>
        /// Procedimiento que lista los datos de entrepaño
        /// </summary>
        /// <param name="sintRefuerzo"></param>
        /// <param name="decFrente"></param>
        /// <param name="decFondo"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarEntrepanio")]
        List<DatosEntrepanio> ListarEntrepanio(short sintRefuerzo, decimal decFrente, decimal decFondo, int intCalibreAceroID, bool bitGalvanizado);
    }
}
