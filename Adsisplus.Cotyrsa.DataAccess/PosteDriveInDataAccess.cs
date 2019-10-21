using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class PosteDriveInDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos poste drive in
        /// </summary>
        /// <param name="intDatoPosteDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        public List<DatosPosteDriveIn> ListarDatosPosteDriveIn(int intDatoPosteDriveInID, int intCotizacionID, int intDatoMarcoID)
        {
            List<DatosPosteDriveIn> result = new List<DatosPosteDriveIn>();
            try
            {
                using (PosteDriveInDataContext dc = new PosteDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPosteDriveIn(intDatoPosteDriveInID, intCotizacionID, intDatoMarcoID)
                                select new DatosPosteDriveIn
                                {
                                    // Datos Poste
                                    intDatoPosteDriveInID = item.intDatoPosteDriveInID,
                                    intElementoID = item.intElementoID,
                                    intDetCotizaID = item.intDetCotizaID,

                                    // DATOS DE DRIVE IN
                                    intDatosDriveInID = item.intDatosDriveInID,
                                    bitDobleMonten = item.bitDobleMonten,
                                    decAlturaDobleMonten = item.decAlturaDobleMonten,
                                    intCotizacionID = item.intCotizacionID,
                                    
                                    // DATOS DE MARCO
                                    intAlturaMarcoID = item.intAlturaMarcoID,
                                    decFondo = item.decFondo,
                                    sintPinturaID = item.sintPinturaID,
                                    decAlturaPandeo = item.decAlturaPandeo,
                                    bitEstructural = item.bitEstructural,
                                    bitRolado = item.bitRolado                                    
                                };
                    result.AddRange(query);
                    if(result.Count() > 0)
                        // Obtenemos la lista de precios
                        result.First().seleccion = ListarPrecioPosteTC2((int)result.First().intAlturaMarcoID, (decimal)result.First().decFondo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el precio poste TC 2
        /// </summary>
        /// <param name="intAlturaMarcoID"></param>
        /// <param name="decFondoMarco"></param>
        /// <returns></returns>
        public List<DatosPrecioPoste> ListarPrecioPosteTC2(int intAlturaMarcoID, decimal decFondoMarco)
        {
            List<DatosPrecioPoste> result = new List<DatosPrecioPoste>();
            try
            {
                using (PosteDriveInDataContext dc = new PosteDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarPrecioPosteTC2(intAlturaMarcoID, decFondoMarco)
                                select new DatosPrecioPoste
                                {
                                    intConfiguraMarcoID = item.intConfiguraMarcoID,
                                    intSKUID = item.intSKUID,
                                    decCalibre = item.decCalibre,
                                    decSolera = item.decSolera,
                                    decTotalKilo = item.decTotalKilo,
                                    decPrecioTyrsa = item.decPrecioTyrsa,
                                    decRelacionPrecios = item.decRelacionPrecios,
                                    decPrecioTyrsaMetro = item.decPrecioTyrsaMetro,
                                    decPrecioTyrsaKg = item.decPrecioTyrsaKg,
                                    sintNumPosteReq = item.sintNumPosteReq,
                                    sintNumTravesanio = item.sintNumTravesanio
                                };
                    result.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
