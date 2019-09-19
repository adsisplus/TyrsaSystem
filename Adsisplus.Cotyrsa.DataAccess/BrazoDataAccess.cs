using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class BrazoDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos de brazo
        /// </summary>
        /// <param name="intBrazoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosBrazo> ListarDatosBrazo(int intBrazoID, int intDetCotizaID)
        {
            List<DatosBrazo> result = new List<DatosBrazo>();
            try
            {
                using (BrazoDataContext dc = new BrazoDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosBrazo(intBrazoID, intDetCotizaID)
                                select new DatosBrazo
                                {
                                    intBrazoID = item.intBrazoID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintPinturaID = item.sintPinturaID,
                                    intCantidad = item.intCantidad,
                                    bitActivo = item.bitActivo,
                                    sintLargoBrazoID = item.sintLargoBrazoID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    decLargo = item.decLargo,
                                    decPrecioVentaUnitario = item.decPrecioVentaUnitario,
                                    decPrecioVentaTotal = item.decPrecioVentaTotal,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    // Agregamos la entidad que almacenará los datos de la seleccion
                                    seleccion = new SeleccionBrazo()
                                    {
                                        intSeleccionBrazoID = item.intSeleccionBrazoID,
                                        intBrazo = item.intBrazoID,
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista datos Drive In Brazo
        /// </summary>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        public List<SeleccionBrazo> ListarDatosBrazoDriveIn(bool bitEsEstructural)
        {
            List<SeleccionBrazo> result = new List<SeleccionBrazo>();
            try
            {
                using (BrazoDataContext dc = new BrazoDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDriveInBrazo(bitEsEstructural)
                                select new SeleccionBrazo
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
