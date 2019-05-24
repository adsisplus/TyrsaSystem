using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class GastosDataAccess
    {
        /// <summary>
        /// Procedimiento que devuelve los datos de la pantalla de Gastos
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosGastos> ListarDatosPantallaGastos(int intCotizacionID, int intDetCotizaID)
        {
            List<DatosGastos> result = new List<DatosGastos>();
            try
            {
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPantallaGasto(intCotizacionID, intDetCotizaID)
                                select new DatosGastos
                                {
                                    flete = new DatosFlete()
                                    {
                                        intDatoFleteID = item.intDatoFleteID,
                                        sintFleteID = item.sintFleteID,
                                        intCantidad = item.intCantidadFlete,
                                        datFechaCarga = item.datFechaCarga,
                                        datFechaDescarga = item.datFechaDescarga
                                    },
                                    instalacion = new DatosInstalacion()
                                    {
                                        intDatosInstalacionID = item.intDatosInstalacionID,
                                        sintInstalacionID = item.sintInstalacionID,
                                        intCantidad = item.intCantidadInstalacion,
                                        datFecha = item.datFechaInstalacion
                                    },
                                    viatico = new DatosViaticos()
                                    {
                                        intDatoViaticoID = item.intDatoViaticoID,
                                        sintViaticoID = item.sintViaticoID,
                                        intCantidad = item.intCantidadViaticos,
                                        datFecha = item.datFechaViatico
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
        /// Procedimiento que realiza el alta, modificación o baja de los datos de gastos
        /// </summary>
        /// <param name="flete"></param>
        /// <param name="instalacion"></param>
        /// <param name="viaticos"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitActivo"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosGastos(DatosFlete flete, DatosInstalacion instalacion, DatosViaticos viaticos, int intCotizacionID, bool bitActivo, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosGasto(intCotizacionID, flete.intDetCotizaID, flete.intDatoFleteID, flete.intElementoID,
                        flete.sintFleteID, flete.intCantidad, flete.datFechaCarga, flete.datFechaDescarga, 
                        instalacion.intDetCotizaID, instalacion.intDatosInstalacionID, instalacion.sintInstalacionID, instalacion.intElementoID,
                        instalacion.intCantidad, instalacion.datFecha, viaticos.intDetCotizaID, viaticos.intDatoViaticoID,
                        viaticos.intElementoID, viaticos.sintViaticoID, viaticos.intCantidad, viaticos.datFecha, bitActivo, 
                        (byte)tinOpcion)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
                                };
                    result = query.First();
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
