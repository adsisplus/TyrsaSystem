using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class PisoDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos de piso
        /// </summary>
        /// <param name="intDatosPisoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPiso> ListarDatosPiso(int intDatosPisoID, int intCotizacionID)
        {
            List<DatosPiso> result = new List<DatosPiso>();
            try
            {
                using (PisoDataContext dc = new PisoDataContext())
                {
                    var query = from item in dc.stp_ListarDatosPiso(intDatosPisoID, intCotizacionID)
                                select new DatosPiso
                                {
                                    intDatoPisoID = item.intDatoPisoID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    sintPinturaID = item.sintPinturaID,
                                    intCantidad = item.intCantidad,
                                    decLargoPiso = item.decLargoPiso,
                                    bitUsoPatin = item.bitUsoPatin,
                                    bitActivo = item.bitActivo,
                                    intDetCotizaID = item.intDetCotizaID,
                                    decAncho = item.decAncho,
                                    bitTipoPisoAbierto = item.bitTipoPisoAbierto,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPesoBase = item.decPesoUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioBase = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    decPrecioVentaTotal = item.decPrecioTotal,
                                    bitGalvanizado = item.bitGalvanizado
                                };
                    result.AddRange(query);

                    // Realizamos el barrido de la lista
                    for (int i = 0; i < result.Count(); i++)
                        result[i].seleccion = ListarDatosSeleccionPiso((int)result[i].intDatoPisoID);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de los pisos registrados
        /// </summary>
        /// <param name="intDatoPisoID"></param>
        /// <returns></returns>
        public List<SeleccionPiso> ListarDatosSeleccionPiso(int intDatoPisoID)
        {
            List<SeleccionPiso> result = new List<SeleccionPiso>();
            try
            {
                using (PisoDataContext dc = new PisoDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosSeleccionPiso(intDatoPisoID)
                                select new SeleccionPiso
                                {
                                    intSeleccionPisoID = item.intSeleccionPisoID,
                                    intDatoPisoID = item.intDatoPisoID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    sintTipoPisoID = item.sintTipoPisoID,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPrecioTotal = item.decPrecioTotal,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPesoTotal = item.decPesoTotal,
                                    vchMaterial = item.vchMaterial,
                                    intCantidad = item.intCantidad,
                                    decLargo = item.decLongitud,
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
        /// <summary>
        /// Procedimiento que lista los datos de seleccion Piso Drive In
        /// </summary>
        /// <param name="intCantidad"></param>
        /// <param name="decLargo"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<SeleccionPisoDriveIn> ListarPisoDriveIn(int? intCantidad, decimal? decLargo, bool? bitGalvanizado)
        {
            List<SeleccionPisoDriveIn> result = new List<SeleccionPisoDriveIn>();
            try
            {
                using (PisoDataContext dc = new PisoDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarPisoDriveIn(intCantidad, decLargo, bitGalvanizado)
                                select new SeleccionPisoDriveIn
                                {
                                    sintPisoID = item.sintPisoID,
                                    sintTipoPisoID = item.sintTipoPisoID,
                                    decLongitud = item.decLongitud,
                                    vchMaterial = item.vchMaterial,
                                    decPesoUnitario = item.decPesoUnitario,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    decPesoBase = item.decPesoBase,
                                    decPrecioBase = item.decPrecioBase
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
