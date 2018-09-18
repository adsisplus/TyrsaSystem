using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CotizacionServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CotizacionServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CotizacionServices.svc o CotizacionServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CotizacionServices : ICotizacionServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intEstatusID"></param>
        /// <param name="sintPrioridadID"></param>
        /// <param name="intEmpresaID"></param>
        /// <returns></returns>
        public List<Cotizacion> ListarCatAlturaMarco(int intCotizacionID, int intEstatusID, int sintPrioridadID, int intEmpresaID)
        {
            List<Cotizacion> result = new List<BusinessEntities.Cotizacion>();
            try
            {
                result = (new CotizacionLogic()).ListarCatAlturaMarco(intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
