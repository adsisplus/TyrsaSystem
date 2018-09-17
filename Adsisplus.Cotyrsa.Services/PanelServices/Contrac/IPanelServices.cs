using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.PanelServices.Contrac
{
    [ServiceContract]
    interface IPanelServices
    {
        /// <summary>
        /// Obtiene la lista de datos del panel
        /// </summary>
        /// <param name="intDatosPanelID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosPanel> ListarDatosPanel(Int32 @intDatosPanelID, Int32 @intElementoID, Int32 @intDatoMarcoID, Int16 @sintPinturaID);
    }
}
