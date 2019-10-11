using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class AtirantadoDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos Atirantado
        /// </summary>
        /// <param name="intAtirantadoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosAtirantado> ListarDatosAtirantado(int intAtirantadoID, int intCotizacionID)
        {
            List<DatosAtirantado> result = new List<DatosAtirantado>();
            try
            {
                using (AtirantadoDataContext dc = new AtirantadoDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosAtirantado(intAtirantadoID, intCotizacionID)
                                select new DatosAtirantado
                                {
                                    intAtirantadoID = item.intAtirantadoID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintPinturaID = item.sintPinturaID,
                                    intCantidad = item.intCantidad,
                                    bitActivo = item.bitActivo,
                                    intDetCotizaID = item.intDetCotizaID,
                                    decLargo = item.decLargo,
                                    //decPrecioVentaUnitario = item.decPrecioVentaUnitario,
                                    //decPrecioVentaTotal = item.decPrecioVentaTotal,
                                    //decPesoUnitario = item.decPesoUnitario,
                                    //decPesoTotal = item.decPesoTotal,
                                    decLongitud = item.decLongitud,
                                    intCalibreID = item.intCalibreID,
                                    seleccion = new SeleccionArriestrado()
                                    {
                                        intSeleccionArriestradoID = item.intSeleccionArriestradoID,
                                        sintDriveInID = item.sintDriveInID,
                                        intAtirantadoID = item.intAtirantadoID,
                                        decLargo = item.decLargo,
                                        decLongitud = item.decLongitud,
                                        decAncho = item.decAncho,
                                        decTotalKiloUnitario = item.decTotalKiloUnitario,
                                        decPrecioFinal = item.decPrecioFinal,
                                        decPrecioVentaUnitario = item.decPrecioVentaUnitario,
                                        decPrecioVentaTotal = item.decPrecioVentaTotal,
                                        decPesoUnitario = item.decPesoUnitario,
                                        decPesoTotal = item.decPesoTotal,
                                        intCantidad = item.intCantidad
                                    }
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
        /// Procedimiento que lista los datos de selección Arriestrado
        /// </summary>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        public List<SeleccionArriestrado> ListarDriveInArriestrado(bool bitEsEstructural)
        {
            List<SeleccionArriestrado> result = new List<SeleccionArriestrado>();
            try
            {
                using (AtirantadoDataContext dc = new AtirantadoDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDriveInArriestrado(bitEsEstructural)
                                select new SeleccionArriestrado
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
        /// <summary>
        /// Procedimiento que lista los datos de seleccion Atirantado en base al ID de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionArriestrado> ListarSeleccionAtirantado(int intCotizacionID)
        {
            List<SeleccionArriestrado> result = new List<SeleccionArriestrado>();
            try
            {
                using (AtirantadoDataContext dc = new AtirantadoDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionAtirantado(intCotizacionID)
                                select new SeleccionArriestrado
                                {
                                    intSeleccionArriestradoID = item.intSeleccionArriestradoID,
                                    intAtirantadoID = item.intAtirantadoID,
                                    sintDriveInID = item.sintDriveInID,
                                    decLargo = item.decLargo,
                                    decLongitud = item.decLongitud,
                                    decAncho = item.decAncho,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    decPrecioFinal = item.decPrecioFinal,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID
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
