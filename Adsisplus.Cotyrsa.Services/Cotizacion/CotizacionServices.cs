using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.Cotizacion.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.Cotizacion
{
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
        public List<BusinessEntities.Cotizacion> ListarCatAlturaMarco(int intCotizacionID, int intEstatusID, int sintPrioridadID, int intEmpresaID)
        {
            List<BusinessEntities.Cotizacion> result = new List<BusinessEntities.Cotizacion>();
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
