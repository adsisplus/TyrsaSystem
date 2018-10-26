using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.MateriaPrimaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMateriaPrimaServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMateriaPrimaServices
    {
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de un producto acero
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "setProductoAcero")]
        Resultado setProductoAcero(ProductoAcero producto, short sintOpcion);
    }
}
