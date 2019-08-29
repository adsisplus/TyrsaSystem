﻿using Adsisplus.Cotyrsa.BusinessEntities;
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
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosPosteDriveIn> ListarDatosPosteDriveIn(int intDatoPosteDriveInID, int intDetCotizaID)
        {
            List<DatosPosteDriveIn> result = new List<DatosPosteDriveIn>();
            try
            {
                using (PosteDriveInDataContext dc = new PosteDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPosteDriveIn(intDatoPosteDriveInID, intDetCotizaID)
                                select new DatosPosteDriveIn
                                {
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
                                    bitActivo = item.bitActivo
                                };
                    result.AddRange(query);
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
