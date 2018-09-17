using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.ProtectoresServices.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.ProtectoresServices
{
    public class ProtectoresServices : IProtectoresServices
    {
        /// <summary>
        /// Obtiene la lista de los datos de protector por poste
        /// </summary>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosProtectorBateria> ListarDatosProtectorBateria(int intProtectorBateriaID, int intElementoID, int intCotizacionID)
        {
            List<DatosProtectorBateria> result = new List<DatosProtectorBateria>();
            try
            {
                result = (new ProtectoresLogic()).ListarDatosProtectorBateria(intProtectorBateriaID, intElementoID, intCotizacionID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de los datos de proctector por batería.
        /// </summary>
        /// <param name="intProtectorPosteID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosProtectorBase> ListarDatosProtectorPoste(int intProtectorPosteID, int intElementoID, int intCotizacionID, short sintPinturaID)
        {
            List<DatosProtectorBase> result = new List<DatosProtectorBase>();
            try
            {
                result = (new ProtectoresLogic()).ListarDatosProtectorPoste(intProtectorPosteID, intElementoID, intCotizacionID, sintPinturaID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
