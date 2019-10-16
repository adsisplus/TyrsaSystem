using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class BarandalDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos Barandal
        /// </summary>
        /// <param name="intDatosBarandalID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosBarandal> ListarDatosBarandal(int intDatosBarandalID, int intCotizacionID)
        {
            List<DatosBarandal> result = new List<DatosBarandal>();
            try
            {
                using (BarandalDataContext dc = new BarandalDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosBarandal(intDatosBarandalID, intCotizacionID)
                                select new DatosBarandal
                                {
                                    intDatosBarandalID = item.intDatosBarandalID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    sintPinturaID = item.sintPinturaID,
                                    decLargo = item.decLargo,
                                    intCantidad = item.intCantidad,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    bitActivo = item.bitActivo
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
        ///// <summary>
        ///// Procedimiento que lista los datos de precio DriveIn Barandal en base al largo
        ///// </summary>
        ///// <param name="decLargo"></param>
        ///// <returns></returns>
        //public List<SeleccionBarandal> ListarDriveInBarandal(decimal decLargo)
        //{
        //    List<SeleccionBarandal> result = new List<SeleccionBarandal>();
        //    try
        //    {
        //        using (BarandalDataContext dc = new BarandalDataContext(Helper.ConnectionString()))
        //        {
        //            var query = from item in dc.stp_ListarDriveInBarandal(decLargo)
        //                        select new SeleccionBarandal
        //                        {
        //                            sintTipoVigaBarandalID = item.sintTipoVigaBarandalID,
        //                            decLargo = item.decLargo,
        //                            decPesoUnitario = item.decPesoUnitario,
        //                            decPrecioUnitario = item.decPrecioUnitario
        //                        };
        //            result.AddRange(query);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result;
        //}
    }
}
