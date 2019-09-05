using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class GuiaEntradaDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos Guia Entrada
        /// </summary>
        /// <param name="intGuiaEntradaID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosGuiaEntrada> ListarDatosGuiaEntrada(int intGuiaEntradaID, int intDetCotizaID)
        {
            List<DatosGuiaEntrada> result = new List<DatosGuiaEntrada>();
            try
            {
                using (GuiaEntradaDataContext dc = new GuiaEntradaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosGuiaEntrada(intGuiaEntradaID, intDetCotizaID)
                                select new DatosGuiaEntrada
                                {
                                    intGuiaEntradaID = item.intGuiaEntradaID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintPinturaID = item.sintPinturaID,
                                    decLargo = item.decLargo,
                                    intCantidad = item.intCantidad,
                                    bitActivo = item.bitActivo,
                                    intDetCotizaID = item.intDetCotizaID,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal
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
        /// Procedimiento que lista los datos de guia monta carga en base al largo
        /// </summary>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        public List<DatosMontaCargaDriveIn> ListarDatosGuiaMontaCargaDriveIn(short sintLargoID)
        {
            List<DatosMontaCargaDriveIn> result = new List<DatosMontaCargaDriveIn>();
            try
            {
                using (GuiaEntradaDataContext dc = new GuiaEntradaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarGuiaMontacargaDiveIn(sintLargoID)
                                select new DatosMontaCargaDriveIn
                                {
                                    sintDriveInID = item.sintDriveInID,
                                    decTotal = item.decTotal,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    vchMedida = item.vchMedida,
                                    decPrecioFinal = item.decPrecioFinal,
                                    decPrecioMasLargoTotal = item.decPrecioMasLargoTotal
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
