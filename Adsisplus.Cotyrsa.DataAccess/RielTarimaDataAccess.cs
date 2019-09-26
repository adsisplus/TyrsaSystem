using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class RielTarimaDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos Riel Tarima
        /// </summary>
        /// <param name="intRielTarimaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosRielTarima> ListarDatosRielTarima(int intRielTarimaID, int intCotizacionID)
        {
            List<DatosRielTarima> result = new List<DatosRielTarima>();
            using (RielTarimaDataContext dc = new RielTarimaDataContext(Helper.ConnectionString()))
            {
                var query = from item in dc.stp_ListarDatosRielTarima(intRielTarimaID, intCotizacionID)
                            select new DatosRielTarima
                            {
                                intRielTarimaID = item.intRielTarimaID,
                                intElementoID = item.intElementoID,
                                intCotizacionID = item.intCotizacionID,
                                intDetCotizaID = item.intDetCotizaID,
                                sintTipoRielTarimaID = item.sintTipoRielTarimaID,
                                sintPinturaID = item.sintPinturaID,
                                intCantidad = item.intCantidad,
                                decCarga = item.decCarga,
                                decLargo = item.decLargo,
                                bitActivo = item.bitActivo,
                                seleccion = new SeleccionRielDeCarga()
                                {
                                    intSeleccionRielCargaID = item.intSeleccionRielCargaID,
                                    intRielTarimaID = item.intRielTarimaID,
                                    sintDriveInID = item.sintDriveInID,
                                    decLargo = item.decLargo,
                                    decLongitud = item.decLongitud,
                                    decAncho = item.decAncho,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioFinal = item.decPrecioFinal
                                }
                            };
                result.AddRange(query);
            }
                return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion riel de carga
        /// </summary>
        /// <param name="decPeso"></param>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        public List<SeleccionRielDeCarga> ListarDriveInRielDeCarga(decimal decPeso, bool bitEsEstructural)
        {
            List<SeleccionRielDeCarga> result = new List<SeleccionRielDeCarga>();
            try
            {
                using (RielTarimaDataContext dc = new RielTarimaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDriveInRielDeCarga(decPeso, bitEsEstructural)
                                select new SeleccionRielDeCarga
                                {
                                    sintDriveInID = item.sintDriveInID,
                                    decLargo = item.decLargo,
                                    decLongitud = item.decLongitud,
                                    decAncho = item.decAncho,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioFinal = item.decPrecioFinal
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
