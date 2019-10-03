﻿using Adsisplus.Cotyrsa.BusinessEntities;
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
                                    decPesoTotal = item.decPesoTotal,
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
    }
}
