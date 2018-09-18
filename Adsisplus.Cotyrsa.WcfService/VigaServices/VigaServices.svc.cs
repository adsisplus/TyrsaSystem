using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.VigaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "VigaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione VigaServices.svc o VigaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class VigaServices : IVigaServices
    {
        /// <summary>
        /// Obtiene la lista del total por viga
        /// </summary>
        /// <param name="intConfiguraVigaID"></param>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="intCapacidadVigaID"></param>
        /// <param name="intFactorVigaID"></param>
        /// <param name="sintInsumoViga"></param>
        /// <returns></returns>
        public List<Viga> ListarConfiguracionViga(int intConfiguraVigaID, int sintTipoVigaID, int intElementoID, int intCalibreID, int intCapacidadVigaID, int intFactorVigaID, short sintInsumoViga)
        {
            List<Viga> result = new List<Viga>();
            try
            {
                result = (new VigaLogic()).ListarConfiguracionViga(intConfiguraVigaID, sintTipoVigaID, intElementoID, intCalibreID, intCapacidadVigaID, intFactorVigaID, sintInsumoViga);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de configuración por viga
        /// </summary>
        /// <param name="intDatosVigaID"></param>
        /// <param name="sintPinturaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        public List<DatosViga> ListarDatosViga(int intDatosVigaID, short sintPinturaID, int intElementoID, int intDatoMarcoID)
        {
            List<DatosViga> result = new List<DatosViga>();
            try
            {
                result = (new VigaLogic()).ListarDatosViga(intDatosVigaID, sintPinturaID, intElementoID, intDatosVigaID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de los datos por viga
        /// </summary>
        /// <param name="intCantidadVigaTope"></param>
        /// <param name="intVigaTopeID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatosVigaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosVigaTope> ListarDatosVigaTope(int intCantidadVigaTope, int intVigaTopeID, int intElementoID, int intDatosVigaID, int intCotizacionID, short sintPinturaID)
        {
            List<DatosVigaTope> result = new List<DatosVigaTope>();
            try
            {
                result = (new VigaLogic()).ListarDatosVigaTope(intCantidadVigaTope, intVigaTopeID, intElementoID, intDatosVigaID, intCotizacionID, sintPinturaID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de las viga por tope
        /// </summary>
        /// <param name="intTotalViga"></param>
        /// <param name="intConfiguraVigaID"></param>
        /// <returns></returns>
        public List<TotalViga> ListarTotalViga(int intTotalViga, int intConfiguraVigaID)
        {
            List<TotalViga> result = new List<TotalViga>();
            try
            {
                result = (new VigaLogic()).ListarTotalViga(intTotalViga, intConfiguraVigaID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
