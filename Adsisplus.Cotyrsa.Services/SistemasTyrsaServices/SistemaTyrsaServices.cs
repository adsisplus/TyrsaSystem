using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.SistemasTyrsaServices.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.SistemasTyrsaServices
{
    public class SistemaTyrsaServices : ISistemaTyrsaServices
    {
        /// <summary>
        /// Obtiene la lista de las relaciones de los sistemas selectivos
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intTipoElementoCoti_Producto"></param>
        /// <param name="intTipoElementoID"></param>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="intConfiguraMarcoID"></param>
        /// <param name="intConfiguraVigaID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="intDatosVigaID"></param>
        /// <param name="intDatosPanelID"></param>
        /// <param name="intDatosCrossBarID"></param>
        /// <param name="intDistanciadorID"></param>
        /// <param name="intParrillaID"></param>
        /// <param name="intVigaTopeID"></param>
        /// <param name="intProtectorPosteID"></param>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="sintSistemaCargaMarcoID"></param>
        /// <param name="datFechaAlta"></param>
        /// <returns></returns>
        public List<RelSistemaSelectivo> ListarRelSistemaSelectivo(int intCotizacionID, int intTipoElementoCoti_Producto, int intTipoElementoID, int intTipoElementoAlmacenID, 
            int intConfiguraMarcoID, int intConfiguraVigaID, int intDatoMarcoID, int intDatosVigaID, int intDatosPanelID, int intDatosCrossBarID, int intDistanciadorID, 
            int intParrillaID, int intVigaTopeID, int intProtectorPosteID, int intProtectorBateriaID, short sintSistemaCargaMarcoID, DateTime datFechaAlta)
        {
            List<RelSistemaSelectivo> result = new List<RelSistemaSelectivo>();
            try
            {
                result = (new SistemasTyrsaLogic()).ListarRelSistemaSelectivo(intCotizacionID, intTipoElementoCoti_Producto, intTipoElementoID, intTipoElementoAlmacenID,
                    intConfiguraMarcoID, intConfiguraVigaID, intDatoMarcoID, intDatosVigaID, intDatosPanelID, intDatosCrossBarID, intDistanciadorID, intParrillaID,
                    intVigaTopeID, intProtectorPosteID, intProtectorBateriaID, sintSistemaCargaMarcoID, datFechaAlta);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
