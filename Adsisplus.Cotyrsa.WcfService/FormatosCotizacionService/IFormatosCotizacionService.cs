using Adsisplus.Cotyrsa.BusinessEntities.Reportes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.FormatosCotizacionService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IFormatosCotizacionService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IFormatosCotizacionService
    {

        [OperationContract]
        [WebGet(UriTemplate = "RetrieveFile?cotizacionId={cotizacionId}")]
        Stream RetrieveFile(int cotizacionId);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GuardarParametrosFormato")]
        void GuardarParametrosFormato(IEnumerable<ParametroCotizacion> parametrosFormato);

        [OperationContract]
        [WebGet(UriTemplate = "GetParametrosFormatoCotizacion?cotizacionId={cotizacionId}", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ParametroCotizacion> GetParametrosFormatoCotizacion(int cotizacionId);

        [OperationContract]
        [WebGet(UriTemplate = "TieneCantidadMinimaParametros?cotizacionId={cotizacionId}", ResponseFormat = WebMessageFormat.Json)]
        bool TieneCantidadMinimaParametros(int cotizacionId);
    }
}
