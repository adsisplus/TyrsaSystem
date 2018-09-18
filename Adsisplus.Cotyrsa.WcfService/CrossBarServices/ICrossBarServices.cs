using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CrossBarServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICrossBarServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICrossBarServices
    {
        /// <summary>
        /// Obtiene la lista de datos del panel
        /// </summary>
        /// <param name="intDatosCrossBarID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosCrossBar> ListarDatosPanel(Int32 @intDatosCrossBarID, Int32 @intElementoID, Int32 @intDatoMarcoID);
    }
}
