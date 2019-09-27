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
        /// <returns></returns>
        public List<DatosPosteDriveIn> ListarDatosPosteDriveIn(int intDatoPosteDriveInID, int intCotizacionID)
        {
            List<DatosPosteDriveIn> result = new List<DatosPosteDriveIn>();
            try
            {
                using (PosteDriveInDataContext dc = new PosteDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPosteDriveIn(intDatoPosteDriveInID, intCotizacionID)
                                select new DatosPosteDriveIn
                                {
                                    // Datos Poste
                                    intDatoPosteDriveInID = item.intDatoPosteDriveInID,
                                    intElementoID = item.intElementoID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intSKUID = item.intSKUID,
                                    intCantidad = item.intCantidad,
                                    decCalibre = item.decCalibre,
                                    decSolera = item.decSolera,
                                    decTotalKilo = item.decTotalKilo,
                                    decPrecioTyrsa = item.decPrecioTyrsa,
                                    decRelacionPrecios = item.decRelacionPrecios,
                                    decPrecioTyrsaMetro = item.decPrecioTyrsaMetro,
                                    decPrecioTyrsaKg = item.decPrecioTyrsaKg,
                                    sintNumPosteReq = item.sintNumPosteReq,
                                    sintNumTravesanio = item.sintNumTravesanio,
                                    bitActivo = item.bitActivo,
                                    // Datos DriveInd
                                    bitDobleMonten = item.bitDobleMonten,
                                    intDatosDriveInID = item.intDatosDriveInID,
                                    intCotizacionID = item.intCotizacionID,
                                    decAlturaDobleMonten = item.decAlturaDobleMonten,
                                    // Datos de Marco
                                    intAlturaMarcoID = item.intAlturaMarcoID,
                                    decFondo = item.decFondo
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
