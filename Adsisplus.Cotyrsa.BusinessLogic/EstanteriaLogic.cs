using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class EstanteriaLogic
    {
        private EstanteriaDataAccess EstanteriaDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public EstanteriaLogic()
        {
            EstanteriaDA = new EstanteriaDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos de entrepaño
        /// </summary>
        /// <param name="sintRefuerzo"></param>
        /// <param name="decFrente"></param>
        /// <param name="decFondo"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<DatosEntrepanio> ListarEntrepanio(short sintRefuerzo, decimal decFrente, decimal decFondo, int intCalibreAceroID, bool bitGalvanizado)
        {
            List<DatosEntrepanio> result = new List<DatosEntrepanio>();
            try
            {
                result = EstanteriaDA.ListarEntrepanio(sintRefuerzo, decFrente, decFondo, intCalibreAceroID, bitGalvanizado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
