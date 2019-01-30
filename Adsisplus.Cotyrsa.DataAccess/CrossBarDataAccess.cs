using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
namespace Adsisplus.Cotyrsa.DataAccess
{
   public class CrossBarDataAccess
    {
       
            public List<DatosCrossBar> ListarDatosPanel(Int32 intDatosCrossBarID, Int32 intElementoID, Int32 intDatoMarcoID)
            {
                List<DatosCrossBar> results = new List<DatosCrossBar>();
                try
                {
                    using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                    {
                        var query = from item in dc.stp_ListarDatosCrossBar(intDatosCrossBarID, intElementoID, intDatoMarcoID)
                                    select new DatosCrossBar()
                                    {
                                        intDatosCrossBarID = item.intDatosCrossBarID,
                                        vchElemento = item.vchElemento,
                                        sintCantidadDatoMarco = item.sintCantidadDatoMarco,
                                        decAnchoCrossBar = item.decAnchoCrossBar,
                                        bitConectorVigaCrossbar = item.bitConectorVigaCrossbar,
                                        intCantidadNivelCrossbar = item.intCantidadNivelCrossbar,
                                        bitActivo = item.bitActivo
                                    };
                        results.AddRange(query);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return results;
            }
        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <returns></returns>
        public List<decimal> ListarAnchoCrossBar()
        {
            List<decimal> result = new List<decimal>();
            try
            {
                using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                {
                    var query = dc.stp_ListarAnchoCrossBar();
                    result = (List<decimal>) query;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que nos muestra la lista de ancho páneles para cotizaciones
        /// </summary>
        /// <param name="decAncho"></param>
        /// <returns></returns>
        public List<SeleccionCrossBar> ListarSeleccionCrossBar(decimal decAncho)
        {
            List<SeleccionCrossBar> result = new List<SeleccionCrossBar>();
            try
            {
                using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionCrossBar(decAncho)
                                select new SeleccionCrossBar
                                {
                                    bitActivo = item.bitActivo,
                                    decAncho = item.decAncho,
                                    decAreaPintura = item.decAreaPintura,
                                    decDesarrollo = item.decDesarrollo,
                                    decLargo = item.decLargo,
                                    decLongitud = item.decLongitud,
                                    decPesoPartida = item.decPesoPartida,
                                    decPrecioAcero = item.decPrecioAcero,
                                    decPrecioFinal = item.decPrecioFinal,
                                    decTotal = item.decTotal,
                                    decTotalKiloUnitario = item.decTotalKiloUnitario,
                                    intNumPiezas = item.intNumPiezas,
                                    intPiezaLamina = item.intPiezaLamina,
                                    sintCara = item.sintCara,
                                    sintCrossBarID = item.sintCrossBarID,
                                    sintFactorCrossBarID = item.sintFactorCrossBarID,
                                    sintNumPieza = item.sintNumPieza,
                                    sintPesoPieza = item.sintPesoPieza,
                                    vchMaterial = item.vchMaterial,
                                    vchTipoCrossBar = item.vchTipoCrossBar
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
