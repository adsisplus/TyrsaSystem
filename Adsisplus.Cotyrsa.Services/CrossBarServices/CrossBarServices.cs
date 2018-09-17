using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.CrossBarServices.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.CrossBarServices
{
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
