using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CrossBarServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CrossBarServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CrossBarServices.svc o CrossBarServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CrossBarServices : ICrossBarServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intDatosCrossBarID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        public List<DatosCrossBar> ListarDatosPanel(int intDatosCrossBarID, int intElementoID, int intDatoMarcoID)
        {
            List<DatosCrossBar> result = new List<DatosCrossBar>();
            try
            {
                result = (new CrossBarDataLogic()).ListarDatosPanel(intDatosCrossBarID, intElementoID, intDatoMarcoID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
