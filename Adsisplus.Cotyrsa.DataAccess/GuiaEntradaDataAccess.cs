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
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosGuiaEntrada> ListarDatosGuiaEntrada(int intGuiaEntradaID, int intCotizacionID)
        {
            List<DatosGuiaEntrada> result = new List<DatosGuiaEntrada>();
            try
            {
                using (GuiaEntradaDataContext dc = new GuiaEntradaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosGuiaEntrada(intGuiaEntradaID, intCotizacionID)
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
                                    decPrecioTotal = item.decPrecioTotal,
                                    seleccion = new SeleccionGuiaMonteCarga()
                                    {
                                        intSeleccionGuiaMontaCargaID = item.intSeleccionGuiaMontaCargaID,
                                        intGuiaEntradaID = item.intGuiaEntradaID,
                                        decTotal = item.decTotal,
                                        decTotalKiloUnitario = item.decTotalKiloUnitario,
                                        vchMedida = item.vchMedida,
                                        decPrecioFinal = item.decPrecioFinal,
                                        decPrecioMasLargoTotal = item.decPrecioMasLargoTotal,
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
        /// <summary>
        /// Procedimiento que lista los datos de seleccion de guia monta carga en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionGuiaMonteCarga> ListarSeleccionGuiaMontaCarga(int intCotizacionID)
        {
            List<SeleccionGuiaMonteCarga> result = new List<SeleccionGuiaMonteCarga>();
            try
            {
                using (GuiaEntradaDataContext dc = new GuiaEntradaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosGuiaEntrada(0, intCotizacionID)
                                select new SeleccionGuiaMonteCarga
                                {
                                    intSeleccionGuiaMontaCargaID = item.intSeleccionGuiaMontaCargaID,
                                    intGuiaEntradaID = item.intGuiaEntradaID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intCantidad = item.intCantidad,
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
