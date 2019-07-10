using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class ParrillaDataAccess
    {
        /// <summary>
        /// Procedimiento que muestra los datos de la parrilla en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosParrilla> ListarDatosParrilla(Int32 intCotizacionID)
        {
            List<DatosParrilla> results = new List<DatosParrilla>();
            try
            {
                using (ParrillaDataContext dc = new ParrillaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosParrilla(intCotizacionID)
                                select new DatosParrilla()
                                {
                                    intParrillaID = item.intParrillaID,
                                    vchElemento = item.vchElemento,
                                    sintPinturaID = item.sintPinturaID,
                                    vchPintura = item.vchPintura,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    vchFolio = item.vchFolio,
                                    decFrenteParrilla = item.decFrenteParrilla,
                                    decFondoParrilla = item.decFondoParrilla,
                                    decCostoParrilla = item.decCostoParrilla,
                                    vchTamanioCuadroParrilla = item.vchTamanioCuadroParrilla,
                                    intCantidadParrilla = item.intCantidadParrilla,
                                    decPesoParrilla = item.decPesoParrilla,
                                    bitGalvanizado = item.bitGalvanizado,
                                    bitPintura = item.bitPintura,

                                    decPrecioVentaUnitario = item.decPrecioVentaUnitario,
                                    decPrecioVentaTotal = item.decPrecioVentaTotal,
                                    
                                    decCapacidadCarga = item.decCapacidadCarga,

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
        /// Procedimiento que realiza la baja lógica y física (en caso de existir error) en los 
        /// datos de la parrilla
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = realiza el borrado físico de los datos
        ///                         0 = realiza el borrado lógico de los datos</param>
        /// <returns></returns>
        public Resultado setBajaParrilla(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                using (ParrillaDataContext dc = new ParrillaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setBajaParrilla(intDetCotizaID, bitRollBack)
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
